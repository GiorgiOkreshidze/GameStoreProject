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
    public partial class FifteenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PermissionEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRoles",
                columns: table => new
                {
                    RoleEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRoles", x => new { x.PermissionEntityId, x.RoleEntityId });
                    table.ForeignKey(
                        name: "FK_PermissionRoles_PermissionEntities_PermissionEntityId",
                        column: x => x.PermissionEntityId,
                        principalTable: "PermissionEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRoles_RoleEntities_RoleEntityId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRoles_RoleEntityId",
                table: "PermissionRoles",
                column: "RoleEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionRoles");

            migrationBuilder.DropTable(
                name: "PermissionEntities");

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

            migrationBuilder.CreateTable(
                name: "PremissionEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremissionEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePremissions",
                columns: table => new
                {
                    PremissionEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    { new Guid("e652b1f8-6567-448d-a4b9-289d286197bd"), "", "Action", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("26408167-7ac2-458b-8cbf-8a36ea57f0b4"), "Desktop" },
                    { new Guid("7734adbd-2fca-4639-9b9f-1e036dea49c2"), "Mobile" },
                    { new Guid("bd4bb6b4-71bd-4edc-b791-6977e67f4720"), "Console" },
                    { new Guid("d66c1564-9653-4f88-b751-c78d85fb45c0"), "Browser" }
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
                    { new Guid("e5f7fd68-c87d-45b0-b45e-7830bde1431a"), "", "Formula", new Guid("926eb9c8-38f1-470b-89e4-896c59b8f927"), "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePremissions_RoleEntityId",
                table: "RolePremissions",
                column: "RoleEntityId");
        }
    }
}
