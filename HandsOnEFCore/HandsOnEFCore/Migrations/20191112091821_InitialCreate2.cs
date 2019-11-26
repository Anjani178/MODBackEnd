using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCore_CodeFirst.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinDate",
                table: "Student1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "JoinDate",
                table: "Student1",
                type: "Date",
                nullable: true);
        }
    }
}
