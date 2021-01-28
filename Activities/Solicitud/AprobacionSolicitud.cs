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
    [ActivityDefinition(Category = "Solcitud", Description = "Actualiza Aprobacion de una Solicitud", Icon = "fas fa-calendar-check", Outcomes = new[] { OutcomeNames.Done })]
    public class AprobacionSolicitud : Activity
    {
        private readonly ApplicationDbContext _store;

        public AprobacionSolicitud(ApplicationDbContext store)
        {
            _store = store;
        }

        [ActivityProperty(Hint = "Enter an expression")]
        public WorkflowExpression<int> IdSolicitud
        {
            get => GetState<WorkflowExpression<int>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression")]
        public WorkflowExpression<string> Log
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression")]
        public WorkflowExpression<bool> Aprobado
        {
            get => GetState<WorkflowExpression<bool>>();
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var idSolicitud = await context.EvaluateAsync(IdSolicitud, cancellationToken);
            var sol = await _store.SolicitudesGenericas.Include(x => x.Logs).FirstOrDefaultAsync(x => x.Id == idSolicitud, cancellationToken);

            if (sol == null)
                return Outcome("Not Found");

            sol.Aprobado = await context.EvaluateAsync(Aprobado, cancellationToken);
            var log = new SolicitudGenericaLog()
            {
                Log = await context.EvaluateAsync(Log, cancellationToken)
            };
            sol.Logs.Add(log);

            _store.Entry(sol).State = EntityState.Modified;

            //_store.Add(log);
            await _store.SaveChangesAsync(cancellationToken);

            return Done();
        }
    }
}