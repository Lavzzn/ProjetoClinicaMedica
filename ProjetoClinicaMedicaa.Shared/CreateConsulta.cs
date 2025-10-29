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
        public bool IsCovenio { get; set; }

        [Required]
        public Guid MedicoId { get; set; }

        [Required]
        public Guid PacienteId { get; set; }

        public string? Convenio { get; set; }

        [Required]
        public string Tipo { get; set; }

        public string Diagnosticos { get; set; }
    }
}
