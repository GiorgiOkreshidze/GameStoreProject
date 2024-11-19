#pragma warning disable IDE0005
using System;
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
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("034f2c9e-6b39-4247-a46a-c9e4cead66f4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("05d9af50-709b-4e19-920c-3cc6791b22d8"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1067bed4-d7aa-4748-b9e9-a6f9357d488a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("75c92c51-1ed6-46ac-9178-dd21d8894ea0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f2f8c3d-55fc-41c5-b687-98cd1b25229d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa09e067-200c-4b5f-8ca2-76cbc273d80a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b4fbb613-5cd0-486e-8863-c1159df5adb9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b7b49741-1b5e-4d13-a437-6fd6d48220fc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb28cab6-bb51-4682-ba9d-2458517101b8"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e5807121-9457-4e8d-a372-ce1f15152dc3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e96878b2-0479-492c-9491-efef4d36ed1b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f76974be-8105-478b-9876-16106a993671"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("39dfa3f4-f5d8-4715-9bfd-996afb42ad68"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("3f4e76bd-49f0-45e2-863b-1d23447f03f6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("81c6e194-40e2-43af-a3fc-3aa2acad8415"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("c4c9689d-c96d-4996-b6a7-14de9b9d35d7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("742c6f15-8c3e-4213-87df-9f3a18e91683"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8cfa6a94-798a-49e6-a197-77814b9adec7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("eba938cb-c257-4079-82e4-1d4a22753786"));

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "GameEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "GameEntities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "PublisherId",
                table: "GameEntities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "UnitInStock",
                table: "GameEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PublisherEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HomePage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0bda1c48-8b0f-4f0a-a912-f4319cecb9ae"), "Action", null },
                    { new Guid("11e3023e-197a-4863-8c5a-bc221ebae4be"), "Adventure", null },
                    { new Guid("159aa1b6-6674-4f4a-9ee5-636f3b121d92"), "RPG", null },
                    { new Guid("2a78bcf1-d627-4fd1-a179-c27d1650f654"), "Strategy", null },
                    { new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad"), "Races", null },
                    { new Guid("c810e50c-55ba-42f9-8d31-a29cee42bf90"), "Puzzle & Skill", null },
                    { new Guid("d9eb95e7-5be6-4ae2-9185-6a985413e7ff"), "Sports", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1b5cdf01-f7cb-4714-b6d6-c534c5bb7863"), "Mobile" },
                    { new Guid("6bd1a416-4966-4cf5-927c-037dbaf1c2ee"), "Browser" },
                    { new Guid("95e32a44-a290-41f5-b09b-1076a2818da6"), "Console" },
                    { new Guid("cada2521-bdcd-4915-86fc-33feadc1124a"), "Desktop" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0698b891-2e51-4b40-a01b-458aeabd6172"), "Formula", new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad") },
                    { new Guid("3cf2a4ec-c87e-4006-abaf-3dd26f1e7db2"), "RTS", new Guid("2a78bcf1-d627-4fd1-a179-c27d1650f654") },
                    { new Guid("43ede327-16f4-4d7b-ac16-eb090789f2a9"), "Arcade", new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad") },
                    { new Guid("4af9f656-7ac6-44b7-8616-c6a69ffaf552"), "Rally", new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad") },
                    { new Guid("9a9f279f-c51a-4055-b7b7-a3d10482e2ed"), "TBS", new Guid("2a78bcf1-d627-4fd1-a179-c27d1650f654") },
                    { new Guid("caa3e07e-e0e3-4f0e-b0bd-8aa255503d06"), "Off-road", new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad") },
                    { new Guid("cf047ced-7dc8-4238-bac3-115ea37cce09"), "TPS", new Guid("0bda1c48-8b0f-4f0a-a912-f4319cecb9ae") },
                    { new Guid("ebb58d0e-795a-4a0d-8597-73c7c1f51ac8"), "FPS", new Guid("0bda1c48-8b0f-4f0a-a912-f4319cecb9ae") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameEntities_PublisherId",
                table: "GameEntities",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_PublisherEntities_CompanyName",
                table: "PublisherEntities",
                column: "CompanyName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GameEntities_PublisherEntities_PublisherId",
                table: "GameEntities",
                column: "PublisherId",
                principalTable: "PublisherEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameEntities_PublisherEntities_PublisherId",
                table: "GameEntities");

            migrationBuilder.DropTable(
                name: "PublisherEntities");

            migrationBuilder.DropIndex(
                name: "IX_GameEntities_PublisherId",
                table: "GameEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0698b891-2e51-4b40-a01b-458aeabd6172"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("11e3023e-197a-4863-8c5a-bc221ebae4be"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("159aa1b6-6674-4f4a-9ee5-636f3b121d92"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3cf2a4ec-c87e-4006-abaf-3dd26f1e7db2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("43ede327-16f4-4d7b-ac16-eb090789f2a9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4af9f656-7ac6-44b7-8616-c6a69ffaf552"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a9f279f-c51a-4055-b7b7-a3d10482e2ed"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c810e50c-55ba-42f9-8d31-a29cee42bf90"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("caa3e07e-e0e3-4f0e-b0bd-8aa255503d06"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf047ced-7dc8-4238-bac3-115ea37cce09"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d9eb95e7-5be6-4ae2-9185-6a985413e7ff"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ebb58d0e-795a-4a0d-8597-73c7c1f51ac8"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b5cdf01-f7cb-4714-b6d6-c534c5bb7863"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("6bd1a416-4966-4cf5-927c-037dbaf1c2ee"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("95e32a44-a290-41f5-b09b-1076a2818da6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cada2521-bdcd-4915-86fc-33feadc1124a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0bda1c48-8b0f-4f0a-a912-f4319cecb9ae"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a78bcf1-d627-4fd1-a179-c27d1650f654"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("745a261f-9805-4d03-ba51-1c80cfce50ad"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "UnitInStock",
                table: "GameEntities");

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
                    { new Guid("f76974be-8105-478b-9876-16106a993671"), "RPG", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("39dfa3f4-f5d8-4715-9bfd-996afb42ad68"), "Console" },
                    { new Guid("3f4e76bd-49f0-45e2-863b-1d23447f03f6"), "Desktop" },
                    { new Guid("81c6e194-40e2-43af-a3fc-3aa2acad8415"), "Mobile" },
                    { new Guid("c4c9689d-c96d-4996-b6a7-14de9b9d35d7"), "Browser" },
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
                    { new Guid("e96878b2-0479-492c-9491-efef4d36ed1b"), "FPS", new Guid("8cfa6a94-798a-49e6-a197-77814b9adec7") },
                });
        }
    }
}
