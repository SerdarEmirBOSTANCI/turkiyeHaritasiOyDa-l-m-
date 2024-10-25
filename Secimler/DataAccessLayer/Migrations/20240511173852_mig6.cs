using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "İkibinondortsecims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RTEaldiğioy = table.Column<double>(type: "float", nullable: false),
                    RTEoyorani = table.Column<double>(type: "float", nullable: false),
                    EIaldiğioy = table.Column<double>(type: "float", nullable: false),
                    EIoyorani = table.Column<double>(type: "float", nullable: false),
                    SDaldiğioy = table.Column<double>(type: "float", nullable: false),
                    SDoyorani = table.Column<double>(type: "float", nullable: false),
                    Toplamoy = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İkibinondortsecims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_İkibinondortsecims_sehirs_SehirID",
                        column: x => x.SehirID,
                        principalTable: "sehirs",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_İkibinondortsecims_SehirID",
                table: "İkibinondortsecims",
                column: "SehirID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İkibinondortsecims");
        }
    }
}
