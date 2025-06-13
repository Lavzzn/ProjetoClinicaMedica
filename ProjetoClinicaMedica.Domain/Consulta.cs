namespace ProjetoClinicaMedica.Domain
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public bool IsCovenio { get; set; }
        public string? Convenio { get; set; }
        public int MedicoId { get; set; }
        public Medico? Medico { get; set; }
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
        public string Diagnosticos { get; set; }
    }
}
