using System.ComponentModel.DataAnnotations;

namespace ProjetoClinicaMedicaa.Shared
{
    public class UserRegister
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4 caracteres")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Senha e Confirmação de Senha não coicidem")]
        public string ConfirmPassword { get; set; }

        public string AreaAtuacao { get; set; } = "User";
    }
}
