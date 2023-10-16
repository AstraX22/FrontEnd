using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La Categoria es obligatorio")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El Codigo es obligatorio")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public string Precio { get; set; }

        [Required(ErrorMessage = "La Descripcion es obligatorio")]
        public string Descripcion { get; set; }

       
    }
}
