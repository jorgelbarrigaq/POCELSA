using System.ComponentModel.DataAnnotations;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class SolicitudGenericaModel
    {
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Rut { get; set; }

        [Required]
        public string Producto { get; set; }

        [Required]
        public string Origen { get; set; }

        [Required]
        public string NombreQuimico { get; set; }


    }
}