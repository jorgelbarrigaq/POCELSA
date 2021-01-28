using Elsa.Samples.UserRegistration.Web.Activities;
using Elsa.Samples.UserRegistration.Web.Activities.Solicitud;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Samples.UserRegistration.Web.Extensions
{
    public static class UserServiceCollectionExtensions
    {
        public static IServiceCollection AddUserActivities(this IServiceCollection services)
        {
            return services
                .AddActivity<CreateUser>()                
                .AddActivity<ExistsUser>()
                .AddActivity<ActivateUser>()
                .AddActivity<CrearSolicitud>()
                .AddActivity<AprobacionSolicitud>()
                .AddActivity<ActualizarSolicitud>()
                .AddActivity<DeleteUser>();
        }
    }
}