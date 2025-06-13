using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoClinicaMedica.API.Data;
using ProjetoClinicaMedica.Domain;
using ProjetoClinicaMedicaa.Shared;

namespace ProjetoClinicaMedica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {


namespace ProjetoGestaoServicos.Api.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProntuarioController : ControllerBase
        {
            private readonly ClinicaContext _context;

            public ProntuarioController(ClinicaContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<ProntuarioDto>>> GetProntuario()
            {
                var prontuarios = await _context.Prontuarios.ToListAsync();

                var lista = prontuarios.Select(a => new ProntuarioDto
                {
                    Id = a.Id,
                    Exames = a.Exames,
                    Diagnosticos = a.Diagnosticos,
                    PacienteId = a.PacienteId
                }).ToList();

                return lista;
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<ProntuarioDto>> GetProntuarioById(int id)
            {
                var prontuario = await _context.Prontuarios.FindAsync(id);
                if (prontuario == null)
                {
                    return NotFound();
                }

                var prontuarioDto = new ProntuarioDto
                {
                    Id = prontuario.Id,
                    Exames = prontuario.Exames,
                    Diagnosticos = prontuario.Diagnosticos,
                    PacienteId = prontuario.PacienteId
                };

                return prontuarioDto;
            }

            [HttpPost]
            public async Task<ProntuarioDto> CriarProntuario(CreateProntuario dto)
            {
                var novoProntuario = new Prontuario
                {
                    Exames = dto.Exames,
                    Diagnosticos = dto.Diagnosticos,
                    PacienteId = dto.PacienteId
                };

                await _context.Prontuarios.AddAsync(novoProntuario);

                await _context.SaveChangesAsync();

                return new ProntuarioDto
                {
                    Id = novoProntuario.Id,
                    Exames = novoProntuario.Exames,
                    Diagnosticos = novoProntuario.Diagnosticos
                };
            }

            [HttpPut("{id}")]
            public async Task<ActionResult<bool>> UpdateProntuarioDto(int id, UpdateProntuarioDto dto)
            {
                var prontuario = await _context.Prontuarios.FindAsync(id);

                if (prontuario == null)
                {
                    return NotFound();
                }

                prontuario.PacienteId = dto.PacienteId;
                prontuario.Exames = dto.Exames;
                prontuario.Diagnosticos = dto.Diagnosticos;

                await _context.SaveChangesAsync();

                return Ok();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCliente(int id)
            {
                var prontuario = await _context.Prontuarios.FindAsync(id);

                if (prontuario == null)
                {
                    return NotFound();
                }

                _context.Prontuarios.Remove(prontuario);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
    }
}
}
