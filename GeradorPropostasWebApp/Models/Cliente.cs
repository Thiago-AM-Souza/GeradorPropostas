namespace GeradorPropostasWebApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Empresa { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? Telefone { get; set; }
    }

}
