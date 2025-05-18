namespace GeradorPropostasWebApp.Models
{
    public class Proposta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public List<Servico> Servicos { get; set; } = new();
        public decimal Total => Servicos.Sum(s => s.Valor);
    }
}
