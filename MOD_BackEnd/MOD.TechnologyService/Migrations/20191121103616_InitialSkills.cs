using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TechnologyService.Migrations
{
    public partial class InitialSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SId = table.Column<string>(nullable: false),
                    SName = table.Column<string>(nullable: false),
                    toc = table.Column<string>(nullable: true),
                    PreReq = table.Column<string>(nullable: true),
                    Fees = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
