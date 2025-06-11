namespace ProjetoClinicaMedica.Domain
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
        public string Valor { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
    }
}
