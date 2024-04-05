using AutoMapper;
using examen_unidad2_backend.Dtos.Pacientes;
using examen_unidad2_backend.Entities;

namespace examen_unidad2_backend.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            MapForTasks();
        }

        private void MapForTasks()
        {
            CreateMap<PacienteEntity, PacienteDto>();

            CreateMap<PacienteCreateDto, PacienteDto>();

        }
    }
}
