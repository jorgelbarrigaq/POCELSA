using System.ComponentModel.DataAnnotations;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class EjecutaWF
    {
        [Required]
        public string Signal { get; set; }
        
        [Required]
        public string CorrelationId { get; set; }

        
        public string Variable { get; set; }

    }
}