using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examen_unidad2_backend.Entities
{
    [Table("Pacientes", Schema = "transaccional")]
    public class PacienteEntity
    {
        [Column("id")]
        [Key]
        public Guid Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("peso")]
        public double Peso { get; set; }

        [Column("altura")]
        public double Altura { get; set; }

        [Column("imc")]
        public double IMC { get; set; }
    }
}
