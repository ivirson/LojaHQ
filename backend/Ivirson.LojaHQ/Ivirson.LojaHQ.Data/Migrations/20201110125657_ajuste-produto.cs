using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ivirson.LojaHQ.Data.Migrations
{
    public partial class ajusteproduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Descricao", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 10, 9, 56, 55, 807, DateTimeKind.Local).AddTicks(3237), "Revista 1", "Turma da Mônica" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Descricao", "ImagemUrl", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 10, 9, 56, 55, 812, DateTimeKind.Local).AddTicks(1864), "Revista 1", "https://lh3.googleusercontent.com/proxy/zR3zvI6x6GeYkvAHiQVSaRDX_jL0VBIy1pIZJvO4FwYUQwc3buhVcsIDbuzRa30op9PzJcS4sfc_vYwmcxu2E9Jl-aGizR5vQNLOtuyDDkQtS11kXU6dWTwAiSXLowYfHwwJ97d3nXiM8JR331iiYGzPCEtH", "Dragon Ball Z" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Descricao", "ImagemUrl", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 10, 9, 56, 55, 812, DateTimeKind.Local).AddTicks(2247), "Revista 1", "https://images-na.ssl-images-amazon.com/images/I/81czyYh+PWL.jpg", "Vingadores" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 101, DateTimeKind.Local).AddTicks(1962), "Turma da Mônica - Revista 1" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "ImagemUrl", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 102, DateTimeKind.Local).AddTicks(6009), "http://www.guiadosquadrinhos.com/edicao/ShowImage.aspx?id=22314&path=conrad/d/dr03310001.jpg&w=400&h=604", "Dragon Ball Z - Revista 1" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "ImagemUrl", "Titulo" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 102, DateTimeKind.Local).AddTicks(6152), "https://cdn.awsli.com.br/393/393351/produto/40009441/15cfeba375.jpg", "Vingadores - Revista 1" });
        }
    }
}
