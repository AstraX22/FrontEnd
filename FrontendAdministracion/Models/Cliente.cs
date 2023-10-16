using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.Models
{
    public class Cliente
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Direccion es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Telefono { get; set; }


    }
}
