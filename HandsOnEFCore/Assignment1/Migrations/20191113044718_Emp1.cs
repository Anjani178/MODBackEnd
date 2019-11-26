using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class Emp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 20, 10, 17, 17, 462, DateTimeKind.Local).AddTicks(6336), new DateTime(2019, 11, 13, 10, 17, 17, 461, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 20, 10, 17, 17, 462, DateTimeKind.Local).AddTicks(8430), new DateTime(2019, 11, 13, 10, 17, 17, 462, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 20, 10, 17, 17, 462, DateTimeKind.Local).AddTicks(8489), new DateTime(2019, 11, 13, 10, 17, 17, 462, DateTimeKind.Local).AddTicks(8485) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(1333), new DateTime(2019, 11, 12, 16, 31, 25, 890, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5909), new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "DeliveryDate", "OrderDate" },
                values: new object[] { new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6016), new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6009) });
        }
    }
}
