using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedCostumerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                column: "ConcurrencyStamp",
                value: "ac886ff5-8440-4d0e-85fa-9a881fdde754");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                column: "ConcurrencyStamp",
                value: "c7e64e4e-ae6d-4467-ba50-282ea3fbe846");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa7ee06-559a-45c9-b3e1-e8b8ebcb9709", "AQAAAAEAACcQAAAAEJnyFYccV6fi8o97uBtyNkRMUPKie+m2lDAA136mO0hEqaJnRUwmaPkCNwdaIYDnyw==", "3ed5e393-56ee-4ae8-a2ef-4ab08d3849ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd925d6b-20f9-418e-a17b-3b490501561e", "AQAAAAEAACcQAAAAEPAVFOngIcPhHilWQwOtfMfyJQbdQMzT4ryEMNq+LSEQgDgTzVslIiHUdNNCbQnLxg==", "0e53d6f9-08e1-44c5-bf8f-62c88341fc81" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 249, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 4, 1, 14, 21, 2, 249, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 249, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 4, 1, 14, 21, 2, 249, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(2020), new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 4, 1, 14, 21, 2, 248, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2430), new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2440), new DateTime(2022, 4, 1, 14, 21, 2, 250, DateTimeKind.Local).AddTicks(2440) });
        }
    }
}
