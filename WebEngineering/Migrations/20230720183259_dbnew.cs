using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class dbnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -1);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e43c773d-caef-40da-953f-237a39ab0347", "0e9b5eab-40f1-45c2-a24d-63fd37af6fa5", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16b1ded0-d96f-4766-b1ab-9f0e95756c1e", 0, "e93827c7-5b27-45ec-8cdf-7f2ccecca76a", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4Uuoi1Ppm1VP+aSsrLL4m9pQ7GajRhFrvlzCLueRLvk43kpRTK7rIGpP1O2Hv9zQ==", null, false, "e59aafa4-ef7b-4237-93dd-537ae2e98c18", false, "demo01@gmail.com" },
                    { "2e5a8c01-cd13-4c38-8efe-27adb9d37d41", 0, "a58ce7aa-bb35-4308-a131-571481064bb2", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEOjHYoU7pXsV0AkpYQ0GqetSm16m3t/69s6ejKljhHSL78ItAq22p3lBmPRsRV7Qvw==", null, false, "fd182861-5ae8-4b55-87f9-a85f0071fbc5", false, "demo03@gmail.com" },
                    { "817d72c8-a46f-48a2-b5fa-2ff5f7302ea2", 0, "50ab9473-26c0-4853-8862-65f1e553dc6d", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAELSMYgX4wkUbUnj22+2C6A1NsRJUOwu0Wfib8VHipsD38R7D2qJEHhDj0FvkKGmzhA==", null, false, "f3cc39e3-a319-4f53-bf93-deb80d38ced5", false, "demo02@gmail.com" },
                    { "83a569cd-8e2b-4e3e-95bb-a24a1a7fd532", 0, "647537b6-77d3-4ad4-b0a0-b4b16d321daf", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFys1q9tH8dyAnt/N5hRHqX31ikSZYJK3AaEeahFbargQmocqYPWxNySeS5FuK1fQg==", null, false, "9abbae67-87d8-46ee-870f-e66ae47081b5", false, "admin@gmail.com" },
                    { "e63c7ee9-d210-454d-be09-b6dddb0f83f6", 0, "f49a9648-3e31-4ba3-8902-159b7d782be6", null, false, false, null, null, "DEMO04@GMAIL.COM", "AQAAAAEAACcQAAAAEFNpC042qEl8YFgL17nsg8js1Ee/jOifhb91FTSkvqyARGGYSkEesnFBY5aDQdVjZQ==", null, false, "ee740da1-8159-4376-96be-0a8966bacdd5", false, "demo04@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 8, 9, 6, 0, 0, DateTimeKind.Unspecified), 215, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 26, 15, 31, 0, 0, DateTimeKind.Unspecified), 105, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 10, 3, 30, 0, 0, DateTimeKind.Unspecified), 297, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 27, 20, 24, 0, 0, DateTimeKind.Unspecified), 105, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 29, 9, 48, 0, 0, DateTimeKind.Unspecified), 116, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 17, 8, 37, 0, 0, DateTimeKind.Unspecified), 43, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 38, 0, 0, DateTimeKind.Unspecified), 159, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 21, 5, 0, 0, 0, DateTimeKind.Unspecified), 205, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 40, 0, 0, DateTimeKind.Unspecified), 247, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 15, 12, 15, 0, 0, DateTimeKind.Unspecified), 104, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 23, 3, 34, 0, 0, DateTimeKind.Unspecified), 129, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 7, 15, 2, 0, 0, DateTimeKind.Unspecified), 149, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 3, 2, 1, 0, 0, DateTimeKind.Unspecified), 168, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 9, 15, 23, 0, 0, DateTimeKind.Unspecified), 223, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 5, 12, 29, 0, 0, DateTimeKind.Unspecified), 10, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 12, 5, 55, 0, 0, DateTimeKind.Unspecified), 291, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 3, 11, 50, 0, 0, DateTimeKind.Unspecified), 123, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 3, 10, 4, 0, 0, DateTimeKind.Unspecified), 130, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 15, 6, 58, 0, 0, DateTimeKind.Unspecified), 288, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 27, 19, 44, 0, 0, DateTimeKind.Unspecified), 80, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 20, 3, 50, 0, 0, DateTimeKind.Unspecified), 158, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 15, 14, 46, 0, 0, DateTimeKind.Unspecified), 263, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 11, 6, 6, 0, 0, DateTimeKind.Unspecified), 10, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 4, 6, 31, 0, 0, DateTimeKind.Unspecified), 133, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 24, 3, 31, 0, 0, DateTimeKind.Unspecified), 35, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 58, 0, 0, DateTimeKind.Unspecified), 39, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 17, 11, 16, 0, 0, DateTimeKind.Unspecified), 105, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 190, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 4, 9, 59, 0, 0, DateTimeKind.Unspecified), 161, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 18, 2, 13, 0, 0, DateTimeKind.Unspecified), 214, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 28, 4, 40, 0, 0, DateTimeKind.Unspecified), 21, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 3, 7, 4, 0, 0, DateTimeKind.Unspecified), 86, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 15, 22, 46, 0, 0, DateTimeKind.Unspecified), 154, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 16, 6, 38, 0, 0, DateTimeKind.Unspecified), 287, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 3, 16, 17, 0, 0, DateTimeKind.Unspecified), 138, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 9, 6, 10, 40, 0, 0, DateTimeKind.Unspecified), 89 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 26, 9, 47, 0, 0, DateTimeKind.Unspecified), 215, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 19, 10, 6, 0, 0, DateTimeKind.Unspecified), 161, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 8, 11, 23, 16, 0, 0, DateTimeKind.Unspecified), 234 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 26, 1, 13, 0, 0, DateTimeKind.Unspecified), 9, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 46, 0, 0, DateTimeKind.Unspecified), 182, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 17, 0, 0, DateTimeKind.Unspecified), 148, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 24, 18, 44, 0, 0, DateTimeKind.Unspecified), 211, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 26, 7, 3, 0, 0, DateTimeKind.Unspecified), 45, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 11, 5, 19, 0, 0, DateTimeKind.Unspecified), 211, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 17, 1, 20, 0, 0, DateTimeKind.Unspecified), 236, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 37, 0, 0, DateTimeKind.Unspecified), 230, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 23, 9, 45, 0, 0, DateTimeKind.Unspecified), 62, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 5, 4, 33, 0, 0, DateTimeKind.Unspecified), 167, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 20, 10, 41, 0, 0, DateTimeKind.Unspecified), 42, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 2, 20, 22, 0, 0, DateTimeKind.Unspecified), 201, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 1, 22, 55, 0, 0, DateTimeKind.Unspecified), 25, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 28, 20, 23, 0, 0, DateTimeKind.Unspecified), 285, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 29, 2, 48, 0, 0, DateTimeKind.Unspecified), 44, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 13, 5, 36, 0, 0, DateTimeKind.Unspecified), 271, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 2, 0, 47, 0, 0, DateTimeKind.Unspecified), 227, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 23, 5, 14, 0, 0, DateTimeKind.Unspecified), 142, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 7, 3, 29, 0, 0, DateTimeKind.Unspecified), 30, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 22, 2, 56, 0, 0, DateTimeKind.Unspecified), 48, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 19, 17, 41, 0, 0, DateTimeKind.Unspecified), 206, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 27, 3, 24, 0, 0, DateTimeKind.Unspecified), 106, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 18, 0, 0, DateTimeKind.Unspecified), 187, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 29, 18, 20, 0, 0, DateTimeKind.Unspecified), 288, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 288, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 16, 23, 42, 0, 0, DateTimeKind.Unspecified), 24, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 2, 4, 12, 0, 0, DateTimeKind.Unspecified), 261, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 57, 0, 0, DateTimeKind.Unspecified), 167, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 23, 17, 41, 0, 0, DateTimeKind.Unspecified), 261, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 20, 14, 51, 0, 0, DateTimeKind.Unspecified), 298, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 31, 5, 45, 0, 0, DateTimeKind.Unspecified), 247, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 7, 1, 51, 0, 0, DateTimeKind.Unspecified), 61, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 29, 1, 52, 0, 0, DateTimeKind.Unspecified), 169, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 10, 12, 19, 0, 0, DateTimeKind.Unspecified), 232, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 6, 23, 42, 0, 0, DateTimeKind.Unspecified), 249, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 22, 20, 28, 0, 0, DateTimeKind.Unspecified), 142, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 22, 4, 51, 0, 0, DateTimeKind.Unspecified), 88, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 4, 5, 1, 0, 0, DateTimeKind.Unspecified), 61, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 21, 18, 14, 0, 0, DateTimeKind.Unspecified), 260, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 22, 4, 18, 0, 0, DateTimeKind.Unspecified), 227, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 8, 0, 32, 0, 0, DateTimeKind.Unspecified), 71, -19 });

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 10, 59, 0, 0, DateTimeKind.Unspecified), 1936, -16 },
                    { 2, new DateTime(2022, 9, 13, 14, 22, 0, 0, DateTimeKind.Unspecified), 1137, -13 },
                    { 3, new DateTime(2023, 1, 10, 16, 59, 0, 0, DateTimeKind.Unspecified), 4130, -15 },
                    { 4, new DateTime(2023, 10, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 4531, -3 },
                    { 5, new DateTime(2022, 4, 4, 14, 56, 0, 0, DateTimeKind.Unspecified), 3461, -12 },
                    { 6, new DateTime(2022, 2, 13, 15, 27, 0, 0, DateTimeKind.Unspecified), 2217, -14 },
                    { 7, new DateTime(2023, 6, 14, 17, 45, 0, 0, DateTimeKind.Unspecified), 1780, -4 },
                    { 8, new DateTime(2022, 10, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), 661, -5 },
                    { 9, new DateTime(2023, 3, 24, 6, 43, 0, 0, DateTimeKind.Unspecified), 3800, -12 },
                    { 10, new DateTime(2023, 3, 21, 11, 27, 0, 0, DateTimeKind.Unspecified), 1776, -13 },
                    { 11, new DateTime(2023, 6, 7, 2, 8, 0, 0, DateTimeKind.Unspecified), 1262, -15 },
                    { 12, new DateTime(2022, 2, 11, 7, 51, 0, 0, DateTimeKind.Unspecified), 1907, -15 },
                    { 13, new DateTime(2022, 9, 12, 12, 22, 0, 0, DateTimeKind.Unspecified), 4271, -12 },
                    { 14, new DateTime(2022, 5, 26, 9, 34, 0, 0, DateTimeKind.Unspecified), 2502, -1 },
                    { 15, new DateTime(2022, 4, 21, 2, 3, 0, 0, DateTimeKind.Unspecified), 2666, -15 },
                    { 16, new DateTime(2022, 4, 6, 22, 26, 0, 0, DateTimeKind.Unspecified), 3179, -3 },
                    { 17, new DateTime(2022, 1, 12, 20, 4, 0, 0, DateTimeKind.Unspecified), 4018, -18 },
                    { 18, new DateTime(2022, 6, 18, 2, 27, 0, 0, DateTimeKind.Unspecified), 850, -9 },
                    { 19, new DateTime(2023, 4, 4, 14, 57, 0, 0, DateTimeKind.Unspecified), 2529, -8 },
                    { 20, new DateTime(2022, 8, 6, 4, 8, 0, 0, DateTimeKind.Unspecified), 3290, -1 }
                });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -20,
                column: "Name",
                value: "Steinbolzen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -19,
                column: "Name",
                value: "Kunststoffrohre");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -18,
                column: "Name",
                value: "Keramikfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -17,
                column: "Name",
                value: "Papierschalter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -16,
                column: "Name",
                value: "Steinzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -15,
                column: "Name",
                value: "Betonzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -14,
                column: "Name",
                value: "Betonkabel");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -13,
                column: "Name",
                value: "Metallschalter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -12,
                column: "Name",
                value: "Keramikdichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -11,
                column: "Name",
                value: "Stahlgehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -10,
                column: "Name",
                value: "Acrylsensoren");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -9,
                column: "Name",
                value: "Glasbolzen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -8,
                column: "Name",
                value: "Acrylventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -7,
                column: "Name",
                value: "Plexiglassensoren");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -6,
                column: "Name",
                value: "Silberzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -5,
                column: "Name",
                value: "Titangehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -4,
                column: "Name",
                value: "Keramikunterlegscheiben");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -3,
                column: "Name",
                value: "Titansensoren");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -2,
                column: "Name",
                value: "Titanschalter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -1,
                column: "Name",
                value: "Kunststoffgehäuse");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e43c773d-caef-40da-953f-237a39ab0347", "83a569cd-8e2b-4e3e-95bb-a24a1a7fd532" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e43c773d-caef-40da-953f-237a39ab0347", "83a569cd-8e2b-4e3e-95bb-a24a1a7fd532" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16b1ded0-d96f-4766-b1ab-9f0e95756c1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e5a8c01-cd13-4c38-8efe-27adb9d37d41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "817d72c8-a46f-48a2-b5fa-2ff5f7302ea2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e63c7ee9-d210-454d-be09-b6dddb0f83f6");

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e43c773d-caef-40da-953f-237a39ab0347");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83a569cd-8e2b-4e3e-95bb-a24a1a7fd532");

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
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 16, 18, 31, 0, 0, DateTimeKind.Unspecified), 254, -18 });

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
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 6, 24, 3, 22, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 3, 18, 48, 0, 0, DateTimeKind.Unspecified), 247, -7 });

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
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 31, 0, 0, DateTimeKind.Unspecified), 99 });

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
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 17, 8, 31, 0, 0, DateTimeKind.Unspecified), 165, -19 });

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

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -20, new DateTime(2023, 1, 27, 18, 31, 0, 0, DateTimeKind.Unspecified), 1638, -12 },
                    { -19, new DateTime(2023, 11, 21, 4, 44, 0, 0, DateTimeKind.Unspecified), 3054, -2 },
                    { -18, new DateTime(2022, 2, 19, 13, 17, 0, 0, DateTimeKind.Unspecified), 679, -2 },
                    { -17, new DateTime(2022, 9, 28, 15, 53, 0, 0, DateTimeKind.Unspecified), 1273, -6 },
                    { -16, new DateTime(2022, 6, 18, 18, 15, 0, 0, DateTimeKind.Unspecified), 2831, -11 },
                    { -15, new DateTime(2022, 2, 23, 12, 39, 0, 0, DateTimeKind.Unspecified), 1296, -3 },
                    { -14, new DateTime(2023, 2, 14, 10, 35, 0, 0, DateTimeKind.Unspecified), 4690, -11 },
                    { -13, new DateTime(2022, 1, 21, 22, 32, 0, 0, DateTimeKind.Unspecified), 4647, -16 },
                    { -12, new DateTime(2022, 1, 12, 15, 15, 0, 0, DateTimeKind.Unspecified), 562, -3 },
                    { -11, new DateTime(2023, 4, 13, 17, 24, 0, 0, DateTimeKind.Unspecified), 3958, -12 },
                    { -10, new DateTime(2023, 12, 23, 17, 20, 0, 0, DateTimeKind.Unspecified), 1853, -20 },
                    { -9, new DateTime(2023, 5, 15, 0, 36, 0, 0, DateTimeKind.Unspecified), 4682, -5 },
                    { -8, new DateTime(2023, 9, 20, 23, 51, 0, 0, DateTimeKind.Unspecified), 3699, -12 },
                    { -7, new DateTime(2022, 3, 18, 19, 44, 0, 0, DateTimeKind.Unspecified), 4115, -17 },
                    { -6, new DateTime(2022, 10, 26, 2, 44, 0, 0, DateTimeKind.Unspecified), 3401, -5 },
                    { -5, new DateTime(2022, 3, 14, 9, 1, 0, 0, DateTimeKind.Unspecified), 1724, -11 },
                    { -4, new DateTime(2023, 5, 10, 4, 59, 0, 0, DateTimeKind.Unspecified), 3433, -4 },
                    { -3, new DateTime(2023, 6, 25, 18, 38, 0, 0, DateTimeKind.Unspecified), 2834, -19 },
                    { -2, new DateTime(2022, 8, 12, 9, 56, 0, 0, DateTimeKind.Unspecified), 3490, -15 },
                    { -1, new DateTime(2022, 1, 8, 3, 7, 0, 0, DateTimeKind.Unspecified), 542, -20 }
                });

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
    }
}
