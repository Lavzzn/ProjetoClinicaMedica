using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinicaMedicaa.Shared
{
    public class CreateConsulta
    {

        [Required]
        public DateTime DataHora { get; set; }

        [Required]
        public string Valor { get; set; }

        [Required]
        public int MedicoId { get; set; }

        [Required]
        public int PacienteId { get; set; }

        [Required]
        public string? Convenio { get; set; }
    }
}
