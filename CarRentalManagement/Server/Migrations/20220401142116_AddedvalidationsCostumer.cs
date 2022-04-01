using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedvalidationsCostumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
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
                value: "bed471f2-c59c-41af-a02e-03bde057b890");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "0f09de6b-b617-4664-8b35-f03b3615fd5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "508e533b-6cfb-43e1-b608-82be9183d78b", "AQAAAAEAACcQAAAAEB3i4mNCLgJnlxgPUvr6VGYX/mG9MOH+pSAlgRk805ecRZnS3Wr0cVLIdz0kgnCybA==", "bd7d2a91-0cdc-4a55-83c7-cc44582b7c8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e7d86a-6ca8-4fbb-b041-80e8cd8fba1c", "AQAAAAEAACcQAAAAEGnbrmdpsY364ekBQ50jOk5deXJXns1CYP1h974kgvaY1KZoRAmd4B6kq/xU9Yr65A==", "b5094961-490f-4e25-b94b-355d85bb2464" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 51, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 4, 1, 14, 22, 11, 51, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 51, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 4, 1, 14, 22, 11, 51, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 1, 14, 22, 11, 50, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 4, 1, 14, 22, 11, 52, DateTimeKind.Local).AddTicks(2870) });
        }
    }
}
