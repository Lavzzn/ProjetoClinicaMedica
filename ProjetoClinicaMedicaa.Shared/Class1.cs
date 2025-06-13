using System.ComponentModel.DataAnnotations;

namespace ProjetoClinicaMedicaa.Shared
{
    public class Class1
    {

    }
    public class MedicoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string AreaAtuacao { get; set; }
    }
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
    public class UserLogin
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
