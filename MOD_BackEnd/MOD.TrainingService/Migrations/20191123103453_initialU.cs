using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class initialU : Migration
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

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TId = table.Column<string>(nullable: false),
                    TName = table.Column<string>(nullable: false),
                    TimeDuration = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    Rating = table.Column<float>(nullable: false),
                    CommissionFee = table.Column<float>(nullable: false),
                    Mid = table.Column<string>(nullable: false),
                    Uid = table.Column<string>(nullable: false),
                    SId = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndTime = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TId);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Skills_SId",
                        column: x => x.SId,
                        principalTable: "Skills",
                        principalColumn: "SId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_User_Uid",
                        column: x => x.Uid,
                        principalTable: "User",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<string>(nullable: false),
                    Uid = table.Column<string>(nullable: true),
                    Mid = table.Column<string>(nullable: true),
                    TId = table.Column<string>(nullable: true),
                    Amount = table.Column<float>(nullable: false),
                    AmountMentor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Training_TId",
                        column: x => x.TId,
                        principalTable: "Training",
                        principalColumn: "TId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_User_Uid",
                        column: x => x.Uid,
                        principalTable: "User",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Mid",
                table: "Payment",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TId",
                table: "Payment",
                column: "TId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Uid",
                table: "Payment",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mid",
                table: "Training",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SId",
                table: "Training",
                column: "SId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Uid",
                table: "Training",
                column: "Uid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
