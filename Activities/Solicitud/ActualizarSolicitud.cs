using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Extensions;
using Elsa.Persistence.EntityFrameworkCore.DbContexts;
using Elsa.Results;
using Elsa.Samples.UserRegistration.Web.Data;
using Elsa.Samples.UserRegistration.Web.Models;
using Elsa.Samples.UserRegistration.Web.Services;
using Elsa.Services;
using Elsa.Services.Models;
using Microsoft.EntityFrameworkCore;



namespace Elsa.Samples.UserRegistration.Web.Activities.Solicitud
{
    [ActivityDefinition(Category = "Solcitud", Description = "Actualiza una Solicitud", Icon = "fas fa-sync", Outcomes = new[] { OutcomeNames.Done })]
    public class ActualizarSolicitud : Activity
    {
        private readonly ApplicationDbContext _store;

        //public CreateUser(
        //    IMongoCollection<User> store,
        //    IIdGenerator idGenerator,
        //    IPasswordHasher passwordHasher)
        //{
        public ActualizarSolicitud(
            ApplicationDbContext store)
        {
            _store = store;
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<int> IdSolicitud
        {
            get => GetState<WorkflowExpression<int>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Nombre
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Email
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Telefono
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Rut
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Producto
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> Origen
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression.")]
        public WorkflowExpression<string> NombreQuimico
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var idSolicitud = await context.EvaluateAsync(IdSolicitud, cancellationToken);
            var sol = await _store.SolicitudesGenericas.FirstOrDefaultAsync(x => x.Id == idSolicitud, cancellationToken);

            if (sol == null)
                return Outcome("Not Found");


            sol.Nombre = await context.EvaluateAsync(Nombre, cancellationToken);
            sol.Email = await context.EvaluateAsync(Email, cancellationToken);
            sol.Telefono = await context.EvaluateAsync(Telefono, cancellationToken);
            sol.Rut = await context.EvaluateAsync(Rut, cancellationToken);
            sol.Producto = await context.EvaluateAsync(Producto, cancellationToken);
            sol.Origen = await context.EvaluateAsync(Origen, cancellationToken);
            sol.NombreQuimico = await context.EvaluateAsync(NombreQuimico, cancellationToken);


            _store.Entry(sol).State = EntityState.Modified;

            await _store.SaveChangesAsync(cancellationToken);
      

            return Done();
        }
    }
}