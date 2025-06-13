using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinicaMedicaa.Shared
{
    public class ProntuarioDto
    {
        public int Id { get; set; } 
        public string Medico { get; set; }
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
        public string PacienteNome { get; set; }
    }
}
