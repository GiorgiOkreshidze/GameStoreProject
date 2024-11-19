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
    public partial class NinthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "GameEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "GameEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0b29e979-9087-4a5e-803a-87863a33d862"), "Adventure", null },
                    { new Guid("834e7dcc-f606-454a-9373-cb858baedec9"), "Strategy", null },
                    { new Guid("bb25f334-50de-44b3-914e-7974b378b4a4"), "Action", null },
                    { new Guid("ced1ccdc-65a1-4030-bb3b-628f653ba789"), "Puzzle & Skill", null },
                    { new Guid("ddb5ce50-4265-4b04-995b-a95e222c199e"), "RPG", null },
                    { new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025"), "Races", null },
                    { new Guid("fe9af3fa-5245-4415-8127-5fac152825ca"), "Sports", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("60f772ac-b42a-4c9a-8ae5-e137b9221016"), "Console" },
                    { new Guid("9e634ee1-05ff-4c40-8f1a-daefc565c905"), "Desktop" },
                    { new Guid("aff58f6c-7215-4aef-a464-e182a0eb953f"), "Browser" },
                    { new Guid("f8857eb1-50f7-4278-8d4d-1984ef4c933d"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("00a9e5f0-fa02-486f-a441-e32bdbbce798"), "FPS", new Guid("bb25f334-50de-44b3-914e-7974b378b4a4") },
                    { new Guid("00b3079e-b3c5-4c92-b593-75e75e3e10d4"), "Arcade", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("245bc2e6-0b40-430f-893e-2d8717e5b0b1"), "Rally", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("2ce71d49-cacc-44ea-9fcd-ffbf1a765daf"), "TBS", new Guid("834e7dcc-f606-454a-9373-cb858baedec9") },
                    { new Guid("3225de36-468b-41ec-b60e-c20398e218a2"), "RTS", new Guid("834e7dcc-f606-454a-9373-cb858baedec9") },
                    { new Guid("358ad9d8-772c-40b9-9916-c3778a3552b4"), "Formula", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("69c50341-bcd9-441a-841b-e1b058a9db28"), "Off-road", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("ff503b22-abe4-41d0-bf64-13553d593794"), "TPS", new Guid("bb25f334-50de-44b3-914e-7974b378b4a4") },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("00a9e5f0-fa02-486f-a441-e32bdbbce798"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("00b3079e-b3c5-4c92-b593-75e75e3e10d4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b29e979-9087-4a5e-803a-87863a33d862"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("245bc2e6-0b40-430f-893e-2d8717e5b0b1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2ce71d49-cacc-44ea-9fcd-ffbf1a765daf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3225de36-468b-41ec-b60e-c20398e218a2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("358ad9d8-772c-40b9-9916-c3778a3552b4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("69c50341-bcd9-441a-841b-e1b058a9db28"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ced1ccdc-65a1-4030-bb3b-628f653ba789"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ddb5ce50-4265-4b04-995b-a95e222c199e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fe9af3fa-5245-4415-8127-5fac152825ca"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ff503b22-abe4-41d0-bf64-13553d593794"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("60f772ac-b42a-4c9a-8ae5-e137b9221016"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9e634ee1-05ff-4c40-8f1a-daefc565c905"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("aff58f6c-7215-4aef-a464-e182a0eb953f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8857eb1-50f7-4278-8d4d-1984ef4c933d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("834e7dcc-f606-454a-9373-cb858baedec9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb25f334-50de-44b3-914e-7974b378b4a4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025"));

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "GameEntities");

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
    }
}
