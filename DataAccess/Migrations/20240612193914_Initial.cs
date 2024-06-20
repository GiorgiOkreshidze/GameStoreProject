using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentGenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenreEntities_GenreEntities_ParentGenreId",
                        column: x => x.ParentGenreId,
                        principalTable: "GenreEntities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlatformEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameGenre",
                columns: table => new
                {
                    GameEntitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreEntitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenre", x => new { x.GameEntitiesId, x.GenreEntitiesId });
                    table.ForeignKey(
                        name: "FK_GameGenre_GameEntities_GameEntitiesId",
                        column: x => x.GameEntitiesId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenre_GenreEntities_GenreEntitiesId",
                        column: x => x.GenreEntitiesId,
                        principalTable: "GenreEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatform",
                columns: table => new
                {
                    GameEntitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformEntitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatform", x => new { x.GameEntitiesId, x.PlatformEntitiesId });
                    table.ForeignKey(
                        name: "FK_GamePlatform_GameEntities_GameEntitiesId",
                        column: x => x.GameEntitiesId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatform_PlatformEntities_PlatformEntitiesId",
                        column: x => x.PlatformEntitiesId,
                        principalTable: "PlatformEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("1b8b72f1-042a-429b-ba5c-09697a4fdf72"), "Sports", null },
                    { new Guid("2734ae8a-9dc3-4367-955a-429f425b6198"), "RPG", null },
                    { new Guid("342fa136-fa19-47e1-96d1-53e75ed85a0e"), "Adventure", null },
                    { new Guid("3c33edf2-3698-4000-b1fb-462129d0c954"), "Races", null },
                    { new Guid("836301c7-7b07-4dcf-83ec-705b25946c63"), "Action", null },
                    { new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547"), "Strategy", null },
                    { new Guid("cd615658-4c0f-4acc-b3c3-9ab3fb7a2bd5"), "Puzzle & Skill", null }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("4249a843-f8f3-4147-8b9c-8022dc03222e"), "Desktop" },
                    { new Guid("90a1e9e8-e3de-4298-a4b3-936c7d99451e"), "Mobile" },
                    { new Guid("924dc40d-1f67-44dc-af83-aad13124186e"), "Browser" },
                    { new Guid("95e2b27c-3c93-4c7c-95a8-52affc9c04ff"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("056c55ea-4f32-4a10-b002-615568469c19"), "FPS", new Guid("836301c7-7b07-4dcf-83ec-705b25946c63") },
                    { new Guid("0f444308-dd13-42b1-8cc3-af4ed8e89bd3"), "RTS", new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547") },
                    { new Guid("1902c41b-310b-4efc-81c4-7a3ff7820337"), "Formula", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("66ec2d72-6208-4178-9ea0-9f0c66d98293"), "Rally", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("7ae46eee-aa6a-448a-a1c6-d20daa2bc506"), "Off-road", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("b22e712c-34ce-422f-9fde-614e0d69664f"), "Arcade", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("b5117a1c-28d3-4d91-a96c-244fb41f20e9"), "TBS", new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547") },
                    { new Guid("fae914d8-1a86-42c8-992d-f7f12d1138f4"), "TPS", new Guid("836301c7-7b07-4dcf-83ec-705b25946c63") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GenreEntitiesId",
                table: "GameGenre",
                column: "GenreEntitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatform_PlatformEntitiesId",
                table: "GamePlatform",
                column: "PlatformEntitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreEntities_ParentGenreId",
                table: "GenreEntities",
                column: "ParentGenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenre");

            migrationBuilder.DropTable(
                name: "GamePlatform");

            migrationBuilder.DropTable(
                name: "GenreEntities");

            migrationBuilder.DropTable(
                name: "GameEntities");

            migrationBuilder.DropTable(
                name: "PlatformEntities");
        }
    }
}
