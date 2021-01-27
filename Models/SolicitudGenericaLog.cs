using System.ComponentModel.DataAnnotations;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class SolicitudGenericaLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Log { get; set; }

    }
}