using examen_unidad2_backend.Dtos;
using examen_unidad2_backend.Dtos.Pacientes;

namespace examen_unidad2_backend.Services.Interfaces
{
    public interface IPacientesService
    {
        Task<ResponseDto<PacienteDto>> CreateAsync(PacienteCreateDto model);
        Task<ResponseDto<List<PacienteDto>>> GetListAsync(string searchTerm = "");
        Task<ResponseDto<PacienteDto>> GetOneByIdAsync(Guid id);
    }
}
