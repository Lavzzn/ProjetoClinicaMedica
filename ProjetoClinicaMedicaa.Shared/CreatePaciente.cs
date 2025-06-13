using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinicaMedicaa.Shared
{
    public class CreatePaciente
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Numero { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string HistoricoMedico { get; set; }
        [Required]
        public string ContatoEmergencia { get; set; }
    }
}
