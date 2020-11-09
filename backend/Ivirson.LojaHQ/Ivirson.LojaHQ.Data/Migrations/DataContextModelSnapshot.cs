﻿// <auto-generated />
using System;
using Ivirson.LojaHQ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ivirson.LojaHQ.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ivirson.LojaHQ.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Ivirson.LojaHQ.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Autor = "Maurício de Souza",
                            DataCadastro = new DateTime(2020, 11, 9, 15, 14, 3, 511, DateTimeKind.Local).AddTicks(1386),
                            DataLancamento = new DateTime(1990, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImagemUrl = "https://organicsnewsbrasil.com.br/wp-content/uploads/2016/01/Revista-Salvando-Vidas_Capa.jpg",
                            Quantidade = 6,
                            Titulo = "Turma da Mônica - Revista 1"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Autor = "Akira Toryama",
                            DataCadastro = new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5497),
                            DataLancamento = new DateTime(1989, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImagemUrl = "http://www.guiadosquadrinhos.com/edicao/ShowImage.aspx?id=22314&path=conrad/d/dr03310001.jpg&w=400&h=604",
                            Quantidade = 4,
                            Titulo = "Dragon Ball Z - Revista 1"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            Autor = "Marvel Comics",
                            DataCadastro = new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5577),
                            DataLancamento = new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImagemUrl = "https://cdn.awsli.com.br/393/393351/produto/40009441/15cfeba375.jpg",
                            Quantidade = 5,
                            Titulo = "Vingadores - Revista 1"
                        });
                });

            modelBuilder.Entity("Ivirson.LojaHQ.Models.ProdutoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosPedidos");
                });

            modelBuilder.Entity("Ivirson.LojaHQ.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Login = "admin",
                            Nome = "Usuario Admin",
                            Role = "Admin",
                            Senha = "senhateste"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Login = "usuario",
                            Nome = "Usuario",
                            Role = "Usuario",
                            Senha = "senhateste"
                        });
                });

            modelBuilder.Entity("Ivirson.LojaHQ.Models.Pedido", b =>
                {
                    b.HasOne("Ivirson.LojaHQ.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ivirson.LojaHQ.Models.ProdutoPedido", b =>
                {
                    b.HasOne("Ivirson.LojaHQ.Models.Pedido", null)
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId");

                    b.HasOne("Ivirson.LojaHQ.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}