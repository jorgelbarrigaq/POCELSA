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
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Rut { get; set; }
        public string Producto { get; set; }
        public string Origen { get; set; }
        public string NombreQuimico { get; set; }
        public bool Aprobado { get; set; }
        public IList<SolicitudGenericaLog> Logs { get; set; }

    }
}