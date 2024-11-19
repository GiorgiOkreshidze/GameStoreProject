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
    public partial class TwentiethMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "GameEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DatabaseIdsSet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1a71180c-ceb2-43de-b75c-116fa008585e"), "", "RPG", null, "" },
                    { new Guid("6c38b607-ada9-4ca8-a4d7-51dc1b15fa63"), "", "Puzzle & Skill", null, "" },
                    { new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "", "Strategy", null, "" },
                    { new Guid("af0e3070-3943-438e-9c90-7a1b316a90d6"), "", "Adventure", null, "" },
                    { new Guid("b991789b-d61a-44f9-b862-1fd6da77fe11"), "", "Sports", null, "" },
                    { new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "", "Races", null, "" },
                    { new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "", "Action", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0f4c2fe7-5f63-4f61-9562-15c2c957f8cd"), "Mobile" },
                    { new Guid("1230d4bc-44b1-4451-a098-e88296c9285c"), "Desktop" },
                    { new Guid("b04855e2-5b9d-4685-8367-0a8b1af0bbf4"), "Console" },
                    { new Guid("b5ca5f97-3a4c-4238-b399-daa8f84e53ea"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("3b044478-027c-4e1f-844c-988c76d640bb"), "", "TBS", new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "" },
                    { new Guid("3be3d294-550a-4dd6-ba09-05ef907f37af"), "", "TPS", new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "" },
                    { new Guid("809f1d59-4175-4f1b-b88f-214cd32ba754"), "", "Rally", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("81b497e4-79fc-4052-9b2b-1875ca7346f0"), "", "FPS", new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "" },
                    { new Guid("91243d3a-dab9-4d4e-8fc1-2b89f2845fd7"), "", "Formula", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("a2e456d4-8627-424f-ad3e-c7f996bf4f58"), "", "Arcade", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("da3be1bd-e063-4469-84a3-22adb6551647"), "", "Off-road", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("f145c03e-8fb7-4fde-bc4d-70f7aed57864"), "", "RTS", new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a71180c-ceb2-43de-b75c-116fa008585e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b044478-027c-4e1f-844c-988c76d640bb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3be3d294-550a-4dd6-ba09-05ef907f37af"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6c38b607-ada9-4ca8-a4d7-51dc1b15fa63"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("809f1d59-4175-4f1b-b88f-214cd32ba754"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("81b497e4-79fc-4052-9b2b-1875ca7346f0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("91243d3a-dab9-4d4e-8fc1-2b89f2845fd7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a2e456d4-8627-424f-ad3e-c7f996bf4f58"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("af0e3070-3943-438e-9c90-7a1b316a90d6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b991789b-d61a-44f9-b862-1fd6da77fe11"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("da3be1bd-e063-4469-84a3-22adb6551647"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f145c03e-8fb7-4fde-bc4d-70f7aed57864"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f4c2fe7-5f63-4f61-9562-15c2c957f8cd"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1230d4bc-44b1-4451-a098-e88296c9285c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b04855e2-5b9d-4685-8367-0a8b1af0bbf4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5ca5f97-3a4c-4238-b399-daa8f84e53ea"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"));

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DatabaseIdsSet");

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
    }
}
