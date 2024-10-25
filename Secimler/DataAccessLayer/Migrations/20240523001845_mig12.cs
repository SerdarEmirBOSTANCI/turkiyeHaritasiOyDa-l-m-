using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ikibinyirmidortsecims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKP = table.Column<double>(type: "float", nullable: false),
                    CHP = table.Column<double>(type: "float", nullable: false),
                    MHP = table.Column<double>(type: "float", nullable: false),
                    YRefah = table.Column<double>(type: "float", nullable: false),
                    DP = table.Column<double>(type: "float", nullable: false),
                    IP = table.Column<double>(type: "float", nullable: false),
                    BBP = table.Column<double>(type: "float", nullable: false),
                    Bagimsiz = table.Column<double>(type: "float", nullable: false),
                    Hudapar = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ikibinyirmidortsecims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ikibinyirmidortsecims_sehirs_SehirID",
                        column: x => x.SehirID,
                        principalTable: "sehirs",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ikibinyirmidortsecims_SehirID",
                table: "ikibinyirmidortsecims",
                column: "SehirID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ikibinyirmidortsecims");
        }
    }
}
