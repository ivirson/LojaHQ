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
                    Titulo = "Turma da Mônica - Revista 1",
                    Autor = "Maurício de Souza",
                    Quantidade = 6,
                    DataLancamento = new DateTime(1990, 02, 20),
                    ImagemUrl = "https://organicsnewsbrasil.com.br/wp-content/uploads/2016/01/Revista-Salvando-Vidas_Capa.jpg"
                },
                new Produto()
                {
                    Id = 2,
                    Titulo = "Dragon Ball Z - Revista 1",
                    Autor = "Akira Toryama",
                    Quantidade = 4,
                    DataLancamento = new DateTime(1989, 10, 05),
                    ImagemUrl = "http://www.guiadosquadrinhos.com/edicao/ShowImage.aspx?id=22314&path=conrad/d/dr03310001.jpg&w=400&h=604"
                },
                new Produto()
                {
                    Id = 3,
                    Titulo = "Vingadores - Revista 1",
                    Autor = "Marvel Comics",
                    Quantidade = 5,
                    DataLancamento = new DateTime(2000, 08, 15),
                    ImagemUrl = "https://cdn.awsli.com.br/393/393351/produto/40009441/15cfeba375.jpg"
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
