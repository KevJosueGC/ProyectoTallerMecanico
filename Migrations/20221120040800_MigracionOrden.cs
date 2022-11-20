using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaTallerMecanico.Migrations
{
    public partial class MigracionOrden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCotizacion",
                table: "Orden");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinalizacion",
                table: "Orden",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Orden",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaFinalizacion",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Orden");

            migrationBuilder.AddColumn<int>(
                name: "IdCotizacion",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
