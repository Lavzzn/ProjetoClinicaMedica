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
        public DateTime Data { get; set; }
        public DateTime DataHora { get; set; }
        public string Valor { get; set; } = string.Empty;
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public string? Convenio { get; set; }
    }
}
