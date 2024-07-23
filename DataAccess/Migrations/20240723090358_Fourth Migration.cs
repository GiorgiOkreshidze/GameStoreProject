#pragma warning disable IDE0005
using System;
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
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3080c56c-505a-4357-a4fe-32a1c5b60442"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("39274e2a-0195-4b1f-a3bf-c515c136d3c9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3bb4cd02-9fcc-4676-b7cf-ade9dcc14ce9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4aaa444f-61cd-4702-addd-8a022b1df434"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6258e0f0-2b30-4f9e-b58e-c9db433bf928"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a49ebe5-dd2f-422f-b839-fcb4cf194fb2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("742fb096-8310-4c8c-8e23-4c242f0e2368"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a95ad46-7cc3-4c91-842f-ac3c548367fc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d283917-34ac-473f-aac8-fb73750ecee6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b0cbe55c-8b06-4ab3-9542-2adaeed4b2c7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e38cbd14-b845-4b75-bb43-14aceea60c3a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e4451bda-8930-4b49-b3d6-02a2190648df"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("50ab627f-f57b-4271-a2fc-072adfe64257"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("af10512e-25d5-4e3e-99ad-806b6160a940"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("c1916250-d617-499d-b719-e83ccbe1f945"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e700f8db-67a8-4871-93d5-bf4ce14a32d5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315"));

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Title);
                });

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
                table: "PaymentMethods",
                columns: new[] { "Title", "Description", "Url" },
                values: new object[,]
                {
                    { "Bank", "Bank Method Description", "Bank Method URL" },
                    { "IBox Terminal", "IBox Terminal Method Description", "IBox Terminal Method URL" },
                    { "Visa", "Visa Method Description", "Visa Method URL" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

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

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("3080c56c-505a-4357-a4fe-32a1c5b60442"), "Adventure", null },
                    { new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351"), "Strategy", null },
                    { new Guid("3bb4cd02-9fcc-4676-b7cf-ade9dcc14ce9"), "Sports", null },
                    { new Guid("6258e0f0-2b30-4f9e-b58e-c9db433bf928"), "RPG", null },
                    { new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c"), "Action", null },
                    { new Guid("9d283917-34ac-473f-aac8-fb73750ecee6"), "Puzzle & Skill", null },
                    { new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315"), "Races", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("50ab627f-f57b-4271-a2fc-072adfe64257"), "Browser" },
                    { new Guid("af10512e-25d5-4e3e-99ad-806b6160a940"), "Console" },
                    { new Guid("c1916250-d617-499d-b719-e83ccbe1f945"), "Desktop" },
                    { new Guid("e700f8db-67a8-4871-93d5-bf4ce14a32d5"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("39274e2a-0195-4b1f-a3bf-c515c136d3c9"), "TBS", new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351") },
                    { new Guid("4aaa444f-61cd-4702-addd-8a022b1df434"), "Off-road", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("6a49ebe5-dd2f-422f-b839-fcb4cf194fb2"), "RTS", new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351") },
                    { new Guid("742fb096-8310-4c8c-8e23-4c242f0e2368"), "Arcade", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("8a95ad46-7cc3-4c91-842f-ac3c548367fc"), "Formula", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("b0cbe55c-8b06-4ab3-9542-2adaeed4b2c7"), "FPS", new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c") },
                    { new Guid("e38cbd14-b845-4b75-bb43-14aceea60c3a"), "Rally", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("e4451bda-8930-4b49-b3d6-02a2190648df"), "TPS", new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c") },
                });
        }
    }
}
