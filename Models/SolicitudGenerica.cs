using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class SolicitudGenerica
    {
        public SolicitudGenerica()
        {
            Logs = new List<SolicitudGenericaLog>();
        }
        [Key]
        public int Id { get; set; }
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
        
        public string Origen { get; set; }
        public string NombreQuimico { get; set; }
        public bool Aprobado { get; set; }
        public IList<SolicitudGenericaLog> Logs { get; set; }

    }
}