#pragma warning disable IDE0005
using System;
#pragma warning restore IDE0005
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
#pragma warning disable SA1122
#pragma warning disable IDE0300
#pragma warning disable CA1861
#pragma warning disable IDE0160
#pragma warning disable IDE0161
#pragma warning disable SA1413

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seventeenthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("15e6ef87-fb81-42b9-9e85-488db7a2acab"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1fa7cb58-7d76-4c4a-a6ae-76798e192faf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2ec3cea7-d055-4de7-be46-22d779c83f63"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4377eb68-2dd8-45cf-8612-0be8bbc3ca4e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f0acc31-713e-4928-af5e-a5c6e8d4f16b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a060fb3b-66a2-4884-aebc-347958447902"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b30d4247-4743-4b8b-8353-b9570a0d07a6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d920caa0-22d4-4949-905e-2e497026e5ab"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("deebbf09-70fc-47fe-a25a-78f6cf9a358f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e6ae3c15-d79a-4d7a-9663-afff9a020f9f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ec921590-319f-4750-8255-faf56eb5d4fe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("eec61c75-c9af-46ac-97c9-d65aecdb24bf"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0dddf085-d88c-430b-ac4b-44d7777a2a66"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("4229f006-ec2a-4cf2-a465-bc7c96d4604e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("555955a6-e88c-4403-97de-0f9c73140cb0"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("65be056d-0899-4efa-a415-1292294a9618"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("528da378-129c-4b3a-8549-3f37d2549861"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a81c06b9-1671-4395-bff8-9ab1ed4e8130"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5dc79fb-e3ee-46e0-86d8-d31eaccd4dc4"));

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "CommentEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CommentEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"), "", "Strategy", null, "" },
                    { new Guid("47d66b9a-8133-4ea7-a835-a607c07a56ec"), "", "Puzzle & Skill", null, "" },
                    { new Guid("9a76a6ab-0dc3-4833-bd45-33f65511fffd"), "", "RPG", null, "" },
                    { new Guid("c92dd039-465e-46ca-aeba-81b159cee2fe"), "", "Adventure", null, "" },
                    { new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"), "", "Races", null, "" },
                    { new Guid("e42692bb-88c0-46d4-a503-cf500f1bbefe"), "", "Sports", null, "" },
                    { new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"), "", "Action", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0e635561-c15d-43d3-a6c5-22aa8396915d"), "Browser" },
                    { new Guid("5ac174f0-055f-4e9f-8623-c86a86339329"), "Console" },
                    { new Guid("615fd7bf-5320-44a2-9037-b4eb534d0672"), "Mobile" },
                    { new Guid("9cb37129-e684-4174-bcc7-5e98f769ddba"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("19f1001c-95f0-46f2-b9b3-5111519247fe"), "", "Arcade", new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"), "" },
                    { new Guid("1c1d68ed-bcbe-4e73-b423-a4dc6248f598"), "", "TPS", new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"), "" },
                    { new Guid("1f64b544-6458-4f25-97b7-58fac5d1642b"), "", "RTS", new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"), "" },
                    { new Guid("9a0e1900-a0db-4eea-839c-4d93960f1875"), "", "Formula", new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"), "" },
                    { new Guid("d2830435-cd8c-4726-abd7-5f4e480550ac"), "", "TBS", new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"), "" },
                    { new Guid("dbed1f1b-f0d1-40bd-b82d-eee04cce2f65"), "", "Off-road", new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"), "" },
                    { new Guid("e59f8f19-f30a-4d77-bd1b-717457a1f9dc"), "", "Rally", new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"), "" },
                    { new Guid("f8cf2cb7-ae47-4eba-9036-9dc638719a17"), "", "FPS", new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"), "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("19f1001c-95f0-46f2-b9b3-5111519247fe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1c1d68ed-bcbe-4e73-b423-a4dc6248f598"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f64b544-6458-4f25-97b7-58fac5d1642b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("47d66b9a-8133-4ea7-a835-a607c07a56ec"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a0e1900-a0db-4eea-839c-4d93960f1875"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a76a6ab-0dc3-4833-bd45-33f65511fffd"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c92dd039-465e-46ca-aeba-81b159cee2fe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2830435-cd8c-4726-abd7-5f4e480550ac"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("dbed1f1b-f0d1-40bd-b82d-eee04cce2f65"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e42692bb-88c0-46d4-a503-cf500f1bbefe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e59f8f19-f30a-4d77-bd1b-717457a1f9dc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8cf2cb7-ae47-4eba-9036-9dc638719a17"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0e635561-c15d-43d3-a6c5-22aa8396915d"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ac174f0-055f-4e9f-8623-c86a86339329"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("615fd7bf-5320-44a2-9037-b4eb534d0672"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9cb37129-e684-4174-bcc7-5e98f769ddba"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("24a1b221-5ed8-46c4-b474-fdb36af683da"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c974a1f2-36b6-40f4-8b60-c356c3fd9796"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e532d529-b9fb-4030-ae1b-bb33f76b94cc"));

            migrationBuilder.DropColumn(
                name: "Action",
                table: "CommentEntities");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CommentEntities");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("15e6ef87-fb81-42b9-9e85-488db7a2acab"), "", "Puzzle & Skill", null, "" },
                    { new Guid("1fa7cb58-7d76-4c4a-a6ae-76798e192faf"), "", "RPG", null, "" },
                    { new Guid("2ec3cea7-d055-4de7-be46-22d779c83f63"), "", "Adventure", null, "" },
                    { new Guid("528da378-129c-4b3a-8549-3f37d2549861"), "", "Races", null, "" },
                    { new Guid("a81c06b9-1671-4395-bff8-9ab1ed4e8130"), "", "Action", null, "" },
                    { new Guid("b5dc79fb-e3ee-46e0-86d8-d31eaccd4dc4"), "", "Strategy", null, "" },
                    { new Guid("ec921590-319f-4750-8255-faf56eb5d4fe"), "", "Sports", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0dddf085-d88c-430b-ac4b-44d7777a2a66"), "Mobile" },
                    { new Guid("4229f006-ec2a-4cf2-a465-bc7c96d4604e"), "Browser" },
                    { new Guid("555955a6-e88c-4403-97de-0f9c73140cb0"), "Desktop" },
                    { new Guid("65be056d-0899-4efa-a415-1292294a9618"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("4377eb68-2dd8-45cf-8612-0be8bbc3ca4e"), "", "Rally", new Guid("528da378-129c-4b3a-8549-3f37d2549861"), "" },
                    { new Guid("9f0acc31-713e-4928-af5e-a5c6e8d4f16b"), "", "Arcade", new Guid("528da378-129c-4b3a-8549-3f37d2549861"), "" },
                    { new Guid("a060fb3b-66a2-4884-aebc-347958447902"), "", "FPS", new Guid("a81c06b9-1671-4395-bff8-9ab1ed4e8130"), "" },
                    { new Guid("b30d4247-4743-4b8b-8353-b9570a0d07a6"), "", "Formula", new Guid("528da378-129c-4b3a-8549-3f37d2549861"), "" },
                    { new Guid("d920caa0-22d4-4949-905e-2e497026e5ab"), "", "RTS", new Guid("b5dc79fb-e3ee-46e0-86d8-d31eaccd4dc4"), "" },
                    { new Guid("deebbf09-70fc-47fe-a25a-78f6cf9a358f"), "", "Off-road", new Guid("528da378-129c-4b3a-8549-3f37d2549861"), "" },
                    { new Guid("e6ae3c15-d79a-4d7a-9663-afff9a020f9f"), "", "TPS", new Guid("a81c06b9-1671-4395-bff8-9ab1ed4e8130"), "" },
                    { new Guid("eec61c75-c9af-46ac-97c9-d65aecdb24bf"), "", "TBS", new Guid("b5dc79fb-e3ee-46e0-86d8-d31eaccd4dc4"), "" }
                });
        }
    }
}
