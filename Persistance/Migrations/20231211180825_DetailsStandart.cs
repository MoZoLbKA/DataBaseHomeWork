using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class DetailsStandart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Standarts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Standarts_DetailId",
                table: "Standarts",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Standarts_Details_DetailId",
                table: "Standarts",
                column: "DetailId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Standarts_Details_DetailId",
                table: "Standarts");

            migrationBuilder.DropIndex(
                name: "IX_Standarts_DetailId",
                table: "Standarts");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Standarts");
        }
    }
}
