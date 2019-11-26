using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class order1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "IName", "Price" },
                values: new object[] { 1, "Pen", 10.0 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "IName", "Price" },
                values: new object[] { 2, "Watch", 500.10000000000002 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryDate", "ItemId", "OrderDate" },
                values: new object[] { 2, new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5909), 1, new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryDate", "ItemId", "OrderDate" },
                values: new object[] { 1, new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(1333), 2, new DateTime(2019, 11, 12, 16, 31, 25, 890, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryDate", "ItemId", "OrderDate" },
                values: new object[] { 3, new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6016), 2, new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemId",
                table: "Orders",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
