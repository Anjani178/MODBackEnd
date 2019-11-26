using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCore_CodeFirst.Migrations
{
    public partial class Employee1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    Did = table.Column<string>(nullable: false),
                    Dname = table.Column<string>(type: "varchar(20)", nullable: false)
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
                    Ename = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(type: "varchar(20)", nullable: true),
                    Salary = table.Column<int>(nullable: true),
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
