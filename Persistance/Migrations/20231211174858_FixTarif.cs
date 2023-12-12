using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class FixTarif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Standarts_TarifId",
                table: "Standarts");

            migrationBuilder.DropColumn(
                name: "StandartId",
                table: "Tarifs");

            migrationBuilder.CreateIndex(
                name: "IX_Standarts_TarifId",
                table: "Standarts",
                column: "TarifId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Standarts_TarifId",
                table: "Standarts");

            migrationBuilder.AddColumn<int>(
                name: "StandartId",
                table: "Tarifs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Standarts_TarifId",
                table: "Standarts",
                column: "TarifId",
                unique: true);
        }
    }
}
