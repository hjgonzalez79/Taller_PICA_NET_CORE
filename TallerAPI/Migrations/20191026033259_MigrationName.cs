using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerAPI.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactoAPIs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombresContratoAPI = table.Column<string>(nullable: true),
                    ApellidosContratoAPI = table.Column<string>(nullable: true),
                    EmailContratoAPI = table.Column<string>(nullable: true),
                    CelularContratoAPI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoAPIs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactoAPIs");
        }
    }
}
