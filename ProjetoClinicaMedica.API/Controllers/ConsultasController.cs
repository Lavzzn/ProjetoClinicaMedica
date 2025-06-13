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
    public class ConsultasController : ControllerBase
        {
            private readonly ClinicaContext _context;

            public ConsultasController (ClinicaContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<ConsultaDto>>> GetConsulta()
            {
                var consultas = await _context.Consultas.ToListAsync();

                var lista = consultas.Select(a => new ConsultaDto
                {
                    Id = a.Id,
                    DataHora = a.DataHora,
                    Valor = a.Valor,
                    MedicoId = a.MedicoId,
                    PacienteId = a.PacienteId
                }).ToList();

                return lista;
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<ConsultaDto>> GetConsultaById(int id)
            {
                var consulta = await _context.Consultas.FindAsync(id);
                if (consulta == null)
                {
                    return NotFound();
                }

                var consultaDto = new ConsultaDto
                {
                    Id = consulta.Id,
                    DataHora = consulta.DataHora,
                    Valor = consulta.Valor,
                    MedicoId = consulta.MedicoId,
                    PacienteId = consulta.PacienteId,
                    Convenio = consulta.Convenio,
                };

                return consultaDto;
            }

            [HttpPost]
            public async Task<ConsultaDto> CriarConsulta(CreateConsulta dto)
            {
                var novaConsulta = new Consulta
                {
          
                    Valor = dto.Valor,
                    DataHora = dto.DataHora,
                    MedicoId = dto.MedicoId,
                    PacienteId = dto.PacienteId,
                    Convenio = dto.Convenio,
                };

                await _context.Consultas.AddAsync(novaConsulta);

                await _context.SaveChangesAsync();

                return new ConsultaDto
                {
                    Id = novaConsulta.Id,
                    DataHora = novaConsulta.DataHora,
                    Valor = novaConsulta.Valor,
                    MedicoId = novaConsulta.MedicoId,
                    PacienteId = novaConsulta.PacienteId,
                    Convenio = novaConsulta.Convenio,

                };
            }

            [HttpPut("{id}")]
            public async Task<ActionResult<bool>> UpdateConsultaDto(int id, UpdateConsulta dto)
            {
                var consulta = await _context.Consultas.FindAsync(id);

                if (consulta == null)
                {
                    return NotFound();
                }

                consulta.PacienteId = dto.PacienteId;
                consulta.MedicoId = dto.MedicoId;
                consulta.DataHora = dto.DataHora;
                consulta.Valor = dto.Valor;
                consulta.Id = dto.Id;
                consulta.Convenio = dto.Convenio;

                await _context.SaveChangesAsync();

                return Ok();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeletePaciente(int id)
            {
                var consulta = await _context.Consultas.FindAsync(id);

                if (consulta == null)
                {
                    return NotFound();
                }

                _context.Consultas.Remove(consulta);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
    }

