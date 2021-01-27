using System;
using Elsa.Samples.UserRegistration.Web.Models;

namespace Elsa.Samples.UserRegistration.Web.Messages
{
    public class UserActivated
    {
        // Convention based property for message correlation
        // https://masstransit-project.com/MassTransit/usage/messages.html#message-correlation
        public Guid CorrelationId { get; set; }
        public User User { get; set; }
    }
}