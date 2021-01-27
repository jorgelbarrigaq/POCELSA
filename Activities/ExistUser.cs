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
    [ActivityDefinition(Category = "Usuarios", Description = "Valida si existe un Usuario", Icon = "fas fa-user-secret", Outcomes = new[] { OutcomeNames.True, OutcomeNames.False })]
    public class ExistsUser : Activity
    {
        private readonly ApplicationDbContext _store;

        public ExistsUser(ApplicationDbContext store)
        {
            _store = store;
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the ID of the user to evaluate.")]
        public WorkflowExpression<string> UserId
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var userId = await context.EvaluateAsync(UserId, cancellationToken);
            //var user = await _store.AsQueryable().FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
            var user = await _store.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

            var exists = user != null;

            Output.SetVariable("ExistsUser", exists);

            return Outcome(exists ? OutcomeNames.True : OutcomeNames.False);

        }
    }
}