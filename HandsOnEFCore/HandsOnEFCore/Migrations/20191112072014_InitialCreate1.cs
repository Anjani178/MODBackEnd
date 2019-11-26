using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCore_CodeFirst.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student1",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Std = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    School = table.Column<string>(type: "char(20)", maxLength: 20, nullable: true),
                    JoinDate = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student1", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student1");
        }
    }
}
