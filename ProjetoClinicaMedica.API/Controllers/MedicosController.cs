using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoClinicaMedica.API.Data;
using ProjetoClinicaMedica.Domain;
using ProjetoClinicaMedicaa.Shared;

namespace ProjetoClinicaMedica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public MedicosController(ClinicaContext context)
        {
            _context = context;
        }
        [HttpGet]
            public async Task<ActionResult<List<MedicoDto>>> GetMedicos()
            {
                var medicos = await _context.Medicos.ToListAsync();

                var lista = medicos.Select(a => new MedicoDto
                {
                    Id = a.Id,
                    NomeCompleto = a.NomeCompleto,
                    AreaAtuacao = a.AreaAtuacao

                }).ToList();

                return lista;
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<MedicoDto>> GetMedicosById(int id)
            {
                var medicos = await _context.Medicos.FindAsync(id);
                if (medicos == null)
                {
                    return NotFound();
                }

                var medicosDto = new MedicoDto
                {
                    Id = medicos.Id,
                    NomeCompleto = medicos.NomeCompleto,
                    AreaAtuacao = medicos.AreaAtuacao
                };

                return medicosDto;
            }

            [HttpPost]
            public async Task<MedicoDto> CriarMedico(CreateMedico dto)
        {
                var novoMedico = new Medico
                {
                    NomeCompleto = dto.NomeCompleto,
                    Email = dto.Email,
                    Numero = dto.Numero,
                    AreaAtuacao = dto.AreaAtuacao

                };

                await _context.Medicos.AddAsync(novoMedico);

                await _context.SaveChangesAsync();

                return new MedicoDto
                {
                    Id = novoMedico.Id,
                    NomeCompleto = novoMedico.NomeCompleto,
                   AreaAtuacao = novoMedico.AreaAtuacao
                };
            }

            [HttpPut("{id}")]
            public async Task<ActionResult<bool>> UpdateMedico(int id, UpadateMedico dto)
            {
                var medico = await _context.Medicos.FindAsync(id);

                if (medico == null)
                {
                    return NotFound();
                }

                  medico.NomeCompleto = dto.NomeCompleto;
                  medico.Email = dto.Email;
                  medico.Numero = dto.Numero;

                await _context.SaveChangesAsync();

                return Ok();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteMedico(int id)
            {
                var medico = await _context.Medicos.FindAsync(id);

                if (medico == null)
                {
                    return NotFound();
                }

                _context.Medicos.Remove(medico);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
    }
