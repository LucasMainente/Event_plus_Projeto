using Microsoft.EntityFrameworkCore;
using EventoDB.Models;
using Event_.Domain;
using Event_.Domains;

namespace EventoDB
{
    public class EventoContext : DbContext
    {
        public DbSet<TiposEventos> TiposEvento { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TiposUsuarios> TiposUsuario { get; set; }
        public DbSet<PresencaEventos> Presencas { get; set; }
        public DbSet<ComentarioEvento> ComentarioEventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE41-S28\\SQLEXPRESS; Database=EventtPlus; User Id=sa; Pwd=Senai@134; TrustServerCertificate=True;");
        }
    }
}
