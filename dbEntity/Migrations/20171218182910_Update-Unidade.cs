using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dbEntity.Migrations
{
    public partial class UpdateUnidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Unidade",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Unidade",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
