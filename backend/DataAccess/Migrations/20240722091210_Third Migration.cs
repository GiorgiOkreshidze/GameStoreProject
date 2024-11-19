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
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "OrderEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderGames",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGames", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderGames_GameEntities_ProductId",
                        column: x => x.ProductId,
                        principalTable: "GameEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderGames_OrderEntities_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("3080c56c-505a-4357-a4fe-32a1c5b60442"), "Adventure", null },
                    { new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351"), "Strategy", null },
                    { new Guid("3bb4cd02-9fcc-4676-b7cf-ade9dcc14ce9"), "Sports", null },
                    { new Guid("6258e0f0-2b30-4f9e-b58e-c9db433bf928"), "RPG", null },
                    { new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c"), "Action", null },
                    { new Guid("9d283917-34ac-473f-aac8-fb73750ecee6"), "Puzzle & Skill", null },
                    { new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315"), "Races", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("50ab627f-f57b-4271-a2fc-072adfe64257"), "Browser" },
                    { new Guid("af10512e-25d5-4e3e-99ad-806b6160a940"), "Console" },
                    { new Guid("c1916250-d617-499d-b719-e83ccbe1f945"), "Desktop" },
                    { new Guid("e700f8db-67a8-4871-93d5-bf4ce14a32d5"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("39274e2a-0195-4b1f-a3bf-c515c136d3c9"), "TBS", new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351") },
                    { new Guid("4aaa444f-61cd-4702-addd-8a022b1df434"), "Off-road", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("6a49ebe5-dd2f-422f-b839-fcb4cf194fb2"), "RTS", new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351") },
                    { new Guid("742fb096-8310-4c8c-8e23-4c242f0e2368"), "Arcade", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("8a95ad46-7cc3-4c91-842f-ac3c548367fc"), "Formula", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("b0cbe55c-8b06-4ab3-9542-2adaeed4b2c7"), "FPS", new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c") },
                    { new Guid("e38cbd14-b845-4b75-bb43-14aceea60c3a"), "Rally", new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315") },
                    { new Guid("e4451bda-8930-4b49-b3d6-02a2190648df"), "TPS", new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderGames_ProductId",
                table: "OrderGames",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderGames");

            migrationBuilder.DropTable(
                name: "OrderEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3080c56c-505a-4357-a4fe-32a1c5b60442"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("39274e2a-0195-4b1f-a3bf-c515c136d3c9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3bb4cd02-9fcc-4676-b7cf-ade9dcc14ce9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4aaa444f-61cd-4702-addd-8a022b1df434"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6258e0f0-2b30-4f9e-b58e-c9db433bf928"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a49ebe5-dd2f-422f-b839-fcb4cf194fb2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("742fb096-8310-4c8c-8e23-4c242f0e2368"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a95ad46-7cc3-4c91-842f-ac3c548367fc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d283917-34ac-473f-aac8-fb73750ecee6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b0cbe55c-8b06-4ab3-9542-2adaeed4b2c7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e38cbd14-b845-4b75-bb43-14aceea60c3a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e4451bda-8930-4b49-b3d6-02a2190648df"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("50ab627f-f57b-4271-a2fc-072adfe64257"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("af10512e-25d5-4e3e-99ad-806b6160a940"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("c1916250-d617-499d-b719-e83ccbe1f945"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e700f8db-67a8-4871-93d5-bf4ce14a32d5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("34a55503-ffd4-456a-8e3a-3db1e5119351"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("91acfbb6-c13d-4e5e-ba00-a49f43c2e45c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d6e874f3-0ac4-43a5-8896-b73d1c64b315"));

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
        }
    }
}
