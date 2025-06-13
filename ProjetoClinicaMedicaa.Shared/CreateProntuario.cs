using System.ComponentModel.DataAnnotations;

namespace ProjetoClinicaMedicaa.Shared
{
    public class CreateProntuario
    {
        [Required]
        public string MedicoNome { get; set; }
        [Required]
        public int PacienteNome { get; set; }
        [Required]
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
    }
}
