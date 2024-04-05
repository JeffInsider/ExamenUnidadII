using AutoMapper;
using examen_unidad2_backend.Database;
using examen_unidad2_backend.Dtos;
using examen_unidad2_backend.Dtos.Pacientes;
using examen_unidad2_backend.Entities;
using examen_unidad2_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace examen_unidad2_backend.Services
{
    public class PacientesService : IPacientesService
    {
        private readonly PacientesDbContext _context;
        private readonly IMapper _mapper;

        public PacientesService(PacientesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<PacienteDto>>> GetListAsync(string searchTerm = "")
        {
            var pacientesEntity = await _context.Pacientes
                .Where(t => t.Nombre.Contains(searchTerm)).ToListAsync();

            var pacientesDto = _mapper.Map<List<PacienteDto>>(pacientesEntity);
            return new ResponseDto<List<PacienteDto>>
            {
                Status = true,
                StatusCode = 200,
                Message = "Datos obtenidos correctamente",
                Data = pacientesDto
            };
        }

        public async Task<ResponseDto<PacienteDto>> GetOneByIdAsync(Guid id)
        {
            //await porque es una petición a la base de datos
            var pacienteEntity = await _context.Pacientes.FirstOrDefaultAsync(t => t.Id == id);

            if (pacienteEntity is null)
            {
                return new ResponseDto<PacienteDto>
                {
                    Status = false,
                    StatusCode = 404,
                    Message = $"Tarea {id} no obtenida "
                };
            }

            var pacienteDto = _mapper.Map<PacienteDto>(pacienteEntity);

            return new ResponseDto<PacienteDto>
            {
                Status = true,
                StatusCode = 200,
                Message = $"Tarea {pacienteDto.Id} obtenida correctamente",
                Data = pacienteDto
            };
        }

        public async Task<ResponseDto<PacienteDto>> CreateAsync(PacienteCreateDto model)
        {

            var pacienteEntity = _mapper.Map<PacienteEntity>(model);

            _context.Pacientes.Add(pacienteEntity);
            await _context.SaveChangesAsync();

            var pacienteDto = _mapper.Map<PacienteDto>(pacienteEntity);

            return new ResponseDto<PacienteDto>
            {
                Status = true,
                StatusCode = 201,
                Message = "Task creada correctamente",
                Data = pacienteDto
            };
        }
    }
}
