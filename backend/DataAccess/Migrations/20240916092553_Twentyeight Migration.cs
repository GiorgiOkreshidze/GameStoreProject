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
    public partial class TwentyeightMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
