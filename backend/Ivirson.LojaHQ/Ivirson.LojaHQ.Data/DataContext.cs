using Ivirson.LojaHQ.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ivirson.LojaHQ.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoPedido> ProdutosPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=LojaDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto()
                {
                    Id = 1,
                    Titulo = "Turma da Mônica",
                    Descricao = "Revista 1",
                    Autor = "Maurício de Souza",
                    Quantidade = 6,
                    Preco = 2.99M,
                    DataLancamento = new DateTime(1990, 02, 20),
                    ImagemUrl = "https://organicsnewsbrasil.com.br/wp-content/uploads/2016/01/Revista-Salvando-Vidas_Capa.jpg"
                },
                new Produto()
                {
                    Id = 2,
                    Titulo = "Dragon Ball Z",
                    Descricao = "Revista 1",
                    Autor = "Akira Toryama",
                    Quantidade = 4,
                    Preco = 2.59M,
                    DataLancamento = new DateTime(1989, 10, 05),
                    ImagemUrl = "https://images-na.ssl-images-amazon.com/images/I/91pllXbnH1L.jpg"
                },
                new Produto()
                {
                    Id = 3,
                    Titulo = "Vingadores",
                    Descricao = "Revista 1",
                    Autor = "Marvel Comics",
                    Quantidade = 5,
                    Preco = 3.99M,
                    DataLancamento = new DateTime(2000, 08, 15),
                    ImagemUrl = "https://images-na.ssl-images-amazon.com/images/I/81czyYh+PWL.jpg"
                }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario()
                {
                    Id = 1,
                    Nome = "Usuario Admin",
                    Login = "admin",
                    Senha = "senhateste",
                    Role = "Admin"
                },
                new Usuario()
                {
                    Id = 2,
                    Nome = "Usuario",
                    Login = "usuario",
                    Senha = "senhateste",
                    Role = "Usuario"
                }
            );
        }
    }
}
