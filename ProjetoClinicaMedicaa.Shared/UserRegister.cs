using System.ComponentModel.DataAnnotations;


namespace ProjetoClinicaMedicaa.Shared
{
    public class UserRegister
    {
        public string Nome { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4 caracteres")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Senha e confirmação nao coicidem")]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }

}
