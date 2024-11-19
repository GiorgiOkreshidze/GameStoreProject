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
    public partial class EighteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ObjectType",
                table: "DatabaseIdsSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Synchronized",
                table: "DatabaseIdsSet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("218ebbd6-17bb-425c-969a-f8e79e53b7f7"), "", "Puzzle & Skill", null, "" },
                    { new Guid("5b384e5c-bf03-4b58-8251-f8597543249b"), "", "RPG", null, "" },
                    { new Guid("677bc7cf-ce77-4e31-977a-32c868d45c0f"), "", "Action", null, "" },
                    { new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"), "", "Races", null, "" },
                    { new Guid("e5682db0-34ac-4d75-b97a-a0a0afe0b8aa"), "", "Strategy", null, "" },
                    { new Guid("ec8f4b6f-4c19-47ae-ac2e-8b18e907cfcd"), "", "Adventure", null, "" },
                    { new Guid("fa3252e6-63ad-4aa4-8055-6fe040cf349f"), "", "Sports", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("04707c98-876c-4ab9-ad2c-14387d871824"), "Browser" },
                    { new Guid("346078eb-94de-42fa-a105-7e22bec4bbba"), "Desktop" },
                    { new Guid("5959f91a-9f36-4d07-b8fe-9626a65c38a1"), "Console" },
                    { new Guid("9667b23f-aeaf-4037-8181-7aa4110198a2"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("04d87893-d10a-4e81-9b16-85e212ad908e"), "", "Off-road", new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"), "" },
                    { new Guid("12d25583-3667-4bd5-b7e9-b931fe5b10dd"), "", "Formula", new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"), "" },
                    { new Guid("3805550f-c00b-4883-9279-ab99809eaa6e"), "", "TPS", new Guid("677bc7cf-ce77-4e31-977a-32c868d45c0f"), "" },
                    { new Guid("40417a8e-908a-4f51-9f65-216a93af10c7"), "", "FPS", new Guid("677bc7cf-ce77-4e31-977a-32c868d45c0f"), "" },
                    { new Guid("41643b4e-e170-4842-bc93-e3dd79365934"), "", "RTS", new Guid("e5682db0-34ac-4d75-b97a-a0a0afe0b8aa"), "" },
                    { new Guid("45eebf82-ec13-4fe9-9e1b-07570746a65f"), "", "Arcade", new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"), "" },
                    { new Guid("6c2befd4-6d85-42ab-b76e-d4e73047ec2f"), "", "TBS", new Guid("e5682db0-34ac-4d75-b97a-a0a0afe0b8aa"), "" },
                    { new Guid("b93f6912-e322-42dc-bb2f-25516ee5696b"), "", "Rally", new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"), "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("04d87893-d10a-4e81-9b16-85e212ad908e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("12d25583-3667-4bd5-b7e9-b931fe5b10dd"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("218ebbd6-17bb-425c-969a-f8e79e53b7f7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3805550f-c00b-4883-9279-ab99809eaa6e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("40417a8e-908a-4f51-9f65-216a93af10c7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("41643b4e-e170-4842-bc93-e3dd79365934"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("45eebf82-ec13-4fe9-9e1b-07570746a65f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b384e5c-bf03-4b58-8251-f8597543249b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6c2befd4-6d85-42ab-b76e-d4e73047ec2f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b93f6912-e322-42dc-bb2f-25516ee5696b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ec8f4b6f-4c19-47ae-ac2e-8b18e907cfcd"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa3252e6-63ad-4aa4-8055-6fe040cf349f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("04707c98-876c-4ab9-ad2c-14387d871824"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("346078eb-94de-42fa-a105-7e22bec4bbba"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("5959f91a-9f36-4d07-b8fe-9626a65c38a1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9667b23f-aeaf-4037-8181-7aa4110198a2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("677bc7cf-ce77-4e31-977a-32c868d45c0f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a123f089-9ac1-4e26-b7ff-6b5554166a3f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e5682db0-34ac-4d75-b97a-a0a0afe0b8aa"));

            migrationBuilder.DropColumn(
                name: "ObjectType",
                table: "DatabaseIdsSet");

            migrationBuilder.DropColumn(
                name: "Synchronized",
                table: "DatabaseIdsSet");

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
    }
}
