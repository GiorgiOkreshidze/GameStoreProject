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
    public partial class ThirteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "RoleEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleEntityId, x.UserEntityId });
                    table.ForeignKey(
                        name: "FK_UserRoles_RoleEntities_RoleEntityId",
                        column: x => x.RoleEntityId,
                        principalTable: "RoleEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserEntities_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "UserEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"), "", "Races", null, "" },
                    { new Guid("4a66d2e0-aa89-43f0-892e-d35659b46a96"), "", "Strategy", null, "" },
                    { new Guid("7b52e525-b9b1-4565-9e67-467ee78c1ca1"), "", "Sports", null, "" },
                    { new Guid("94a42337-75e5-447e-ac0e-9ec2ddf4670f"), "", "Puzzle & Skill", null, "" },
                    { new Guid("9f67d6b0-dbcf-400d-ac86-1564406f1916"), "", "Action", null, "" },
                    { new Guid("ca9cc793-1fe9-42f6-b820-445af9b59546"), "", "RPG", null, "" },
                    { new Guid("d15d24a3-54cd-4379-86f6-b404bb9d374c"), "", "Adventure", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2c7885ce-39ff-45dc-b24e-3fc17ce5ea9a"), "Console" },
                    { new Guid("490b433f-f19d-4627-af7b-cb6af12c7d68"), "Mobile" },
                    { new Guid("6abab298-d80c-4033-bd94-3b5add2a43d2"), "Desktop" },
                    { new Guid("f1b78aa6-8aec-4620-af7a-eada99ec86c0"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1c3f95d5-527d-41ce-b2e9-e2f04a1c0058"), "", "FPS", new Guid("9f67d6b0-dbcf-400d-ac86-1564406f1916"), "" },
                    { new Guid("68645222-7273-4680-9e94-35de5b0eaf75"), "", "Off-road", new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"), "" },
                    { new Guid("806f7294-b360-4313-8543-39ee9c23c19c"), "", "Rally", new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"), "" },
                    { new Guid("aa5cc1dd-531e-40f7-a505-57520ae0f5f5"), "", "Arcade", new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"), "" },
                    { new Guid("bed83619-1c9c-4db3-a8cf-329a8d841945"), "", "TPS", new Guid("9f67d6b0-dbcf-400d-ac86-1564406f1916"), "" },
                    { new Guid("d59012c2-0e63-4875-b757-ebce62a0e103"), "", "RTS", new Guid("4a66d2e0-aa89-43f0-892e-d35659b46a96"), "" },
                    { new Guid("de3dc7d6-ff21-492e-ba36-e1cfb40bd78c"), "", "Formula", new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"), "" },
                    { new Guid("e192d8aa-a56a-4f92-947e-a87f7e7ec3e2"), "", "TBS", new Guid("4a66d2e0-aa89-43f0-892e-d35659b46a96"), "" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserEntityId",
                table: "UserRoles",
                column: "UserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "RoleEntities");

            migrationBuilder.DropTable(
                name: "UserEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1c3f95d5-527d-41ce-b2e9-e2f04a1c0058"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("68645222-7273-4680-9e94-35de5b0eaf75"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7b52e525-b9b1-4565-9e67-467ee78c1ca1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("806f7294-b360-4313-8543-39ee9c23c19c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("94a42337-75e5-447e-ac0e-9ec2ddf4670f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa5cc1dd-531e-40f7-a505-57520ae0f5f5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bed83619-1c9c-4db3-a8cf-329a8d841945"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca9cc793-1fe9-42f6-b820-445af9b59546"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d15d24a3-54cd-4379-86f6-b404bb9d374c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d59012c2-0e63-4875-b757-ebce62a0e103"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("de3dc7d6-ff21-492e-ba36-e1cfb40bd78c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e192d8aa-a56a-4f92-947e-a87f7e7ec3e2"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("2c7885ce-39ff-45dc-b24e-3fc17ce5ea9a"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("490b433f-f19d-4627-af7b-cb6af12c7d68"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("6abab298-d80c-4033-bd94-3b5add2a43d2"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1b78aa6-8aec-4620-af7a-eada99ec86c0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0e0476cd-7e15-4701-abe3-19b3cd93f3a6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a66d2e0-aa89-43f0-892e-d35659b46a96"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f67d6b0-dbcf-400d-ac86-1564406f1916"));

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
    }
}
