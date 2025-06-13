namespace ProjetoClinicaMedica.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
        public Guid PacienteId {  get; set; }
        public Paciente? Paciente { get; set; }
    }
}
