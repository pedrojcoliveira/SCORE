using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCORE.Data.Migrations
{
    /// <inheritdoc />
    public partial class oooo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Uc",
                table: "Campeonato",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Uc",
                table: "Campeonato");
        }
    }
}
