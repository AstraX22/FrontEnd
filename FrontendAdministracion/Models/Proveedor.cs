using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.Models
{
    public class Proveedor
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Nombre de la empresa es obligatorio")]
        public string NombreEmpresa { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Telefono { get; set; }
    }
}
