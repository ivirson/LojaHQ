using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ivirson.LojaHQ.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    ImagemUrl = table.Column<string>(nullable: true),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Ativo", "Autor", "DataCadastro", "DataLancamento", "ImagemUrl", "Titulo" },
                values: new object[,]
                {
                    { 1, true, "Maurício de Souza", new DateTime(2020, 11, 9, 14, 22, 51, 137, DateTimeKind.Local).AddTicks(5304), new DateTime(1990, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://organicsnewsbrasil.com.br/wp-content/uploads/2016/01/Revista-Salvando-Vidas_Capa.jpg", "Turma da Mônica - Revista 1" },
                    { 2, true, "Akira Toryama", new DateTime(2020, 11, 9, 14, 22, 51, 138, DateTimeKind.Local).AddTicks(5347), new DateTime(1989, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.guiadosquadrinhos.com/edicao/ShowImage.aspx?id=22314&path=conrad/d/dr03310001.jpg&w=400&h=604", "Dragon Ball Z - Revista 1" },
                    { 3, true, "Marvel Comics", new DateTime(2020, 11, 9, 14, 22, 51, 138, DateTimeKind.Local).AddTicks(5411), new DateTime(2000, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.awsli.com.br/393/393351/produto/40009441/15cfeba375.jpg", "Vingadores - Revista 1" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Ativo", "Login", "Nome", "Role", "Senha" },
                values: new object[,]
                {
                    { 1, true, "admin", "Usuario Admin", "Admin", "senhateste" },
                    { 2, true, "usuario", "Usuario", "Usuario", "senhateste" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
