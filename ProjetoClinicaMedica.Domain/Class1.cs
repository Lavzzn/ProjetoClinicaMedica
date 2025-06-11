namespace ProjetoClinicaMedica.Domain
{
    public class Class1
    {

    }
    public class Usuario
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string HistoricoMedico { get; set; }
        public string ContatoEmergencia { get; set; }
    }
}
