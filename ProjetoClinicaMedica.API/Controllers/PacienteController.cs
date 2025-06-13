using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjetoClinicaMedica.API.Data;
using ProjetoClinicaMedicaa.Shared;
using ProjetoClinicaMedica.Domain;

namespace ProjetoClinicaMedica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public PacienteController (ClinicaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PacienteDto>>> GetPacientes()
        {
            var pacientes = await _context.Pacientes.ToListAsync();

            var lista = pacientes.Select(a => new PacienteDto
            {
                Id = a.Id,
                Nome = a.Nome,
                DataNascimento = a.DataNascimento,
                ContatoEmergencia = a.ContatoEmergencia,

            }).ToList();

            return lista;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDto>> GetPacienteById(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            var pacienteDto = new PacienteDto
            {
                Id = paciente.Id,
                Nome = paciente.Nome,
                DataNascimento = paciente.DataNascimento,
                ContatoEmergencia = paciente.ContatoEmergencia,
            };

            return pacienteDto;
        }

        [HttpPost]
        public async Task<PacienteDto> CriarPaciente(CreatePaciente dto)
        {
            var novoPaciente = new Paciente
            {
                Nome = dto.Nome,
                Email = dto.Email,
                DataNascimento = dto.DataNascimento,
                ContatoEmergencia= dto.ContatoEmergencia,
                HistoricoMedico = dto.HistoricoMedico
            };

            await _context.Pacientes.AddAsync(novoPaciente);

            await _context.SaveChangesAsync();

            return new PacienteDto
            {
                Id = novoPaciente.Id,
                Nome = novoPaciente.Nome,
                DataNascimento = novoPaciente.DataNascimento,
                ContatoEmergencia = novoPaciente.ContatoEmergencia,
                HistoricoMedico = dto.HistoricoMedico
            };
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdatePaciente(int id, UpdatePaciente dto)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if (paciente == null)
            {
                return NotFound();
            }

            paciente.Nome = dto.Nome;
            paciente.Email = dto.Email;
            paciente.DataNascimento = dto.DataNascimento;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if (paciente == null)
            {
                return NotFound();
            }

            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
