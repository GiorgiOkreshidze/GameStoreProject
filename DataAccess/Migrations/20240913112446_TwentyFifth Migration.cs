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
    public partial class TwentyFifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("06caf581-7c4d-498d-9850-149c09d049d7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0da343c5-be15-4583-b748-4f4140f2a616"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("14038d79-1193-4b52-9e26-729345a47d00"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2762d31a-19bf-4385-a072-31b9d88d52f0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3ea863d6-e1fd-4716-81db-abc6f6ce65ab"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4cb5de89-4bf7-4c76-9206-102a3c4dea5d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("559c6d9f-1c6c-4d28-8a1f-f7cba459c43c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c4576b4-d0b6-409b-a00c-371a84621349"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5fdd4f2f-021a-44a3-8d8a-f069d1a8273d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6f66163d-2216-4209-87e1-e3859165d37d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ea14c9db-2a5d-4e3b-9297-f5526a9f64de"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("feddc288-3702-4b93-8fa1-9cab60f3bd41"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a7383c9-a73b-43e4-b0ff-fe766764c15b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a4312c74-87c6-4bb6-ad6d-7cc43e30a64a"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("430b74f9-8911-4d0e-8608-8e29a2a2e4ef"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("57a9efc2-965f-48a9-bb51-5e440dcbf819"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("a2d90a47-f6dd-4a2b-884e-65926ca19693"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e6f56830-89a6-421a-b69d-b425206f27c5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), new Guid("8397daf4-dea7-4213-b21b-877deff4815f") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("000bfe38-c230-45db-a072-9ba9febbb848"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1916055f-41aa-490c-bde2-2d5603833e56"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("19833ab6-efa2-4564-b086-93d63c56f673"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("327b7fd6-625d-492f-8639-70a635856ef7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("45a54225-4517-472c-802a-a9fca83a05c1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7f622100-a378-483c-80f9-d495ee4bceca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c5bda9e-8afe-4445-b784-42400452c884"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("929c66a1-712d-4947-8d89-4641440877b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("acc56866-f457-461d-ad52-ffe917878ca8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae623b64-9078-4195-802a-25a7c1d95553"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2cc7559-23de-4121-965a-9975e2010082"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb84982e-a25f-4573-8218-08f3174fd66d"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("8397daf4-dea7-4213-b21b-877deff4815f"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("90054d5c-1f12-4c7b-9d4c-086f2aa5f0e0"), "", "RPG", null, "" },
                    { new Guid("99e10418-b3cb-482f-8527-0cb0f5d46a6d"), "", "Strategy", null, "" },
                    { new Guid("a9b107b3-5c16-4ff6-8a94-f4f305c0aa6d"), "", "Adventure", null, "" },
                    { new Guid("bcc26c0d-ee81-40f5-8d16-d115a264773c"), "", "Action", null, "" },
                    { new Guid("ecfb6d78-2ca8-4211-a436-2a12453d95f1"), "", "Sports", null, "" },
                    { new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"), "", "Races", null, "" },
                    { new Guid("fa580b4d-fdb2-44ba-a0a5-de2ecbfdfc06"), "", "Puzzle & Skill", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01a0c383-81fb-4dab-9a89-89e286f94b67"), "User" },
                    { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), "AddGameToOrderByKey" },
                    { new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"), "DeleteGenre" },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), "GetOrderById" },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), "GetComments" },
                    { new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"), "DeleteGame" },
                    { new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"), "CreateGenre" },
                    { new Guid("14afa652-2f71-4931-8ef5-1615f08c8ef5"), "DeleteUserById" },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), "GetGenre" },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), "Comments" },
                    { new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"), "UpdateGenre" },
                    { new Guid("1ff228db-e61d-4382-bd3c-da37aecdd333"), "Users" },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), "GetAllOrders" },
                    { new Guid("29320509-23a9-4905-8753-13bf872f2fa1"), "ManageAllComments" },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), "GetDateFilterOptions" },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), "GetGames" },
                    { new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"), "CreatePublisher" },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), "GetGenresOfGame" },
                    { new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"), "DeleteOrderDetails" },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), "Platform" },
                    { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), "AddGameInCart" },
                    { new Guid("48460200-d180-49df-b336-b7ec6883a7fc"), "DeletePublisher" },
                    { new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"), "UpdateOrderDetailQuantity" },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), "GetBanDurations" },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), "Publisher" },
                    { new Guid("4f2c5be6-68b4-4bd7-84ae-6dae2bba907b"), "GetRoleById" },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), "GetOrders" },
                    { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), "BanUser" },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), "GetPlatformsOfGame" },
                    { new Guid("5b14d2a7-ec0d-47e7-ba88-3fab0e3b0bc6"), "UpdateUser" },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), "Comment" },
                    { new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"), "UpdatePublisher" },
                    { new Guid("6b8606b3-a06b-43f8-89a5-f4bcf08301e7"), "GetUserById" },
                    { new Guid("6db1dbab-0b91-459a-895e-c04a8c78a925"), "GetAllUsers" },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), "Genre" },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), "Game" },
                    { new Guid("78b310ca-54e3-4198-84b5-f0cd58194717"), "UpdateRole" },
                    { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), "Buy" },
                    { new Guid("7d48a83d-6433-426b-98a0-191a95f83e51"), "Role" },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), "Publishers" },
                    { new Guid("80a83fb2-632c-4775-85a9-cb2700617e57"), "DeleteRoleById" },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), "History" },
                    { new Guid("862f694f-34a7-4489-8223-26ee9c629804"), "ManageDeletedGames" },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), "DownloadGameFile" },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), "Orders" },
                    { new Guid("930f6e39-261e-47c5-afa9-922f278b031a"), "DeleteRole" },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), "GetPublisherByCompanyName" },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), "GetPaymentMethods" },
                    { new Guid("96ae35d8-0fa1-46b6-9c0d-a637a36db36a"), "GetAllRoles" },
                    { new Guid("9c59dc46-7ffe-474e-b1ee-59cdc0b5c7ec"), "GetRolesOfUser" },
                    { new Guid("9d735a69-7efb-491b-9758-b32f911b1199"), "UpdatePlatform" },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), "GetAllPublishers" },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), "Platforms" },
                    { new Guid("9e45d461-146c-4b5c-8b19-db831119b863"), "CreatePlatform" },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), "GetGameByKey" },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), "GetGameById" },
                    { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), "ShipOrder" },
                    { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), "DeleteComment" },
                    { new Guid("aa3d5b84-eca1-4a94-a4d5-2cc4c7e566ee"), "AddUser" },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), "GetGamesByGenreId" },
                    { new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"), "UpdateGame" },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), "GetPlatformById" },
                    { new Guid("b200e994-99d7-4239-b170-ab3695334864"), "DeleteGameFromCart" },
                    { new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"), "DeletePlatform" },
                    { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), "Basket" },
                    { new Guid("b70fd24c-614a-4bb2-9cac-4bbb22bc78a9"), "GetPermissionsByRoleId" },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), "GetGamesByPlatformId" },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), "Genres" },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), "GetSubGenres" },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), "GetAllOrdersDetails" },
                    { new Guid("c29fe881-54fd-4d8d-a12c-5fdb78d11d7a"), "AddRole" },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), "GetAllGenres" },
                    { new Guid("cac45a66-1a1b-4113-b5e2-4e67cf2c1445"), "SeeDeletedGames" },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), "GetCart" },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), "GetPaginationOptions" },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), "Order" },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), "GetPublisherOfGame" },
                    { new Guid("d86f29d2-e960-41bd-8d7b-67971ea7ded7"), "GetAllPermissions" },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), "GetSortingOptions" },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), "GetAllGames" },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), "GetGamesByPublisherName" },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), "GetAllPlatforms" },
                    { new Guid("e7fb2c03-ac27-441c-a89f-9dad66e8e780"), "Roles" },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), "Games" },
                    { new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"), "CreateGame" },
                    { new Guid("f4d62b25-e311-4e75-b690-9e6c7fc1237e"), "DeleteUser" },
                    { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), "AddComment" },
                    { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), "Payment" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1f19ed65-f9d2-4285-9ee8-9bddc2f9ee84"), "Mobile" },
                    { new Guid("61d3b490-b317-42f4-9899-0356e96d4983"), "Console" },
                    { new Guid("9c5e611c-2cb2-48ac-a24f-0dd9bd7d07ce"), "Browser" },
                    { new Guid("e9b2841e-283f-43a4-b191-b242d21b113b"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6"), "Admin" },
                    { new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d"), "User" },
                    { new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795"), "Manager" },
                    { new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe"), "Guest" },
                    { new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6"), "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("6ab12a16-e034-4feb-a8c2-a30a5667c7ad"), "Admin", "$2a$11$JmGoMC2wYEELIfopS/7eYupnNurU1qhMLyw6PQHwMqes7ZLhnn89y" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("02cfcce1-0ca5-4a8b-ad86-897738b81968"), "", "Formula", new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"), "" },
                    { new Guid("2379f931-37f8-44c6-9e9f-267fd18023b4"), "", "Rally", new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"), "" },
                    { new Guid("2f98f4c6-468a-46d9-80b0-2114a3b3da35"), "", "Off-road", new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"), "" },
                    { new Guid("38d77a96-7cf6-4601-9b08-eac174ffd6a0"), "", "RTS", new Guid("99e10418-b3cb-482f-8527-0cb0f5d46a6d"), "" },
                    { new Guid("448492a9-6b7c-40b7-bd6a-4b172b85ede6"), "", "TPS", new Guid("bcc26c0d-ee81-40f5-8d16-d115a264773c"), "" },
                    { new Guid("624a2661-4ca3-44ad-aedf-096f3c05fe4c"), "", "Arcade", new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"), "" },
                    { new Guid("c84abba1-1e5f-47c7-96cf-52dd17769c81"), "", "TBS", new Guid("99e10418-b3cb-482f-8527-0cb0f5d46a6d"), "" },
                    { new Guid("d8265257-8482-4576-b64c-ec9f5bfb13b1"), "", "FPS", new Guid("bcc26c0d-ee81-40f5-8d16-d115a264773c"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("01a0c383-81fb-4dab-9a89-89e286f94b67"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("14afa652-2f71-4931-8ef5-1615f08c8ef5"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("1ff228db-e61d-4382-bd3c-da37aecdd333"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("29320509-23a9-4905-8753-13bf872f2fa1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("48460200-d180-49df-b336-b7ec6883a7fc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("48460200-d180-49df-b336-b7ec6883a7fc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("4f2c5be6-68b4-4bd7-84ae-6dae2bba907b"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("5b14d2a7-ec0d-47e7-ba88-3fab0e3b0bc6"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("6b8606b3-a06b-43f8-89a5-f4bcf08301e7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6db1dbab-0b91-459a-895e-c04a8c78a925"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("78b310ca-54e3-4198-84b5-f0cd58194717"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("7d48a83d-6433-426b-98a0-191a95f83e51"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("80a83fb2-632c-4775-85a9-cb2700617e57"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("862f694f-34a7-4489-8223-26ee9c629804"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("930f6e39-261e-47c5-afa9-922f278b031a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("96ae35d8-0fa1-46b6-9c0d-a637a36db36a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9c59dc46-7ffe-474e-b1ee-59cdc0b5c7ec"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9d735a69-7efb-491b-9758-b32f911b1199"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9d735a69-7efb-491b-9758-b32f911b1199"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("9e45d461-146c-4b5c-8b19-db831119b863"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("9e45d461-146c-4b5c-8b19-db831119b863"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("aa3d5b84-eca1-4a94-a4d5-2cc4c7e566ee"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("b70fd24c-614a-4bb2-9cac-4bbb22bc78a9"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("c29fe881-54fd-4d8d-a12c-5fdb78d11d7a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("d86f29d2-e960-41bd-8d7b-67971ea7ded7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("e7fb2c03-ac27-441c-a89f-9dad66e8e780"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") },
                    { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("f4d62b25-e311-4e75-b690-9e6c7fc1237e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") },
                    { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") },
                    { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") },
                    { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") },
                    { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6"), new Guid("6ab12a16-e034-4feb-a8c2-a30a5667c7ad") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("02cfcce1-0ca5-4a8b-ad86-897738b81968"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2379f931-37f8-44c6-9e9f-267fd18023b4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f98f4c6-468a-46d9-80b0-2114a3b3da35"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("38d77a96-7cf6-4601-9b08-eac174ffd6a0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("448492a9-6b7c-40b7-bd6a-4b172b85ede6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("624a2661-4ca3-44ad-aedf-096f3c05fe4c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("90054d5c-1f12-4c7b-9d4c-086f2aa5f0e0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a9b107b3-5c16-4ff6-8a94-f4f305c0aa6d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c84abba1-1e5f-47c7-96cf-52dd17769c81"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d8265257-8482-4576-b64c-ec9f5bfb13b1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ecfb6d78-2ca8-4211-a436-2a12453d95f1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa580b4d-fdb2-44ba-a0a5-de2ecbfdfc06"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cac45a66-1a1b-4113-b5e2-4e67cf2c1445"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("01a0c383-81fb-4dab-9a89-89e286f94b67"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02657040-c6ee-4a36-9883-50096c54e743"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14afa652-2f71-4931-8ef5-1615f08c8ef5"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18098767-c901-410a-b409-090f87471086"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e101845-111d-401b-8218-60b153410dfe"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ff228db-e61d-4382-bd3c-da37aecdd333"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2767a101-b31d-4c04-bc35-08b17938c627"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("29320509-23a9-4905-8753-13bf872f2fa1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("396bf354-41a5-4e87-8287-388d38761290"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("48460200-d180-49df-b336-b7ec6883a7fc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("48460200-d180-49df-b336-b7ec6883a7fc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4f2c5be6-68b4-4bd7-84ae-6dae2bba907b"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b14d2a7-ec0d-47e7-ba88-3fab0e3b0bc6"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6b8606b3-a06b-43f8-89a5-f4bcf08301e7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6db1dbab-0b91-459a-895e-c04a8c78a925"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78b310ca-54e3-4198-84b5-f0cd58194717"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d48a83d-6433-426b-98a0-191a95f83e51"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("80a83fb2-632c-4775-85a9-cb2700617e57"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("862f694f-34a7-4489-8223-26ee9c629804"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("930f6e39-261e-47c5-afa9-922f278b031a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("96ae35d8-0fa1-46b6-9c0d-a637a36db36a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c59dc46-7ffe-474e-b1ee-59cdc0b5c7ec"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d735a69-7efb-491b-9758-b32f911b1199"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d735a69-7efb-491b-9758-b32f911b1199"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e45d461-146c-4b5c-8b19-db831119b863"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9e45d461-146c-4b5c-8b19-db831119b863"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6f9be18-e681-4a13-bac9-036a13422535"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa3d5b84-eca1-4a94-a4d5-2cc4c7e566ee"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ada6136f-e289-4f20-a118-e48735b067b7"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b200e994-99d7-4239-b170-ab3695334864"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b70fd24c-614a-4bb2-9cac-4bbb22bc78a9"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c29fe881-54fd-4d8d-a12c-5fdb78d11d7a"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d86f29d2-e960-41bd-8d7b-67971ea7ded7"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1099299-5790-4c4a-a694-208b4a58646b"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7fb2c03-ac27-441c-a89f-9dad66e8e780"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f4d62b25-e311-4e75-b690-9e6c7fc1237e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"), new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f19ed65-f9d2-4285-9ee8-9bddc2f9ee84"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("61d3b490-b317-42f4-9899-0356e96d4983"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c5e611c-2cb2-48ac-a24f-0dd9bd7d07ce"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e9b2841e-283f-43a4-b191-b242d21b113b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6"), new Guid("6ab12a16-e034-4feb-a8c2-a30a5667c7ad") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("99e10418-b3cb-482f-8527-0cb0f5d46a6d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bcc26c0d-ee81-40f5-8d16-d115a264773c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f9f08c16-354d-4b2c-9d43-9415d990ebc5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("01a0c383-81fb-4dab-9a89-89e286f94b67"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("02657040-c6ee-4a36-9883-50096c54e743"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("04d7b451-8ada-4f67-b927-1eef6605db7c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("06b54f24-bb10-4f45-bdb7-ab697cc1a6f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f10b6d0-1280-4231-a8eb-ca4ced305d1e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f5c27df-ee42-4faf-af3b-1a7bcbef1d64"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("11eb294a-ec1d-4df7-8658-716ab7303678"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("14afa652-2f71-4931-8ef5-1615f08c8ef5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("18098767-c901-410a-b409-090f87471086"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e101845-111d-401b-8218-60b153410dfe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1fe62b05-b8ba-4bcc-acc9-e5179f93bf2a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ff228db-e61d-4382-bd3c-da37aecdd333"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2767a101-b31d-4c04-bc35-08b17938c627"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("29320509-23a9-4905-8753-13bf872f2fa1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2c986a93-641f-4847-bc38-874e3bb77c41"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3613416a-310c-49be-8a10-b0eeb9686a33"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3843bf80-be0f-4788-8abf-90a8951a6908"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("396bf354-41a5-4e87-8287-388d38761290"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3ab507b1-6902-4787-b3ee-9c3b30811dfe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("403852ee-8b32-4f0e-9af1-9917441c2ecc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("43d098a7-12e9-4774-96ff-2cedf6b05159"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("48460200-d180-49df-b336-b7ec6883a7fc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4c88e928-4d0b-47d9-9f84-222081ce0058"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4cf762c5-962a-4d91-be26-fe73a54f6d9a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4db42577-53a4-4ee1-adc4-c8767f25a9e9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4f2c5be6-68b4-4bd7-84ae-6dae2bba907b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4fb4b3e0-688d-40a8-b983-69cb5c73a7dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("518a0388-26f7-44a4-a31e-98aba6bfb8ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("55901752-9eb4-4017-a86e-4d9ad741310f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b14d2a7-ec0d-47e7-ba88-3fab0e3b0bc6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6440a04a-4175-42ab-9d25-45bda5f11a14"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6849f8cf-2664-484e-b79e-0f95bf130f6d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6b8606b3-a06b-43f8-89a5-f4bcf08301e7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6db1dbab-0b91-459a-895e-c04a8c78a925"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6e16371c-87f7-4915-a195-5ea4c2316814"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6fc0320a-add0-4224-9f0e-8c3e7d5b5838"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("78b310ca-54e3-4198-84b5-f0cd58194717"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7b2acf38-f461-4d5b-aba4-e4d0ca8b82e1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d48a83d-6433-426b-98a0-191a95f83e51"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7f67410a-4097-4bfa-8188-61a606f11b1d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("80a83fb2-632c-4775-85a9-cb2700617e57"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("85834eb6-0afc-492b-aff1-3bdf436f4603"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("862f694f-34a7-4489-8223-26ee9c629804"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b1667f5-1028-4417-965a-1b884179b6e6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f036000-1d0c-424b-a535-bc5e734caef1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("930f6e39-261e-47c5-afa9-922f278b031a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("94db539f-2525-4e18-9a7c-418d30db2f9d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("95fbeb4a-1843-4373-88bd-44b7b15d5887"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("96ae35d8-0fa1-46b6-9c0d-a637a36db36a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c59dc46-7ffe-474e-b1ee-59cdc0b5c7ec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d735a69-7efb-491b-9758-b32f911b1199"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d73cbb3-e037-44a3-9fd7-1445a4422346"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9e34be6b-b049-475a-8b67-416fd76551c7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9e45d461-146c-4b5c-8b19-db831119b863"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a41a28e4-6564-4846-938b-6e1ce99b160f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a5cbe6fb-79cb-4c61-a9bb-d46c4c6473bd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a66b3ac7-fab5-438b-b3a1-9f97d7cd271c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a6f9be18-e681-4a13-bac9-036a13422535"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa3d5b84-eca1-4a94-a4d5-2cc4c7e566ee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("abde188a-efe2-4564-a59a-59a5114bf3bc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("acefe315-5619-4bca-a0e9-c1cc60a23600"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ada6136f-e289-4f20-a118-e48735b067b7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b200e994-99d7-4239-b170-ab3695334864"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5334ab9-4bab-41e2-9f79-f0b920c857ba"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b61c4bc6-26d3-4285-be4c-7bdb5abdfe99"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b70fd24c-614a-4bb2-9cac-4bbb22bc78a9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb58bdec-4246-4cbb-9e14-c5dcf1442975"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bdc8232f-8b1f-463e-b930-ec8a9dcc1486"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("be885550-ccff-4129-a657-a161aa6d0cd1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c07b8aa3-0d22-4423-80b3-f844f0cc4f32"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c29fe881-54fd-4d8d-a12c-5fdb78d11d7a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c85d8c00-7faa-406b-97e1-8657498cdde1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb5b5779-9512-4e2a-b3e5-9d0bd8e6ff13"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cde82e8f-5ac2-449d-9dcd-ccd91d843cf0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d3c362bd-deb9-492b-b7c5-140c711398ec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d476d09a-e610-4ba0-90a7-6edc6ed75a9c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d86f29d2-e960-41bd-8d7b-67971ea7ded7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("db3026fd-a9f9-4e6d-8f7c-2065663e78d2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("db6caef1-6aba-4079-bdba-6e7e1fce0f8c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e1099299-5790-4c4a-a694-208b4a58646b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7c62185-95c3-4f49-bcf4-c59ae88cef36"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7fb2c03-ac27-441c-a89f-9dad66e8e780"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ea4ac6f0-847b-4a75-84cb-6026409f5eef"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f17ec57f-3fbc-42da-9db2-6e4141002634"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f4d62b25-e311-4e75-b690-9e6c7fc1237e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f68cb587-870a-4215-8e09-5cbfda16e036"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fce12e5d-ed49-44fb-a61b-8dbe3962597e"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("1367751f-f90b-4603-af22-21f1ce78b2b6"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ee1c2c1-95b7-4806-9eda-83640cdd388d"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("6eb73d5e-574c-46c8-9e70-6fd23b7f2795"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa8a5ced-d4b9-4b5e-9df1-0f808b837ebe"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("d0fb7370-d382-4dcc-8bcb-4db37a6c4fb6"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("6ab12a16-e034-4feb-a8c2-a30a5667c7ad"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "", "Races", null, "" },
                    { new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "", "Action", null, "" },
                    { new Guid("3ea863d6-e1fd-4716-81db-abc6f6ce65ab"), "", "Puzzle & Skill", null, "" },
                    { new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "", "Strategy", null, "" },
                    { new Guid("559c6d9f-1c6c-4d28-8a1f-f7cba459c43c"), "", "RPG", null, "" },
                    { new Guid("5c4576b4-d0b6-409b-a00c-371a84621349"), "", "Sports", null, "" },
                    { new Guid("feddc288-3702-4b93-8fa1-9cab60f3bd41"), "", "Adventure", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), "GetSortingOptions" },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), "GetGamesByPlatformId" },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), "CreateGenre" },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), "Genres" },
                    { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), "Users" },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), "GetAllPublishers" },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), "GetAllGames" },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), "AddGameToOrderByKey" },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), "GetDateFilterOptions" },
                    { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), "GetAllPermissions" },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), "Buy" },
                    { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), "User" },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), "DeleteGameFromCart" },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), "GetAllOrders" },
                    { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), "GetRolesOfUser" },
                    { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), "GetPermissionsByRoleId" },
                    { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), "Roles" },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), "Games" },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), "Publisher" },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), "DeletePlatform" },
                    { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), "GetUserById" },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), "GetComments" },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), "GetAllGenres" },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), "Order" },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), "GetBanDurations" },
                    { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), "GetAllRoles" },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), "GetGenresOfGame" },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), "GetGenre" },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), "GetAllOrdersDetails" },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), "UpdateGame" },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), "DeleteGame" },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), "UpdatePublisher" },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), "Orders" },
                    { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), "ManageAllComments" },
                    { new Guid("6a7383c9-a73b-43e4-b0ff-fe766764c15b"), "SeeDeletedGames" },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), "DownloadGameFile" },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), "DeleteComment" },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), "BanUser" },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), "Platform" },
                    { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), "ManageDeletedGames" },
                    { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), "GetRoleById" },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), "GetCart" },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), "GetGameByKey" },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), "DeletePublisher" },
                    { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), "Role" },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), "Comments" },
                    { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), "UpdateRole" },
                    { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), "UpdateUser" },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), "GetPlatformById" },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), "GetPublisherByCompanyName" },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), "CreatePublisher" },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), "GetGames" },
                    { new Guid("a4312c74-87c6-4bb6-ad6d-7cc43e30a64a"), "History" },
                    { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), "DeleteRoleById" },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), "GetAllPlatforms" },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), "GetPaymentMethods" },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), "GetOrders" },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), "DeleteGenre" },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), "Comment" },
                    { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), "AddRole" },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), "Genre" },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), "GetSubGenres" },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), "Publishers" },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), "Game" },
                    { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), "GetAllUsers" },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), "AddComment" },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), "GetGamesByPublisherName" },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), "GetPublisherOfGame" },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), "CreateGame" },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), "UpdatePlatform" },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), "GetGameById" },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), "CreatePlatform" },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), "GetOrderById" },
                    { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), "DeleteUserById" },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), "DeleteOrderDetails" },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), "GetGamesByGenreId" },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), "Platforms" },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), "ShipOrder" },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), "UpdateOrderDetailQuantity" },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), "GetPlatformsOfGame" },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), "Payment" },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), "UpdateGenre" },
                    { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), "AddUser" },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), "GetPaginationOptions" },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), "AddGameInCart" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("430b74f9-8911-4d0e-8608-8e29a2a2e4ef"), "Console" },
                    { new Guid("57a9efc2-965f-48a9-bb51-5e440dcbf819"), "Desktop" },
                    { new Guid("a2d90a47-f6dd-4a2b-884e-65926ca19693"), "Mobile" },
                    { new Guid("e6f56830-89a6-421a-b69d-b425206f27c5"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), "Admin" },
                    { new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676"), "Moderator" },
                    { new Guid("bb84982e-a25f-4573-8218-08f3174fd66d"), "Guest" },
                    { new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8"), "Manager" },
                    { new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e"), "User" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("8397daf4-dea7-4213-b21b-877deff4815f"), "Admin", "$2a$11$mX6bLHQmyQdl8yJQU9ZQKOCgUfPra4o86FQh9CoHgXUVMd0HJClsu" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("06caf581-7c4d-498d-9850-149c09d049d7"), "", "Rally", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("0da343c5-be15-4583-b748-4f4140f2a616"), "", "TBS", new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "" },
                    { new Guid("14038d79-1193-4b52-9e26-729345a47d00"), "", "TPS", new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "" },
                    { new Guid("2762d31a-19bf-4385-a072-31b9d88d52f0"), "", "Off-road", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("4cb5de89-4bf7-4c76-9206-102a3c4dea5d"), "", "RTS", new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "" },
                    { new Guid("5fdd4f2f-021a-44a3-8d8a-f069d1a8273d"), "", "FPS", new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "" },
                    { new Guid("6f66163d-2216-4209-87e1-e3859165d37d"), "", "Formula", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("ea14c9db-2a5d-4e3b-9297-f5526a9f64de"), "", "Arcade", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), new Guid("8397daf4-dea7-4213-b21b-877deff4815f") });
        }
    }
}
