#pragma warning disable IDE0005
using System;
#pragma warning restore IDE0005
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
#pragma warning disable IDE0300
#pragma warning disable CA1861
#pragma warning disable IDE0160
#pragma warning disable IDE0161

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("08db5014-181d-4c5e-b358-0707b6e2ab41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("17934fe9-fd88-48b3-b521-45c82d225458"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("33f55a75-be3c-4cad-98c6-f58fd2885a41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3e4b08ae-61a5-4190-920c-7e459ba7b800"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4df789d2-2a0c-410a-930c-2b9de8a71a66"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e3c732d-0f5b-436f-bbd3-19fe00c367c9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b852b775-9c8e-4985-bc0c-1e1d7860bc4f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b9f4b0c2-2d6d-4b68-a907-367bcc92dbe7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e05f09bf-57df-4364-b7f8-6eac6c75c99a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f67c9a8a-94ea-4727-aed5-20498994a0b5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ffe783f7-37c4-4c79-9e47-f1e0aa2d7e98"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ffee4c51-c872-4bd0-bf29-edd4e54b4e86"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Title",
                keyValue: "IBox Terminal");

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("50bfd22a-92d4-49ac-bf89-d285be92e61e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("7eace3d5-35dd-466f-9c74-f6b7b571a2c4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb6be885-c2c2-4cda-8705-184e98464a5e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ed6164cf-b9f2-4401-898b-89ea81adc670"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c805fff-151d-44b5-9816-cab2365714e3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9213d53f-9c93-4c31-971b-f85c73850095"));

            migrationBuilder.CreateTable(
                name: "CommentEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentEntities_CommentEntities_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "CommentEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommentEntities_GameEntities_GameEntityId",
                        column: x => x.GameEntityId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("037b8c48-94ad-4c41-9ee9-74ff9ff5aae2"), "Sports", null },
                    { new Guid("1feb85bd-3b2e-4f51-90dd-accbad905952"), "RPG", null },
                    { new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d"), "Races", null },
                    { new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028"), "Strategy", null },
                    { new Guid("5390bb8c-981f-481e-96e2-539f6599a579"), "Adventure", null },
                    { new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb"), "Action", null },
                    { new Guid("9cbd9ead-9db6-441f-8579-d2bde54e0dbc"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Title", "Description", "ImageUrl" },
                values: new object[] { "IBox terminal", "IBox Terminal Method Description", "IBox Terminal Method URL" });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1b77e2de-3739-4599-b2c2-8a2427529933"), "Desktop" },
                    { new Guid("9ee9c892-2a73-43b4-a5a9-e68f9dc986bc"), "Console" },
                    { new Guid("b15c33f2-fa1b-42fa-9618-79f2bb6c1163"), "Browser" },
                    { new Guid("be29ab2e-3894-4269-9a7e-6c24b673ab30"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("266caa29-06b5-4430-bb0f-8eb421fa58bc"), "RTS", new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028") },
                    { new Guid("2d7b0217-1338-4c42-94d0-7c067e2f3ced"), "Off-road", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("48fbec67-e1cf-4080-b9aa-a11041da9c7c"), "FPS", new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb") },
                    { new Guid("5da0e0d6-3c22-4ce1-b338-b95dd7dbcd95"), "Formula", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("5db211cc-a327-4c28-9deb-16a8634c6d40"), "TBS", new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028") },
                    { new Guid("6641c3ab-4c0e-44dc-9b0d-f8a601b275f5"), "TPS", new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb") },
                    { new Guid("d5281819-00da-4577-b54b-ca62e5828415"), "Arcade", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                    { new Guid("fc4f1526-912a-4852-9184-adfefa95b352"), "Rally", new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentEntities_GameEntityId",
                table: "CommentEntities",
                column: "GameEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentEntities_ParentCommentId",
                table: "CommentEntities",
                column: "ParentCommentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("037b8c48-94ad-4c41-9ee9-74ff9ff5aae2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1feb85bd-3b2e-4f51-90dd-accbad905952"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("266caa29-06b5-4430-bb0f-8eb421fa58bc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d7b0217-1338-4c42-94d0-7c067e2f3ced"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("48fbec67-e1cf-4080-b9aa-a11041da9c7c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5390bb8c-981f-481e-96e2-539f6599a579"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5da0e0d6-3c22-4ce1-b338-b95dd7dbcd95"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5db211cc-a327-4c28-9deb-16a8634c6d40"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6641c3ab-4c0e-44dc-9b0d-f8a601b275f5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9cbd9ead-9db6-441f-8579-d2bde54e0dbc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d5281819-00da-4577-b54b-ca62e5828415"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fc4f1526-912a-4852-9184-adfefa95b352"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Title",
                keyValue: "IBox terminal");

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b77e2de-3739-4599-b2c2-8a2427529933"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ee9c892-2a73-43b4-a5a9-e68f9dc986bc"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b15c33f2-fa1b-42fa-9618-79f2bb6c1163"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("be29ab2e-3894-4269-9a7e-6c24b673ab30"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("372bae05-a005-43ca-a2e6-f6ef1f7e144d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d21f2c9-5b9e-48c3-b90d-ff6e701e9028"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b1c4650-aa37-4ea3-a8c3-e6c3b53becdb"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("08db5014-181d-4c5e-b358-0707b6e2ab41"), "RPG", null },
                    { new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5"), "Action", null },
                    { new Guid("3e4b08ae-61a5-4190-920c-7e459ba7b800"), "Sports", null },
                    { new Guid("7c805fff-151d-44b5-9816-cab2365714e3"), "Races", null },
                    { new Guid("9213d53f-9c93-4c31-971b-f85c73850095"), "Strategy", null },
                    { new Guid("e05f09bf-57df-4364-b7f8-6eac6c75c99a"), "Adventure", null },
                    { new Guid("f67c9a8a-94ea-4727-aed5-20498994a0b5"), "Puzzle & Skill", null },
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Title", "Description", "ImageUrl" },
                values: new object[] { "IBox Terminal", "IBox Terminal Method Description", "IBox Terminal Method URL" });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("50bfd22a-92d4-49ac-bf89-d285be92e61e"), "Mobile" },
                    { new Guid("7eace3d5-35dd-466f-9c74-f6b7b571a2c4"), "Desktop" },
                    { new Guid("cb6be885-c2c2-4cda-8705-184e98464a5e"), "Console" },
                    { new Guid("ed6164cf-b9f2-4401-898b-89ea81adc670"), "Browser" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("17934fe9-fd88-48b3-b521-45c82d225458"), "TBS", new Guid("9213d53f-9c93-4c31-971b-f85c73850095") },
                    { new Guid("33f55a75-be3c-4cad-98c6-f58fd2885a41"), "Arcade", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("4df789d2-2a0c-410a-930c-2b9de8a71a66"), "FPS", new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5") },
                    { new Guid("4e3c732d-0f5b-436f-bbd3-19fe00c367c9"), "Rally", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("b852b775-9c8e-4985-bc0c-1e1d7860bc4f"), "RTS", new Guid("9213d53f-9c93-4c31-971b-f85c73850095") },
                    { new Guid("b9f4b0c2-2d6d-4b68-a907-367bcc92dbe7"), "Off-road", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("ffe783f7-37c4-4c79-9e47-f1e0aa2d7e98"), "Formula", new Guid("7c805fff-151d-44b5-9816-cab2365714e3") },
                    { new Guid("ffee4c51-c872-4bd0-bf29-edd4e54b4e86"), "TPS", new Guid("1d9742ba-8a19-48fa-8727-b97374bc4ce5") },
                });
        }
    }
}
