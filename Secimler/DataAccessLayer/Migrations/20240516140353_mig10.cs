using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SD",
                table: "denemeicins",
                newName: "TS");

            migrationBuilder.RenameColumn(
                name: "MI",
                table: "denemeicins",
                newName: "FB");

            migrationBuilder.RenameColumn(
                name: "MA",
                table: "denemeicins",
                newName: "BJK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TS",
                table: "denemeicins",
                newName: "SD");

            migrationBuilder.RenameColumn(
                name: "FB",
                table: "denemeicins",
                newName: "MI");

            migrationBuilder.RenameColumn(
                name: "BJK",
                table: "denemeicins",
                newName: "MA");
        }
    }
}
