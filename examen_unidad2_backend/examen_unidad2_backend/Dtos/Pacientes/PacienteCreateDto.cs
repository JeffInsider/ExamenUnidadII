using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace examen_unidad2_backend.Dtos.Pacientes
{
    public class PacienteCreateDto
    {

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public double Peso { get; set; }

        [Required]
        public double Altura { get; set; }

        [Required]
        public double IMC { get; set; }
    }
}
