using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class Addedvalidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "4a08b61c-8a76-4528-af1b-3409a371d7f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "66d59c25-2478-46e1-a77d-12e0b5f7d2e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675fa2c4-4692-42a0-b530-d1b9a2ff6d5c", "AQAAAAEAACcQAAAAEHQ+bo2XUECDEZrA0r0bK62PhUF7QKjpIdR06nzQA8BYI0NeA9AzsPco1O6imTjKdA==", "ccd61d89-6ffa-4351-b6c0-2bf5c4671cba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9023f74d-933d-4ccb-b7d6-adc4db15ae03", "AQAAAAEAACcQAAAAEO9as01x4YLCz/Cud44LbCuQhjkUq0yOPPyy9+lqnggCncNEBdJ4GReJI4gdAR3B6Q==", "1bc8ee80-0935-4df7-80fc-821fba742bd3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(2130), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 4, 1, 15, 21, 15, 751, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 4, 1, 15, 21, 15, 753, DateTimeKind.Local).AddTicks(7020) });
        }
    }
}
