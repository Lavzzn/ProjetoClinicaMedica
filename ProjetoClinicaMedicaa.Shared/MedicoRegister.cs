using System.ComponentModel.DataAnnotations;


namespace ProjetoClinicaMedicaa.Shared
{
    public class MedicoRegister
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string NomeCompleto { get; set; } = string.Empty;
        public string AreaAtuacao { get; set; } = string.Empty;
    }

}
