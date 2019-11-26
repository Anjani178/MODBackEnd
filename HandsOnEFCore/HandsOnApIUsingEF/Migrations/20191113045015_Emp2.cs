using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnApIUsingEF.Migrations
{
    public partial class Emp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    Did = table.Column<string>(nullable: false),
                    Dname = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(maxLength: 30, nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: true),
                    Desig = table.Column<string>(maxLength: 30, nullable: true),
                    Sal = table.Column<double>(nullable: false),
                    Did = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employee_Dept_Did",
                        column: x => x.Did,
                        principalTable: "Dept",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Did",
                table: "Employee",
                column: "Did");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Dept");
        }
    }
}
