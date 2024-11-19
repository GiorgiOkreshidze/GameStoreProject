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
    public partial class NineteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "DatabaseIdsSet",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("29f70ee9-b3b8-4596-b01b-415126fd7720"), "", "Adventure", null, "" },
                    { new Guid("2ddb1fbb-763e-4dee-88b6-9b669560480e"), "", "Action", null, "" },
                    { new Guid("4535b85b-9ac6-46e3-befa-874f14e54635"), "", "Strategy", null, "" },
                    { new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"), "", "Races", null, "" },
                    { new Guid("5d6added-72ee-4082-b869-e220318f2d98"), "", "Sports", null, "" },
                    { new Guid("6b59c2d1-85c2-4e1a-a7ad-eea8a3824a50"), "", "Puzzle & Skill", null, "" },
                    { new Guid("896f7b7e-4c4d-40b3-bd0b-1ae60ca91f59"), "", "RPG", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("48bb994b-e074-4917-98d0-d461252fe737"), "Mobile" },
                    { new Guid("66d5d1a0-4a24-47e3-8a3f-5e677390a963"), "Browser" },
                    { new Guid("95737404-e206-452e-9f6e-76f23c6a70b6"), "Console" },
                    { new Guid("bb543333-bec0-4afb-bd01-330d73c71314"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("50faf4de-7b9c-4cc0-b08d-5fb3a66e3060"), "", "RTS", new Guid("4535b85b-9ac6-46e3-befa-874f14e54635"), "" },
                    { new Guid("74931e19-8971-4f10-a251-bbeca3b9b2e2"), "", "FPS", new Guid("2ddb1fbb-763e-4dee-88b6-9b669560480e"), "" },
                    { new Guid("82c77d76-2195-443c-9452-b319d35e851d"), "", "TBS", new Guid("4535b85b-9ac6-46e3-befa-874f14e54635"), "" },
                    { new Guid("8a0e7646-c5dd-45e7-b784-9768ef73d9fe"), "", "Rally", new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"), "" },
                    { new Guid("9712334b-1c2e-44f1-8598-ce3cac88b680"), "", "Arcade", new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"), "" },
                    { new Guid("9ebcb7da-102a-47ef-9e84-c517052d48d2"), "", "TPS", new Guid("2ddb1fbb-763e-4dee-88b6-9b669560480e"), "" },
                    { new Guid("aecbfc9e-a39d-469f-9592-fb0cdb007079"), "", "Formula", new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"), "" },
                    { new Guid("d69b1ad6-dd9a-4440-b9b0-b0c3e9f30795"), "", "Off-road", new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"), "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("29f70ee9-b3b8-4596-b01b-415126fd7720"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("50faf4de-7b9c-4cc0-b08d-5fb3a66e3060"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5d6added-72ee-4082-b869-e220318f2d98"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6b59c2d1-85c2-4e1a-a7ad-eea8a3824a50"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("74931e19-8971-4f10-a251-bbeca3b9b2e2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("82c77d76-2195-443c-9452-b319d35e851d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("896f7b7e-4c4d-40b3-bd0b-1ae60ca91f59"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a0e7646-c5dd-45e7-b784-9768ef73d9fe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9712334b-1c2e-44f1-8598-ce3cac88b680"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ebcb7da-102a-47ef-9e84-c517052d48d2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("aecbfc9e-a39d-469f-9592-fb0cdb007079"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d69b1ad6-dd9a-4440-b9b0-b0c3e9f30795"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("48bb994b-e074-4917-98d0-d461252fe737"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("66d5d1a0-4a24-47e3-8a3f-5e677390a963"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("95737404-e206-452e-9f6e-76f23c6a70b6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb543333-bec0-4afb-bd01-330d73c71314"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2ddb1fbb-763e-4dee-88b6-9b669560480e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4535b85b-9ac6-46e3-befa-874f14e54635"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("46a2b8c0-8ab0-414d-a370-3943148a5e7b"));

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "DatabaseIdsSet");

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
    }
}
