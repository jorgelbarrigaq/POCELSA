using System.Threading;
using System.Threading.Tasks;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Results;
using Elsa.Samples.UserRegistration.Web.Data;
using Elsa.Samples.UserRegistration.Web.Models;
using Elsa.Services;
using Elsa.Services.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Elsa.Samples.UserRegistration.Web.Activities
{
    [ActivityDefinition(Category = "Usuarios", Description = "Activa un Usuario", Icon = "fas fa-user-check", Outcomes = new[] { OutcomeNames.Done, "Not Found" })]
    public class ActivateUser : Activity
    {
        private readonly ApplicationDbContext _store;

        public ActivateUser(ApplicationDbContext store)
        {
            _store = store;
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the ID of the user to activate.")]
        public WorkflowExpression<string> UserId
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var userId = await context.EvaluateAsync(UserId, cancellationToken);
            var user = await _store.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

            if (user == null)
                return Outcome("Not Found");

            user.IsActive = true;
            //await _store.ReplaceOneAsync(x => x.Id == userId, user, cancellationToken: cancellationToken);
            _store.Entry(user).State = EntityState.Modified;
            await _store.SaveChangesAsync(cancellationToken);

            return Done();
        }
    }
}