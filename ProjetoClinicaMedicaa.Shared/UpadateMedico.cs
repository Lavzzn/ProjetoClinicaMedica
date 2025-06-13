namespace ProjetoClinicaMedicaa.Shared
{
    public class UpadateMedico
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string NomeCompleto { get; set; } = string.Empty;
        public string AreaAtuacao { get; set; } = string.Empty;
    }

}
