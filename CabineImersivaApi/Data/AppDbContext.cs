using CabineImersivaApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CabineImersivaApi.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cabine> Cabines { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<DataAtendimento> DataAtendimentos { get; set; }
        public DbSet<Orgao> Orgaos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>()
                .HasIndex(a => a.CPF)
                .IsUnique();
        }
    }
}
