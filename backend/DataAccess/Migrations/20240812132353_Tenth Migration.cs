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
    public partial class TenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("00a9e5f0-fa02-486f-a441-e32bdbbce798"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("00b3079e-b3c5-4c92-b593-75e75e3e10d4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b29e979-9087-4a5e-803a-87863a33d862"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("245bc2e6-0b40-430f-893e-2d8717e5b0b1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2ce71d49-cacc-44ea-9fcd-ffbf1a765daf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3225de36-468b-41ec-b60e-c20398e218a2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("358ad9d8-772c-40b9-9916-c3778a3552b4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("69c50341-bcd9-441a-841b-e1b058a9db28"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ced1ccdc-65a1-4030-bb3b-628f653ba789"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ddb5ce50-4265-4b04-995b-a95e222c199e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fe9af3fa-5245-4415-8127-5fac152825ca"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ff503b22-abe4-41d0-bf64-13553d593794"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("60f772ac-b42a-4c9a-8ae5-e137b9221016"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9e634ee1-05ff-4c40-8f1a-daefc565c905"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("aff58f6c-7215-4aef-a464-e182a0eb953f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8857eb1-50f7-4278-8d4d-1984ef4c933d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("834e7dcc-f606-454a-9373-cb858baedec9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb25f334-50de-44b3-914e-7974b378b4a4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ContactTitle",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "PublisherEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "OrderEntities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequiredDate",
                table: "OrderEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ShipAddress",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ShipCity",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ShipCountry",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ShipName",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ShipPostalCode",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "ShipRegion",
                table: "OrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<int>(
                name: "ShipVia",
                table: "OrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShippedDate",
                table: "OrderEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GenreEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "GenreEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "QuantityPerUnit",
                table: "GameEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<int>(
                name: "ReorderLevel",
                table: "GameEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitsOnOrder",
                table: "GameEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("03ebd16b-ee06-467f-b436-a3e0e92a3475"), string.Empty, "Puzzle & Skill", null, string.Empty },
                    { new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), string.Empty, "Strategy", null, string.Empty },
                    { new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), string.Empty, "Action", null, string.Empty },
                    { new Guid("9bbe051e-c76c-4768-b104-3a7fdd66506a"), string.Empty, "RPG", null, string.Empty },
                    { new Guid("a3b13d1c-d407-4ce4-bec6-6c3b10482bb5"), string.Empty, "Adventure", null, string.Empty },
                    { new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), string.Empty, "Races", null, string.Empty },
                    { new Guid("d598350e-d7d2-4851-afbd-ee84428ec7a7"), string.Empty, "Sports", null, string.Empty },
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
                    { new Guid("1c152611-98b7-46e3-b9b4-1ef88f92589f"), string.Empty, "Rally", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), string.Empty },
                    { new Guid("1fb5c57f-3589-4af7-a107-09d653ee4bbf"), string.Empty, "Formula", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), string.Empty },
                    { new Guid("556cd4fd-78c2-42be-8f96-074b266f9372"), string.Empty, "TBS", new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), string.Empty },
                    { new Guid("5d87f2dc-8c65-4a54-8647-6405b7b788eb"), string.Empty, "TPS", new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), string.Empty },
                    { new Guid("6e3a8446-0c24-4854-85d1-8ab0a5119d99"), string.Empty, "FPS", new Guid("948cee7b-b6fb-44a6-b4e7-598bce096b30"), string.Empty },
                    { new Guid("acf85088-2604-4066-a554-dd91aaad5856"), string.Empty, "RTS", new Guid("80fed641-b822-4718-8ca8-15da6b61fb2b"), string.Empty },
                    { new Guid("b42aa2fb-f03f-44bb-abc0-7920b4c76104"), string.Empty, "Off-road", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), string.Empty },
                    { new Guid("b961e2bf-f34c-45ec-9cf5-0db2f4b04c6e"), string.Empty, "Arcade", new Guid("bce50724-9419-472c-9d43-e0e7436b9678"), string.Empty },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "City",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "ContactTitle",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "PublisherEntities");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "RequiredDate",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipAddress",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipCity",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipCountry",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipName",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipPostalCode",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipRegion",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShipVia",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "ShippedDate",
                table: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GenreEntities");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "GenreEntities");

            migrationBuilder.DropColumn(
                name: "QuantityPerUnit",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "ReorderLevel",
                table: "GameEntities");

            migrationBuilder.DropColumn(
                name: "UnitsOnOrder",
                table: "GameEntities");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("0b29e979-9087-4a5e-803a-87863a33d862"), "Adventure", null },
                    { new Guid("834e7dcc-f606-454a-9373-cb858baedec9"), "Strategy", null },
                    { new Guid("bb25f334-50de-44b3-914e-7974b378b4a4"), "Action", null },
                    { new Guid("ced1ccdc-65a1-4030-bb3b-628f653ba789"), "Puzzle & Skill", null },
                    { new Guid("ddb5ce50-4265-4b04-995b-a95e222c199e"), "RPG", null },
                    { new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025"), "Races", null },
                    { new Guid("fe9af3fa-5245-4415-8127-5fac152825ca"), "Sports", null },
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("60f772ac-b42a-4c9a-8ae5-e137b9221016"), "Console" },
                    { new Guid("9e634ee1-05ff-4c40-8f1a-daefc565c905"), "Desktop" },
                    { new Guid("aff58f6c-7215-4aef-a464-e182a0eb953f"), "Browser" },
                    { new Guid("f8857eb1-50f7-4278-8d4d-1984ef4c933d"), "Mobile" },
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("00a9e5f0-fa02-486f-a441-e32bdbbce798"), "FPS", new Guid("bb25f334-50de-44b3-914e-7974b378b4a4") },
                    { new Guid("00b3079e-b3c5-4c92-b593-75e75e3e10d4"), "Arcade", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("245bc2e6-0b40-430f-893e-2d8717e5b0b1"), "Rally", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("2ce71d49-cacc-44ea-9fcd-ffbf1a765daf"), "TBS", new Guid("834e7dcc-f606-454a-9373-cb858baedec9") },
                    { new Guid("3225de36-468b-41ec-b60e-c20398e218a2"), "RTS", new Guid("834e7dcc-f606-454a-9373-cb858baedec9") },
                    { new Guid("358ad9d8-772c-40b9-9916-c3778a3552b4"), "Formula", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("69c50341-bcd9-441a-841b-e1b058a9db28"), "Off-road", new Guid("f06bf92b-35bb-4af3-b207-62932bbf4025") },
                    { new Guid("ff503b22-abe4-41d0-bf64-13553d593794"), "TPS", new Guid("bb25f334-50de-44b3-914e-7974b378b4a4") },
                });
        }
    }
}
