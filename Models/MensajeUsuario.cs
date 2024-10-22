using System.ComponentModel.DataAnnotations;

namespace Contacto.Models
{
    public class MensajeUsuario
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100.")]
        public int Edad { get; set; }
    }
}
