using examen_unidad2_backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace examen_unidad2_backend.Database
{
    public class PacientesDbContext : DbContext
    {
        public PacientesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PacienteEntity> Pacientes { get; set; }
    }
}
