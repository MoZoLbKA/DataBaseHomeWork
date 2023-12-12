using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionForeighnKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodeProfession",
                table: "Standarts",
                newName: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Standarts_ProfessionId",
                table: "Standarts",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Standarts_Professions_ProfessionId",
                table: "Standarts",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Standarts_Professions_ProfessionId",
                table: "Standarts");

            migrationBuilder.DropIndex(
                name: "IX_Standarts_ProfessionId",
                table: "Standarts");

            migrationBuilder.RenameColumn(
                name: "ProfessionId",
                table: "Standarts",
                newName: "CodeProfession");
        }
    }
}
