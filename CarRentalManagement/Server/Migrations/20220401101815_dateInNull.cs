using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class dateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "111ca048-a583-45ad-a24c-897dcda2e665");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "03f69920-255a-4202-adba-457995deca24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9e02a8b-9842-48c4-9455-ed0cba2f1773", "AQAAAAEAACcQAAAAEO/kBsBAZPKpH7FcVx0Kpc2VwfowrcECnE8fQ/CUYfiPhS0ZNzs0/wKFcvxqOqw7pw==", "91b9eca5-4a2c-443c-8a68-49329c593f12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c7f77f-25c1-41cd-a69e-64a4ec3e073b", "AQAAAAEAACcQAAAAEOeaMYyI3KCr1xrYu612+uDzoHTsiyJ16NmT9Hx/HkG6wb3JOv5KlS6U/ct5lqk35A==", "adbc438c-a3ce-40ce-82b2-dea035752017" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 4, 1, 11, 18, 14, 699, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 4, 1, 11, 18, 14, 701, DateTimeKind.Local).AddTicks(7680) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "2b88bdfd-fcdf-46d2-a32b-c29dd4094771");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "0746a759-9223-4ec6-afa6-43df75853acc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8885d7a1-038c-4f42-aefa-9720bbb428d3", "AQAAAAEAACcQAAAAEAKsPRGyNXk5BrqWoUc+5bExaqsQi8ASflhWpFAb0RnBmEPRq31HrxPo9PAsnaPc0g==", "6eafc349-b276-4bee-a853-f686b7017e5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9407ff34-710e-4c96-b564-efebadf20c0d", "AQAAAAEAACcQAAAAELqb1CXfsV6slX3YcjHfx+zfzbb2giP89cT1S07EW9Fsts6ZXGjYbeH6QxJMqGuPSA==", "c5ea4035-5bfe-48f2-a7ea-dcfa4ae9debd" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 637, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 4, 1, 11, 5, 26, 637, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 637, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 4, 1, 11, 5, 26, 637, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 4, 1, 11, 5, 26, 636, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1470), new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 4, 1, 11, 5, 26, 638, DateTimeKind.Local).AddTicks(1510) });
        }
    }
}
