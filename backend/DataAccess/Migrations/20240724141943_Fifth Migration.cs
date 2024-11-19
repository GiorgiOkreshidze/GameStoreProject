#pragma warning disable IDE0005
using System;
#pragma warning restore IDE0005
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
#pragma warning disable IDE0300
#pragma warning disable CA1861
#pragma warning disable IDE0160
#pragma warning disable IDE0161

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("30e4b92c-83ef-4049-8f57-9d2caa2e3dc2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("444db216-064c-402f-b85c-efb0ccc799d6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4453160f-dd38-4f69-87bb-c12a1847af4e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("526ccb64-d39c-40ce-965c-0908633737da"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("611f231d-6252-4914-a579-3dfee9672ae6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7253af67-c104-4cb7-867a-c929ba24a7ea"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d55723b-290e-49eb-826c-0ed66a7d479e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e487d68-fcc2-4520-920c-4b69b6d88d41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8087aa04-a17f-4693-b039-e90f610de819"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("da9ff1cb-5978-4023-ad27-dcbf70266282"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("dabe0717-c93f-4023-b638-40fa79554705"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f11e9e17-6b99-4c36-ad34-90b4ffdac2cd"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0d3ba892-0eeb-49f3-9d51-eb4a962843e8"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa20094e-8f68-47cb-b380-84c83d2939a1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae8d2f3b-9691-48d9-819d-39eced79c0cd"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6bd67fc-9cc7-4649-a333-8f30467644b3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17"));

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "PaymentMethods",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("08db5014-181d-4c5e-b358-0707b6e2ab41"), "RPG", null },
                    { new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5"), "Action", null },
                    { new Guid("3e4b08ae-61a5-4190-920c-7e459ba7b800"), "Sports", null },
                    { new Guid("7c805fff-151d-44b5-9816-cab2365714e3"), "Races", null },
                    { new Guid("9213d53f-9c93-4c31-971b-f85c73850095"), "Strategy", null },
                    { new Guid("e05f09bf-57df-4364-b7f8-6eac6c75c99a"), "Adventure", null },
                    { new Guid("f67c9a8a-94ea-4727-aed5-20498994a0b5"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("50bfd22a-92d4-49ac-bf89-d285be92e61e"), "Mobile" },
                    { new Guid("7eace3d5-35dd-466f-9c74-f6b7b571a2c4"), "Desktop" },
                    { new Guid("cb6be885-c2c2-4cda-8705-184e98464a5e"), "Console" },
                    { new Guid("ed6164cf-b9f2-4401-898b-89ea81adc670"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("17934fe9-fd88-48b3-b521-45c82d225458"), "TBS", new Guid("9213d53f-9c93-4c31-971b-f85c73850095") },
                    { new Guid("33f55a75-be3c-4cad-98c6-f58fd2885a41"), "Arcade", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("4df789d2-2a0c-410a-930c-2b9de8a71a66"), "FPS", new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5") },
                    { new Guid("4e3c732d-0f5b-436f-bbd3-19fe00c367c9"), "Rally", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("b852b775-9c8e-4985-bc0c-1e1d7860bc4f"), "RTS", new Guid("9213d53f-9c93-4c31-971b-f85c73850095") },
                    { new Guid("b9f4b0c2-2d6d-4b68-a907-367bcc92dbe7"), "Off-road", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("ffe783f7-37c4-4c79-9e47-f1e0aa2d7e98"), "Formula", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("ffee4c51-c872-4bd0-bf29-edd4e54b4e86"), "TPS", new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5") },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("08db5014-181d-4c5e-b358-0707b6e2ab41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("17934fe9-fd88-48b3-b521-45c82d225458"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("33f55a75-be3c-4cad-98c6-f58fd2885a41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3e4b08ae-61a5-4190-920c-7e459ba7b800"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4df789d2-2a0c-410a-930c-2b9de8a71a66"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e3c732d-0f5b-436f-bbd3-19fe00c367c9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b852b775-9c8e-4985-bc0c-1e1d7860bc4f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b9f4b0c2-2d6d-4b68-a907-367bcc92dbe7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e05f09bf-57df-4364-b7f8-6eac6c75c99a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f67c9a8a-94ea-4727-aed5-20498994a0b5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ffe783f7-37c4-4c79-9e47-f1e0aa2d7e98"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ffee4c51-c872-4bd0-bf29-edd4e54b4e86"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("50bfd22a-92d4-49ac-bf89-d285be92e61e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("7eace3d5-35dd-466f-9c74-f6b7b571a2c4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb6be885-c2c2-4cda-8705-184e98464a5e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ed6164cf-b9f2-4401-898b-89ea81adc670"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c805fff-151d-44b5-9816-cab2365714e3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9213d53f-9c93-4c31-971b-f85c73850095"));

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "PaymentMethods",
                newName: "Url");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5"), "Races", null },
                    { new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3"), "Strategy", null },
                    { new Guid("611f231d-6252-4914-a579-3dfee9672ae6"), "Adventure", null },
                    { new Guid("7e487d68-fcc2-4520-920c-4b69b6d88d41"), "Sports", null },
                    { new Guid("8087aa04-a17f-4693-b039-e90f610de819"), "RPG", null },
                    { new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17"), "Action", null },
                    { new Guid("dabe0717-c93f-4023-b638-40fa79554705"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0d3ba892-0eeb-49f3-9d51-eb4a962843e8"), "Browser" },
                    { new Guid("aa20094e-8f68-47cb-b380-84c83d2939a1"), "Desktop" },
                    { new Guid("ae8d2f3b-9691-48d9-819d-39eced79c0cd"), "Mobile" },
                    { new Guid("f6bd67fc-9cc7-4649-a333-8f30467644b3"), "Console" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("30e4b92c-83ef-4049-8f57-9d2caa2e3dc2"), "FPS", new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17") },
                    { new Guid("444db216-064c-402f-b85c-efb0ccc799d6"), "RTS", new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3") },
                    { new Guid("4453160f-dd38-4f69-87bb-c12a1847af4e"), "Off-road", new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5") },
                    { new Guid("526ccb64-d39c-40ce-965c-0908633737da"), "Arcade", new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5") },
                    { new Guid("7253af67-c104-4cb7-867a-c929ba24a7ea"), "Rally", new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5") },
                    { new Guid("7d55723b-290e-49eb-826c-0ed66a7d479e"), "Formula", new Guid("377e0f8b-8742-4dc8-bedb-f1fab2c323d5") },
                    { new Guid("da9ff1cb-5978-4023-ad27-dcbf70266282"), "TPS", new Guid("9fb95638-a74c-4dd5-9f28-f15a2b122f17") },
                    { new Guid("f11e9e17-6b99-4c36-ad34-90b4ffdac2cd"), "TBS", new Guid("5a2e31bc-a552-40c0-bc8d-fbdab228e4a3") },
                });
        }
    }
}
