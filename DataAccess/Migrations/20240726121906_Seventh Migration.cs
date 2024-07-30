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
    public partial class SeventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("037b8c48-94ad-4c41-9ee9-74ff9ff5aae2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1feb85bd-3b2e-4f51-90dd-accbad905952"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("266caa29-06b5-4430-bb0f-8eb421fa58bc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d7b0217-1338-4c42-94d0-7c067e2f3ced"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("48fbec67-e1cf-4080-b9aa-a11041da9c7c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5390bb8c-981f-481e-96e2-539f6599a579"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5da0e0d6-3c22-4ce1-b338-b95dd7dbcd95"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5db211cc-a327-4c28-9deb-16a8634c6d40"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6641c3ab-4c0e-44dc-9b0d-f8a601b275f5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9cbd9ead-9db6-441f-8579-d2bde54e0dbc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d5281819-00da-4577-b54b-ca62e5828415"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fc4f1526-912a-4852-9184-adfefa95b352"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b77e2de-3739-4599-b2c2-8a2427529933"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ee9c892-2a73-43b4-a5a9-e68f9dc986bc"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b15c33f2-fa1b-42fa-9618-79f2bb6c1163"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("be29ab2e-3894-4269-9a7e-6c24b673ab30"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("037b8c48-94ad-4c41-9ee9-74ff9ff5aae2"), "Sports", null },
                    { new Guid("1feb85bd-3b2e-4f51-90dd-accbad905952"), "RPG", null },
                    { new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d"), "Races", null },
                    { new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028"), "Strategy", null },
                    { new Guid("5390bb8c-981f-481e-96e2-539f6599a579"), "Adventure", null },
                    { new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb"), "Action", null },
                    { new Guid("9cbd9ead-9db6-441f-8579-d2bde54e0dbc"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1b77e2de-3739-4599-b2c2-8a2427529933"), "Desktop" },
                    { new Guid("9ee9c892-2a73-43b4-a5a9-e68f9dc986bc"), "Console" },
                    { new Guid("b15c33f2-fa1b-42fa-9618-79f2bb6c1163"), "Browser" },
                    { new Guid("be29ab2e-3894-4269-9a7e-6c24b673ab30"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("266caa29-06b5-4430-bb0f-8eb421fa58bc"), "RTS", new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028") },
                    { new Guid("2d7b0217-1338-4c42-94d0-7c067e2f3ced"), "Off-road", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("48fbec67-e1cf-4080-b9aa-a11041da9c7c"), "FPS", new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb") },
                    { new Guid("5da0e0d6-3c22-4ce1-b338-b95dd7dbcd95"), "Formula", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("5db211cc-a327-4c28-9deb-16a8634c6d40"), "TBS", new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028") },
                    { new Guid("6641c3ab-4c0e-44dc-9b0d-f8a601b275f5"), "TPS", new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb") },
                    { new Guid("d5281819-00da-4577-b54b-ca62e5828415"), "Arcade", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("fc4f1526-912a-4852-9184-adfefa95b352"), "Rally", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                });
        }
    }
}
