using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ikibinyirmiucsecimikis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RTE = table.Column<double>(type: "float", nullable: false),
                    KK = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ikibinyirmiucsecimikis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ikibinyirmiucsecimikis_sehirs_SehirID",
                        column: x => x.SehirID,
                        principalTable: "sehirs",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ikibinyirmiucsecimikis_SehirID",
                table: "ikibinyirmiucsecimikis",
                column: "SehirID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ikibinyirmiucsecimikis");
        }
    }
}
