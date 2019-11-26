using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationService.Migrations
{
    public partial class auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mid = table.Column<string>(nullable: false),
                    MUserName = table.Column<string>(maxLength: 30, nullable: false),
                    MEmail = table.Column<string>(maxLength: 30, nullable: false),
                    MPassword = table.Column<string>(maxLength: 30, nullable: false),
                    Contact = table.Column<string>(maxLength: 10, nullable: true),
                    Facilities = table.Column<string>(nullable: true),
                    Technologies = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    TimeSlot = table.Column<string>(nullable: true),
                    linkedinUrl = table.Column<string>(nullable: true),
                    yearOfExperience = table.Column<int>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Uid = table.Column<string>(nullable: false),
                    UEmail = table.Column<string>(maxLength: 30, nullable: false),
                    UPassword = table.Column<string>(maxLength: 30, nullable: false),
                    Contact = table.Column<string>(maxLength: 10, nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Uid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
