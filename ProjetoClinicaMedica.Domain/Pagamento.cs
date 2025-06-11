namespace ProjetoClinicaMedica.Domain
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Convenio { get; set; }
        public string ValorConsulta { get; set; }
    }
}
