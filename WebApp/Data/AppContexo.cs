using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppContexo : DbContext
    {
        public AppContexo(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Atribuicao> Atribuicoes { get; set; }
        public DbSet<Tempo> Tempos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atribuicao>().HasKey(x => new { x.TarefaId, x.UsuarioId });
            modelBuilder.Entity<Tempo>().Property(x => x.Minutos).HasComputedColumnSql("DATEDIFF(minute, [DataHoraInicio], [DataHoraFim])");

            base.OnModelCreating(modelBuilder);
        }
    }
}
