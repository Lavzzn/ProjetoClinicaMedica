namespace ProjetoClinicaMedica.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string PacienteNome { get; set; }
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
        public string Pacienteid {  get; set; }
        public Paciente? Paciente { get; set; }
    }
}
