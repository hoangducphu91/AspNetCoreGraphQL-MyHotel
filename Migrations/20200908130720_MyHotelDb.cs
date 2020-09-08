using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHotel.Migrations
{
    public partial class MyHotelDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2020, 8, 29, 20, 7, 20, 580, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2020, 9, 3, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2020, 9, 7, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2020, 9, 6, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(6624), new DateTime(2020, 9, 11, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2020, 9, 7, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(8967), new DateTime(2020, 9, 12, 20, 7, 20, 582, DateTimeKind.Local).AddTicks(8971) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 1, 17, 24, 17, 42, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 6, 17, 24, 17, 45, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 10, 17, 24, 17, 45, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 2, 11, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(3759), new DateTime(2019, 2, 21, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 2, 11, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(9405), new DateTime(2019, 2, 21, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(9540) });
        }
    }
}
