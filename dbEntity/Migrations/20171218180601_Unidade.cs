using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dbEntity.Migrations
{
    public partial class Unidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "PrecoU");

            migrationBuilder.AddColumn<int>(
                name: "Unidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "PrecoU",
                table: "Produtos",
                newName: "Preco");
        }
    }
}
