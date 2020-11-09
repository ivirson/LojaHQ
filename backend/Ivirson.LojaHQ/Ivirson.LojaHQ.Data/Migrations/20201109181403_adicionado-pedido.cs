using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ivirson.LojaHQ.Data.Migrations
{
    public partial class adicionadopedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    PedidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Quantidade" },
                values: new object[] { new DateTime(2020, 11, 9, 15, 14, 3, 511, DateTimeKind.Local).AddTicks(1386), 6 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Quantidade" },
                values: new object[] { new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5497), 4 });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Quantidade" },
                values: new object[] { new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5577), 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UsuarioId",
                table: "Pedidos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_PedidoId",
                table: "ProdutosPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_ProdutoId",
                table: "ProdutosPedidos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutosPedidos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 14, 22, 51, 137, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 14, 22, 51, 138, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 14, 22, 51, 138, DateTimeKind.Local).AddTicks(5411));
        }
    }
}
