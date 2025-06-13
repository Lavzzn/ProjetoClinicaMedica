namespace ProjetoClinicaMedicaa.Shared
{
    public class UpdateProntuarioDto
    {
        public int Id { get; set; }
        public DateTime DataConsuta { get; set; }
        public DateTime HorarioConsuta { get; set; }       
        public string Exames { get; set; }
        public string Diagnosticos { get; set; }
        public Guid PacienteId { get; set; }
    }
}
