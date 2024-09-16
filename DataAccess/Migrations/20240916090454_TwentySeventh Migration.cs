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
    public partial class TwentySeventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("065f25a1-d7b2-4b02-9718-1ef078e62508"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0a1fe298-bded-4bea-8507-2c54bcfa6f0b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0aedb8e8-5eaf-443e-b630-3c0446af9461"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("21debb5f-e572-4503-947b-2f4965b9d193"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5386792c-45c7-400a-afac-add5a9122028"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("57ecc3a9-528b-431c-8b30-101dbdfb15ef"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c5cbcba6-1c06-4431-9fa9-c0ef1ec88962"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc2fcdf2-8e2f-429f-9a81-823947449659"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("df3e4f46-f43d-4a13-8452-724f30e222a9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e8fca566-dc87-4592-8cba-66fe58f24cd1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e9470e7d-fd37-4480-aa31-1f601ef802ce"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f476299a-9c23-4722-8f7a-0711aafeaad5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3bed52ca-ee4c-413d-bc31-25a24f622830"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("008181b6-0f9b-44c4-b872-176717d65ced"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("008181b6-0f9b-44c4-b872-176717d65ced"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07bfc981-f5da-4820-a3bd-a45018794991"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07bfc981-f5da-4820-a3bd-a45018794991"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27eaa6b5-a66a-485e-9a56-88059d91c2d2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("29ab7e2c-e830-424c-a83f-ec7d5d11e52c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2b806e2e-1e2d-4f35-9842-73ef1829c598"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("30826463-dbad-4b54-9645-a1fbdc79adad"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ddd4927-af1f-43e6-a7dd-5bc523abeb2b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57aa5c07-8ec3-48b7-8292-14ab37b0aac7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ab445f2-3b95-444a-afd5-c8609bd7c8c6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6942df16-57cd-4040-91f2-ff88f7d71c73"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7ea4c9fc-9e65-4a2f-87ba-bff2e36b480c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8993665a-bf31-4549-9126-d9b30f138471"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8993665a-bf31-4549-9126-d9b30f138471"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e23e725-c243-464b-a918-ef7c6d28c0e0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("942ba553-9a20-4de5-b7db-ff335625cb8a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("98f3f6b7-7986-43d9-bf4d-4052a70a25e0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c6c246b-c3a9-477f-8c8a-eeb69aadccf4"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa5c024b-4a16-4b60-adad-72c08a91e603"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2b2a3c9-b78b-48f6-a762-08bb749555f8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7f9e26c-3d1f-401c-8cc1-97ad9b286997"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e089fa10-de1c-4ae9-874d-0e9cd5e9a7f1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e149e840-49e7-4b0a-86bf-8e75f189b991"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e39ad140-1ecc-4a0a-8c0c-b7123af9c1db"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e57da906-ec72-4d49-b534-24a254f4ff5a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e8c12d30-af9b-4a85-99e0-1f7c3f6ed0b3"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("21c5ef38-1aa2-40a1-a3c0-e6b024ee53b9"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("44946ceb-67f9-4de2-b063-8fd234586cc1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("62d9ca60-df22-4948-bcec-68e7799a68b1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad3f7ea2-43ab-4ea5-bff5-43bf2b0b77d0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c"), new Guid("f546fb49-9550-429e-8f44-31b4877490bc") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d785499a-ee66-428a-9be1-1e7d975dd425"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e5bcc8b2-ee16-4f64-8a77-1bf29168ed40"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("008181b6-0f9b-44c4-b872-176717d65ced"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("07bfc981-f5da-4820-a3bd-a45018794991"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0a9065f7-71df-476d-b850-1b77dae66826"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("27eaa6b5-a66a-485e-9a56-88059d91c2d2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("29ab7e2c-e830-424c-a83f-ec7d5d11e52c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2b806e2e-1e2d-4f35-9842-73ef1829c598"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("30826463-dbad-4b54-9645-a1fbdc79adad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("414af816-ee8e-4241-af08-375851c43cb8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4275b705-404e-4f19-9035-0249581b7447"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ddd4927-af1f-43e6-a7dd-5bc523abeb2b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("53916983-b914-4d7e-bab9-2f92284cb468"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57aa5c07-8ec3-48b7-8292-14ab37b0aac7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ab445f2-3b95-444a-afd5-c8609bd7c8c6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6942df16-57cd-4040-91f2-ff88f7d71c73"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("705ef0f9-3ece-440a-8102-c26662aec137"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7494dc09-3561-4137-af87-3186aa3c861a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7ea4c9fc-9e65-4a2f-87ba-bff2e36b480c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8993665a-bf31-4549-9126-d9b30f138471"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8e23e725-c243-464b-a918-ef7c6d28c0e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("942ba553-9a20-4de5-b7db-ff335625cb8a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("98f3f6b7-7986-43d9-bf4d-4052a70a25e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c6c246b-c3a9-477f-8c8a-eeb69aadccf4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa5c024b-4a16-4b60-adad-72c08a91e603"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b215981d-2400-4d9c-818f-320241da00e2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c2b2a3c9-b78b-48f6-a762-08bb749555f8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7f9e26c-3d1f-401c-8cc1-97ad9b286997"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e089fa10-de1c-4ae9-874d-0e9cd5e9a7f1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e149e840-49e7-4b0a-86bf-8e75f189b991"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e39ad140-1ecc-4a0a-8c0c-b7123af9c1db"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e498e90d-ee82-448c-a70f-519aeead4215"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e57da906-ec72-4d49-b534-24a254f4ff5a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e78fe743-843e-4341-852c-2d9b9450e239"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e8c12d30-af9b-4a85-99e0-1f7c3f6ed0b3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8da5b87-3058-4120-a920-952074837076"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("21508c50-9f2e-4efc-8668-f376f325e943"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("7606a348-254d-48de-8add-3d7178da2f27"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("f546fb49-9550-429e-8f44-31b4877490bc"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("66f70299-8415-4ad7-b606-a1d4f9720d62"), "", "Strategy", null, "" },
                    { new Guid("9003b63f-4358-4d9f-a611-878d78441173"), "", "Action", null, "" },
                    { new Guid("9f983b0e-9045-42c9-b111-0f365f460181"), "", "Sports", null, "" },
                    { new Guid("ab97932b-b657-4f27-838b-8887cc641789"), "", "Adventure", null, "" },
                    { new Guid("f236d376-425e-4d6d-9133-ce7ff72a58c8"), "", "RPG", null, "" },
                    { new Guid("f5890121-bfd4-4fbe-9fb3-e6627f77a37b"), "", "Puzzle & Skill", null, "" },
                    { new Guid("f6a884f6-9235-43d4-9541-2487eff62468"), "", "Races", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("0004d700-1891-4c2e-acd7-38e956507791"), false, "UpdateUser" },
                    { new Guid("05207fe9-a494-480e-9c32-0e5fda40195c"), false, "DeleteRole" },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), true, "GetBanDurations" },
                    { new Guid("09689287-9e0c-4b9a-82b3-9d4ba7fb54a4"), false, "SeeDeletedGames" },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), true, "GetGamesByGenreId" },
                    { new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"), false, "UpdatePlatform" },
                    { new Guid("12c06467-98e4-4f0a-a264-88ff0204d441"), false, "AddRole" },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), true, "GetGameById" },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), true, "Genre" },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), true, "GetAllOrdersDetails" },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), true, "Comments" },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), true, "GetGamesByPlatformId" },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), true, "Order" },
                    { new Guid("2227eb75-07ae-4cd7-a6bd-09659d5b6e2e"), false, "Users" },
                    { new Guid("24405d4b-5b43-4783-b325-c47ae1b50f17"), false, "ManageDeletedGames" },
                    { new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"), false, "DeletePublisher" },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), true, "GetDateFilterOptions" },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), true, "GetPublisherByCompanyName" },
                    { new Guid("2d8a7bd5-56c9-431c-bfbf-802b059118a7"), false, "GetPermissionsByRoleId" },
                    { new Guid("31adde51-e7f1-4e9f-89b0-f71edfae87bf"), false, "DeleteUser" },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), true, "GetGameByKey" },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), true, "GetPaymentMethods" },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), true, "GetAllGames" },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), true, "GetGames" },
                    { new Guid("47688776-3eba-413a-a81e-ceffcea69f43"), false, "UpdateRole" },
                    { new Guid("4b153664-2c4c-478f-9379-e625d9fa4b57"), false, "ManageAllComments" },
                    { new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"), false, "DeleteOrderDetails" },
                    { new Guid("50ef92cd-8119-4914-bcac-27391d96c600"), false, "Roles" },
                    { new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"), false, "UpdatePublisher" },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), true, "Games" },
                    { new Guid("60202538-7137-4eeb-9117-9d642f4957d7"), false, "AddUser" },
                    { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), false, "Basket" },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), true, "GetGenre" },
                    { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), false, "ShipOrder" },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), true, "GetPlatformsOfGame" },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), true, "GetPublisherOfGame" },
                    { new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"), false, "CreatePublisher" },
                    { new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("6f5f9ce8-a552-40c4-915f-e587ef4f6f3c"), false, "GetAllPermissions" },
                    { new Guid("720a1afb-9fe4-4987-ae04-c9975a30e0c8"), false, "User" },
                    { new Guid("7368781f-0f84-4c65-b298-d6c77b437ed4"), false, "GetRolesOfUser" },
                    { new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"), false, "CreateGenre" },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), true, "GetCart" },
                    { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), false, "AddGameInCart" },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), true, "GetGamesByPublisherName" },
                    { new Guid("80cb1725-e78f-451f-8406-d1486050c888"), false, "GetAllRoles" },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), true, "Comment" },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), true, "DownloadGameFile" },
                    { new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"), false, "DeleteGenre" },
                    { new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"), false, "DeleteGame" },
                    { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), false, "Buy" },
                    { new Guid("94f6dff3-ad12-4add-a858-6ab3b11ab2e5"), false, "GetAllUsers" },
                    { new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"), false, "UpdateGenre" },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), true, "GetGenresOfGame" },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), true, "GetOrders" },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), false, "History" },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), true, "Genres" },
                    { new Guid("a29f28f1-986c-4b43-8c37-799adeb9016f"), false, "Role" },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), true, "Platforms" },
                    { new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"), false, "DeletePlatform" },
                    { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), false, "AddComment" },
                    { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), false, "DeleteComment" },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), true, "GetAllPlatforms" },
                    { new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"), false, "UpdateGame" },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), true, "Publishers" },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), true, "GetOrderById" },
                    { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), false, "AddGameToOrderByKey" },
                    { new Guid("b8a6d6bb-1991-4d19-94d9-091391ff1b5b"), false, "CanSeeDeletedGames" },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), true, "GetPaginationOptions" },
                    { new Guid("bd52e548-dfef-4901-a443-f56aa97e03f4"), false, "GetUserById" },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), true, "GetAllPublishers" },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), true, "Orders" },
                    { new Guid("c6926ecf-f8e2-4fec-a4c5-1e54d0145d0c"), false, "DeleteUserById" },
                    { new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"), false, "CreatePlatform" },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), true, "GetAllOrders" },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), true, "GetPlatformById" },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), true, "Game" },
                    { new Guid("e129069e-faff-4bf2-b408-7f254c5beeca"), false, "DeleteRoleById" },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), true, "Platform" },
                    { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), false, "Payment" },
                    { new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"), false, "CreateGame" },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), true, "GetSubGenres" },
                    { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), false, "DeleteGameFromCart" },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), true, "GetComments" },
                    { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), false, "BanUser" },
                    { new Guid("f3151e31-1e47-4113-8d8e-15fc3870e76d"), false, "GetRoleById" },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), true, "Publisher" },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), true, "GetSortingOptions" },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), true, "GetAllGenres" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("13adefd4-482e-4f87-bd53-aff85a5a8af7"), "Desktop" },
                    { new Guid("19dc2d4a-1b1a-4be7-99ae-c2800d0f9dc0"), "Browser" },
                    { new Guid("38223005-9da4-40ec-b663-1ae9ee4fe02e"), "Console" },
                    { new Guid("a889e618-14b7-4a72-8856-45059d7db5c2"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395"), "Manager" },
                    { new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8"), "Admin" },
                    { new Guid("81183519-76e7-4d8c-87f2-344a6f468480"), "Guest" },
                    { new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619"), "Moderator" },
                    { new Guid("f170c5c0-c764-4887-940f-04a96e2288ad"), "User" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("75b0aa94-f458-45c2-8fea-6d784239bbbf"), "Admin", "$2a$11$7m32.Ma9Cf/Y26D7CehNrO6NVJXVdO6FoHeCS/QjwKhUOLcorAxY6" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("24ee5d5e-7d79-41f3-bccf-dcbd47bb52bb"), "", "FPS", new Guid("9003b63f-4358-4d9f-a611-878d78441173"), "" },
                    { new Guid("269459c2-8190-478a-bfb3-245c4181b9af"), "", "TPS", new Guid("9003b63f-4358-4d9f-a611-878d78441173"), "" },
                    { new Guid("4738f310-bd02-4bf0-b637-cace0f645ca7"), "", "TBS", new Guid("66f70299-8415-4ad7-b606-a1d4f9720d62"), "" },
                    { new Guid("81ee9cad-6f8a-45bf-aec7-efe92431c279"), "", "Arcade", new Guid("f6a884f6-9235-43d4-9541-2487eff62468"), "" },
                    { new Guid("9f7feff7-5020-4706-899c-a51b0514245c"), "", "Off-road", new Guid("f6a884f6-9235-43d4-9541-2487eff62468"), "" },
                    { new Guid("a4a6b41c-d10f-4a3e-870f-226f0cb0b564"), "", "Formula", new Guid("f6a884f6-9235-43d4-9541-2487eff62468"), "" },
                    { new Guid("af4d665b-79be-4311-84ab-37c4349503b5"), "", "RTS", new Guid("66f70299-8415-4ad7-b606-a1d4f9720d62"), "" },
                    { new Guid("cd297d90-ae47-42d7-8d88-822d747dd851"), "", "Rally", new Guid("f6a884f6-9235-43d4-9541-2487eff62468"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("0004d700-1891-4c2e-acd7-38e956507791"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("05207fe9-a494-480e-9c32-0e5fda40195c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("12c06467-98e4-4f0a-a264-88ff0204d441"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("2227eb75-07ae-4cd7-a6bd-09659d5b6e2e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("24405d4b-5b43-4783-b325-c47ae1b50f17"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("2d8a7bd5-56c9-431c-bfbf-802b059118a7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("31adde51-e7f1-4e9f-89b0-f71edfae87bf"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("47688776-3eba-413a-a81e-ceffcea69f43"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("4b153664-2c4c-478f-9379-e625d9fa4b57"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("50ef92cd-8119-4914-bcac-27391d96c600"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("60202538-7137-4eeb-9117-9d642f4957d7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("6f5f9ce8-a552-40c4-915f-e587ef4f6f3c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("720a1afb-9fe4-4987-ae04-c9975a30e0c8"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7368781f-0f84-4c65-b298-d6c77b437ed4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("80cb1725-e78f-451f-8406-d1486050c888"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("94f6dff3-ad12-4add-a858-6ab3b11ab2e5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("a29f28f1-986c-4b43-8c37-799adeb9016f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("b8a6d6bb-1991-4d19-94d9-091391ff1b5b"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("bd52e548-dfef-4901-a443-f56aa97e03f4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("c6926ecf-f8e2-4fec-a4c5-1e54d0145d0c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("e129069e-faff-4bf2-b408-7f254c5beeca"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f3151e31-1e47-4113-8d8e-15fc3870e76d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") },
                    { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8"), new Guid("75b0aa94-f458-45c2-8fea-6d784239bbbf") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("24ee5d5e-7d79-41f3-bccf-dcbd47bb52bb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("269459c2-8190-478a-bfb3-245c4181b9af"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4738f310-bd02-4bf0-b637-cace0f645ca7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("81ee9cad-6f8a-45bf-aec7-efe92431c279"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f7feff7-5020-4706-899c-a51b0514245c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f983b0e-9045-42c9-b111-0f365f460181"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a4a6b41c-d10f-4a3e-870f-226f0cb0b564"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ab97932b-b657-4f27-838b-8887cc641789"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("af4d665b-79be-4311-84ab-37c4349503b5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("cd297d90-ae47-42d7-8d88-822d747dd851"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f236d376-425e-4d6d-9133-ce7ff72a58c8"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5890121-bfd4-4fbe-9fb3-e6627f77a37b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("09689287-9e0c-4b9a-82b3-9d4ba7fb54a4"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0004d700-1891-4c2e-acd7-38e956507791"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("05207fe9-a494-480e-9c32-0e5fda40195c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0b85d51d-f857-4613-89b4-725a157573a7"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12c06467-98e4-4f0a-a264-88ff0204d441"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1c363927-2544-48f4-a98b-8fac425d0959"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f59229d-b201-4430-ad6e-32c72af06209"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2227eb75-07ae-4cd7-a6bd-09659d5b6e2e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24405d4b-5b43-4783-b325-c47ae1b50f17"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d8a7bd5-56c9-431c-bfbf-802b059118a7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("31adde51-e7f1-4e9f-89b0-f71edfae87bf"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("47688776-3eba-413a-a81e-ceffcea69f43"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b153664-2c4c-478f-9379-e625d9fa4b57"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("50ef92cd-8119-4914-bcac-27391d96c600"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57614acd-cc59-445b-bda8-a3aed0740504"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60202538-7137-4eeb-9117-9d642f4957d7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69845819-c756-4cb7-a31f-181453ad9b78"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6f5f9ce8-a552-40c4-915f-e587ef4f6f3c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("720a1afb-9fe4-4987-ae04-c9975a30e0c8"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7368781f-0f84-4c65-b298-d6c77b437ed4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("80cb1725-e78f-451f-8406-d1486050c888"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94f6dff3-ad12-4add-a858-6ab3b11ab2e5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a29f28f1-986c-4b43-8c37-799adeb9016f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b785b843-07f9-41a5-b786-536389c343df"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8a6d6bb-1991-4d19-94d9-091391ff1b5b"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd52e548-dfef-4901-a443-f56aa97e03f4"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6926ecf-f8e2-4fec-a4c5-1e54d0145d0c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e129069e-faff-4bf2-b408-7f254c5beeca"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f165d735-0597-4d9f-994f-10bb00162146"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3151e31-1e47-4113-8d8e-15fc3870e76d"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("81183519-76e7-4d8c-87f2-344a6f468480") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"), new Guid("f170c5c0-c764-4887-940f-04a96e2288ad") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("13adefd4-482e-4f87-bd53-aff85a5a8af7"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("19dc2d4a-1b1a-4be7-99ae-c2800d0f9dc0"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("38223005-9da4-40ec-b663-1ae9ee4fe02e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("a889e618-14b7-4a72-8856-45059d7db5c2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8"), new Guid("75b0aa94-f458-45c2-8fea-6d784239bbbf") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("66f70299-8415-4ad7-b606-a1d4f9720d62"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9003b63f-4358-4d9f-a611-878d78441173"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6a884f6-9235-43d4-9541-2487eff62468"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0004d700-1891-4c2e-acd7-38e956507791"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("05207fe9-a494-480e-9c32-0e5fda40195c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("072a7849-f0e0-4cf6-8f9e-87ea9894582f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b85d51d-f857-4613-89b4-725a157573a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("10c07ba1-5fba-46cc-85ee-707f12e4a1ec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("12c06467-98e4-4f0a-a264-88ff0204d441"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("14c93797-24b9-49d9-b02f-19facc874ba6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1760a8fd-9871-47ac-9703-d3897f1c9cbe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a40feb3-6e25-4896-9240-bbe0d083d9b1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1c363927-2544-48f4-a98b-8fac425d0959"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f59229d-b201-4430-ad6e-32c72af06209"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("211474f4-6455-4a96-a2b1-635f56f98dff"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2227eb75-07ae-4cd7-a6bd-09659d5b6e2e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("24405d4b-5b43-4783-b325-c47ae1b50f17"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("24aef4c0-6e7e-4268-9c69-5f24e32dc462"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("251d9b9b-ffc3-4e72-b132-21c263b8128e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2556c9ff-22a5-4313-8be9-5098aabc5a43"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d8a7bd5-56c9-431c-bfbf-802b059118a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("31adde51-e7f1-4e9f-89b0-f71edfae87bf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3350bda2-aaf0-44dc-9701-70e9f228fec5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("34ffeffb-0a6d-4112-872f-df71300acfc3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b8799fe-07a1-4950-92cc-b3e1b73c606d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("416e2a12-6302-482a-8c89-fa18de1c799f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("47688776-3eba-413a-a81e-ceffcea69f43"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4b153664-2c4c-478f-9379-e625d9fa4b57"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4fbdce6a-620b-42c3-8690-5f827fd5490d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("50ef92cd-8119-4914-bcac-27391d96c600"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("539dfd83-e792-4feb-b96b-5f15e57278e4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57614acd-cc59-445b-bda8-a3aed0740504"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("60202538-7137-4eeb-9117-9d642f4957d7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("63d17ac2-1f6c-4f94-b8ad-ceacac9e124f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65471d12-8cb7-4de8-9083-bcbbe0588694"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68c385f5-87d3-4a94-913d-8edd4ceb573e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("69845819-c756-4cb7-a31f-181453ad9b78"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("69881958-06ac-4ea6-99ec-5418bab800ac"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6ab783c1-db5a-4fae-ac44-1e73ebe2b472"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6d6a87d8-3952-420f-a91e-7d6bf05c8b68"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6f5f9ce8-a552-40c4-915f-e587ef4f6f3c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("720a1afb-9fe4-4987-ae04-c9975a30e0c8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7368781f-0f84-4c65-b298-d6c77b437ed4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7bfd9842-6b91-4297-8f25-a1a4cca5e84c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c2ff262-c677-475d-88ac-eadbc0fbd907"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c6eec30-33e2-41ef-ac2e-617fcebef229"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d509a5f-1f37-457f-b5ee-0b4542394c01"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("80cb1725-e78f-451f-8406-d1486050c888"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("82da5c20-88ac-4f34-9aa4-f19f13078d7e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("869c44ad-a361-40a3-ad24-c5a359c02aad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8aaa7093-fedd-4769-9c5a-65fed0f57b77"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8eddad5f-b0be-45ae-aca6-1fe4fb64fdcb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("93bb07df-0993-43e4-b06e-8ff83b3a88e6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("94f6dff3-ad12-4add-a858-6ab3b11ab2e5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c6681fd-25b0-44e3-acd3-c389e38cc261"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ca763c4-c89b-4b8a-8b9d-7066ebe4d831"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9fde6c7f-cde7-4426-8f9c-738d25f8d873"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a036c8db-eb04-4f90-a87a-15844ee0dc1b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a08e9e6e-1098-4389-aabc-a2ddc5d9ed70"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a29f28f1-986c-4b43-8c37-799adeb9016f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3d5091d-d509-43dc-8e23-b00ba7b2aae6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a79d8571-f726-4a93-885b-be0cb5cfac00"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a7ef9196-2ef8-4129-8b10-9a624f0a89f5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa217013-cd91-49aa-8b3d-b006b19899c7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ab611599-e80f-43f6-a375-eaaca4564d8f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae204c4c-acb6-4f57-a54a-2a6ebcaed718"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b04b68ae-b5a2-4468-8c03-6103096ff000"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b785b843-07f9-41a5-b786-536389c343df"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b79abe2d-71f6-4a76-8191-7e546b8ed63a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8a6d6bb-1991-4d19-94d9-091391ff1b5b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bc1ce26e-6ef5-40c7-8011-472d03f3e097"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bd52e548-dfef-4901-a443-f56aa97e03f4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bd772bb4-69de-4bb3-8b7b-6e39602dda96"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bedcac07-d8ba-4103-a18d-496eb4f5d737"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c6926ecf-f8e2-4fec-a4c5-1e54d0145d0c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c977e2f4-abcf-4c8d-84c2-0d8f02c9579c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cde2c949-6896-471d-ad16-4808ca43a6a0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d90a2202-c997-48a5-82b6-fe65d2e524d1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dde87a74-3ba9-4e7d-86c9-3cec383f52d2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e129069e-faff-4bf2-b408-7f254c5beeca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e3f8a9e6-5c35-485c-bdfd-21143dbc8c0d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e48dea32-5db2-4d39-a7dd-5a2748ed44e1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e6588da4-4f54-44a5-a816-1e3c0efebd2e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e82c1c6b-0df4-4898-93d3-80ef8208fee3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f165d735-0597-4d9f-994f-10bb00162146"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f16e917e-bbbf-45a6-a480-9e54aa8ec357"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1e98163-f24f-4870-aa39-81a83189c2fd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3151e31-1e47-4113-8d8e-15fc3870e76d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5a1548f-4326-4c5f-a5ee-7c8f9ac46ef5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6b6e333-976b-42e5-80dc-59aa1567e522"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8b5941d-5122-46a5-83b9-6bd687094801"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b5bab23-55b2-4e1a-8a20-0480e49c8395"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("78a563eb-d174-4c19-bd38-7a6f044775d8"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("81183519-76e7-4d8c-87f2-344a6f468480"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("98b4c85f-89a4-40d7-a6c5-c7556146b619"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("f170c5c0-c764-4887-940f-04a96e2288ad"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("75b0aa94-f458-45c2-8fea-6d784239bbbf"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0aedb8e8-5eaf-443e-b630-3c0446af9461"), "", "Puzzle & Skill", null, "" },
                    { new Guid("5386792c-45c7-400a-afac-add5a9122028"), "", "RPG", null, "" },
                    { new Guid("d785499a-ee66-428a-9be1-1e7d975dd425"), "", "Strategy", null, "" },
                    { new Guid("dc2fcdf2-8e2f-429f-9a81-823947449659"), "", "Adventure", null, "" },
                    { new Guid("df3e4f46-f43d-4a13-8452-724f30e222a9"), "", "Sports", null, "" },
                    { new Guid("e5bcc8b2-ee16-4f64-8a77-1bf29168ed40"), "", "Action", null, "" },
                    { new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"), "", "Races", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), true, "GetGamesByGenreId" },
                    { new Guid("008181b6-0f9b-44c4-b872-176717d65ced"), false, "CreatePlatform" },
                    { new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"), false, "DeletePublisher" },
                    { new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"), false, "DeleteGame" },
                    { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), false, "DeleteComment" },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), true, "GetPublisherOfGame" },
                    { new Guid("07bfc981-f5da-4820-a3bd-a45018794991"), false, "UpdatePlatform" },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), true, "GetDateFilterOptions" },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), true, "GetPublisherByCompanyName" },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), true, "GetAllPlatforms" },
                    { new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"), false, "UpdateGenre" },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), true, "GetPlatformsOfGame" },
                    { new Guid("27eaa6b5-a66a-485e-9a56-88059d91c2d2"), false, "UpdateUser" },
                    { new Guid("29ab7e2c-e830-424c-a83f-ec7d5d11e52c"), false, "AddRole" },
                    { new Guid("2b806e2e-1e2d-4f35-9842-73ef1829c598"), false, "UpdateRole" },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), true, "GetAllPublishers" },
                    { new Guid("30826463-dbad-4b54-9645-a1fbdc79adad"), false, "DeleteUser" },
                    { new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"), false, "DeleteOrderDetails" },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), true, "GetOrders" },
                    { new Guid("3bed52ca-ee4c-413d-bc31-25a24f622830"), false, "SeeDeletedGames" },
                    { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), false, "Payment" },
                    { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), false, "Basket" },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), true, "GetSortingOptions" },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), true, "Orders" },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), true, "Order" },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), true, "GetGenresOfGame" },
                    { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), false, "DeleteGameFromCart" },
                    { new Guid("4ddd4927-af1f-43e6-a7dd-5bc523abeb2b"), false, "Users" },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), true, "GetGameById" },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), true, "Games" },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), true, "GetComments" },
                    { new Guid("57aa5c07-8ec3-48b7-8292-14ab37b0aac7"), false, "GetAllUsers" },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), true, "GetCart" },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), true, "GetGames" },
                    { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), false, "AddGameToOrderByKey" },
                    { new Guid("5ab445f2-3b95-444a-afd5-c8609bd7c8c6"), false, "User" },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), true, "Platform" },
                    { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), false, "AddComment" },
                    { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), false, "AddGameInCart" },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), true, "Platforms" },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), true, "GetAllOrdersDetails" },
                    { new Guid("6942df16-57cd-4040-91f2-ff88f7d71c73"), false, "AddUser" },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), true, "GetGamesByPlatformId" },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), true, "GetGenre" },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), false, "History" },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), true, "GetAllGenres" },
                    { new Guid("7ea4c9fc-9e65-4a2f-87ba-bff2e36b480c"), false, "GetPermissionsByRoleId" },
                    { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), false, "ShipOrder" },
                    { new Guid("8993665a-bf31-4549-9126-d9b30f138471"), false, "UpdatePublisher" },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), true, "Genres" },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), true, "Publisher" },
                    { new Guid("8e23e725-c243-464b-a918-ef7c6d28c0e0"), false, "GetRoleById" },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), true, "Genre" },
                    { new Guid("942ba553-9a20-4de5-b7db-ff335625cb8a"), false, "DeleteRoleById" },
                    { new Guid("98f3f6b7-7986-43d9-bf4d-4052a70a25e0"), false, "ManageDeletedGames" },
                    { new Guid("9c6c246b-c3a9-477f-8c8a-eeb69aadccf4"), false, "DeleteUserById" },
                    { new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"), false, "CreateGenre" },
                    { new Guid("aa5c024b-4a16-4b60-adad-72c08a91e603"), false, "GetAllRoles" },
                    { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), false, "BanUser" },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), true, "GetGamesByPublisherName" },
                    { new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"), false, "DeletePlatform" },
                    { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), false, "Buy" },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), true, "GetGameByKey" },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), true, "GetAllGames" },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), true, "GetPaginationOptions" },
                    { new Guid("c2b2a3c9-b78b-48f6-a762-08bb749555f8"), false, "ManageAllComments" },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), true, "GetPlatformById" },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), true, "DownloadGameFile" },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), true, "Comments" },
                    { new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"), false, "UpdateGame" },
                    { new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"), false, "CreateGame" },
                    { new Guid("d7f9e26c-3d1f-401c-8cc1-97ad9b286997"), false, "Role" },
                    { new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"), false, "DeleteGenre" },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), true, "Game" },
                    { new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"), false, "CreatePublisher" },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), true, "GetAllOrders" },
                    { new Guid("e089fa10-de1c-4ae9-874d-0e9cd5e9a7f1"), false, "GetUserById" },
                    { new Guid("e149e840-49e7-4b0a-86bf-8e75f189b991"), false, "DeleteRole" },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), true, "GetBanDurations" },
                    { new Guid("e39ad140-1ecc-4a0a-8c0c-b7123af9c1db"), false, "Roles" },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), true, "Comment" },
                    { new Guid("e57da906-ec72-4d49-b534-24a254f4ff5a"), false, "GetRolesOfUser" },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), true, "GetSubGenres" },
                    { new Guid("e8c12d30-af9b-4a85-99e0-1f7c3f6ed0b3"), false, "GetAllPermissions" },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), true, "GetPaymentMethods" },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), true, "Publishers" },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), true, "GetOrderById" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("21c5ef38-1aa2-40a1-a3c0-e6b024ee53b9"), "Desktop" },
                    { new Guid("44946ceb-67f9-4de2-b063-8fd234586cc1"), "Console" },
                    { new Guid("62d9ca60-df22-4948-bcec-68e7799a68b1"), "Browser" },
                    { new Guid("ad3f7ea2-43ab-4ea5-bff5-43bf2b0b77d0"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("21508c50-9f2e-4efc-8668-f376f325e943"), "Manager" },
                    { new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c"), "Admin" },
                    { new Guid("7606a348-254d-48de-8add-3d7178da2f27"), "Moderator" },
                    { new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce"), "User" },
                    { new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb"), "Guest" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("f546fb49-9550-429e-8f44-31b4877490bc"), "Admin", "$2a$11$eG.DMQNPdl3aJheJz2AxVOzKrGagIh0IjxDV1VsBbpcu3f4CHUwHm" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("065f25a1-d7b2-4b02-9718-1ef078e62508"), "", "Off-road", new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"), "" },
                    { new Guid("0a1fe298-bded-4bea-8507-2c54bcfa6f0b"), "", "TPS", new Guid("e5bcc8b2-ee16-4f64-8a77-1bf29168ed40"), "" },
                    { new Guid("21debb5f-e572-4503-947b-2f4965b9d193"), "", "Formula", new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"), "" },
                    { new Guid("57ecc3a9-528b-431c-8b30-101dbdfb15ef"), "", "RTS", new Guid("d785499a-ee66-428a-9be1-1e7d975dd425"), "" },
                    { new Guid("c5cbcba6-1c06-4431-9fa9-c0ef1ec88962"), "", "FPS", new Guid("e5bcc8b2-ee16-4f64-8a77-1bf29168ed40"), "" },
                    { new Guid("e8fca566-dc87-4592-8cba-66fe58f24cd1"), "", "TBS", new Guid("d785499a-ee66-428a-9be1-1e7d975dd425"), "" },
                    { new Guid("e9470e7d-fd37-4480-aa31-1f601ef802ce"), "", "Arcade", new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"), "" },
                    { new Guid("f476299a-9c23-4722-8f7a-0711aafeaad5"), "", "Rally", new Guid("f2bf2b28-7dfc-430e-8533-b28bb364f999"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("003deea5-c3f9-4bca-9b94-6e6b47db13f1"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("008181b6-0f9b-44c4-b872-176717d65ced"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("008181b6-0f9b-44c4-b872-176717d65ced"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("052b4e6e-bccf-4fe1-92e2-a3d59854364f"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("05609006-9fac-4a63-a4df-90b08a6407dc"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("062ac9a6-0be8-4eb8-9f75-dbb7297eadae"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("066416ae-fcd3-4bf2-a220-d23a2e179b80"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("07bfc981-f5da-4820-a3bd-a45018794991"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("07bfc981-f5da-4820-a3bd-a45018794991"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("0a9065f7-71df-476d-b850-1b77dae66826"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("1023fa5d-2bd1-4394-9ee2-7e80c43e90c1"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("12c21572-60f8-4f63-bddb-ffe6cf99a6e9"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("13a140c1-b3d8-47a5-a2be-491814e56b74"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("27da9d3f-3244-4e11-86d4-f619d2691ac0"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("27eaa6b5-a66a-485e-9a56-88059d91c2d2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("29ab7e2c-e830-424c-a83f-ec7d5d11e52c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("2b806e2e-1e2d-4f35-9842-73ef1829c598"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("3035a0b9-1844-47d4-8ead-c2b070418f37"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("30826463-dbad-4b54-9645-a1fbdc79adad"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("33c639b3-3115-489f-a68f-c0012478e3a7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("36cfec62-f89a-44c8-ba1c-0aa19ca2c093"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("3ea879a3-9c61-4dcd-b9bf-e40b1d58a5b6"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("40e4f4a6-8544-479e-9b5b-b25005751649"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("414af816-ee8e-4241-af08-375851c43cb8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("4275b705-404e-4f19-9035-0249581b7447"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("43b46d91-f0ac-4dda-baef-93cd6ca8ab32"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("4747a1a4-17e7-43ce-85ea-edb0276b49f2"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("4812e6dc-234d-4cda-bc94-471b262facbe"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("4ddd4927-af1f-43e6-a7dd-5bc523abeb2b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("4ed8b26f-d015-4b3c-8492-ed39b5e540b8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("53916983-b914-4d7e-bab9-2f92284cb468"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("559a1d80-c73c-4f59-bd81-71cb91ccfd1e"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("57aa5c07-8ec3-48b7-8292-14ab37b0aac7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("57adb91f-5741-40b0-9ff0-ff4f0a6b88b8"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("57f4f320-5bc1-4d88-90b8-8965e2cdf0ae"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("5ab15e1f-a4f6-4dc5-bdbb-614ee51df545"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("5ab445f2-3b95-444a-afd5-c8609bd7c8c6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("5ce29acd-7d71-45a8-b7d1-0564a4f32760"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("5ef96bca-bb22-424e-9a2e-8c03be3a1a20"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("6027929d-e51c-4306-a8f0-1231fc8e1302"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("612f6f4b-0e3b-4d29-bfdb-2e385c5dad5d"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("64e44499-b669-45cc-a913-3c5010ba8b4c"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("6942df16-57cd-4040-91f2-ff88f7d71c73"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("705ef0f9-3ece-440a-8102-c26662aec137"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("7494dc09-3561-4137-af87-3186aa3c861a"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("74fa54ea-2573-4f18-a077-d3bee867b8a7"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("7d3f741f-fc72-4216-b151-4009941eff9b"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("7ea4c9fc-9e65-4a2f-87ba-bff2e36b480c"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("83e81207-c1d0-4ad7-85fb-0563763aae4f"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("8993665a-bf31-4549-9126-d9b30f138471"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("8993665a-bf31-4549-9126-d9b30f138471"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("8a3fc67e-4f22-4754-80cc-91feac2f98f9"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("8b9a1a18-3a4c-4324-8d4b-5b74723207b0"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("8e23e725-c243-464b-a918-ef7c6d28c0e0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("8f9570e9-70f0-41ce-a53d-112311170ecd"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("942ba553-9a20-4de5-b7db-ff335625cb8a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("98f3f6b7-7986-43d9-bf4d-4052a70a25e0"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("9c6c246b-c3a9-477f-8c8a-eeb69aadccf4"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("9f038b97-f759-4b0b-a2c3-aeb8282d5f42"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("aa5c024b-4a16-4b60-adad-72c08a91e603"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("ab209ad6-6d9d-4390-8f73-b7cae2375803"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("abac0f53-ece9-47ba-aa42-cc7a0349dd05"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("ac85b38f-9b38-4e40-aaf8-e1640d16d368"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("b183181c-b7f5-474f-aabb-6b082af2f5ea"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("b215981d-2400-4d9c-818f-320241da00e2"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("b2faef2f-3c51-414b-9bae-a980972e8a69"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("bda99297-7dd3-413a-9730-e4b323c08ceb"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("c2b2a3c9-b78b-48f6-a762-08bb749555f8"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("c2d0b1dd-b39b-4458-aba2-6376fec810a4"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("cf9166f0-8931-411b-87da-00d757c7e1cc"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("cfee9beb-f914-48f6-a724-a7069c8a5900"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("d21ae80d-6b67-4b82-92bf-bb87dd009b4b"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("d23b48d7-cfdd-41eb-8494-9937443faf37"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("d58d707c-6fca-4077-b1af-ecdb189e5ec1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d7f9e26c-3d1f-401c-8cc1-97ad9b286997"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("d81f723e-079d-4b45-bc4a-306c8d6613f6"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("d91085ba-3c10-4d6f-8d50-a8553a7e8b60"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("decf0a81-b7a1-4326-a2c7-77d325612b40"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("e00508fe-776a-48f2-8f0e-44f653dc7786"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("e089fa10-de1c-4ae9-874d-0e9cd5e9a7f1"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e149e840-49e7-4b0a-86bf-8e75f189b991"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("e3809594-69bf-442e-bfa1-7434d1b33a24"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("e39ad140-1ecc-4a0a-8c0c-b7123af9c1db"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("e498e90d-ee82-448c-a70f-519aeead4215"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("e57da906-ec72-4d49-b534-24a254f4ff5a"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("e78fe743-843e-4341-852c-2d9b9450e239"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("e8c12d30-af9b-4a85-99e0-1f7c3f6ed0b3"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("f530bac2-ed37-449a-8cad-0849da9ee620"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("f8da5b87-3058-4120-a920-952074837076"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("21508c50-9f2e-4efc-8668-f376f325e943") },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c") },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("7606a348-254d-48de-8add-3d7178da2f27") },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("8a7881e9-0530-44bb-ab80-48979b79f6ce") },
                    { new Guid("fe437897-51ee-4131-867a-39e043cbf0ad"), new Guid("8c3bcffc-fc1c-45dd-a9ca-b5013194f2fb") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("53632eb2-bf3c-4acf-a407-1651bef7c42c"), new Guid("f546fb49-9550-429e-8f44-31b4877490bc") });
        }
    }
}
