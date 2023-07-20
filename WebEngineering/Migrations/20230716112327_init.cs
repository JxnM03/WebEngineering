using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "cabd83c0-5826-465d-b401-604cd1955566" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3547d056-87ed-4dc1-adeb-3b03b588f2b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73939acc-e242-4942-9091-0249c06ee341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b1a4ca-6cf4-4b12-8b5d-5391ffc24f7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d9095ea-cf62-442a-94a2-e237df42bbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b08697c-2966-4480-a747-99abecda42dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cabd83c0-5826-465d-b401-604cd1955566");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Produkte",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "DurchschnittlicheBestellmenge",
                table: "Produkte",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DurchschnittlicheLiefermenge",
                table: "Produkte",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed204f79-8e88-48d7-8789-47e8f341e647", "372f11ee-8146-49fb-935c-810e3e4a12e6", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0da76ccb-6a24-4a42-bb74-7916f38f886b", 0, "6bb0dd4d-0bad-4a06-93bb-16e20fa03c12", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAEPZRmbvzUmLdidtz/usiPZA46GbsSiH/K7NXU8F/tjn0ukUPM7ZHopQJgiA5gR8RVA==", null, false, "4db63005-4ac8-4263-9840-9ed66d3808fa", false, "demo02@gmail.com" },
                    { "112b2ab1-7a6e-495f-952e-5c25c697e1dc", 0, "e7223eca-ee21-48be-9642-55f7fe903f09", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAELJ2iP+jIxt1PuCstO3fVkgoIaMQf+lrqNyMr3cIybm0I/FFwkIbu+0Mjpgb4tLwCQ==", null, false, "e306149a-c620-4b2e-9c89-dcdde8af3592", false, "demo01@gmail.com" },
                    { "77ebb93d-5c7a-4abb-9431-702f1437af51", 0, "60399f73-27e4-4491-bf58-c3a99fefe018", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEJMDGY8iRPqfHDm+qnRuMG8BH9HAfB9AaAzBrx9C9w34OVykXRlqtKU8VmALndyGDA==", null, false, "819eb97f-47c4-400c-ac55-c096a25b8f37", false, "demo03@gmail.com" },
                    { "887b8ef7-7744-48dd-b3a9-58997b447aa4", 0, "8ef0e7c8-af36-4290-a269-0774fbd0eb34", null, false, false, null, null, "DEMO04@GMAIL.COM", "AQAAAAEAACcQAAAAEK9HUiM7IvQsuhMFa53AxxGtYIa/dJCD8o1h/6GIQZgqlu9UjLhbQd5myAa4CTx7zg==", null, false, "7d1faddf-62c5-4458-a275-dc6eaed0df19", false, "demo04@gmail.com" },
                    { "91de8b44-6ea8-4e18-9e53-7891725196f9", 0, "6a19c4e3-5ebd-4113-b0f1-e277d95f782a", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK4yCtsLaH4X5yaKhfRXlTfYtv/U/+MIDfapilvQ0eQkjDmniaDzc3lkoGu1kBiCvw==", null, false, "5bac7536-21ee-4ba3-bed2-b5850fd240bd", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 20, 0, 0, DateTimeKind.Unspecified), 288, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 23, 13, 54, 0, 0, DateTimeKind.Unspecified), 164, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 8, 1, 30, 0, 0, DateTimeKind.Unspecified), 67, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 26, 1, 16, 0, 0, DateTimeKind.Unspecified), 93, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 7, 0, 0, DateTimeKind.Unspecified), 186, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 57, 0, 0, DateTimeKind.Unspecified), 123, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 16, 18, 49, 0, 0, DateTimeKind.Unspecified), 70, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 1, 4, 12, 0, 0, DateTimeKind.Unspecified), 121, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 37, 0, 0, DateTimeKind.Unspecified), 60, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 20, 11, 6, 0, 0, DateTimeKind.Unspecified), 239, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 166, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 19, 22, 45, 0, 0, DateTimeKind.Unspecified), 103, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 9, 16, 18, 31, 0, 0, DateTimeKind.Unspecified), 254 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 9, 14, 18, 0, 0, DateTimeKind.Unspecified), 227, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 41, 0, 0, DateTimeKind.Unspecified), 110, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 25, 8, 7, 0, 0, DateTimeKind.Unspecified), 263, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 28, 3, 41, 0, 0, DateTimeKind.Unspecified), 20, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 30, 8, 39, 0, 0, DateTimeKind.Unspecified), 264, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 26, 13, 17, 0, 0, DateTimeKind.Unspecified), 149, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 14, 5, 21, 0, 0, DateTimeKind.Unspecified), 28, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 3, 23, 21, 0, 0, DateTimeKind.Unspecified), 32, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 4, 5, 30, 0, 0, DateTimeKind.Unspecified), 137, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 52, 0, 0, DateTimeKind.Unspecified), 158, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 27, 23, 58, 0, 0, DateTimeKind.Unspecified), 290, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 29, 5, 7, 0, 0, DateTimeKind.Unspecified), 105, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 15, 0, 5, 0, 0, DateTimeKind.Unspecified), 238, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 7, 0, 0, DateTimeKind.Unspecified), 46, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 26, 1, 53, 0, 0, DateTimeKind.Unspecified), 193, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 18, 4, 23, 0, 0, DateTimeKind.Unspecified), 263, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 6, 8, 35, 0, 0, DateTimeKind.Unspecified), 255, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 20, 20, 59, 0, 0, DateTimeKind.Unspecified), 59, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 9, 0, 37, 0, 0, DateTimeKind.Unspecified), 205, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 23, 5, 2, 0, 0, DateTimeKind.Unspecified), 41, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 8, 17, 5, 0, 0, DateTimeKind.Unspecified), 113, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 29, 10, 53, 0, 0, DateTimeKind.Unspecified), 293, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 24, 3, 22, 0, 0, DateTimeKind.Unspecified), 45, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 11, 3, 18, 48, 0, 0, DateTimeKind.Unspecified), 247 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 3, 3, 52, 0, 0, DateTimeKind.Unspecified), 39, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 31, 0, 0, DateTimeKind.Unspecified), 99, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 16, 17, 12, 0, 0, DateTimeKind.Unspecified), 294, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 11, 3, 33, 0, 0, DateTimeKind.Unspecified), 23, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 5, 14, 25, 0, 0, DateTimeKind.Unspecified), 190, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 24, 17, 26, 0, 0, DateTimeKind.Unspecified), 97, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 23, 4, 36, 0, 0, DateTimeKind.Unspecified), 184, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 11, 4, 54, 0, 0, DateTimeKind.Unspecified), 121, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 18, 20, 58, 0, 0, DateTimeKind.Unspecified), 140, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 51, 0, 0, DateTimeKind.Unspecified), 186, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 4, 18, 8, 0, 0, DateTimeKind.Unspecified), 181, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 9, 19, 28, 0, 0, DateTimeKind.Unspecified), 74, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 8, 13, 59, 0, 0, DateTimeKind.Unspecified), 95, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), 57, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 27, 14, 4, 0, 0, DateTimeKind.Unspecified), 21, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 8, 0, 0, DateTimeKind.Unspecified), 187, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 9, 7, 23, 0, 0, DateTimeKind.Unspecified), 67, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 2, 0, 0, DateTimeKind.Unspecified), 47, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 31, 5, 43, 0, 0, DateTimeKind.Unspecified), 4, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 19, 22, 24, 0, 0, DateTimeKind.Unspecified), 36, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 19, 15, 56, 0, 0, DateTimeKind.Unspecified), 108, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 22, 14, 52, 0, 0, DateTimeKind.Unspecified), 223, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 21, 16, 13, 0, 0, DateTimeKind.Unspecified), 2, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 22, 0, 43, 0, 0, DateTimeKind.Unspecified), 239, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 8, 2, 19, 0, 0, DateTimeKind.Unspecified), 154, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 10, 18, 40, 0, 0, DateTimeKind.Unspecified), 105, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 21, 17, 1, 0, 0, DateTimeKind.Unspecified), 218, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 25, 11, 54, 0, 0, DateTimeKind.Unspecified), 177, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 24, 9, 51, 0, 0, DateTimeKind.Unspecified), 141, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 6, 17, 8, 31, 0, 0, DateTimeKind.Unspecified), 165 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 17, 0, 0, DateTimeKind.Unspecified), 112, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 17, 21, 10, 0, 0, DateTimeKind.Unspecified), 265, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 19, 5, 56, 0, 0, DateTimeKind.Unspecified), 51, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 31, 4, 57, 0, 0, DateTimeKind.Unspecified), 255, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 6, 14, 39, 0, 0, DateTimeKind.Unspecified), 81, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 13, 3, 7, 0, 0, DateTimeKind.Unspecified), 61, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 14, 11, 2, 0, 0, DateTimeKind.Unspecified), 130, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 10, 8, 41, 0, 0, DateTimeKind.Unspecified), 124, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 58, 0, 0, DateTimeKind.Unspecified), 243, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 5, 0, 48, 0, 0, DateTimeKind.Unspecified), 235, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 191, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 22, 5, 2, 0, 0, DateTimeKind.Unspecified), 87, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 2, 13, 35, 0, 0, DateTimeKind.Unspecified), 291, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 27, 18, 31, 0, 0, DateTimeKind.Unspecified), 1638, -12 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 21, 4, 44, 0, 0, DateTimeKind.Unspecified), 3054, -2 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 19, 13, 17, 0, 0, DateTimeKind.Unspecified), 679, -2 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 28, 15, 53, 0, 0, DateTimeKind.Unspecified), 1273, -6 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 18, 18, 15, 0, 0, DateTimeKind.Unspecified), 2831, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 2, 23, 12, 39, 0, 0, DateTimeKind.Unspecified), 1296 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 14, 10, 35, 0, 0, DateTimeKind.Unspecified), 4690, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 21, 22, 32, 0, 0, DateTimeKind.Unspecified), 4647, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 12, 15, 15, 0, 0, DateTimeKind.Unspecified), 562, -3 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 13, 17, 24, 0, 0, DateTimeKind.Unspecified), 3958, -12 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 23, 17, 20, 0, 0, DateTimeKind.Unspecified), 1853, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 36, 0, 0, DateTimeKind.Unspecified), 4682, -5 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 20, 23, 51, 0, 0, DateTimeKind.Unspecified), 3699, -12 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 44, 0, 0, DateTimeKind.Unspecified), 4115, -17 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 26, 2, 44, 0, 0, DateTimeKind.Unspecified), 3401, -5 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 3, 14, 9, 1, 0, 0, DateTimeKind.Unspecified), 1724 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 10, 4, 59, 0, 0, DateTimeKind.Unspecified), 3433, -4 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 25, 18, 38, 0, 0, DateTimeKind.Unspecified), 2834, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 12, 9, 56, 0, 0, DateTimeKind.Unspecified), 3490, -15 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 8, 3, 7, 0, 0, DateTimeKind.Unspecified), 542, -20 });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Bronzemuttern" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Stahlfilter" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Kupferzahnräder" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Glasschalter" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Keramikriemen" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Papierbolzen" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Aluminiumpumpen" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Keramikunterlegscheiben" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Kunststoffzahnräder" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Gummifilter" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Plexiglassensoren" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Aluminiumrohre" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Plexiglassensoren" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Metallfilter" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Titanfedern" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Bronzekabel" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Metallunterlegscheiben" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Keramikkabel" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Kupferfedern" });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DurchschnittlicheBestellmenge", "DurchschnittlicheLiefermenge", "Name" },
                values: new object[] { 0m, 0m, "Titanschalter" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed204f79-8e88-48d7-8789-47e8f341e647", "91de8b44-6ea8-4e18-9e53-7891725196f9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed204f79-8e88-48d7-8789-47e8f341e647", "91de8b44-6ea8-4e18-9e53-7891725196f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0da76ccb-6a24-4a42-bb74-7916f38f886b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112b2ab1-7a6e-495f-952e-5c25c697e1dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77ebb93d-5c7a-4abb-9431-702f1437af51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "887b8ef7-7744-48dd-b3a9-58997b447aa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed204f79-8e88-48d7-8789-47e8f341e647");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91de8b44-6ea8-4e18-9e53-7891725196f9");

            migrationBuilder.DropColumn(
                name: "DurchschnittlicheBestellmenge",
                table: "Produkte");

            migrationBuilder.DropColumn(
                name: "DurchschnittlicheLiefermenge",
                table: "Produkte");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Produkte",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "3c907fdf-38e3-481e-9de8-240bdcbf3812", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3547d056-87ed-4dc1-adeb-3b03b588f2b8", 0, "77b9bfa8-b88f-459f-8eeb-26b19659c73d", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAEFXFkC9ofPn87AhIHpvomP7uAVnHzLHKKEl+0qBS0CUJ4Q//IG0lmDjnDJsXZ1Qewg==", null, false, "27dcc8f3-dc32-4131-b19a-5c5090c81022", false, "demo01@gmail.com" },
                    { "73939acc-e242-4942-9091-0249c06ee341", 0, "589c6a0e-881d-43ec-9640-c5903c1a9c53", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEO6IDF8iXfyvAZSI8fbxiyJh3cKfOPWkHx4PID/Dkpui3j8ADWme32zd84lDRX1Blg==", null, false, "95456dbb-69f9-41c8-8f44-e0fb270f2a2e", false, "demo03@gmail.com" },
                    { "82b1a4ca-6cf4-4b12-8b5d-5391ffc24f7a", 0, "e3567953-a7bd-4d3a-b832-63f1f7c908d8", null, false, false, null, null, "DEMO04@GMAIL.COM", "AQAAAAEAACcQAAAAEBx9gLsjHQF+BJgko0acAQ3aY4Zj31h4J1JROOigSbQ4ZF04ObfjGwjxf8jCjgcuaQ==", null, false, "0254c1f8-0097-4203-be27-9446a8c717a7", false, "demo04@gmail.com" },
                    { "8d9095ea-cf62-442a-94a2-e237df42bbbf", 0, "29c6a031-b0b3-4eb7-97c3-eef5b6805cd7", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAECEPkT/N1c0y9QIf4KXN8dOlf3ER+bSNyYtRQl5kA5WQ0m+YJ7pDWOcTrfwImWTa/Q==", null, false, "24f24c5b-450b-42a9-b7c0-a0c51da97215", false, "demo02@gmail.com" },
                    { "cabd83c0-5826-465d-b401-604cd1955566", 0, "0c004468-e518-4de2-bb56-b4ff4bcbf3b3", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEM1/JhUui5DIxg4LW6KMRBa+xS9xUtvRh7Wssit/nukRD0Ck+91eeKcsmhZpcGggTg==", null, false, "d8b2ee83-48aa-48ea-8bc7-55021eeb2a5a", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 59, 0, 0, DateTimeKind.Unspecified), 168, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 15, 4, 0, 0, 0, DateTimeKind.Unspecified), 250, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 10, 19, 2, 0, 0, DateTimeKind.Unspecified), 145, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 29, 0, 0, DateTimeKind.Unspecified), 54, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 9, 4, 40, 0, 0, DateTimeKind.Unspecified), 179, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 7, 3, 4, 0, 0, DateTimeKind.Unspecified), 44, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 23, 22, 54, 0, 0, DateTimeKind.Unspecified), 162, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 24, 1, 38, 0, 0, DateTimeKind.Unspecified), 261, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 2, 2, 31, 0, 0, DateTimeKind.Unspecified), 157, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 26, 11, 34, 0, 0, DateTimeKind.Unspecified), 292, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 22, 18, 19, 0, 0, DateTimeKind.Unspecified), 155, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 8, 4, 23, 33, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 24, 18, 1, 0, 0, DateTimeKind.Unspecified), 52, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 16, 5, 11, 0, 0, DateTimeKind.Unspecified), 201, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 10, 4, 29, 0, 0, DateTimeKind.Unspecified), 162, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 14, 1, 46, 0, 0, DateTimeKind.Unspecified), 238, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 8, 14, 50, 0, 0, DateTimeKind.Unspecified), 119, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 31, 3, 36, 0, 0, DateTimeKind.Unspecified), 131, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 27, 10, 34, 0, 0, DateTimeKind.Unspecified), 193, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 31, 4, 20, 0, 0, DateTimeKind.Unspecified), 132, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 2, 4, 49, 0, 0, DateTimeKind.Unspecified), 74, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 10, 10, 8, 0, 0, DateTimeKind.Unspecified), 260, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 29, 4, 53, 0, 0, DateTimeKind.Unspecified), 110, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 24, 14, 23, 0, 0, DateTimeKind.Unspecified), 257, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 30, 5, 49, 0, 0, DateTimeKind.Unspecified), 42, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 38, 0, 0, DateTimeKind.Unspecified), 281, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 10, 1, 50, 0, 0, DateTimeKind.Unspecified), 237, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 3, 17, 51, 0, 0, DateTimeKind.Unspecified), 78, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 24, 4, 56, 0, 0, DateTimeKind.Unspecified), 156, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 56, 0, 0, DateTimeKind.Unspecified), 125, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 4, 18, 12, 0, 0, DateTimeKind.Unspecified), 93, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 8, 17, 7, 0, 0, DateTimeKind.Unspecified), 166, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 21, 6, 51, 0, 0, DateTimeKind.Unspecified), 195, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 10, 15, 25, 0, 0, DateTimeKind.Unspecified), 159, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 23, 14, 25, 0, 0, DateTimeKind.Unspecified), 298, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 3, 12, 5, 38, 0, 0, DateTimeKind.Unspecified), 287 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 56, 0, 0, DateTimeKind.Unspecified), 30, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 19, 21, 21, 0, 0, DateTimeKind.Unspecified), 236, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 21, 8, 45, 0, 0, DateTimeKind.Unspecified), 140, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 27, 18, 23, 0, 0, DateTimeKind.Unspecified), 224, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 33, 0, 0, DateTimeKind.Unspecified), 65, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 25, 3, 4, 0, 0, DateTimeKind.Unspecified), 215, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 30, 6, 42, 0, 0, DateTimeKind.Unspecified), 207, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 8, 0, 0, DateTimeKind.Unspecified), 152, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 5, 5, 57, 0, 0, DateTimeKind.Unspecified), 260, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 9, 2, 18, 0, 0, DateTimeKind.Unspecified), 281, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 18, 22, 22, 0, 0, DateTimeKind.Unspecified), 154, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 25, 1, 32, 0, 0, DateTimeKind.Unspecified), 288, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 15, 13, 32, 0, 0, DateTimeKind.Unspecified), 194, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 18, 4, 6, 0, 0, DateTimeKind.Unspecified), 105, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 8, 3, 26, 0, 0, DateTimeKind.Unspecified), 216, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 56, 0, 0, DateTimeKind.Unspecified), 27, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 41, 0, 0, DateTimeKind.Unspecified), 268, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 18, 4, 55, 0, 0, DateTimeKind.Unspecified), 132, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 26, 0, 0, DateTimeKind.Unspecified), 126, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 22, 0, 0, DateTimeKind.Unspecified), 167, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), 177, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 27, 10, 44, 0, 0, DateTimeKind.Unspecified), 230, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 4, 9, 3, 0, 0, DateTimeKind.Unspecified), 295, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 4, 12, 58, 0, 0, DateTimeKind.Unspecified), 138, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 184, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 23, 12, 29, 0, 0, DateTimeKind.Unspecified), 156, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 20, 6, 39, 0, 0, DateTimeKind.Unspecified), 18, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 14, 9, 10, 0, 0, DateTimeKind.Unspecified), 25, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 13, 10, 22, 0, 0, DateTimeKind.Unspecified), 58, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 5, 20, 0, 33, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 19, 8, 56, 0, 0, DateTimeKind.Unspecified), 184, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 19, 1, 18, 0, 0, DateTimeKind.Unspecified), 268, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 52, 0, 0, DateTimeKind.Unspecified), 263, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 13, 0, 0, DateTimeKind.Unspecified), 137, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 4, 16, 49, 0, 0, DateTimeKind.Unspecified), 170, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 27, 22, 30, 0, 0, DateTimeKind.Unspecified), 12, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 2, 23, 2, 0, 0, DateTimeKind.Unspecified), 163, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 25, 2, 48, 0, 0, DateTimeKind.Unspecified), 127, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 51, 0, 0, DateTimeKind.Unspecified), 211, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 3, 4, 35, 0, 0, DateTimeKind.Unspecified), 88, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 18, 7, 19, 0, 0, DateTimeKind.Unspecified), 254, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 27, 5, 35, 0, 0, DateTimeKind.Unspecified), 132, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 19, 6, 19, 0, 0, DateTimeKind.Unspecified), 293, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 24, 0, 0, DateTimeKind.Unspecified), 2060, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 42, 0, 0, DateTimeKind.Unspecified), 4681, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 2475, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 7, 17, 53, 0, 0, DateTimeKind.Unspecified), 2554, -14 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 15, 0, 0, DateTimeKind.Unspecified), 854, -6 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 9, 0, 0, DateTimeKind.Unspecified), 1604 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 18, 13, 15, 0, 0, DateTimeKind.Unspecified), 3939, -18 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 6, 12, 22, 0, 0, DateTimeKind.Unspecified), 992, -14 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 21, 23, 10, 0, 0, DateTimeKind.Unspecified), 2587, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 8, 8, 52, 0, 0, DateTimeKind.Unspecified), 4231, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 2, 8, 50, 0, 0, DateTimeKind.Unspecified), 2800, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 13, 21, 13, 0, 0, DateTimeKind.Unspecified), 1341, -6 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 2, 0, 0, DateTimeKind.Unspecified), 4036, -15 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), 4836, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 17, 3, 44, 0, 0, DateTimeKind.Unspecified), 1286, -4 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 7, 29, 4, 34, 0, 0, DateTimeKind.Unspecified), 3265 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 25, 20, 14, 0, 0, DateTimeKind.Unspecified), 860, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 22, 0, 0, DateTimeKind.Unspecified), 2461, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 8, 7, 37, 0, 0, DateTimeKind.Unspecified), 1249, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 43, 0, 0, DateTimeKind.Unspecified), 4504, -17 });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -20,
                column: "Name",
                value: "Golddichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -19,
                column: "Name",
                value: "Steinventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -18,
                column: "Name",
                value: "Gummifilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -17,
                column: "Name",
                value: "Gummifilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -16,
                column: "Name",
                value: "Plexiglasfedern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -15,
                column: "Name",
                value: "Titanriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -14,
                column: "Name",
                value: "Aluminiumfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -13,
                column: "Name",
                value: "Plexiglasventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -12,
                column: "Name",
                value: "Goldplatten");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -11,
                column: "Name",
                value: "Titangehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -10,
                column: "Name",
                value: "Bronzeriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -9,
                column: "Name",
                value: "Aluminiumfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -8,
                column: "Name",
                value: "Goldmuttern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -7,
                column: "Name",
                value: "Bronzedichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -6,
                column: "Name",
                value: "Keramikzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -5,
                column: "Name",
                value: "Kupferfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -4,
                column: "Name",
                value: "Metallkabel");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -3,
                column: "Name",
                value: "Keramikfedern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -2,
                column: "Name",
                value: "Stahlventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -1,
                column: "Name",
                value: "Textildichtungen");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "cabd83c0-5826-465d-b401-604cd1955566" });
        }
    }
}
