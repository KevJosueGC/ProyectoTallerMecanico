using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaTallerMecanico.Migrations
{
    public partial class MigracionCorreccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Cotizacion_CotizacionIdCotizacion",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Orden_CotizacionIdCotizacion",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "CotizacionIdCotizacion",
                table: "Orden");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CotizacionIdCotizacion",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orden_CotizacionIdCotizacion",
                table: "Orden",
                column: "CotizacionIdCotizacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Cotizacion_CotizacionIdCotizacion",
                table: "Orden",
                column: "CotizacionIdCotizacion",
                principalTable: "Cotizacion",
                principalColumn: "IdCotizacion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
