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
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameGenres",
                columns: table => new
                {
                    GameEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenres", x => new { x.GameEntityId, x.GenreEntityId });
                    table.ForeignKey(
                        name: "FK_GameGenres_GameEntities_GameEntityId",
                        column: x => x.GameEntityId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenres_GenreEntities_GenreEntityId",
                        column: x => x.GenreEntityId,
                        principalTable: "GenreEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    GameEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => new { x.GameEntityId, x.PlatformEntityId });
                    table.ForeignKey(
                        name: "FK_GamePlatforms_GameEntities_GameEntityId",
                        column: x => x.GameEntityId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_PlatformEntities_PlatformEntityId",
                        column: x => x.PlatformEntityId,
                        principalTable: "PlatformEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("034f2c9e-6b39-4247-a46a-c9e4cead66f4"), "Adventure", null },
                    { new Guid("742c6f15-8c3e-4213-87df-9f3a18e91683"), "Strategy", null },
                    { new Guid("8cfa6a94-798a-49e6-a197-77814b9adec7"), "Action", null },
                    { new Guid("aa09e067-200c-4b5f-8ca2-76cbc273d80a"), "Sports", null },
                    { new Guid("e5807121-9457-4e8d-a372-ce1f15152dc3"), "Puzzle & Skill", null },
                    { new Guid("eba938cb-c257-4079-82e4-1d4a22753786"), "Races", null },
                    { new Guid("f76974be-8105-478b-9876-16106a993671"), "RPG", null }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("39dfa3f4-f5d8-4715-9bfd-996afb42ad68"), "Console" },
                    { new Guid("3f4e76bd-49f0-45e2-863b-1d23447f03f6"), "Desktop" },
                    { new Guid("81c6e194-40e2-43af-a3fc-3aa2acad8415"), "Mobile" },
                    { new Guid("c4c9689d-c96d-4996-b6a7-14de9b9d35d7"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("05d9af50-709b-4e19-920c-3cc6791b22d8"), "Formula", new Guid("eba938cb-c257-4079-82e4-1d4a22753786") },
                    { new Guid("1067bed4-d7aa-4748-b9e9-a6f9357d488a"), "RTS", new Guid("742c6f15-8c3e-4213-87df-9f3a18e91683") },
                    { new Guid("75c92c51-1ed6-46ac-9178-dd21d8894ea0"), "Off-road", new Guid("eba938cb-c257-4079-82e4-1d4a22753786") },
                    { new Guid("9f2f8c3d-55fc-41c5-b687-98cd1b25229d"), "TBS", new Guid("742c6f15-8c3e-4213-87df-9f3a18e91683") },
                    { new Guid("b4fbb613-5cd0-486e-8863-c1159df5adb9"), "TPS", new Guid("8cfa6a94-798a-49e6-a197-77814b9adec7") },
                    { new Guid("b7b49741-1b5e-4d13-a437-6fd6d48220fc"), "Arcade", new Guid("eba938cb-c257-4079-82e4-1d4a22753786") },
                    { new Guid("bb28cab6-bb51-4682-ba9d-2458517101b8"), "Rally", new Guid("eba938cb-c257-4079-82e4-1d4a22753786") },
                    { new Guid("e96878b2-0479-492c-9491-efef4d36ed1b"), "FPS", new Guid("8cfa6a94-798a-49e6-a197-77814b9adec7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameEntities_Key",
                table: "GameEntities",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GenreEntityId",
                table: "GameGenres",
                column: "GenreEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformEntityId",
                table: "GamePlatforms",
                column: "PlatformEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreEntities_Name",
                table: "GenreEntities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreEntities_ParentGenreId",
                table: "GenreEntities",
                column: "ParentGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformEntities_Type",
                table: "PlatformEntities",
                column: "Type",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "GenreEntities");

            migrationBuilder.DropTable(
                name: "GameEntities");

            migrationBuilder.DropTable(
                name: "PlatformEntities");
        }
    }
}
