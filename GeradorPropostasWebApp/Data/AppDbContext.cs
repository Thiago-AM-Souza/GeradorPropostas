using GeradorPropostasWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GeradorPropostasWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Proposta> Propostas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proposta>()
                        .HasMany(p => p.Servicos)
                        .WithMany();
        }
    }
}
