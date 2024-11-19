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
    public partial class FourteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PremissionEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremissionEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePremissions",
                columns: table => new
                {
                    RoleEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PremissionEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePremissions", x => new { x.PremissionEntityId, x.RoleEntityId });
                    table.ForeignKey(
                        name: "FK_RolePremissions_PremissionEntities_PremissionEntityId",
                        column: x => x.PremissionEntityId,
                        principalTable: "PremissionEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePremissions_RoleEntities_RoleEntityId",
                        column: x => x.RoleEntityId,
                        principalTable: "RoleEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1eca36cf-837f-47ad-92ae-ba1ccf7d0e3c"), "", "Sports", null, "" },
                    { new Guid("762723da-da11-4ebf-aa15-dfd78a1ec376"), "", "Puzzle & Skill", null, "" },
                    { new Guid("868dd747-a8b4-4568-93b5-b689ccac0000"), "", "Strategy", null, "" },
                    { new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "", "Races", null, "" },
                    { new Guid("a9b6f82d-4025-4bb9-9661-efe53b71ce80"), "", "Adventure", null, "" },
                    { new Guid("b403145d-fefb-4ca8-b1e5-13821a5f284d"), "", "RPG", null, "" },
                    { new Guid("e652b1f8-6567-448d-a4b9-289d286197bd"), "", "Action", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("26408167-7ac2-458b-8cbf-8a36ea57f0b4"), "Desktop" },
                    { new Guid("7734adbd-2fca-4639-9b9f-1e036dea49c2"), "Mobile" },
                    { new Guid("bd4bb6b4-71bd-4edc-b791-6977e67f4720"), "Console" },
                    { new Guid("d66c1564-9653-4f88-b751-c78d85fb45c0"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0fa2e894-7358-4644-bdd8-e1a4fa9e555c"), "", "Rally", new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "" },
                    { new Guid("873f05a1-5884-4fd2-b53b-66df4539e724"), "", "Arcade", new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "" },
                    { new Guid("991b93f5-5c39-4e2d-9e36-9eaaf7e9d443"), "", "Off-road", new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "" },
                    { new Guid("9dd4e8c4-09cc-4a70-bacd-23a60371c739"), "", "TPS", new Guid("e652b1f8-6567-448d-a4b9-289d286197bd"), "" },
                    { new Guid("b7839f0b-d7c4-40ea-b56c-bfc1bb2fa7f1"), "", "RTS", new Guid("868dd747-a8b4-4568-93b5-b689ccac0000"), "" },
                    { new Guid("b88a058f-bae0-4c7e-8b75-289a51a8e348"), "", "FPS", new Guid("e652b1f8-6567-448d-a4b9-289d286197bd"), "" },
                    { new Guid("d240b0ce-5902-4948-8fb8-847f252fa93f"), "", "TBS", new Guid("868dd747-a8b4-4568-93b5-b689ccac0000"), "" },
                    { new Guid("e5f7fd68-c87d-45b0-b45e-7830bde1431a"), "", "Formula", new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePremissions_RoleEntityId",
                table: "RolePremissions",
                column: "RoleEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePremissions");

            migrationBuilder.DropTable(
                name: "PremissionEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0fa2e894-7358-4644-bdd8-e1a4fa9e555c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1eca36cf-837f-47ad-92ae-ba1ccf7d0e3c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("762723da-da11-4ebf-aa15-dfd78a1ec376"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("873f05a1-5884-4fd2-b53b-66df4539e724"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("991b93f5-5c39-4e2d-9e36-9eaaf7e9d443"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9dd4e8c4-09cc-4a70-bacd-23a60371c739"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a9b6f82d-4025-4bb9-9661-efe53b71ce80"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b403145d-fefb-4ca8-b1e5-13821a5f284d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b7839f0b-d7c4-40ea-b56c-bfc1bb2fa7f1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b88a058f-bae0-4c7e-8b75-289a51a8e348"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d240b0ce-5902-4948-8fb8-847f252fa93f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e5f7fd68-c87d-45b0-b45e-7830bde1431a"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("26408167-7ac2-458b-8cbf-8a36ea57f0b4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("7734adbd-2fca-4639-9b9f-1e036dea49c2"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("bd4bb6b4-71bd-4edc-b791-6977e67f4720"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("d66c1564-9653-4f88-b751-c78d85fb45c0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("868dd747-a8b4-4568-93b5-b689ccac0000"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e652b1f8-6567-448d-a4b9-289d286197bd"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserEntities");

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
        }
    }
}
