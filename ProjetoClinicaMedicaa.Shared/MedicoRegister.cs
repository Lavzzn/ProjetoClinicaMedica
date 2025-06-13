using System.ComponentModel.DataAnnotations;


namespace ProjetoClinicaMedicaa.Shared
{
    public class MedicoRegister
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Numero { get; set; } = string.Empty;
        [Required]
        public string NomeCompleto { get; set; } = string.Empty;
        [Required]
        public string AreaAtuacao { get; set; } = string.Empty;
    }

}
