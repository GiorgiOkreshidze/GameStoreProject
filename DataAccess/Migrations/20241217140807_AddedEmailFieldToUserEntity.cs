using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailFieldToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f8c4363-ffe6-46e1-b194-ed68dc42ca41"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1305baf9-6e39-41d3-8f46-e1f4d9edeab8"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("29a12d27-a1ea-4ee1-ba32-96ed94defa25"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f4b5014-f4d5-406c-a824-86c4ff515b63"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f61bc79-d72b-455c-86d9-541923ab4467"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("303f6803-7436-4fae-82fa-67ef02b61d3b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7758c810-de5f-419b-86f7-e9faf3ef0448"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7a6cb6a4-d8f3-4de7-b37b-ac10859da87d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad44f63c-159d-41aa-bf35-94b1654ccc72"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("be2c4ebb-bb9a-42ed-8f36-84346a9722c7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e48ce5be-a8b6-4314-a8ce-b36bb39d7fa1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e95d93ab-3dc2-4e49-a199-9c6ecddcd97f"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("244b59d8-1b6d-4060-a036-f3aab26df734"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("36495951-8c79-4d5b-8014-5cc746c716dd"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("c6339fa4-f52b-4623-aa50-7611271b0c27"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a45836a-30e0-40df-9d4b-b71a26aed3b4"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10472401-7254-4c06-af36-4db450d2c248"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("17f6c557-1040-44c1-ba41-9642a2ee6ef0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("200a0485-4460-45a9-87d3-10f604be71b4"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("27b5368b-99c6-4cc0-ad52-1f1b6bd3015b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d2324ee-1941-4e39-a786-bffed359714f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("47d5916f-f60a-4969-9c56-14ca2988178a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49571d68-b057-4c5a-a6b3-ce4372a74f7f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5c197062-ab1c-44de-86bf-0114a7353563"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5c197062-ab1c-44de-86bf-0114a7353563"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cb5999a-091f-4b03-9a58-c3ca98d1cc9d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("678141dc-9c96-4fbe-b72a-66fb534cd492"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68e96013-f4df-4bc4-a1a8-0f8667f28a90"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6dac93b1-8c93-4017-af93-8ebc830a8e2a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6dda337a-a26c-4a52-8547-51e18f1ebec4"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("76de98df-eb02-437a-a3f9-6465f7c65890"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b94e97b-f279-46dd-95c9-81bbdd442bc7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a63395e5-ab39-47f0-beb6-ca2adb7ff64d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6f90305-cd19-4583-b32f-56a79a776a36"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a7b2ceec-c121-43e3-9d69-4b8d61cffff9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8470e68-c7ef-4c87-8676-a9173300ccec"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c793f0f6-aff5-46c7-a7b5-26bd1101c9c2"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb602ab3-5b41-45cb-8235-f9d75a42f4e7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dde98b71-f7e4-40e1-96ce-8626094020fa"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ec0c2cda-d390-4b8d-8b25-01da40ddcb9c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1ff0c01-63d5-4eb6-85ae-f157d6f809b8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f549439c-ba5f-402c-8a81-4560f0977ae6"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("61b80b71-88cc-4c55-b5cb-604b6351e7b7"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("a056b318-b0fe-4807-94e8-1a0a4cfdb400"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("d0e4c357-284a-414c-b555-f6d51239dfa1"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("d10b3782-adb4-4dbb-aac1-156e0835425d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78"), new Guid("dc249123-cabc-4a32-bf75-e65525ee6ce0") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("31ba694a-f0b3-4d31-86a9-b69853d1203a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("76f335cc-5dc4-427d-b89c-6e45d56a0a66"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("07a70844-b669-429b-9625-ac04992d6b3f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("10472401-7254-4c06-af36-4db450d2c248"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1315befb-f177-405a-afff-7e206c27bf1b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("17f6c557-1040-44c1-ba41-9642a2ee6ef0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("200a0485-4460-45a9-87d3-10f604be71b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("27b5368b-99c6-4cc0-ad52-1f1b6bd3015b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d2324ee-1941-4e39-a786-bffed359714f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("47d5916f-f60a-4969-9c56-14ca2988178a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("49571d68-b057-4c5a-a6b3-ce4372a74f7f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("59413036-3d21-462b-a75b-77a36be018ee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("59416536-826e-4ad9-9d6f-2965794f0912"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c197062-ab1c-44de-86bf-0114a7353563"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5cb5999a-091f-4b03-9a58-c3ca98d1cc9d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6773b1c9-c760-42c7-993a-32542959122d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("678141dc-9c96-4fbe-b72a-66fb534cd492"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68e96013-f4df-4bc4-a1a8-0f8667f28a90"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6dac93b1-8c93-4017-af93-8ebc830a8e2a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6dda337a-a26c-4a52-8547-51e18f1ebec4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("76de98df-eb02-437a-a3f9-6465f7c65890"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("84722900-2c56-41e4-a9ad-db2485582edb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9b94e97b-f279-46dd-95c9-81bbdd442bc7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a63395e5-ab39-47f0-beb6-ca2adb7ff64d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a6f90305-cd19-4583-b32f-56a79a776a36"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a7b2ceec-c121-43e3-9d69-4b8d61cffff9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8470e68-c7ef-4c87-8676-a9173300ccec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c793f0f6-aff5-46c7-a7b5-26bd1101c9c2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb602ab3-5b41-45cb-8235-f9d75a42f4e7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dde98b71-f7e4-40e1-96ce-8626094020fa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e49c586c-4797-4861-9a77-a058080f3324"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ec0c2cda-d390-4b8d-8b25-01da40ddcb9c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1ff0c01-63d5-4eb6-85ae-f157d6f809b8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f549439c-ba5f-402c-8a81-4560f0977ae6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("feb997ce-1054-4c46-a7d3-91be90174074"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a965945-25dc-4495-a855-b6d51a5266aa"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc249123-cabc-4a32-bf75-e65525ee6ce0"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("8f4d215c-d1e3-4783-bd49-9fea5ea7bab2"), "", "Adventure", null, "" },
                    { new Guid("91cf40bf-3f1b-49bb-9ab0-e231f0f23d64"), "", "Action", null, "" },
                    { new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"), "", "Races", null, "" },
                    { new Guid("d7ed8ae1-a4f6-43d9-847b-a6c741b61846"), "", "RPG", null, "" },
                    { new Guid("f28c527e-887b-4cad-8010-a771305d729e"), "", "Puzzle & Skill", null, "" },
                    { new Guid("f565b4a6-418c-4604-ad4e-67ad9d41a3b3"), "", "Strategy", null, "" },
                    { new Guid("f8a3ff11-c522-42ef-8f82-e4936ea655be"), "", "Sports", null, "" }
                });

            migrationBuilder.InsertData(
                table: "NotificationMethodEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("5fcb388b-4f04-44d8-9a51-a4c8b94d10e3"), "email" },
                    { new Guid("8526ece3-1312-44fc-be87-f4f1d0e2b4c1"), "SMS" },
                    { new Guid("cc28f793-ffb7-4241-9849-18ca3e574055"), "push" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), false, "AddGameInCart" },
                    { new Guid("05a6f4a2-c6ef-43c6-8887-d18450706a0a"), false, "GetRolesOfUser" },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), true, "GetAllPublishers" },
                    { new Guid("094ee9db-6c2b-4681-95a3-ccea310b30c7"), false, "AddUser" },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), true, "GetPublisherOfGame" },
                    { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), false, "QuoteComment" },
                    { new Guid("0c9df4c5-57bb-49b8-aaf2-d47b6702f182"), false, "DeleteUser" },
                    { new Guid("24a08398-8a78-4ba5-84a3-cf43e7adad23"), false, "GetUserById" },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), true, "Platforms" },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), true, "GetGenre" },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), true, "GetCart" },
                    { new Guid("3695a3cb-1d5d-461d-958c-12f2043ae749"), false, "DeleteRoleById" },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), true, "Platform" },
                    { new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"), false, "CreateGenre" },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), true, "GetBanDurations" },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), true, "GetComments" },
                    { new Guid("3cb0d877-9269-49a8-9600-eeee6832e783"), false, "GetRoleById" },
                    { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), false, "DeleteGameFromCart" },
                    { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), false, "BanUser" },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), true, "GetPlatformsOfGame" },
                    { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), false, "Basket" },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), true, "Order" },
                    { new Guid("4da80013-a363-410b-a582-ec3249dfe037"), false, "DeleteOrder" },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), true, "Genre" },
                    { new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"), false, "DeleteGenre" },
                    { new Guid("5612d1c7-84ca-4740-a870-4726fbf1c37a"), false, "ManageAllComments" },
                    { new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"), false, "CreatePublisher" },
                    { new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"), false, "UpdatePlatform" },
                    { new Guid("6000fe7c-75b1-4995-b556-6773e5a62aec"), false, "DeleteRole" },
                    { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), false, "Payment" },
                    { new Guid("61706e7c-5bcd-48c4-a9df-2ce2775f4bb8"), false, "GetPermissionsByRoleId" },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), true, "GetPublisherByCompanyName" },
                    { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), false, "AddComment" },
                    { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), false, "ReplyComment" },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), true, "GetAllOrders" },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), false, "History" },
                    { new Guid("75e4582a-bbc2-46a2-bbaf-c4676bb5d561"), false, "GetAllRoles" },
                    { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), false, "DeleteComment" },
                    { new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"), false, "UpdateGame" },
                    { new Guid("7c1616f9-406b-4d7c-b305-7cd2966d89f6"), false, "SeeDeletedGames" },
                    { new Guid("7df2f371-fea8-4c7d-b6f6-fe903b9049dd"), false, "UpdateRole" },
                    { new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"), false, "UpdatePublisher" },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), true, "Publisher" },
                    { new Guid("80c5ffc2-5f22-4853-b61e-b989fa6b6d3e"), false, "Roles" },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), true, "GetGamesByPlatformId" },
                    { new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"), false, "DeleteOrderDetails" },
                    { new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"), false, "DeletePlatform" },
                    { new Guid("84d0945c-b5f4-4167-af22-792a6b06a71a"), false, "CanSeeDeletedGames" },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), true, "Comments" },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), true, "GetSubGenres" },
                    { new Guid("8fabc7fd-aabd-42e9-9285-212d8ad871ad"), false, "Role" },
                    { new Guid("8fdd04b3-56ba-4929-af7b-a55504820caa"), false, "UpdateOrder" },
                    { new Guid("91333c78-f6bf-472c-8139-48dbe587d1c7"), false, "DeleteUserById" },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), true, "GetGenresOfGame" },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), true, "GetPaymentMethods" },
                    { new Guid("9d3c430f-ff4c-4fba-b82f-a3209c39b7ad"), false, "Users" },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), true, "Orders" },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), true, "GetDateFilterOptions" },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), true, "GetOrders" },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), true, "GetGameByKey" },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), true, "GetOrderById" },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), true, "Comment" },
                    { new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"), false, "UpdateGenre" },
                    { new Guid("b8c98315-d986-4f69-b188-8518e7226afd"), false, "DeletePublisher" },
                    { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), false, "ShipOrder" },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), true, "Games" },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), true, "GetPlatformById" },
                    { new Guid("c6739048-e82c-4bc0-a0ef-164ec3517efc"), false, "UpdateUser" },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), true, "GetAllGames" },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), true, "GetAllGenres" },
                    { new Guid("c9c3a3df-e686-4249-ac57-bcb7ee1da85b"), false, "GetAllUsers" },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), true, "DownloadGameFile" },
                    { new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"), false, "CreatePlatform" },
                    { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), false, "AddGameToOrderByKey" },
                    { new Guid("d534390c-4f6f-4b24-b665-0901e7fc1620"), false, "AddRole" },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), true, "GetPaginationOptions" },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), true, "GetAllPlatforms" },
                    { new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), true, "GetAllOrdersDetails" },
                    { new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"), false, "CreateGame" },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), true, "GetSortingOptions" },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), true, "GetGamesByGenreId" },
                    { new Guid("ec3b0a4a-ded5-44f2-8e74-4df7afd301b4"), false, "ManageDeletedGames" },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), true, "Genres" },
                    { new Guid("f5f31e80-1b46-4156-866b-6b1b96adf2e2"), false, "User" },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), true, "GetGameById" },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), true, "Publishers" },
                    { new Guid("fc1cd04e-990f-4f59-9b66-031b9ff6c323"), false, "GetAllPermissions" },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), true, "GetGamesByPublisherName" },
                    { new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"), false, "DeleteGame" },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), true, "Game" },
                    { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), false, "Buy" },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), true, "GetGames" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("149a3bad-8a60-404b-86d9-663a5ffb6c74"), "Console" },
                    { new Guid("230ed120-83ce-4679-97de-cbab48a3ec0f"), "Desktop" },
                    { new Guid("a136f2fc-9dd8-454b-88db-58bad0c0f245"), "Browser" },
                    { new Guid("fe3b24d7-2751-4735-88c1-dfcb2514ef03"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("60635078-a43c-4e97-8326-f4126044b158"), "User" },
                    { new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163"), "Guest" },
                    { new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0"), "Manager" },
                    { new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31"), "Admin" },
                    { new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d"), "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[] { new Guid("f0ed50f5-53b2-41ac-b7c1-60945e7b2c96"), "example@gamestore.com", "Admin", "$2a$11$.n0b6xr8sctTn..EBAn1GuTKrXev788u3m7dt/P8pgAdIQF.wZXu." });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("15120bc1-72a8-42c9-86ba-6b9f322475c1"), "", "Formula", new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"), "" },
                    { new Guid("1ef8f66f-39a1-45ee-babf-4d78898eeba7"), "", "Arcade", new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"), "" },
                    { new Guid("26f7a2a3-45ed-40bf-bf39-cd3b3cac1c68"), "", "TPS", new Guid("91cf40bf-3f1b-49bb-9ab0-e231f0f23d64"), "" },
                    { new Guid("39cb7432-523e-452c-ad54-6b92766224c5"), "", "FPS", new Guid("91cf40bf-3f1b-49bb-9ab0-e231f0f23d64"), "" },
                    { new Guid("871a3aaf-04ef-450b-b098-c5d12a5d6850"), "", "Rally", new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"), "" },
                    { new Guid("a916ce70-ca18-4d9a-a7ed-371319d9adb5"), "", "Off-road", new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"), "" },
                    { new Guid("b4a4f813-3fe5-4349-a153-29390b8f18f0"), "", "TBS", new Guid("f565b4a6-418c-4604-ad4e-67ad9d41a3b3"), "" },
                    { new Guid("bb355545-3c03-40ec-a8cc-c936d946edfc"), "", "RTS", new Guid("f565b4a6-418c-4604-ad4e-67ad9d41a3b3"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("05a6f4a2-c6ef-43c6-8887-d18450706a0a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("094ee9db-6c2b-4681-95a3-ccea310b30c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("0c9df4c5-57bb-49b8-aaf2-d47b6702f182"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("24a08398-8a78-4ba5-84a3-cf43e7adad23"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("3695a3cb-1d5d-461d-958c-12f2043ae749"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("3cb0d877-9269-49a8-9600-eeee6832e783"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("4da80013-a363-410b-a582-ec3249dfe037"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("5612d1c7-84ca-4740-a870-4726fbf1c37a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("6000fe7c-75b1-4995-b556-6773e5a62aec"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("61706e7c-5bcd-48c4-a9df-2ce2775f4bb8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("75e4582a-bbc2-46a2-bbaf-c4676bb5d561"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("7df2f371-fea8-4c7d-b6f6-fe903b9049dd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("80c5ffc2-5f22-4853-b61e-b989fa6b6d3e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("84d0945c-b5f4-4167-af22-792a6b06a71a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("8fabc7fd-aabd-42e9-9285-212d8ad871ad"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("8fdd04b3-56ba-4929-af7b-a55504820caa"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("91333c78-f6bf-472c-8139-48dbe587d1c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("9d3c430f-ff4c-4fba-b82f-a3209c39b7ad"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("b8c98315-d986-4f69-b188-8518e7226afd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("b8c98315-d986-4f69-b188-8518e7226afd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("c6739048-e82c-4bc0-a0ef-164ec3517efc"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("c9c3a3df-e686-4249-ac57-bcb7ee1da85b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("d534390c-4f6f-4b24-b665-0901e7fc1620"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("ec3b0a4a-ded5-44f2-8e74-4df7afd301b4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("f5f31e80-1b46-4156-866b-6b1b96adf2e2"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("fc1cd04e-990f-4f59-9b66-031b9ff6c323"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("60635078-a43c-4e97-8326-f4126044b158") },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") },
                    { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31"), new Guid("f0ed50f5-53b2-41ac-b7c1-60945e7b2c96") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("15120bc1-72a8-42c9-86ba-6b9f322475c1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ef8f66f-39a1-45ee-babf-4d78898eeba7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("26f7a2a3-45ed-40bf-bf39-cd3b3cac1c68"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("39cb7432-523e-452c-ad54-6b92766224c5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("871a3aaf-04ef-450b-b098-c5d12a5d6850"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f4d215c-d1e3-4783-bd49-9fea5ea7bab2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a916ce70-ca18-4d9a-a7ed-371319d9adb5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b4a4f813-3fe5-4349-a153-29390b8f18f0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb355545-3c03-40ec-a8cc-c936d946edfc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7ed8ae1-a4f6-43d9-847b-a6c741b61846"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f28c527e-887b-4cad-8010-a771305d729e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8a3ff11-c522-42ef-8f82-e4936ea655be"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("5fcb388b-4f04-44d8-9a51-a4c8b94d10e3"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("8526ece3-1312-44fc-be87-f4f1d0e2b4c1"));

            migrationBuilder.DeleteData(
                table: "NotificationMethodEntities",
                keyColumn: "Id",
                keyValue: new Guid("cc28f793-ffb7-4241-9849-18ca3e574055"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c1616f9-406b-4d7c-b305-7cd2966d89f6"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("05a6f4a2-c6ef-43c6-8887-d18450706a0a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("094ee9db-6c2b-4681-95a3-ccea310b30c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("09995943-8f20-4024-8ce2-4d39b715240b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c9df4c5-57bb-49b8-aaf2-d47b6702f182"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a08398-8a78-4ba5-84a3-cf43e7adad23"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("32726b95-5339-453f-b950-d72e908baeef"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3346affa-3363-43a0-9668-2a082d68c804"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3695a3cb-1d5d-461d-958c-12f2043ae749"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3cb0d877-9269-49a8-9600-eeee6832e783"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4da80013-a363-410b-a582-ec3249dfe037"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("53946f27-23ea-4e67-83ff-09ab35343027"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5612d1c7-84ca-4740-a870-4726fbf1c37a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6000fe7c-75b1-4995-b556-6773e5a62aec"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61706e7c-5bcd-48c4-a9df-2ce2775f4bb8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("61a60eca-3648-4935-912e-4febb7d8823d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("758c59a7-1753-4d2f-8b73-4866accded29"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75e4582a-bbc2-46a2-bbaf-c4676bb5d561"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78cf681e-6056-471f-8fc0-52c88912e983"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7df2f371-fea8-4c7d-b6f6-fe903b9049dd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("80c5ffc2-5f22-4853-b61e-b989fa6b6d3e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("84d0945c-b5f4-4167-af22-792a6b06a71a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8fabc7fd-aabd-42e9-9285-212d8ad871ad"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8fdd04b3-56ba-4929-af7b-a55504820caa"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91333c78-f6bf-472c-8139-48dbe587d1c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d3c430f-ff4c-4fba-b82f-a3209c39b7ad"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8c98315-d986-4f69-b188-8518e7226afd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8c98315-d986-4f69-b188-8518e7226afd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bd4e5590-6292-4613-8d10-fdd209035833"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c6739048-e82c-4bc0-a0ef-164ec3517efc"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9c3a3df-e686-4249-ac57-bcb7ee1da85b"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d534390c-4f6f-4b24-b665-0901e7fc1620"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e888af98-67a2-455c-b288-2505aed676e5"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ec3b0a4a-ded5-44f2-8e74-4df7afd301b4"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f31e80-1b46-4156-866b-6b1b96adf2e2"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb1e93a3-046b-4d96-8152-29956218d143"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc1cd04e-990f-4f59-9b66-031b9ff6c323"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("60635078-a43c-4e97-8326-f4126044b158") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"), new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("149a3bad-8a60-404b-86d9-663a5ffb6c74"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("230ed120-83ce-4679-97de-cbab48a3ec0f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("a136f2fc-9dd8-454b-88db-58bad0c0f245"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("fe3b24d7-2751-4735-88c1-dfcb2514ef03"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31"), new Guid("f0ed50f5-53b2-41ac-b7c1-60945e7b2c96") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("91cf40bf-3f1b-49bb-9ab0-e231f0f23d64"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ced83c89-fbda-4414-bdd6-4e873d8b056b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f565b4a6-418c-4604-ad4e-67ad9d41a3b3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("03a2f33d-6a69-4973-b28f-1553773338e4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("05a6f4a2-c6ef-43c6-8887-d18450706a0a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("085acb2d-8693-4ad5-9676-d0d0beda7880"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("094ee9db-6c2b-4681-95a3-ccea310b30c7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("09995943-8f20-4024-8ce2-4d39b715240b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0ac39ea3-fe80-41f3-b2ac-5a741af43b0b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0c9df4c5-57bb-49b8-aaf2-d47b6702f182"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("24a08398-8a78-4ba5-84a3-cf43e7adad23"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2e2e116c-b14a-4542-97ea-58b394577eda"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("32726b95-5339-453f-b950-d72e908baeef"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3346affa-3363-43a0-9668-2a082d68c804"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3695a3cb-1d5d-461d-958c-12f2043ae749"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3885e7bc-63fd-4733-8430-625456b0c27f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("38b288fb-8e61-4e39-b6f0-dcfbb410593e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3ac1ee72-eb47-4304-b5f9-4ebc51b95b1b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c6452a3-2034-4859-acdf-82d7110f32f1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3cb0d877-9269-49a8-9600-eeee6832e783"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d557dd7-442d-4b26-aca7-94998634c79d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("42854fc9-7065-4e94-8b29-8fdfc267240c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("441c24cf-91b1-41cb-80d2-372a88f68e1d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("44db87b4-06ab-4941-ac13-2b8d4c744132"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ceb33e8-d713-4b9e-b800-625b3017f58e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4da80013-a363-410b-a582-ec3249dfe037"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("53946f27-23ea-4e67-83ff-09ab35343027"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("55559411-bc34-41a0-ae3e-7f1ff37a4bc2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5612d1c7-84ca-4740-a870-4726fbf1c37a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c1dc562-74c5-4d90-962b-63d2cc303b70"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5f40e703-ffd0-424a-a5ca-d11a998fdf9d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6000fe7c-75b1-4995-b556-6773e5a62aec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("60d23d33-ec1b-47c9-a75c-9ff8d8544f18"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("61706e7c-5bcd-48c4-a9df-2ce2775f4bb8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("61a60eca-3648-4935-912e-4febb7d8823d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6925be04-415c-4534-89b1-a34a4cb3ea2b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6ac7fa5c-a0e3-400b-ae98-5bcf616c99e1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("757dd54a-ec6e-46ae-bf55-b4191b738479"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("758c59a7-1753-4d2f-8b73-4866accded29"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("75e4582a-bbc2-46a2-bbaf-c4676bb5d561"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("78cf681e-6056-471f-8fc0-52c88912e983"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7bb67c83-f645-4f8e-8884-af8f8d461be4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7df2f371-fea8-4c7d-b6f6-fe903b9049dd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("80560d98-1ed9-49ef-9254-67426f6c53e5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("807beb2e-2a72-497f-9e3d-69f4adda0f0f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("80c5ffc2-5f22-4853-b61e-b989fa6b6d3e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("81d30113-9d5d-4836-85cc-3057a0af1e2d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("82a0728c-822e-4234-86ad-ca3e0943e38f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("831e403c-7fe0-4a09-9710-ed25ade64104"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("84d0945c-b5f4-4167-af22-792a6b06a71a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("867d22a7-7813-4c9c-a3b4-96896cc4e1cc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c07a66c-7cf3-47d4-aada-c5e7026e58e7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8fabc7fd-aabd-42e9-9285-212d8ad871ad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8fdd04b3-56ba-4929-af7b-a55504820caa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("91333c78-f6bf-472c-8139-48dbe587d1c7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("972f14c5-101d-46e1-a128-ce14a246f7bb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9a62dfe5-5129-427b-8f9e-a9a8a9d26c7d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d3c430f-ff4c-4fba-b82f-a3209c39b7ad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9dbd2177-0aaf-4b01-b971-08a4592d882c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9eb718f5-550d-49c6-aef1-0cf83960385a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3f2cbbd-05b1-4dd4-9fbd-cb283386b105"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a6cb35be-bcf5-4db1-843a-2f977d6e2caf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("aad65069-52ac-4c34-b296-64a7becd2cbd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad0a7d1c-dc42-4639-b049-0d9f391ef63e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b50ebd19-cb82-46c8-b316-909867e0a0e9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8c98315-d986-4f69-b188-8518e7226afd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bcf276c3-9fd8-4dd2-8c2c-3b8372c15cb1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bd4e5590-6292-4613-8d10-fdd209035833"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bdbf72fc-a8b3-42fd-abcd-0dcb308d83d6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c6739048-e82c-4bc0-a0ef-164ec3517efc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c86a6cc0-77e6-41ca-baf6-464ed4dbac4a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c8e02edc-1856-4cfd-9631-fa952305b208"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c9c3a3df-e686-4249-ac57-bcb7ee1da85b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d245bbfa-32be-42c2-bfe9-e82cde6f05dd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d3ae79a3-4e97-47fe-9717-f3bdfa817bc3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d52d3e0d-011a-4cfd-9924-102f13d48cd8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d534390c-4f6f-4b24-b665-0901e7fc1620"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d65b3caf-9905-40ee-8aec-a64af07dfa23"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc28695d-4624-4459-87b6-ecea21f761fa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e4d172b1-3f28-46b5-9bee-8d0a7d07a4eb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7b43012-4cd8-45ef-8d2e-1541b84da0fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e862c0ab-84e7-4336-b6f7-ef14e3d2f88f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e888af98-67a2-455c-b288-2505aed676e5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ebe243c0-8fc4-4c59-a500-a2853c79aa93"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ec3b0a4a-ded5-44f2-8e74-4df7afd301b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3bed040-552d-44ad-a554-61cb0ec709b8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5f31e80-1b46-4156-866b-6b1b96adf2e2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa000eb9-b8d4-406b-a06c-39d4ee0a459c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb1e93a3-046b-4d96-8152-29956218d143"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fc1cd04e-990f-4f59-9b66-031b9ff6c323"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fc556d44-a13b-47b1-8b9f-e74b5d9470d6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fcc060fb-6012-42b9-8f1b-a78a4b5e7f98"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fcf4d5ca-e6ac-4aa3-a554-330a19f078cd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fe2f6c63-455c-4c41-b972-a8694f69b7c7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ff5867af-dc48-45ff-be95-e7c6ee1512ed"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("60635078-a43c-4e97-8326-f4126044b158"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("60edbb8f-59e7-44a3-9067-0d47a6885163"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("a7d8266d-c5b1-4621-a907-6096ab1890a0"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("b6359dac-4803-4b76-a7db-0bc48652fb31"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("e69f9bab-02ce-4bba-a307-f8bff4cba85d"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0ed50f5-53b2-41ac-b7c1-60945e7b2c96"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserEntities");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("303f6803-7436-4fae-82fa-67ef02b61d3b"), "", "Puzzle & Skill", null, "" },
                    { new Guid("31ba694a-f0b3-4d31-86a9-b69853d1203a"), "", "Strategy", null, "" },
                    { new Guid("76f335cc-5dc4-427d-b89c-6e45d56a0a66"), "", "Action", null, "" },
                    { new Guid("7758c810-de5f-419b-86f7-e9faf3ef0448"), "", "Sports", null, "" },
                    { new Guid("7a6cb6a4-d8f3-4de7-b37b-ac10859da87d"), "", "RPG", null, "" },
                    { new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"), "", "Races", null, "" },
                    { new Guid("e48ce5be-a8b6-4314-a8ce-b36bb39d7fa1"), "", "Adventure", null, "" }
                });

            migrationBuilder.InsertData(
                table: "NotificationMethodEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("244b59d8-1b6d-4060-a036-f3aab26df734"), "push" },
                    { new Guid("36495951-8c79-4d5b-8014-5cc746c716dd"), "SMS" },
                    { new Guid("c6339fa4-f52b-4623-aa50-7611271b0c27"), "email" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "AllowedOnGuest", "Name" },
                values: new object[,]
                {
                    { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), false, "Basket" },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), true, "GetGameByKey" },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), true, "GetPaymentMethods" },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), true, "GetOrders" },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), true, "GetGameById" },
                    { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), false, "BanUser" },
                    { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), false, "DeleteGameFromCart" },
                    { new Guid("10472401-7254-4c06-af36-4db450d2c248"), false, "GetAllRoles" },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), true, "GetSortingOptions" },
                    { new Guid("17f6c557-1040-44c1-ba41-9642a2ee6ef0"), false, "Users" },
                    { new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"), false, "UpdateOrderDetailQuantity" },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), true, "GetPaginationOptions" },
                    { new Guid("200a0485-4460-45a9-87d3-10f604be71b4"), false, "AddUser" },
                    { new Guid("27b5368b-99c6-4cc0-ad52-1f1b6bd3015b"), false, "GetRoleById" },
                    { new Guid("2a45836a-30e0-40df-9d4b-b71a26aed3b4"), false, "SeeDeletedGames" },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), true, "GetAllOrders" },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), true, "GetAllPublishers" },
                    { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), false, "Buy" },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), true, "GetPublisherByCompanyName" },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), true, "GetComments" },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), true, "Publisher" },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), true, "GetPlatformById" },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), true, "GetBanDurations" },
                    { new Guid("3d2324ee-1941-4e39-a786-bffed359714f"), false, "ManageDeletedGames" },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), true, "Orders" },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), true, "Games" },
                    { new Guid("47d5916f-f60a-4969-9c56-14ca2988178a"), false, "DeleteUser" },
                    { new Guid("49571d68-b057-4c5a-a6b3-ce4372a74f7f"), false, "ManageAllComments" },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), true, "GetAllOrdersDetails" },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), true, "GetPublisherOfGame" },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), true, "DownloadGameFile" },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), true, "Genre" },
                    { new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"), false, "CreateGame" },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), true, "Publishers" },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), true, "GetAllPlatforms" },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), true, "GetPlatformsOfGame" },
                    { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), false, "AddComment" },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), true, "Comments" },
                    { new Guid("5c197062-ab1c-44de-86bf-0114a7353563"), false, "UpdatePlatform" },
                    { new Guid("5cb5999a-091f-4b03-9a58-c3ca98d1cc9d"), false, "GetAllUsers" },
                    { new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"), false, "UpdatePublisher" },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), true, "GetGames" },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), true, "GetGamesByPublisherName" },
                    { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), false, "QuoteComment" },
                    { new Guid("678141dc-9c96-4fbe-b72a-66fb534cd492"), false, "AddRole" },
                    { new Guid("68e96013-f4df-4bc4-a1a8-0f8667f28a90"), false, "CanSeeDeletedGames" },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), true, "GetSubGenres" },
                    { new Guid("6dac93b1-8c93-4017-af93-8ebc830a8e2a"), false, "UpdateUser" },
                    { new Guid("6dda337a-a26c-4a52-8547-51e18f1ebec4"), false, "DeleteOrder" },
                    { new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"), false, "UpdateGenre" },
                    { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), false, "ReplyComment" },
                    { new Guid("76de98df-eb02-437a-a3f9-6465f7c65890"), false, "DeleteRoleById" },
                    { new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"), false, "CreateGenre" },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), true, "GetOrderById" },
                    { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), false, "Payment" },
                    { new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"), false, "DeletePlatform" },
                    { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), false, "ShipOrder" },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), true, "GetCart" },
                    { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), false, "AddGameInCart" },
                    { new Guid("9b94e97b-f279-46dd-95c9-81bbdd442bc7"), false, "GetAllPermissions" },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), true, "GetAllGenres" },
                    { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), false, "AddGameToOrderByKey" },
                    { new Guid("a63395e5-ab39-47f0-beb6-ca2adb7ff64d"), false, "GetRolesOfUser" },
                    { new Guid("a6f90305-cd19-4583-b32f-56a79a776a36"), false, "GetUserById" },
                    { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), false, "DeleteComment" },
                    { new Guid("a7b2ceec-c121-43e3-9d69-4b8d61cffff9"), false, "DeleteRole" },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), true, "GetGenre" },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), true, "Platforms" },
                    { new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"), false, "DeleteGenre" },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), true, "Game" },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), true, "GetGamesByGenreId" },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), true, "GetAllGames" },
                    { new Guid("b8470e68-c7ef-4c87-8676-a9173300ccec"), false, "UpdateOrder" },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), true, "GetDateFilterOptions" },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), true, "GetGamesByPlatformId" },
                    { new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"), false, "CreatePlatform" },
                    { new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"), false, "DeleteOrderDetails" },
                    { new Guid("c793f0f6-aff5-46c7-a7b5-26bd1101c9c2"), false, "GetPermissionsByRoleId" },
                    { new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"), false, "DeleteGame" },
                    { new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"), false, "CreatePublisher" },
                    { new Guid("cb602ab3-5b41-45cb-8235-f9d75a42f4e7"), false, "Role" },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), true, "GetGenresOfGame" },
                    { new Guid("dde98b71-f7e4-40e1-96ce-8626094020fa"), false, "User" },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), true, "Platform" },
                    { new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"), false, "DeletePublisher" },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), true, "Order" },
                    { new Guid("ec0c2cda-d390-4b8d-8b25-01da40ddcb9c"), false, "UpdateRole" },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), true, "Genres" },
                    { new Guid("f1ff0c01-63d5-4eb6-85ae-f157d6f809b8"), false, "DeleteUserById" },
                    { new Guid("f549439c-ba5f-402c-8a81-4560f0977ae6"), false, "Roles" },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), false, "History" },
                    { new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"), false, "UpdateGame" },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), true, "Comment" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("61b80b71-88cc-4c55-b5cb-604b6351e7b7"), "Browser" },
                    { new Guid("a056b318-b0fe-4807-94e8-1a0a4cfdb400"), "Console" },
                    { new Guid("d0e4c357-284a-414c-b555-f6d51239dfa1"), "Mobile" },
                    { new Guid("d10b3782-adb4-4dbb-aac1-156e0835425d"), "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac"), "Manager" },
                    { new Guid("4a965945-25dc-4495-a855-b6d51a5266aa"), "User" },
                    { new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78"), "Admin" },
                    { new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a"), "Guest" },
                    { new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d"), "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("dc249123-cabc-4a32-bf75-e65525ee6ce0"), "Admin", "$2a$11$u8eoQpfsjj3SBk.SrxKqt.SMlef0WG981eKLZFWB9sPcm4HzEqLCm" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0f8c4363-ffe6-46e1-b194-ed68dc42ca41"), "", "FPS", new Guid("76f335cc-5dc4-427d-b89c-6e45d56a0a66"), "" },
                    { new Guid("1305baf9-6e39-41d3-8f46-e1f4d9edeab8"), "", "Off-road", new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"), "" },
                    { new Guid("29a12d27-a1ea-4ee1-ba32-96ed94defa25"), "", "Rally", new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"), "" },
                    { new Guid("2f4b5014-f4d5-406c-a824-86c4ff515b63"), "", "TPS", new Guid("76f335cc-5dc4-427d-b89c-6e45d56a0a66"), "" },
                    { new Guid("2f61bc79-d72b-455c-86d9-541923ab4467"), "", "Formula", new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"), "" },
                    { new Guid("ad44f63c-159d-41aa-bf35-94b1654ccc72"), "", "RTS", new Guid("31ba694a-f0b3-4d31-86a9-b69853d1203a"), "" },
                    { new Guid("be2c4ebb-bb9a-42ed-8f36-84346a9722c7"), "", "TBS", new Guid("31ba694a-f0b3-4d31-86a9-b69853d1203a"), "" },
                    { new Guid("e95d93ab-3dc2-4e49-a199-9c6ecddcd97f"), "", "Arcade", new Guid("c41ad96e-c1e9-42d9-9c19-5f04860ccbec"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("0115f2f4-72ba-4d4b-8874-db2b78e6aec5"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("07a70844-b669-429b-9625-ac04992d6b3f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("088383ef-fba1-4d09-b2b5-184ca8972884"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("08908c75-4a22-4c2c-801d-577bdcf3aee2"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("095b4c6b-e02b-4f01-aa57-e975692c874b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("0bac959c-971e-4b2f-98b5-5afd3cc27eb6"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("0f881215-2e50-4dd5-b7a1-2b5ef6b7daed"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("10472401-7254-4c06-af36-4db450d2c248"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("1315befb-f177-405a-afff-7e206c27bf1b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("17f6c557-1040-44c1-ba41-9642a2ee6ef0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("197b2380-f4d0-4a53-a5e7-da801c3ce703"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("1d7a4ab4-2992-465c-af53-a3fed6238c8f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("200a0485-4460-45a9-87d3-10f604be71b4"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("27b5368b-99c6-4cc0-ad52-1f1b6bd3015b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("2bec8120-e8c6-437b-8186-cc1466d0dd03"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("2e1e0d9e-68a6-41f3-9b6f-d4d32147a527"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("2f27efc4-821e-49a9-b6bb-c81092bba5b7"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("305c9f9f-eb42-4a4f-9057-a9460208d48c"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("3801715f-edf6-490a-a8d6-4e6b57b6190f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("3955fae2-7da4-41e3-9735-d2ab3f4d52e1"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("3b79492e-8e05-4ffc-a929-b79a8e3ece3a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("3b7ec33d-87be-413c-8833-601631ed37c8"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("3d2324ee-1941-4e39-a786-bffed359714f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("3de6c3dd-e89c-4a07-9991-4e78461e5f3f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("4470d1db-bebc-4836-a68a-b3c4816804af"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("47d5916f-f60a-4969-9c56-14ca2988178a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("49571d68-b057-4c5a-a6b3-ce4372a74f7f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("4d9dead1-02da-4c65-9fa1-d58d3a575a6d"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("52b2a382-6164-469b-b09a-ed184b5f9437"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("53655cfe-c418-404a-8b8f-096f40b533c0"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("54c8105b-6690-41d7-a4ee-6461961307fc"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("56974b79-e532-490f-b9df-749bd9b7b12e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("57f1c491-844e-46ff-af38-b3eff6ae9db9"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("586c7b8e-4190-473e-90ec-f987ec609bbd"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("59413036-3d21-462b-a75b-77a36be018ee"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("59416536-826e-4ad9-9d6f-2965794f0912"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("5ad8cdfb-461c-4bc8-b79e-35aa10fa8dac"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("5c197062-ab1c-44de-86bf-0114a7353563"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("5c197062-ab1c-44de-86bf-0114a7353563"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("5cb5999a-091f-4b03-9a58-c3ca98d1cc9d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("63235b0d-cc14-4721-8845-00b0c7df0e24"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("6617258e-3acb-42d9-b0cb-c307665a86ff"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("6736aaa3-571f-484a-90c6-2bd315db5fa8"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6773b1c9-c760-42c7-993a-32542959122d"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("678141dc-9c96-4fbe-b72a-66fb534cd492"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("68e96013-f4df-4bc4-a1a8-0f8667f28a90"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("691650ec-6ea2-4f0d-b716-e651ec30e20b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("6dac93b1-8c93-4017-af93-8ebc830a8e2a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6dda337a-a26c-4a52-8547-51e18f1ebec4"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("6f79da54-fc7a-4275-935d-81c093637c3e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("74afe185-72a4-4c8d-a77d-35b3ee457c5b"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("76de98df-eb02-437a-a3f9-6465f7c65890"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("7b8787a0-e226-4c55-b3df-2c9500c058dc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("7f22e198-f787-4b6b-bba3-493f79ba3a24"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("84722900-2c56-41e4-a9ad-db2485582edb"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("8c704c32-4a7f-4a37-8972-82be869a6e04"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("8f0c750c-43ea-40e2-aae1-e239bd406f97"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("8f2a4c7e-2f3a-4820-ae45-c34d1504e762"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("8f8e6d44-cc5d-4b85-832c-01a2d7c5580a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("9b94e97b-f279-46dd-95c9-81bbdd442bc7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("9cd2cb89-96f5-428a-bb87-c97fc1aa9104"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a3eed810-2181-4c18-8dca-210fee7602ca"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("a63395e5-ab39-47f0-beb6-ca2adb7ff64d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a6f90305-cd19-4583-b32f-56a79a776a36"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a71ec7e5-f4d4-4c7e-9130-aa41b1ba5ec0"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("a7b2ceec-c121-43e3-9d69-4b8d61cffff9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("a8925b4b-9da3-4685-98ab-16fbf2a5112f"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("aa43b3b8-86b4-4dfd-809f-fa1cb5d68ecc"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("ad2836b5-5721-4c57-aaca-61220b70bf73"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("af0d0b06-67a0-4c10-a5c1-07023b58dee7"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("b18fd4c7-fa47-4607-83fb-839dd709f33a"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("b38e35da-13d9-4269-a3de-7786e4f7fa08"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("b8470e68-c7ef-4c87-8676-a9173300ccec"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("b9ffa100-21cc-4317-af7e-3c356a9e9f89"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("ba562037-1ca9-4c98-bb46-c854f9c6af1e"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("c2f7cf4a-ab04-489d-994a-beee1248cf2d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("c7448eca-2ccc-4394-a2e9-bc96f5cc7612"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("c793f0f6-aff5-46c7-a7b5-26bd1101c9c2"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("c9975f9c-9f99-4265-b216-f7df3251d328"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("ca54889e-a5ca-4eae-9a29-27d7abe673a7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("cb602ab3-5b41-45cb-8235-f9d75a42f4e7"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("dcb486ea-6384-40e5-92cd-3d82b5469e10"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("dde98b71-f7e4-40e1-96ce-8626094020fa"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("e49c586c-4797-4861-9a77-a058080f3324"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("e4e925af-d453-4572-a7a1-639ee2affa9c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("e89b74f0-bd9f-449c-bb3f-f17c307c61ae"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("ec0c2cda-d390-4b8d-8b25-01da40ddcb9c"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("ed950bf9-af99-47d1-b8e5-7cedecb7d637"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("f1ff0c01-63d5-4eb6-85ae-f157d6f809b8"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("f549439c-ba5f-402c-8a81-4560f0977ae6"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("f54bef9e-ee9a-4c3b-b650-ab54a14bdbf9"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") },
                    { new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("f680fe91-6760-4fc2-9e0a-21df06c9cd2d"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("0b4d9d81-6d71-4322-bee0-d5823914d7ac") },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("4a965945-25dc-4495-a855-b6d51a5266aa") },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78") },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("efe13980-84d4-4d62-b739-b9ec56b1f14a") },
                    { new Guid("feb997ce-1054-4c46-a7d3-91be90174074"), new Guid("f54c2d25-e38c-4b05-b354-a68a4d06cd3d") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("4bc54d0d-66b8-4596-bf2e-b519feff5e78"), new Guid("dc249123-cabc-4a32-bf75-e65525ee6ce0") });
        }
    }
}
