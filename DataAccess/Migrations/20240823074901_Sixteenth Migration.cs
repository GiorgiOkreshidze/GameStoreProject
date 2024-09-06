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
    public partial class SixteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e790e7d-7e6f-4108-9730-fa018bd46872"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e0a81a4-0ad1-448d-a4b6-a6afd427c245"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("50242e63-4830-4388-a770-a0a3ace77974"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("63b34d0a-7b96-4672-97df-d2537457910b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6b60db5e-04a9-458c-b108-786fdc8e1473"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c88f3d7-a257-4e04-8ac5-1363ddf8fd45"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb165b3d-34a5-42a0-b684-f72fd6d6d34c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("db25ec49-a5bc-4a08-bee1-012a96f8fb44"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc5ebc98-cbc6-45d1-90dd-2ab0d9efe081"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("dd6bc795-1d28-45e2-9efb-f7a1a74ca0a6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e024358e-82d3-45ba-bdef-843a689282a1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3bdaef4-e216-403d-81ed-896d8ae34480"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0cca01e7-72af-449d-a038-39286572c13c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b0e85af-316f-4808-a6c9-5e51f2f52bac"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("63b04322-ead4-41e9-bf9f-53794b0c8043"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("77c1ea9f-a5f5-453b-a27d-301014a3f4c6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("409cb8d8-8434-401b-acbf-561325feb849"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2586aab-af19-456b-a7a3-2596395b238c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e8f96f0b-b0e9-4215-9147-82b6e5ae1884"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderGameId",
                table: "OrderGames",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames",
                column: "OrderGameId");

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderGames_OrderId",
                table: "OrderGames",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames");

            migrationBuilder.DropIndex(
                name: "IX_OrderGames_OrderId",
                table: "OrderGames");

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

            migrationBuilder.DropColumn(
                name: "OrderGameId",
                table: "OrderGames");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderGames",
                table: "OrderGames",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("409cb8d8-8434-401b-acbf-561325feb849"), "", "Action", null, "" },
                    { new Guid("63b34d0a-7b96-4672-97df-d2537457910b"), "", "Adventure", null, "" },
                    { new Guid("d2586aab-af19-456b-a7a3-2596395b238c"), "", "Races", null, "" },
                    { new Guid("dd6bc795-1d28-45e2-9efb-f7a1a74ca0a6"), "", "RPG", null, "" },
                    { new Guid("e024358e-82d3-45ba-bdef-843a689282a1"), "", "Sports", null, "" },
                    { new Guid("e8f96f0b-b0e9-4215-9147-82b6e5ae1884"), "", "Strategy", null, "" },
                    { new Guid("f3bdaef4-e216-403d-81ed-896d8ae34480"), "", "Puzzle & Skill", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0cca01e7-72af-449d-a038-39286572c13c"), "Desktop" },
                    { new Guid("3b0e85af-316f-4808-a6c9-5e51f2f52bac"), "Browser" },
                    { new Guid("63b04322-ead4-41e9-bf9f-53794b0c8043"), "Mobile" },
                    { new Guid("77c1ea9f-a5f5-453b-a27d-301014a3f4c6"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1e790e7d-7e6f-4108-9730-fa018bd46872"), "", "Off-road", new Guid("d2586aab-af19-456b-a7a3-2596395b238c"), "" },
                    { new Guid("4e0a81a4-0ad1-448d-a4b6-a6afd427c245"), "", "TPS", new Guid("409cb8d8-8434-401b-acbf-561325feb849"), "" },
                    { new Guid("50242e63-4830-4388-a770-a0a3ace77974"), "", "RTS", new Guid("e8f96f0b-b0e9-4215-9147-82b6e5ae1884"), "" },
                    { new Guid("6b60db5e-04a9-458c-b108-786fdc8e1473"), "", "Arcade", new Guid("d2586aab-af19-456b-a7a3-2596395b238c"), "" },
                    { new Guid("7c88f3d7-a257-4e04-8ac5-1363ddf8fd45"), "", "Formula", new Guid("d2586aab-af19-456b-a7a3-2596395b238c"), "" },
                    { new Guid("bb165b3d-34a5-42a0-b684-f72fd6d6d34c"), "", "FPS", new Guid("409cb8d8-8434-401b-acbf-561325feb849"), "" },
                    { new Guid("db25ec49-a5bc-4a08-bee1-012a96f8fb44"), "", "TBS", new Guid("e8f96f0b-b0e9-4215-9147-82b6e5ae1884"), "" },
                    { new Guid("dc5ebc98-cbc6-45d1-90dd-2ab0d9efe081"), "", "Rally", new Guid("d2586aab-af19-456b-a7a3-2596395b238c"), "" }
                });
        }
    }
}
