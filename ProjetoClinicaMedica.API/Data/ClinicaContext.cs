using ProjetoClinicaMedica;
using Microsoft.EntityFrameworkCore;
using ProjetoClinicaMedica.Domain;

namespace ProjetoClinicaMedica.API.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
