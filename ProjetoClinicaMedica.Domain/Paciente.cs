namespace ProjetoClinicaMedica.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string HistoricoMedico { get; set; }
        public string ContatoEmergencia { get; set; }
    }
}
