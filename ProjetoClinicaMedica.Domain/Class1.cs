using Microsoft.Win32;

namespace ProjetoClinicaMedica.Domain
{
    public class Class1
    {

    }
    public class Medico
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string NomeCompleto { get; set; } = string.Empty;
        public string AreaAtuacao { get; set; } = string.Empty;
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
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
        public string Valor { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
    }
    public class Prontuario
    {
        public int Id { get; set; }
        public DateTime DataConsuta { get; set; }
        public DateTime HorarioConsuta { get; set; }
        public string Medico { get; set; }
        public string Exames { get; set; }
        public string Diagnósticos { get; set; }
    }
    public class Pagamento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Convenio { get; set; }
        public string ValorConsulta { get; set; }
    }
}
