namespace ProjetoClinicaMedica.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public DateTime DataConsuta { get; set; }
        public DateTime HorarioConsuta { get; set; }
        public string Medico { get; set; }
        public string Exames { get; set; }
        public string Diagnósticos { get; set; }
    }
}
