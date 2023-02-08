using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);


            // Seed
           
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Alimentos Não Perecíveis" },
                new { Id = 2, Nome = "Laticínios" },
                new { Id = 3, Nome = "Limpeza" },
                new { Id = 4, Nome = "Bebidas Não Alcoólicas" }
                ); 

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>()
               .HasData(
               new { Id = 1, Nome = "Arroz", Preco = 10.00, Quantidade = 10, CategoriaId = 1 },
               new { Id = 2, Nome = "Macarrão", Preco = 5.00, Quantidade = 10, CategoriaId = 1 },
               new { Id = 3, Nome = "Leite", Preco = 6.00, Quantidade = 10, CategoriaId = 2 },
               new { Id = 4, Nome = "Queijo", Preco = 40.00, Quantidade = 10, CategoriaId = 2 },
               new { Id = 5, Nome = "Omo", Preco = 9.00, Quantidade = 10, CategoriaId = 3 },
               new { Id = 6, Nome = "Detergente", Preco = 2.00, Quantidade = 10, CategoriaId = 3 },
               new { Id = 7, Nome = "Coca Cola", Preco = 5.00, Quantidade = 10, CategoriaId = 4 },
               new { Id = 8, Nome = "Guarana", Preco = 5.00, Quantidade = 10, CategoriaId = 4 }

               );
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }

        #endregion
    }
}
