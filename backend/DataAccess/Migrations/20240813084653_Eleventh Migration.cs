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
    public partial class EleventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("03ebd16b-ee06-467f-b436-a3e0e92a3475"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1c152611-98b7-46e3-b9b4-1ef88f92589f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1fb5c57f-3589-4af7-a107-09d653ee4bbf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("556cd4fd-78c2-42be-8f96-074b266f9372"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5d87f2dc-8c65-4a54-8647-6405b7b788eb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6e3a8446-0c24-4854-85d1-8ab0a5119d99"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9bbe051e-c76c-4768-b104-3a7fdd66506a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3b13d1c-d407-4ce4-bec6-6c3b10482bb5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("acf85088-2604-4066-a554-dd91aaad5856"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b42aa2fb-f03f-44bb-abc0-7920b4c76104"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b961e2bf-f34c-45ec-9cf5-0db2f4b04c6e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d598350e-d7d2-4851-afbd-ee84428ec7a7"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("2fec40db-be43-4bef-84b0-2987a0847035"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("31bed5a7-481a-44bd-8723-a7805e9aa8ac"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c2ce715-850c-4f36-adcb-123d308d2ecf"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("96629d81-cc69-4542-91f5-7b6abf52f1dd"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bce50724-9419-472c-9d43-e0e7436b9678"));

            migrationBuilder.CreateTable(
                name: "DatabaseIdsSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MongoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseIdsSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1e14e7aa-6016-4a4a-96bb-1c7aa073fede"), "", "Puzzle & Skill", null, "" },
                    { new Guid("1f038d13-f586-4179-b25e-019558671694"), "", "Adventure", null, "" },
                    { new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "", "Strategy", null, "" },
                    { new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "", "Action", null, "" },
                    { new Guid("8a9d7b63-219d-4f3e-863c-ef5dcd4af8c2"), "", "RPG", null, "" },
                    { new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "", "Races", null, "" },
                    { new Guid("db77707a-0b03-4fc0-94f9-c70ca2d9eeec"), "", "Sports", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("49609ea0-2f4d-49fa-80cb-b7a7b02adee6"), "Console" },
                    { new Guid("9eb7ecd5-2b8a-4ecf-8838-3b06cc7071e1"), "Mobile" },
                    { new Guid("ca293d35-d00a-4e21-ae12-fdbc2d64bf79"), "Browser" },
                    { new Guid("cdf5ca7f-6f5d-4ae6-a64a-c9a0bd23eae9"), "Desktop" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("14991903-e627-49a7-91bf-199e015fdbe4"), "", "FPS", new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "" },
                    { new Guid("167060fa-8173-4820-b652-758a3d74b45f"), "", "TBS", new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "" },
                    { new Guid("3c5bab75-585a-48a9-810f-8fd7fb1d17d7"), "", "Arcade", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("9a73b715-2dd9-4484-bb89-431008596af6"), "", "Formula", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("bf0aeb6a-1a73-45b0-92fc-7aa39db5dafc"), "", "RTS", new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"), "" },
                    { new Guid("ddf4e44b-a366-4e9b-b628-c0393b37191a"), "", "TPS", new Guid("3028c15b-1300-488a-b5f3-084b1504960b"), "" },
                    { new Guid("f5143101-dd96-4019-be86-31b05ce87830"), "", "Off-road", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                    { new Guid("fdf5007f-12ba-4915-b344-07667fa0beff"), "", "Rally", new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"), "" },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatabaseIdsSet");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("14991903-e627-49a7-91bf-199e015fdbe4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("167060fa-8173-4820-b652-758a3d74b45f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e14e7aa-6016-4a4a-96bb-1c7aa073fede"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f038d13-f586-4179-b25e-019558671694"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c5bab75-585a-48a9-810f-8fd7fb1d17d7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a9d7b63-219d-4f3e-863c-ef5dcd4af8c2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a73b715-2dd9-4484-bb89-431008596af6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bf0aeb6a-1a73-45b0-92fc-7aa39db5dafc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("db77707a-0b03-4fc0-94f9-c70ca2d9eeec"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ddf4e44b-a366-4e9b-b628-c0393b37191a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5143101-dd96-4019-be86-31b05ce87830"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fdf5007f-12ba-4915-b344-07667fa0beff"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("49609ea0-2f4d-49fa-80cb-b7a7b02adee6"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9eb7ecd5-2b8a-4ecf-8838-3b06cc7071e1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca293d35-d00a-4e21-ae12-fdbc2d64bf79"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cdf5ca7f-6f5d-4ae6-a64a-c9a0bd23eae9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("20241608-a388-4cd8-9d1f-c828eccee3ca"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3028c15b-1300-488a-b5f3-084b1504960b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d25c15b-f11f-42b6-a538-2ad459e5006e"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("03ebd16b-ee06-467f-b436-a3e0e92a3475"), "", "Puzzle & Skill", null, "" },
                    { new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), "", "Strategy", null, "" },
                    { new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), "", "Action", null, "" },
                    { new Guid("9bbe051e-c76c-4768-b104-3a7fdd66506a"), "", "RPG", null, "" },
                    { new Guid("a3b13d1c-d407-4ce4-bec6-6c3b10482bb5"), "", "Adventure", null, "" },
                    { new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), "", "Races", null, "" },
                    { new Guid("d598350e-d7d2-4851-afbd-ee84428ec7a7"), "", "Sports", null, "" },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2fec40db-be43-4bef-84b0-2987a0847035"), "Browser" },
                    { new Guid("31bed5a7-481a-44bd-8723-a7805e9aa8ac"), "Console" },
                    { new Guid("5c2ce715-850c-4f36-adcb-123d308d2ecf"), "Desktop" },
                    { new Guid("96629d81-cc69-4542-91f5-7b6abf52f1dd"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1c152611-98b7-46e3-b9b4-1ef88f92589f"), "", "Rally", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), "" },
                    { new Guid("1fb5c57f-3589-4af7-a107-09d653ee4bbf"), "", "Formula", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), "" },
                    { new Guid("556cd4fd-78c2-42be-8f96-074b266f9372"), "", "TBS", new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), "" },
                    { new Guid("5d87f2dc-8c65-4a54-8647-6405b7b788eb"), "", "TPS", new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), "" },
                    { new Guid("6e3a8446-0c24-4854-85d1-8ab0a5119d99"), "", "FPS", new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), "" },
                    { new Guid("acf85088-2604-4066-a554-dd91aaad5856"), "", "RTS", new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), "" },
                    { new Guid("b42aa2fb-f03f-44bb-abc0-7920b4c76104"), "", "Off-road", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), "" },
                    { new Guid("b961e2bf-f34c-45ec-9cf5-0db2f4b04c6e"), "", "Arcade", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), "" },
                });
        }
    }
}
