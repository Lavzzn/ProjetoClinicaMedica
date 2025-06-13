namespace ProjetoClinicaMedicaa.Shared
{
    public class MedicoDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NomeCompleto { get; set; } = string.Empty;
        public string AreaAtuacao { get; set; } = string.Empty;
    }

}
