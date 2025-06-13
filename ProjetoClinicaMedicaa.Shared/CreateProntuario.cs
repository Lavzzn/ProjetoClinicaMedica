using System.ComponentModel.DataAnnotations;

namespace ProjetoClinicaMedicaa.Shared
{
    public class CreateProntuario
    {
        [Required]
        public string PacienteNome { get; set; }
        [Required]
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
    }
}
