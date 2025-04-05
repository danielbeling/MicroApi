using MicroApi.Data.Map;
using MicroApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroApi.Data
{
    public class SistemaDeTarefasContext : DbContext
    {
        public SistemaDeTarefasContext(DbContextOptions<SistemaDeTarefasContext> options)
            : base(options)
        {
        
        }
        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
