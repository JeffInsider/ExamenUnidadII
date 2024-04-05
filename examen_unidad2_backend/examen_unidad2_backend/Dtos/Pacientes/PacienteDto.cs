using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace examen_unidad2_backend.Dtos.Pacientes
{
    public class PacienteDto
    {
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public double IMC { get; set; }
    }
}
