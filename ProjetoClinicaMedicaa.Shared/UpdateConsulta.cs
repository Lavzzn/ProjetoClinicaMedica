using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinicaMedicaa.Shared
{
    public class UpdateConsulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Valor { get; set; } = string.Empty;
        public Guid MedicoId { get; set; }
        public Guid PacienteId { get; set; }
        public string? Convenio { get; set; }
        public string Tipo {  get; set; }
    }
}
