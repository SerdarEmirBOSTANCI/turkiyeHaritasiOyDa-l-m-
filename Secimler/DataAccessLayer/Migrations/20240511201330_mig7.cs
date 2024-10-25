using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ikibinonsekizsecims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RTE = table.Column<double>(type: "float", nullable: false),
                    MI = table.Column<double>(type: "float", nullable: false),
                    SD = table.Column<double>(type: "float", nullable: false),
                    MA = table.Column<double>(type: "float", nullable: false),
                    TK = table.Column<double>(type: "float", nullable: false),
                    DP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ikibinonsekizsecims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ikibinonsekizsecims_sehirs_SehirID",
                        column: x => x.SehirID,
                        principalTable: "sehirs",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ikibinonsekizsecims_SehirID",
                table: "ikibinonsekizsecims",
                column: "SehirID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ikibinonsekizsecims");
        }
    }
}
