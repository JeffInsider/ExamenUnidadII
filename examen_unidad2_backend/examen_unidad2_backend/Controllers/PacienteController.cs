using examen_unidad2_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using examen_unidad2_backend.Dtos;
using examen_unidad2_backend.Dtos.Pacientes;

namespace examen_unidad2_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacientesService _pacientesService;

        public PacienteController(IPacientesService pacientesService)
        {
            _pacientesService = pacientesService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<PacienteDto>>>> GetAll(string searchTerm = "")
        {
            var pacientesResponse = await _pacientesService.GetListAsync(searchTerm);

            return StatusCode(pacientesResponse.StatusCode, pacientesResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<PacienteDto>>> GetOneById(Guid id)
        {
            var pacientesResponse = await _pacientesService.GetOneByIdAsync(id);

            return StatusCode(pacientesResponse.StatusCode, pacientesResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PacienteDto>>> Create([FromBody] PacienteCreateDto model)
        {
            var pacientesResponse = await _pacientesService.CreateAsync(model);

            return StatusCode(pacientesResponse.StatusCode, pacientesResponse);
        }

    }
}
