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
    public partial class EighthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("017551a1-a776-49dc-9914-b7cc769578ff"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("052cced9-0f9a-440f-9138-852feb4e3dc0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("256616b8-a1fe-4eb7-bee9-beb8de6c88a0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("29ed8eaf-fca2-4ca0-99ca-3fb7aed19db6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d8a5d3d-5401-4d4e-8aac-ad0a99f0dc49"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("35884d14-c840-4a47-9bb0-c888eb2d9617"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("739d6d02-6dd3-4970-9739-c45624934184"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("865f2457-f500-4ec8-b9f3-93feda4c8317"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("979fc130-d4bf-43b1-a085-39388c3e9116"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b028daa5-e4b9-43aa-a0eb-5ed12e1c2195"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ba87ed11-fb38-466c-9648-5761850d41ca"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7e25f21-ed12-4f1d-bd4e-724b219899c6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0fc95a9a-92e8-4c21-ba8c-099e2e190bcb"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("4179ffe7-c5ea-42ce-8811-0764b8b41211"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("4967008f-6a4a-496c-8150-1efcb41a5d8e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("7fa7c335-37e0-4e07-8ca6-1607f40ec6df"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4b2711e8-6a5c-407a-a9b9-b66d2ff5a82e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c4c01f04-d6ed-4853-b4d6-133b5f531b15"));

            migrationBuilder.CreateTable(
                name: "BannedUserEntities",
                columns: table => new
                {
                    User = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannedUserEntities", x => x.User);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("4032d546-f291-41e0-8a13-57988533b424"), "Action", null },
                    { new Guid("4eb68758-5a21-4d49-8da7-e8cd5285e978"), "RPG", null },
                    { new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d"), "Races", null },
                    { new Guid("8a4694bd-38b8-49ef-88c3-ba30a9191fd5"), "Adventure", null },
                    { new Guid("8c371b8b-1b2b-450f-8526-a846e53ef57e"), "Sports", null },
                    { new Guid("b41c57b9-5388-4565-b323-477c94862a1c"), "Puzzle & Skill", null },
                    { new Guid("d14c950c-823b-442f-a9e1-bf4f67f808fa"), "Strategy", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("571318c3-ff28-4ba1-80b4-41a374cc9294"), "Console" },
                    { new Guid("5841e98b-69e9-488c-8421-6f99b539eaba"), "Desktop" },
                    { new Guid("83f6d3ac-400a-4345-a71e-350226de9c5c"), "Mobile" },
                    { new Guid("e55a22e9-260d-44f9-b16a-89ccbdaa80c5"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("11002b55-892b-4c80-9753-f83c98b42667"), "TBS", new Guid("d14c950c-823b-442f-a9e1-bf4f67f808fa") },
                    { new Guid("1cce1bf6-2930-45bb-acea-e033b853fae2"), "Arcade", new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d") },
                    { new Guid("27ac0e9c-0b68-4d8e-9a84-a16d8079a188"), "Rally", new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d") },
                    { new Guid("32bf5f34-b727-4e73-af3f-620103cb0f94"), "FPS", new Guid("4032d546-f291-41e0-8a13-57988533b424") },
                    { new Guid("3f7d4f32-3961-44bc-84a2-b04c2b63aa9e"), "Off-road", new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d") },
                    { new Guid("99a3a8a2-5294-4cec-848a-f225a928e2f4"), "RTS", new Guid("d14c950c-823b-442f-a9e1-bf4f67f808fa") },
                    { new Guid("a55217b6-c039-4159-af58-712423612712"), "TPS", new Guid("4032d546-f291-41e0-8a13-57988533b424") },
                    { new Guid("ca149a29-52d7-41de-91c7-9495c4a562d4"), "Formula", new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d") },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannedUserEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("11002b55-892b-4c80-9753-f83c98b42667"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1cce1bf6-2930-45bb-acea-e033b853fae2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("27ac0e9c-0b68-4d8e-9a84-a16d8079a188"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("32bf5f34-b727-4e73-af3f-620103cb0f94"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3f7d4f32-3961-44bc-84a2-b04c2b63aa9e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4eb68758-5a21-4d49-8da7-e8cd5285e978"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a4694bd-38b8-49ef-88c3-ba30a9191fd5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c371b8b-1b2b-450f-8526-a846e53ef57e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("99a3a8a2-5294-4cec-848a-f225a928e2f4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a55217b6-c039-4159-af58-712423612712"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b41c57b9-5388-4565-b323-477c94862a1c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca149a29-52d7-41de-91c7-9495c4a562d4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("571318c3-ff28-4ba1-80b4-41a374cc9294"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("5841e98b-69e9-488c-8421-6f99b539eaba"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("83f6d3ac-400a-4345-a71e-350226de9c5c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e55a22e9-260d-44f9-b16a-89ccbdaa80c5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4032d546-f291-41e0-8a13-57988533b424"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("527d01f3-3c2d-44d2-b84d-d717174d562d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d14c950c-823b-442f-a9e1-bf4f67f808fa"));

            migrationBuilder.CreateTable(
                name: "BanEntities",
                columns: table => new
                {
                    Duration = table.Column<string>(type: "nvarchar(450)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanEntities", x => x.Duration);
                });

            migrationBuilder.InsertData(
                table: "BanEntities",
                column: "Duration",
                values: new object[]
                {
                    "1 day",
                    "1 hour",
                    "1 month",
                    "1 week",
                    "permanent",
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("29ed8eaf-fca2-4ca0-99ca-3fb7aed19db6"), "Sports", null },
                    { new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8"), "Races", null },
                    { new Guid("4b2711e8-6a5c-407a-a9b9-b66d2ff5a82e"), "Strategy", null },
                    { new Guid("979fc130-d4bf-43b1-a085-39388c3e9116"), "Adventure", null },
                    { new Guid("b028daa5-e4b9-43aa-a0eb-5ed12e1c2195"), "RPG", null },
                    { new Guid("c4c01f04-d6ed-4853-b4d6-133b5f531b15"), "Action", null },
                    { new Guid("d7e25f21-ed12-4f1d-bd4e-724b219899c6"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0fc95a9a-92e8-4c21-ba8c-099e2e190bcb"), "Mobile" },
                    { new Guid("4179ffe7-c5ea-42ce-8811-0764b8b41211"), "Desktop" },
                    { new Guid("4967008f-6a4a-496c-8150-1efcb41a5d8e"), "Console" },
                    { new Guid("7fa7c335-37e0-4e07-8ca6-1607f40ec6df"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("017551a1-a776-49dc-9914-b7cc769578ff"), "Formula", new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8") },
                    { new Guid("052cced9-0f9a-440f-9138-852feb4e3dc0"), "Off-road", new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8") },
                    { new Guid("256616b8-a1fe-4eb7-bee9-beb8de6c88a0"), "Rally", new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8") },
                    { new Guid("2d8a5d3d-5401-4d4e-8aac-ad0a99f0dc49"), "FPS", new Guid("c4c01f04-d6ed-4853-b4d6-133b5f531b15") },
                    { new Guid("35884d14-c840-4a47-9bb0-c888eb2d9617"), "Arcade", new Guid("2d1bdb22-de22-432b-8bf8-537823145ea8") },
                    { new Guid("739d6d02-6dd3-4970-9739-c45624934184"), "TPS", new Guid("c4c01f04-d6ed-4853-b4d6-133b5f531b15") },
                    { new Guid("865f2457-f500-4ec8-b9f3-93feda4c8317"), "RTS", new Guid("4b2711e8-6a5c-407a-a9b9-b66d2ff5a82e") },
                    { new Guid("ba87ed11-fb38-466c-9648-5761850d41ca"), "TBS", new Guid("4b2711e8-6a5c-407a-a9b9-b66d2ff5a82e") },
                });
        }
    }
}
