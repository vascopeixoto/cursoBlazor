using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedImageCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "dc69463c-88a4-4f33-9508-908352a607d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "2a21c50e-5ab1-491d-b013-3bce9a5bf83c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079e2d80-8699-4412-b15f-9f6ce0967150", "AQAAAAEAACcQAAAAEKxtsLNpHRve5VfXpaHqoyZNo1nvAADKl4u/mrOKLTmoQUEmJA7rnxp3xHEajQNrEg==", "2aa558ff-1e60-4d5e-8913-394bbf17279a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b32f747-632a-4548-8b52-5d5ff7a8bc34", "AQAAAAEAACcQAAAAEKRd6oRWisIMawZoxrgdOkU1bs3DmqrdskiP0e6fMxVgUuUH80Tr/b3rkRY9bMm7Ig==", "727d79ee-075d-46c1-8d6f-4f3b9bcb3ef7" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 419, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 4, 6, 11, 40, 12, 419, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 419, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 4, 6, 11, 40, 12, 419, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(960), new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 6, 11, 40, 12, 418, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1770), new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 4, 6, 11, 40, 12, 420, DateTimeKind.Local).AddTicks(1880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "1d59a93c-45ff-4a64-8e26-70efa8ec947e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "3bd49d06-ca12-4496-a736-b8478d751734");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2806c703-b35b-47f4-8a6c-6904a5f4c464", "AQAAAAEAACcQAAAAEI4+IB/IOMGFD90ve4vF0YJBvovqG2bSmVxDzrJxtK3XBi/LKRzBcvwL3FAOjX364Q==", "e39bc82e-f1db-4d6b-9339-3ab696bd09e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53637f9c-a70a-456a-9f8e-cd62c33c5218", "AQAAAAEAACcQAAAAENN679OqRViIouBgpeiJ8gJeqkzndT/s+YtYJTG62pQxZelfqEOFrLUVI2ToJ8NpnQ==", "2084dcf3-09f0-4322-b9b8-8edd77580fb3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(530), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 4, 1, 15, 39, 25, 348, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4880), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 4, 1, 15, 39, 25, 350, DateTimeKind.Local).AddTicks(4920) });
        }
    }
}
