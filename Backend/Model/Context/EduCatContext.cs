using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Reflection;

namespace Model.Context
{
    public class EduCatContext : DbContext
    {
        public EduCatContext(DbContextOptions<EduCatContext> options) : base(options) { }

        // Inserindo as entidades que virarão tabela
        public DbSet<Usuario> Usuario { get; set; }

        // Criando o método obrigatório da interface DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aplica todas as configurações de mapeamento da mesma assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
