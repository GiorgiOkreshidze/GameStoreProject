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
    public partial class TwentyninthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("25874367-d277-4c34-acb7-752b7554057d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("296de412-f0c4-4e08-a4f1-17d3caa1cb5d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("42a217bb-2183-407c-ab7e-a2be29276810"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("575ab4ee-348d-4237-ade2-22067e0797a3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a4c80a9-fed4-48cd-9a4c-3d7202dacf18"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("852dbe44-1642-4a1f-8223-f561f45cd11b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b0a0a589-447c-46bd-8c3a-5fb8cdc83ee2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ba449f88-2072-4e3f-9643-41ac82e0733d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ba9ab52d-8b0b-4afb-9bf1-50f70902a23f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("caf20af2-956e-4bb6-a196-08a1a5857191"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7069d75-ab2c-492d-903a-6198ba0c02cc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f644feff-1c29-4613-a101-2531541cc0d0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68e02513-ebfa-448c-8a6b-81388d4f5c78"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("100bfa8c-d111-4def-bc9c-2f51612028ed"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("125f2b34-dae5-4f0d-b240-89b88dd71270"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("177506aa-c787-4c26-affe-c62b79171fc2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("226c3dd4-7f54-4d38-a6eb-d67dd045c175"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3fb89064-f022-45c9-8871-baf3ba35e4e8"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69aa33c5-8207-42a1-8f41-abd79636b30d"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6f813558-f47c-4bdc-b518-e86e29cc9793"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("736bca76-3d51-4dda-95e8-7c7f852eaf07"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455b8a5-5c4f-48fc-974b-79ed64b737a6"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("77d9f908-fdbd-44d8-a8fd-bc0c45cb1c87"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7eda05a4-a4b2-4763-ad9e-5b3acd0c6b27"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8831d0dc-e543-4845-9bd9-818a56bf2f11"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("921f3a76-4f51-4042-ba2b-f5b77ee02c07"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93a10748-e090-4a9f-8aee-5b6de01ae661"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b1ccac43-c2f0-4c5a-9774-29286e309b28"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("be0edf7a-7a41-4adf-88db-00278587e248"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bff8d4e3-703c-423a-ad01-c534a74b4550"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("caf8f3cb-96fe-42e0-9e7b-c21761eb0441"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cdd9f9e0-044a-4308-a51d-d77fc0b4f0ee"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cff3b8fa-cda0-44d4-8291-8066e1eed2d5"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d04a106b-5811-4154-921f-7f3f537dcffe"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0a3969a-f056-4b60-a457-64e93e87638e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("200a91b4-5e9d-4d08-9ea8-a0ec2f253b3e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("657016c2-0280-4564-a9cb-3fc08bad3328"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("d9ba78f3-3033-4b64-87ec-5b2308a6ef41"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e0ccb394-bb6c-4b5b-b7a0-891f643cc944"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("99a35a48-d722-43da-b287-21038786d0bd"), new Guid("decc8dbc-5b93-41f9-8701-ff40f6b91900") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("63d9e6f3-8dbc-4759-9444-29a65f940a3a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7a073f12-4813-4ba0-a3b4-6aa9722d06da"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0266197a-0105-4f05-b2c1-d104109c5797"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("100bfa8c-d111-4def-bc9c-2f51612028ed"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("125f2b34-dae5-4f0d-b240-89b88dd71270"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("13d97443-7144-4d44-b497-bd04bd45a862"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("177506aa-c787-4c26-affe-c62b79171fc2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("226c3dd4-7f54-4d38-a6eb-d67dd045c175"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2821b465-7f52-402c-a29d-dbd59004a344"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3fb89064-f022-45c9-8871-baf3ba35e4e8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("45bbce1c-e884-40f8-b583-8413285e5521"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5bb94f00-4345-4471-8591-a52e443db06f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("69aa33c5-8207-42a1-8f41-abd79636b30d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6f813558-f47c-4bdc-b518-e86e29cc9793"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("736bca76-3d51-4dda-95e8-7c7f852eaf07"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7455b8a5-5c4f-48fc-974b-79ed64b737a6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("77d9f908-fdbd-44d8-a8fd-bc0c45cb1c87"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7eda05a4-a4b2-4763-ad9e-5b3acd0c6b27"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("808bccce-a447-4121-89dd-09b061e34b85"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8831d0dc-e543-4845-9bd9-818a56bf2f11"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("904f21b5-b556-474b-8353-789099f7102c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("921f3a76-4f51-4042-ba2b-f5b77ee02c07"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("93a10748-e090-4a9f-8aee-5b6de01ae661"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9bc42303-aef9-4d32-a627-eb0489590169"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b1ccac43-c2f0-4c5a-9774-29286e309b28"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("be0edf7a-7a41-4adf-88db-00278587e248"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bff8d4e3-703c-423a-ad01-c534a74b4550"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("caf8f3cb-96fe-42e0-9e7b-c21761eb0441"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cdd9f9e0-044a-4308-a51d-d77fc0b4f0ee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cff3b8fa-cda0-44d4-8291-8066e1eed2d5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d04a106b-5811-4154-921f-7f3f537dcffe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0a3969a-f056-4b60-a457-64e93e87638e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("99a35a48-d722-43da-b287-21038786d0bd"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb61a936-fa7d-4587-a29f-264213eec709"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("decc8dbc-5b93-41f9-8701-ff40f6b91900"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("26510e0b-c2c4-45fa-8b5b-91d0c99bfef7"), "", "RPG", null, "" },
                    { new Guid("581aa43b-3dd3-494d-b70c-d8119256272b"), "", "Adventure", null, "" },
                    { new Guid("64340602-3971-48cc-b0ec-55b7b47b4e59"), "", "Action", null, "" },
                    { new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"), "", "Races", null, "" },
                    { new Guid("d11682ea-1b90-4a7b-a1f3-d98fab0618e3"), "", "Sports", null, "" },
                    { new Guid("edd05f4e-7632-4ba5-bea4-3f014e8710fb"), "", "Strategy", null, "" },
                    { new Guid("f6bef0eb-7d14-4596-b62e-64e3bbb2793e"), "", "Puzzle & Skill", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), true, "GetPublisherOfGame" },
                    { new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), false, "ShipOrder" },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), true, "GetPaginationOptions" },
                    { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), false, "Basket" },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), true, "GetAllOrders" },
                    { new Guid("175a8acd-bdf0-43f2-8769-5f40fecaabd7"), false, "GetAllPermissions" },
                    { new Guid("17ab1e54-4a64-4ecb-a8af-7f1175f1dfc5"), false, "GetPermissionsByRoleId" },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), true, "GetGameById" },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), true, "GetAllPlatforms" },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), true, "DownloadGameFile" },
                    { new Guid("1b0704bc-0121-45ed-97dd-9f19cbb97ec2"), false, "GetAllUsers" },
                    { new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"), false, "DeletePublisher" },
                    { new Guid("1f6fc5cb-ef22-487a-8324-d1374fe46744"), false, "DeleteRoleById" },
                    { new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"), false, "CreateGame" },
                    { new Guid("21cadd89-274f-4db1-ac1b-32b8076313d3"), false, "UpdateUser" },
                    { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), false, "ReplyComment" },
                    { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), false, "AddGameInCart" },
                    { new Guid("240a96a0-6849-455a-8acd-9d28fdf2dc72"), false, "DeleteRole" },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), true, "GetPlatformsOfGame" },
                    { new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"), false, "DeleteGenre" },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), true, "GetDateFilterOptions" },
                    { new Guid("2d600c20-3f6a-466c-84a0-c76615437175"), false, "Roles" },
                    { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), false, "QuoteComment" },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), true, "Genre" },
                    { new Guid("39dcbaf7-ce33-471c-b6d6-fea29a0bd4f0"), false, "Role" },
                    { new Guid("435efd5b-fef5-42d0-b033-9cf46bd91f18"), false, "GetUserById" },
                    { new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"), false, "UpdateGenre" },
                    { new Guid("48a4dc8b-2933-490a-97e0-f82b6fd860b2"), false, "DeleteOrder" },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), true, "Order" },
                    { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), false, "AddComment" },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), true, "GetOrderById" },
                    { new Guid("510b4712-4072-457f-ac46-f23d3ac0644d"), false, "UpdateRole" },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), true, "GetPlatformById" },
                    { new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"), false, "UpdatePublisher" },
                    { new Guid("59616661-e76b-40c6-b892-e2ab38b28372"), false, "DeleteUser" },
                    { new Guid("5ba780da-2497-4c26-8f0c-9414b5c4c64c"), false, "CanSeeDeletedGames" },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), true, "GetAllGenres" },
                    { new Guid("621160e6-f377-46c0-b5cb-9b78e10b066a"), false, "GetRoleById" },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), true, "GetSortingOptions" },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), true, "Platforms" },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), true, "GetSubGenres" },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), true, "GetAllGames" },
                    { new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"), false, "DeleteGame" },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), true, "GetGamesByPublisherName" },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), true, "Comment" },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), true, "GetGameByKey" },
                    { new Guid("7c3525ba-021e-4bea-8412-5e09659298de"), false, "CreateGenre" },
                    { new Guid("7d6f4860-a2d5-4203-b405-b013ace9e9b2"), false, "SeeDeletedGames" },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), true, "Publisher" },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), true, "Game" },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), true, "GetGenre" },
                    { new Guid("86744cba-1cf3-48d9-be19-d7e006722464"), false, "DeleteUserById" },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), true, "GetGames" },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), true, "Orders" },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), true, "GetGamesByGenreId" },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), true, "GetPublisherByCompanyName" },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), false, "History" },
                    { new Guid("94f7b543-a012-463b-895c-a95840a180a6"), false, "GetRolesOfUser" },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), true, "Publishers" },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), true, "Games" },
                    { new Guid("a55f1f35-2dac-44e6-9624-517e7d825285"), false, "Users" },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), true, "GetAllOrdersDetails" },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), true, "Genres" },
                    { new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"), false, "CreatePlatform" },
                    { new Guid("b0377208-9784-4cab-9ce1-045e6b88374a"), false, "UpdateOrder" },
                    { new Guid("b1cc1306-f8d1-42a8-a301-e58374491131"), false, "ManageDeletedGames" },
                    { new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"), false, "DeletePlatform" },
                    { new Guid("b2bb6203-0d65-4f30-8132-3b7d75840cba"), false, "GetAllRoles" },
                    { new Guid("b6538146-3592-49fa-af3c-3b6d46538093"), false, "UpdateGame" },
                    { new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"), false, "DeleteOrderDetails" },
                    { new Guid("b7867b43-0fa3-44c7-9fb9-7aee7b0bdd2c"), false, "AddRole" },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), true, "GetBanDurations" },
                    { new Guid("b94b2053-50ca-4277-82b8-60e5f8d72ab1"), false, "AddUser" },
                    { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), false, "DeleteComment" },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), true, "GetAllPublishers" },
                    { new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"), false, "UpdatePlatform" },
                    { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), false, "DeleteGameFromCart" },
                    { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), false, "Buy" },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), true, "GetComments" },
                    { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), false, "Payment" },
                    { new Guid("ceeb7177-fa55-4e15-af4f-1db11cdbc96f"), false, "User" },
                    { new Guid("cf6cfabd-e1e5-460e-8a9b-da935675d66f"), false, "ManageAllComments" },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), true, "GetPaymentMethods" },
                    { new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"), false, "CreatePublisher" },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), true, "GetGamesByPlatformId" },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), true, "Platform" },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), true, "GetCart" },
                    { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), false, "BanUser" },
                    { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), false, "AddGameToOrderByKey" },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), true, "GetGenresOfGame" },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), true, "GetOrders" },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), true, "Comments" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("13b3a156-61db-462f-8cdd-c6e84482bc9a"), "Browser" },
                    { new Guid("81849ec9-d3b4-487c-9315-5d56d12b058c"), "Mobile" },
                    { new Guid("aad97f15-9c00-4743-9b78-114a0dcf82bd"), "Console" },
                    { new Guid("d5a446f5-3a5e-4ea2-8a54-c081f6530f2c"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210"), "User" },
                    { new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8"), "Moderator" },
                    { new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72"), "Admin" },
                    { new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019"), "Guest" },
                    { new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c"), "Manager" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("b9b487f4-985b-463d-afb0-267c4680477b"), "Admin", "$2a$11$kSbjVcX3sNmD.WpOPN7iee4J6rnc5v1FpuESffqzoVDi3/7WFFUe." });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1b20b352-39a1-44f9-92bb-1e17fa609081"), "", "FPS", new Guid("64340602-3971-48cc-b0ec-55b7b47b4e59"), "" },
                    { new Guid("280e32bc-3507-44be-b131-b13391938612"), "", "TPS", new Guid("64340602-3971-48cc-b0ec-55b7b47b4e59"), "" },
                    { new Guid("8561a85e-54a7-439a-a38a-5540119fc7b1"), "", "Off-road", new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"), "" },
                    { new Guid("8d3238bc-e76a-4ef5-9662-746761294096"), "", "Rally", new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"), "" },
                    { new Guid("d2deefde-4e82-47f1-bd4c-409347d9b005"), "", "Arcade", new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"), "" },
                    { new Guid("e48c78b9-1403-40af-87ee-98754cb2c50d"), "", "TBS", new Guid("edd05f4e-7632-4ba5-bea4-3f014e8710fb"), "" },
                    { new Guid("edff3470-6555-4d08-994a-3d517c734168"), "", "Formula", new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"), "" },
                    { new Guid("f927e23d-c31b-47ef-813a-e66ac82e487b"), "", "RTS", new Guid("edd05f4e-7632-4ba5-bea4-3f014e8710fb"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("175a8acd-bdf0-43f2-8769-5f40fecaabd7"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("17ab1e54-4a64-4ecb-a8af-7f1175f1dfc5"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("1b0704bc-0121-45ed-97dd-9f19cbb97ec2"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("1f6fc5cb-ef22-487a-8324-d1374fe46744"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("21cadd89-274f-4db1-ac1b-32b8076313d3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("240a96a0-6849-455a-8acd-9d28fdf2dc72"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("2d600c20-3f6a-466c-84a0-c76615437175"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("39dcbaf7-ce33-471c-b6d6-fea29a0bd4f0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("435efd5b-fef5-42d0-b033-9cf46bd91f18"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("48a4dc8b-2933-490a-97e0-f82b6fd860b2"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("510b4712-4072-457f-ac46-f23d3ac0644d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("59616661-e76b-40c6-b892-e2ab38b28372"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("5ba780da-2497-4c26-8f0c-9414b5c4c64c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("621160e6-f377-46c0-b5cb-9b78e10b066a"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("7c3525ba-021e-4bea-8412-5e09659298de"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("7c3525ba-021e-4bea-8412-5e09659298de"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("86744cba-1cf3-48d9-be19-d7e006722464"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("94f7b543-a012-463b-895c-a95840a180a6"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("a55f1f35-2dac-44e6-9624-517e7d825285"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("b0377208-9784-4cab-9ce1-045e6b88374a"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b1cc1306-f8d1-42a8-a301-e58374491131"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("b2bb6203-0d65-4f30-8132-3b7d75840cba"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b6538146-3592-49fa-af3c-3b6d46538093"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b6538146-3592-49fa-af3c-3b6d46538093"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("b7867b43-0fa3-44c7-9fb9-7aee7b0bdd2c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("b94b2053-50ca-4277-82b8-60e5f8d72ab1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("ceeb7177-fa55-4e15-af4f-1db11cdbc96f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("cf6cfabd-e1e5-460e-8a9b-da935675d66f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") },
                    { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72"), new Guid("b9b487f4-985b-463d-afb0-267c4680477b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b20b352-39a1-44f9-92bb-1e17fa609081"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("26510e0b-c2c4-45fa-8b5b-91d0c99bfef7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("280e32bc-3507-44be-b131-b13391938612"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("581aa43b-3dd3-494d-b70c-d8119256272b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8561a85e-54a7-439a-a38a-5540119fc7b1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d3238bc-e76a-4ef5-9662-746761294096"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d11682ea-1b90-4a7b-a1f3-d98fab0618e3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2deefde-4e82-47f1-bd4c-409347d9b005"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e48c78b9-1403-40af-87ee-98754cb2c50d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("edff3470-6555-4d08-994a-3d517c734168"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6bef0eb-7d14-4596-b62e-64e3bbb2793e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f927e23d-c31b-47ef-813a-e66ac82e487b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d6f4860-a2d5-4203-b405-b013ace9e9b2"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02444628-b764-44e3-b929-88ad3caf30e0"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("071fea25-d1bd-425c-b47f-78022a95d965"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("175a8acd-bdf0-43f2-8769-5f40fecaabd7"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17ab1e54-4a64-4ecb-a8af-7f1175f1dfc5"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1b0704bc-0121-45ed-97dd-9f19cbb97ec2"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1f6fc5cb-ef22-487a-8324-d1374fe46744"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("21cadd89-274f-4db1-ac1b-32b8076313d3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("240a96a0-6849-455a-8acd-9d28fdf2dc72"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2d600c20-3f6a-466c-84a0-c76615437175"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("39dcbaf7-ce33-471c-b6d6-fea29a0bd4f0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("435efd5b-fef5-42d0-b033-9cf46bd91f18"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("48a4dc8b-2933-490a-97e0-f82b6fd860b2"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("510b4712-4072-457f-ac46-f23d3ac0644d"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59616661-e76b-40c6-b892-e2ab38b28372"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ba780da-2497-4c26-8f0c-9414b5c4c64c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("621160e6-f377-46c0-b5cb-9b78e10b066a"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64339b14-1741-4f82-a9f3-7767138707f8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c3525ba-021e-4bea-8412-5e09659298de"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c3525ba-021e-4bea-8412-5e09659298de"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("86744cba-1cf3-48d9-be19-d7e006722464"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("94f7b543-a012-463b-895c-a95840a180a6"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a55f1f35-2dac-44e6-9624-517e7d825285"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b0377208-9784-4cab-9ce1-045e6b88374a"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b1cc1306-f8d1-42a8-a301-e58374491131"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b2bb6203-0d65-4f30-8132-3b7d75840cba"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b6538146-3592-49fa-af3c-3b6d46538093"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b6538146-3592-49fa-af3c-3b6d46538093"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b7867b43-0fa3-44c7-9fb9-7aee7b0bdd2c"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9277885-61fb-461f-9760-c2a6055fc659"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b94b2053-50ca-4277-82b8-60e5f8d72ab1"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ceeb7177-fa55-4e15-af4f-1db11cdbc96f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf6cfabd-e1e5-460e-8a9b-da935675d66f"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db9f9b92-690e-48fa-9529-54c807375944"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"), new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("13b3a156-61db-462f-8cdd-c6e84482bc9a"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("81849ec9-d3b4-487c-9315-5d56d12b058c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("aad97f15-9c00-4743-9b78-114a0dcf82bd"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("d5a446f5-3a5e-4ea2-8a54-c081f6530f2c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72"), new Guid("b9b487f4-985b-463d-afb0-267c4680477b") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("64340602-3971-48cc-b0ec-55b7b47b4e59"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7a47e7e8-53a1-4015-8af8-5849e721bd99"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("edd05f4e-7632-4ba5-bea4-3f014e8710fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("02444628-b764-44e3-b929-88ad3caf30e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("03668aa3-5d37-4e9c-ae0b-e719eff84863"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("06698c5c-ee5b-4fd8-bb73-9b473bd7b3ad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("071fea25-d1bd-425c-b47f-78022a95d965"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0e1469bc-43aa-4ca3-8463-0714c6d96039"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("127e0b84-e12d-4b4b-9a69-e426a288da88"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("175a8acd-bdf0-43f2-8769-5f40fecaabd7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("17ab1e54-4a64-4ecb-a8af-7f1175f1dfc5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("17d67b80-893e-4b8d-ba02-e42246b73882"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("18560637-cf0d-429d-ad00-f52e6637fd66"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1aac8162-151e-4528-8f04-2dc4f40d9d5d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b0704bc-0121-45ed-97dd-9f19cbb97ec2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b739631-f970-4e3c-9471-b5f8b8b7d3b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1f6fc5cb-ef22-487a-8324-d1374fe46744"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("21b606ad-107e-45be-b97d-b7fcd2ebb90e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("21cadd89-274f-4db1-ac1b-32b8076313d3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2386040e-5a82-428d-8928-0bd9e77e83a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("23cc5d88-7272-412d-9b76-c91499f0f4e9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("240a96a0-6849-455a-8acd-9d28fdf2dc72"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("24902866-0a06-4f80-a07d-4f38f18157ec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("26d1dc15-da10-45d8-ad4c-9a850697fffa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d401699-01a5-403d-9c02-def2bf9a77a1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2d600c20-3f6a-466c-84a0-c76615437175"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("34613d6f-4865-4084-ad1e-05820e8e3111"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("365d81f9-6db0-4f92-bfd3-0d1fcde7fb8d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("39dcbaf7-ce33-471c-b6d6-fea29a0bd4f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("435efd5b-fef5-42d0-b033-9cf46bd91f18"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4371f1c6-39ad-4fab-b85b-4102b1918c43"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("48a4dc8b-2933-490a-97e0-f82b6fd860b2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("49197736-7ed4-4df9-97d9-e62bfef43ebf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e17d8af-b71b-4fc9-8399-6cd1ef2fbd21"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("509f3f8f-56cf-4db5-bc1b-0530befa19ce"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("510b4712-4072-457f-ac46-f23d3ac0644d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("587a04bb-63b9-4d92-a77b-cb184f981430"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("58d214ce-1750-4e4f-b0dd-f58c2ea9e24f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("59616661-e76b-40c6-b892-e2ab38b28372"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ba780da-2497-4c26-8f0c-9414b5c4c64c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("60e77705-89db-4e0a-b6f9-a468c057b403"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("621160e6-f377-46c0-b5cb-9b78e10b066a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("64339b14-1741-4f82-a9f3-7767138707f8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65a40423-265f-4666-acab-66cefcf7f5d1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65eae0a5-bffa-431a-83e6-d3b3ee6d4f47"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("67c65d23-dff9-4a5e-8a79-d9f1209345ca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6fe08a02-6ec2-4828-b776-924607e912fd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("71110cb9-d106-497c-9fef-aad9507b04c8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("72d248bc-ff79-4b3e-8387-14a90e384b0e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("774249b5-e2fa-4ac8-9444-f43c88195dc9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c3525ba-021e-4bea-8412-5e09659298de"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7dc756ce-91dc-4fee-b442-7f7879c15ddd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("83b92723-7051-47cb-bfc8-ccf86f1462fe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("85fc1e49-d362-4301-aeeb-fe2469fb4d31"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("86744cba-1cf3-48d9-be19-d7e006722464"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("888fbe17-5066-4c27-b65c-ef54373677e6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8aa39e8a-4207-4bb2-849d-bfa16faa1be3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b37827a-3e1a-416a-9e0a-e24fbbbba23c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d15a703-a143-421f-b9af-aa3d21ffc33c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9394a9d5-d80e-4b1a-b4fa-08afba454eba"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("94f7b543-a012-463b-895c-a95840a180a6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9acfa25b-5201-49b8-adce-31a581df0e35"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a35d6160-a0f3-4320-8173-1cd93bc4c635"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a55f1f35-2dac-44e6-9624-517e7d825285"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a7ae1b34-fbea-4d6b-8f40-7b43f227cdce"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a81bee48-ced9-4e5b-99d1-f049c9c86456"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad9de21c-c4b1-4b46-b4e4-27fd75b8a333"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b0377208-9784-4cab-9ce1-045e6b88374a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b1cc1306-f8d1-42a8-a301-e58374491131"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b24a299a-3a4d-45c9-8fa8-963cb4519862"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b2bb6203-0d65-4f30-8132-3b7d75840cba"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b6538146-3592-49fa-af3c-3b6d46538093"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b6bfeadf-db14-40cc-81cf-42c718096ce1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b7867b43-0fa3-44c7-9fb9-7aee7b0bdd2c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b9277885-61fb-461f-9760-c2a6055fc659"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b94b2053-50ca-4277-82b8-60e5f8d72ab1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c023ff7e-34e9-4ebb-913a-ecb70a6c0ca9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c3245eb1-be20-4058-ab5a-15f7e933a7bd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c4c413da-d053-49f7-a5ce-49c48f4f3a04"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c6555ecd-2533-4e96-8cfc-e719a8124ec0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c755f220-f293-409e-9ef8-ced2fa2a055b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c8defac2-af7d-4aa3-9638-f9fed97a88dd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cdb61839-af36-4db0-9dcc-30a277c59b32"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ceeb7177-fa55-4e15-af4f-1db11cdbc96f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf6cfabd-e1e5-460e-8a9b-da935675d66f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cfc64301-541e-4137-8b52-13b54e82d0a5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d32c3fca-0082-4eb9-8de2-627dd598c2d9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7982e4b-c0c6-43fb-baeb-330f1bae3650"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("db9f9b92-690e-48fa-9529-54c807375944"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e4c88243-4868-4262-bf51-14a7f0ef968b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ea24e5ed-cbec-432e-8067-535d51b3b4d3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("edcbbb2c-d776-4627-97e8-36a0ce3426f8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ee8ee958-a34e-480b-a00a-345ee7945dda"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f315ee84-3bdb-4c4f-aca9-7c00e78f19fc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f361d355-d6ad-4982-a449-0cf55cf4c101"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("5d8aae91-2b55-4a8e-8bad-3cd118b9d210"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae4fe9d8-cf47-41a2-a86d-d73932508ac8"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cefb6247-b292-4ba9-8554-b11af95aaf72"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2cdf0e2-82d9-47e4-a0ca-6e6a665b8019"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3a4d7bb-35db-4f87-97e2-77bf5fa4f29c"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("b9b487f4-985b-463d-afb0-267c4680477b"));

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"), "", "Races", null, "" },
                    { new Guid("42a217bb-2183-407c-ab7e-a2be29276810"), "", "RPG", null, "" },
                    { new Guid("63d9e6f3-8dbc-4759-9444-29a65f940a3a"), "", "Action", null, "" },
                    { new Guid("7a073f12-4813-4ba0-a3b4-6aa9722d06da"), "", "Strategy", null, "" },
                    { new Guid("b0a0a589-447c-46bd-8c3a-5fb8cdc83ee2"), "", "Adventure", null, "" },
                    { new Guid("d7069d75-ab2c-492d-903a-6198ba0c02cc"), "", "Puzzle & Skill", null, "" },
                    { new Guid("f644feff-1c29-4613-a101-2531541cc0d0"), "", "Sports", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), true, "Publishers" },
                    { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), false, "Basket" },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), true, "GetGenre" },
                    { new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), true, "Orders" },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), true, "GetSortingOptions" },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), true, "GetDateFilterOptions" },
                    { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), false, "QuoteComment" },
                    { new Guid("100bfa8c-d111-4def-bc9c-2f51612028ed"), false, "User" },
                    { new Guid("125f2b34-dae5-4f0d-b240-89b88dd71270"), false, "UpdateUser" },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), true, "Genre" },
                    { new Guid("177506aa-c787-4c26-affe-c62b79171fc2"), false, "GetAllRoles" },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), true, "GetGameByKey" },
                    { new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"), false, "DeleteOrderDetails" },
                    { new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"), false, "CreateGenre" },
                    { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), false, "DeleteComment" },
                    { new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"), false, "DeleteGenre" },
                    { new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"), false, "DeletePlatform" },
                    { new Guid("226c3dd4-7f54-4d38-a6eb-d67dd045c175"), false, "DeleteUser" },
                    { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), false, "Payment" },
                    { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), false, "ReplyComment" },
                    { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), false, "AddGameToOrderByKey" },
                    { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), false, "AddGameInCart" },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), true, "GetComments" },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), true, "GetAllOrders" },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), true, "Platform" },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), true, "GetPublisherOfGame" },
                    { new Guid("3fb89064-f022-45c9-8871-baf3ba35e4e8"), false, "Users" },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), false, "History" },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), true, "GetGameById" },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), true, "GetOrders" },
                    { new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"), false, "UpdateGame" },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), true, "GetPaymentMethods" },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), true, "GetAllPublishers" },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), true, "GetGamesByGenreId" },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), true, "GetSubGenres" },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), true, "GetPlatformById" },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), true, "GetBanDurations" },
                    { new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"), false, "DeleteGame" },
                    { new Guid("68e02513-ebfa-448c-8a6b-81388d4f5c78"), false, "SeeDeletedGames" },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), true, "Order" },
                    { new Guid("69aa33c5-8207-42a1-8f41-abd79636b30d"), false, "AddUser" },
                    { new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"), false, "CreatePlatform" },
                    { new Guid("6f813558-f47c-4bdc-b518-e86e29cc9793"), false, "Roles" },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), true, "Publisher" },
                    { new Guid("736bca76-3d51-4dda-95e8-7c7f852eaf07"), false, "GetAllPermissions" },
                    { new Guid("7455b8a5-5c4f-48fc-974b-79ed64b737a6"), false, "GetRolesOfUser" },
                    { new Guid("77d9f908-fdbd-44d8-a8fd-bc0c45cb1c87"), false, "DeleteUserById" },
                    { new Guid("7eda05a4-a4b2-4763-ad9e-5b3acd0c6b27"), false, "Role" },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), true, "DownloadGameFile" },
                    { new Guid("8831d0dc-e543-4845-9bd9-818a56bf2f11"), false, "AddRole" },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), true, "Comment" },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), true, "GetPlatformsOfGame" },
                    { new Guid("921f3a76-4f51-4042-ba2b-f5b77ee02c07"), false, "CanSeeDeletedGames" },
                    { new Guid("93a10748-e090-4a9f-8aee-5b6de01ae661"), false, "DeleteRoleById" },
                    { new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"), false, "CreateGame" },
                    { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), false, "BanUser" },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), true, "GetPaginationOptions" },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), true, "GetAllPlatforms" },
                    { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), false, "ShipOrder" },
                    { new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"), false, "CreatePublisher" },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), true, "GetCart" },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), true, "GetGames" },
                    { new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"), false, "UpdateGenre" },
                    { new Guid("b1ccac43-c2f0-4c5a-9774-29286e309b28"), false, "GetAllUsers" },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), true, "Game" },
                    { new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"), false, "UpdatePlatform" },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), true, "Platforms" },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), true, "Games" },
                    { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), false, "AddComment" },
                    { new Guid("be0edf7a-7a41-4adf-88db-00278587e248"), false, "UpdateRole" },
                    { new Guid("bff8d4e3-703c-423a-ad01-c534a74b4550"), false, "GetRoleById" },
                    { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), false, "DeleteGameFromCart" },
                    { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), false, "Buy" },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), true, "GetAllGames" },
                    { new Guid("caf8f3cb-96fe-42e0-9e7b-c21761eb0441"), false, "GetPermissionsByRoleId" },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), true, "GetAllOrdersDetails" },
                    { new Guid("cdd9f9e0-044a-4308-a51d-d77fc0b4f0ee"), false, "ManageAllComments" },
                    { new Guid("cff3b8fa-cda0-44d4-8291-8066e1eed2d5"), false, "ManageDeletedGames" },
                    { new Guid("d04a106b-5811-4154-921f-7f3f537dcffe"), false, "DeleteRole" },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), true, "Comments" },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), true, "GetGamesByPlatformId" },
                    { new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"), false, "DeletePublisher" },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), true, "GetGenresOfGame" },
                    { new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"), false, "UpdatePublisher" },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), true, "GetGamesByPublisherName" },
                    { new Guid("f0a3969a-f056-4b60-a457-64e93e87638e"), false, "GetUserById" },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), true, "GetAllGenres" },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), true, "GetPublisherByCompanyName" },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), true, "Genres" },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), true, "GetOrderById" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("200a91b4-5e9d-4d08-9ea8-a0ec2f253b3e"), "Desktop" },
                    { new Guid("657016c2-0280-4564-a9cb-3fc08bad3328"), "Browser" },
                    { new Guid("d9ba78f3-3033-4b64-87ec-5b2308a6ef41"), "Mobile" },
                    { new Guid("e0ccb394-bb6c-4b5b-b7a0-891f643cc944"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e"), "User" },
                    { new Guid("99a35a48-d722-43da-b287-21038786d0bd"), "Admin" },
                    { new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190"), "Moderator" },
                    { new Guid("cb61a936-fa7d-4587-a29f-264213eec709"), "Manager" },
                    { new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2"), "Guest" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("decc8dbc-5b93-41f9-8701-ff40f6b91900"), "Admin", "$2a$11$tT4yDGr/KKBGEfPiv3RLrubUkSwtK7MAzneak.oHLj/FQH3nm6ar6" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("25874367-d277-4c34-acb7-752b7554057d"), "", "TPS", new Guid("63d9e6f3-8dbc-4759-9444-29a65f940a3a"), "" },
                    { new Guid("296de412-f0c4-4e08-a4f1-17d3caa1cb5d"), "", "Rally", new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"), "" },
                    { new Guid("575ab4ee-348d-4237-ade2-22067e0797a3"), "", "Arcade", new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"), "" },
                    { new Guid("6a4c80a9-fed4-48cd-9a4c-3d7202dacf18"), "", "FPS", new Guid("63d9e6f3-8dbc-4759-9444-29a65f940a3a"), "" },
                    { new Guid("852dbe44-1642-4a1f-8223-f561f45cd11b"), "", "RTS", new Guid("7a073f12-4813-4ba0-a3b4-6aa9722d06da"), "" },
                    { new Guid("ba449f88-2072-4e3f-9643-41ac82e0733d"), "", "TBS", new Guid("7a073f12-4813-4ba0-a3b4-6aa9722d06da"), "" },
                    { new Guid("ba9ab52d-8b0b-4afb-9bf1-50f70902a23f"), "", "Formula", new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"), "" },
                    { new Guid("caf20af2-956e-4bb6-a196-08a1a5857191"), "", "Off-road", new Guid("2cfd179e-a2c7-44ce-8ce9-dd251f34ce72"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0018af29-31c5-463b-bc6e-b5cfda7276a1"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("019f791e-8d49-44ff-be05-b4b6658f7525"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0266197a-0105-4f05-b2c1-d104109c5797"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("045c9ac6-7dc1-457b-99f9-2a57fb425791"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0962dfdb-555c-4b35-8e97-2376935026f8"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0abaab8a-828a-44d5-bcbc-ccc4cee87ab1"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("0f5c74c9-ed75-4620-9aae-6701fdacee83"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("1004ac4d-51c4-4a32-9642-0961327bbed2"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("100bfa8c-d111-4def-bc9c-2f51612028ed"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("125f2b34-dae5-4f0d-b240-89b88dd71270"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("13d97443-7144-4d44-b497-bd04bd45a862"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("177506aa-c787-4c26-affe-c62b79171fc2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("1a47f956-16be-422b-a5eb-7b7cd442819e"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1a51ee61-95da-465b-9e5d-3da97efe79da"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1b95a93b-daf0-4ca2-9461-1e6ceb102ff6"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("1bbbdd7a-bc0e-4053-b68a-d67a7a95d27a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1cf69fb5-6180-47cd-9f41-20990ab1868e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("1ed65f21-eda1-40e0-8bdf-4fbe9bfd224e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("226c3dd4-7f54-4d38-a6eb-d67dd045c175"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("247fb806-38cc-4c48-aad3-4aa0dd5e978f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("27429dd9-9761-4fe4-b41b-9f3024e765ce"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("27948f2a-20e0-402b-9e27-2291231b1a57"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("2821b465-7f52-402c-a29d-dbd59004a344"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("2e7812cc-7fee-4bde-bd45-fb585ef0385a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("316a1a79-e675-4398-97ca-d152eb53ef53"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("37da8ef5-d2f0-4b28-9c5f-9b9a09d392b9"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("3bf8e09b-b07b-4685-b849-207cdc87f51c"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("3fb89064-f022-45c9-8871-baf3ba35e4e8"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("458f52ba-7cce-48ec-976d-3d251ea255fb"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("45bbce1c-e884-40f8-b583-8413285e5521"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("45def077-cfbb-4b7b-9e61-0836f7bd5b83"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("45e4b7ff-af0b-4abc-b3a9-c5ce7e337a1b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("46c24b6c-6557-4b72-af01-d29a9d9a1175"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("4e0da604-8ef7-408c-9a1e-27ba048999bb"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("54be2ec4-433f-4044-80af-fa62ab35c78a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("5a509ad3-d6a8-4c87-be78-beea830d7042"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("5bb94f00-4345-4471-8591-a52e443db06f"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("5e836796-94a2-43fe-8ec0-06fa2178599a"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("5fc92c42-2189-4b19-b521-0037e22a6d70"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("68f68a95-ed05-48f8-816a-ec415b6ffed7"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("69aa33c5-8207-42a1-8f41-abd79636b30d"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("6d3ecaf6-b3ea-4a5c-9bcb-6e868568413b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("6f813558-f47c-4bdc-b518-e86e29cc9793"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("705508fb-ebc8-4dd0-a69a-92115390bce0"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("736bca76-3d51-4dda-95e8-7c7f852eaf07"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("7455b8a5-5c4f-48fc-974b-79ed64b737a6"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("77d9f908-fdbd-44d8-a8fd-bc0c45cb1c87"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("7eda05a4-a4b2-4763-ad9e-5b3acd0c6b27"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("808bccce-a447-4121-89dd-09b061e34b85"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("8831d0dc-e543-4845-9bd9-818a56bf2f11"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("8cd48223-2fe4-476b-bf21-609ccb2a71f4"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("904f21b5-b556-474b-8353-789099f7102c"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("921f3a76-4f51-4042-ba2b-f5b77ee02c07"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("93a10748-e090-4a9f-8aee-5b6de01ae661"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("9500ee19-1e9a-4c9f-be3c-d27db186c8b4"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("9bc42303-aef9-4d32-a627-eb0489590169"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a0259bcc-06a4-4eb7-b817-63c24c32b460"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a2271933-9352-4683-b6c8-5046fb91cde2"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("a313b4d6-51ea-47cc-8477-a114efce4627"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a6a61ac1-72e2-43b1-813e-532e74453383"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a901c17c-093d-4d63-afec-358f3b6911f0"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("a9383d03-4185-4e01-bf0d-653d25fa01f5"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("acf43ae4-afab-4131-8099-2c0916b9bb7c"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("b1ccac43-c2f0-4c5a-9774-29286e309b28"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("b21f1194-5cc6-4d74-a486-b1e50612b515"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("b26add85-fe0d-4b44-9b06-5fdf15b75b8b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("b5f965e7-a8c0-4db5-8e66-a043c8e5f545"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("b7acc4db-db03-41fd-aaeb-63771f47f417"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("bdad3837-68e0-40fb-9c62-3f0309dd469b"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("be0edf7a-7a41-4adf-88db-00278587e248"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("bff8d4e3-703c-423a-ad01-c534a74b4550"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("c09765b9-1cc0-4804-aa1b-279fc3f38e5a"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("c9618f2e-7757-4ffc-ad56-07c33528310e"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("c96b7fc7-fa94-4bfc-9d95-4e631d45a354"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("caf8f3cb-96fe-42e0-9e7b-c21761eb0441"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("cd28ce9e-1eb7-46e2-b3dc-adbd027d7708"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("cdd9f9e0-044a-4308-a51d-d77fc0b4f0ee"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("cff3b8fa-cda0-44d4-8291-8066e1eed2d5"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("d04a106b-5811-4154-921f-7f3f537dcffe"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("d0b1e47e-4485-4b12-96e1-a2299e215927"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("d790d9a2-4212-44db-8d09-cb3c0d13e380"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("d832df6d-f5ed-468d-b450-e14600916cf9"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("dbcd6b0f-dba2-4541-ae2a-c25567f315d3"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("e524e7e4-251b-4652-bded-a9bd8f6a6291"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("e7b6ca79-6555-47f0-9354-9a5d5a106f21"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("f0a3969a-f056-4b60-a457-64e93e87638e"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("f30f3399-a60e-4c08-bc17-fa5969ef8045"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("f6b2e597-7bf1-4f45-a62f-26ccf6e1bb1f"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("f876c484-d041-4e04-b13f-ccb6eb4e2f0d"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("032fe0d9-8ae4-4a32-a0fa-6c1591c84c9e") },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("99a35a48-d722-43da-b287-21038786d0bd") },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("c7787093-6216-4a0e-8f8c-ccae9f04e190") },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("cb61a936-fa7d-4587-a29f-264213eec709") },
                    { new Guid("f9c74188-cb9d-4e15-bed6-fd7c31518878"), new Guid("f9b01e1b-24bc-4b94-a7ad-ffe8046901f2") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("99a35a48-d722-43da-b287-21038786d0bd"), new Guid("decc8dbc-5b93-41f9-8701-ff40f6b91900") });
        }
    }
}
