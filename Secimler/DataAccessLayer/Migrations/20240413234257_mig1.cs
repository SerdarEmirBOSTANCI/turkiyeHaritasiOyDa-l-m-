using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sehirs",
                columns: table => new
                {
                    SehirID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sehirs", x => x.SehirID);
                });

            migrationBuilder.CreateTable(
                name: "ikibinonyedisecims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    Kayitlisecmen = table.Column<int>(type: "int", nullable: false),
                    oylayaninsansayisi = table.Column<int>(type: "int", nullable: false),
                    gecerlioysayisi = table.Column<int>(type: "int", nullable: false),
                    gecersizoysayisi = table.Column<int>(type: "int", nullable: false),
                    evetoysayisi = table.Column<int>(type: "int", nullable: false),
                    evetoyorani = table.Column<double>(type: "float", nullable: false),
                    hayiroysayisi = table.Column<int>(type: "int", nullable: false),
                    hayiroyorani = table.Column<double>(type: "float", nullable: false),
                    katilimorani = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ikibinonyedisecims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ikibinonyedisecims_sehirs_SehirID",
                        column: x => x.SehirID,
                        principalTable: "sehirs",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ikibinonyedisecims_SehirID",
                table: "ikibinonyedisecims",
                column: "SehirID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ikibinonyedisecims");

            migrationBuilder.DropTable(
                name: "sehirs");
        }
    }
}
