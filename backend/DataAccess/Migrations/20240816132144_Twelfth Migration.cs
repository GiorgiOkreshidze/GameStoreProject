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

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TwelfthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("14991903-e627-49a7-91bf-199e015fdbe4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("167060fa-8173-4820-b652-758a3d74b45f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e14e7aa-6016-4a4a-96bb-1c7aa073fede"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f038d13-f586-4179-b25e-019558671694"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c5bab75-585a-48a9-810f-8fd7fb1d17d7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a9d7b63-219d-4f3e-863c-ef5dcd4af8c2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a73b715-2dd9-4484-bb89-431008596af6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bf0aeb6a-1a73-45b0-92fc-7aa39db5dafc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("db77707a-0b03-4fc0-94f9-c70ca2d9eeec"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ddf4e44b-a366-4e9b-b628-c0393b37191a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5143101-dd96-4019-be86-31b05ce87830"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fdf5007f-12ba-4915-b344-07667fa0beff"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("49609ea0-2f4d-49fa-80cb-b7a7b02adee6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9eb7ecd5-2b8a-4ecf-8838-3b06cc7071e1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca293d35-d00a-4e21-ae12-fdbc2d64bf79"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cdf5ca7f-6f5d-4ae6-a64a-c9a0bd23eae9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3028c15b-1300-488a-b5f3-084b1504960b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("62558ff1-ecc8-487a-936d-4eaaae3d1da2"), "", "Action", null, "" },
                    { new Guid("6af9f94c-6cde-47bc-8cfd-7d5b3ff64e74"), "", "Puzzle & Skill", null, "" },
                    { new Guid("7dbff9a4-98d4-44d6-b207-3d211aadd05e"), "", "RPG", null, "" },
                    { new Guid("907cd8f6-1c02-40c6-8f0e-39ff27fb04c0"), "", "Strategy", null, "" },
                    { new Guid("c30e0492-e7d5-4352-b8f8-88996d571f13"), "", "Adventure", null, "" },
                    { new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"), "", "Races", null, "" },
                    { new Guid("ea509420-c34f-4b52-98c3-ac6cab368983"), "", "Sports", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1c1f4dea-2dc5-4298-887d-20cd2ca51f22"), "Mobile" },
                    { new Guid("32228abf-c751-4323-ac16-39f5198979e1"), "Console" },
                    { new Guid("9f51b327-b006-4e70-ba8d-90bb65019cb3"), "Browser" },
                    { new Guid("e89f026a-2ba8-4661-873e-1b6885c84690"), "Desktop" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("171d27a1-9c7d-475f-ba29-ebcdc8e0b601"), "", "TBS", new Guid("907cd8f6-1c02-40c6-8f0e-39ff27fb04c0"), "" },
                    { new Guid("19103674-1a64-437d-b7c3-0d43067817e1"), "", "Rally", new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"), "" },
                    { new Guid("19848fd6-94b6-496f-abf5-5a62fdcb778f"), "", "RTS", new Guid("907cd8f6-1c02-40c6-8f0e-39ff27fb04c0"), "" },
                    { new Guid("32776058-6efc-4ef6-a994-39b466b7b21e"), "", "Arcade", new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"), "" },
                    { new Guid("6b71aebf-a0d9-4924-8ed4-800ca30f17a4"), "", "FPS", new Guid("62558ff1-ecc8-487a-936d-4eaaae3d1da2"), "" },
                    { new Guid("97511906-00bc-4273-83a5-e3781da9ddda"), "", "TPS", new Guid("62558ff1-ecc8-487a-936d-4eaaae3d1da2"), "" },
                    { new Guid("baa636cf-ffc1-4681-bf8a-1dd17ea8c45c"), "", "Off-road", new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"), "" },
                    { new Guid("fedc097f-ef50-497a-85cc-11d0597ca62b"), "", "Formula", new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"), "" },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("171d27a1-9c7d-475f-ba29-ebcdc8e0b601"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("19103674-1a64-437d-b7c3-0d43067817e1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("19848fd6-94b6-496f-abf5-5a62fdcb778f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("32776058-6efc-4ef6-a994-39b466b7b21e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6af9f94c-6cde-47bc-8cfd-7d5b3ff64e74"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6b71aebf-a0d9-4924-8ed4-800ca30f17a4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7dbff9a4-98d4-44d6-b207-3d211aadd05e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("97511906-00bc-4273-83a5-e3781da9ddda"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("baa636cf-ffc1-4681-bf8a-1dd17ea8c45c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c30e0492-e7d5-4352-b8f8-88996d571f13"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ea509420-c34f-4b52-98c3-ac6cab368983"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fedc097f-ef50-497a-85cc-11d0597ca62b"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1c1f4dea-2dc5-4298-887d-20cd2ca51f22"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("32228abf-c751-4323-ac16-39f5198979e1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f51b327-b006-4e70-ba8d-90bb65019cb3"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e89f026a-2ba8-4661-873e-1b6885c84690"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("62558ff1-ecc8-487a-936d-4eaaae3d1da2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("907cd8f6-1c02-40c6-8f0e-39ff27fb04c0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("def2e7a3-ff09-4706-9641-10e72fb7244e"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1e14e7aa-6016-4a4a-96bb-1c7aa073fede"), "", "Puzzle & Skill", null, "" },
                    { new Guid("1f038d13-f586-4179-b25e-019558671694"), "", "Adventure", null, "" },
                    { new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "", "Strategy", null, "" },
                    { new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "", "Action", null, "" },
                    { new Guid("8a9d7b63-219d-4f3e-863c-ef5dcd4af8c2"), "", "RPG", null, "" },
                    { new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "", "Races", null, "" },
                    { new Guid("db77707a-0b03-4fc0-94f9-c70ca2d9eeec"), "", "Sports", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("49609ea0-2f4d-49fa-80cb-b7a7b02adee6"), "Console" },
                    { new Guid("9eb7ecd5-2b8a-4ecf-8838-3b06cc7071e1"), "Mobile" },
                    { new Guid("ca293d35-d00a-4e21-ae12-fdbc2d64bf79"), "Browser" },
                    { new Guid("cdf5ca7f-6f5d-4ae6-a64a-c9a0bd23eae9"), "Desktop" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("14991903-e627-49a7-91bf-199e015fdbe4"), "", "FPS", new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "" },
                    { new Guid("167060fa-8173-4820-b652-758a3d74b45f"), "", "TBS", new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "" },
                    { new Guid("3c5bab75-585a-48a9-810f-8fd7fb1d17d7"), "", "Arcade", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("9a73b715-2dd9-4484-bb89-431008596af6"), "", "Formula", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("bf0aeb6a-1a73-45b0-92fc-7aa39db5dafc"), "", "RTS", new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "" },
                    { new Guid("ddf4e44b-a366-4e9b-b628-c0393b37191a"), "", "TPS", new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "" },
                    { new Guid("f5143101-dd96-4019-be86-31b05ce87830"), "", "Off-road", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("fdf5007f-12ba-4915-b344-07667fa0beff"), "", "Rally", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                });
        }
    }
}
