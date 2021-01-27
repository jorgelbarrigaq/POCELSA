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
using MongoDB.Driver;


namespace Elsa.Samples.UserRegistration.Web.Activities.Solicitud
{
    [ActivityDefinition(Category = "Solcitud", Description = "Crea una Solicitud", Icon = "fas fa-user-plus", Outcomes = new[] { OutcomeNames.Done })]
    public class CrearSolicitud : Activity
    {
        private readonly ApplicationDbContext _store;

        //public CreateUser(
        //    IMongoCollection<User> store,
        //    IIdGenerator idGenerator,
        //    IPasswordHasher passwordHasher)
        //{
        public CrearSolicitud(
            ApplicationDbContext store)
        {
            _store = store;
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
            //var solicitudModel = await context.EvaluateAsync(Entidad, cancellationToken);
            var solicitud = new SolicitudGenerica()
            {
                Nombre = await context.EvaluateAsync(Nombre, cancellationToken),
                Email = await context.EvaluateAsync(Email, cancellationToken),
                Telefono = await context.EvaluateAsync(Telefono, cancellationToken),
                Rut = await context.EvaluateAsync(Rut, cancellationToken),
                Producto = await context.EvaluateAsync(Producto, cancellationToken),
                Origen = await context.EvaluateAsync(Origen, cancellationToken),
                NombreQuimico = await context.EvaluateAsync(NombreQuimico, cancellationToken)
            };


            _store.Add(solicitud);
            await _store.SaveChangesAsync(cancellationToken);
            // await _store.InsertOneAsync(user, cancellationToken: cancellationToken);

            //IEnumerable<User> listUsuarios = _store.User.fi();

            Output.SetVariable("Solicitud", solicitud);
            return Done();
        }
    }
}