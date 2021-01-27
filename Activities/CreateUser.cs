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


namespace Elsa.Samples.UserRegistration.Web.Activities
{
    [ActivityDefinition(Category = "Usuarios", Description = "Create a Usuario", Icon = "fas fa-user-plus", Outcomes = new[] { OutcomeNames.Done })]
    public class CreateUser : Activity
    {
        private readonly ApplicationDbContext _store;
        private readonly IIdGenerator _idGenerator;
        private readonly IPasswordHasher _passwordHasher;

        //public CreateUser(
        //    IMongoCollection<User> store,
        //    IIdGenerator idGenerator,
        //    IPasswordHasher passwordHasher)
        //{
        public CreateUser(
            ApplicationDbContext store,
            IIdGenerator idGenerator,
            IPasswordHasher passwordHasher)
        {
            _store = store;
            _idGenerator = idGenerator;
            _passwordHasher = passwordHasher;
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the name of the user to create.")]
        public WorkflowExpression<string> UserName
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the email address of the user to create.")]
        public WorkflowExpression<string> Email
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the password of the user to create.")]
        public WorkflowExpression<string> Password
        {
            get => GetState<WorkflowExpression<string>>();
            set => SetState(value);
        }

        protected override async Task<ActivityExecutionResult> OnExecuteAsync(WorkflowExecutionContext context, CancellationToken cancellationToken)
        {
            var password = await context.EvaluateAsync(Password, cancellationToken);
            var hashedPassword = _passwordHasher.HashPassword(password);

            var user = new User
            {
                Id = _idGenerator.Generate(),
                Name = await context.EvaluateAsync(UserName, cancellationToken),
                Email = await context.EvaluateAsync(Email, cancellationToken),
                Password = hashedPassword.Hashed,
                PasswordSalt = hashedPassword.Salt,
                IsActive = false
            };
            

            _store.Add(user);
            await _store.SaveChangesAsync(cancellationToken);
            // await _store.InsertOneAsync(user, cancellationToken: cancellationToken);

            //IEnumerable<User> listUsuarios = _store.User.fi();

            Output.SetVariable("User", user);
            return Done();
        }
    }
}