using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ivirson.LojaHQ.Data.Migrations
{
    public partial class updatingproductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCadastro", "Preco" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 101, DateTimeKind.Local).AddTicks(1962), 2.99m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCadastro", "Preco" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 102, DateTimeKind.Local).AddTicks(6009), 2.59m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCadastro", "Preco" },
                values: new object[] { new DateTime(2020, 11, 9, 16, 38, 41, 102, DateTimeKind.Local).AddTicks(6152), 3.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Produtos");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 15, 14, 3, 511, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2020, 11, 9, 15, 14, 3, 512, DateTimeKind.Local).AddTicks(5577));
        }
    }
}
