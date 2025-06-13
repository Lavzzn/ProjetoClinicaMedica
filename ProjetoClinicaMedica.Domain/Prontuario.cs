namespace ProjetoClinicaMedica.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
    }
}
