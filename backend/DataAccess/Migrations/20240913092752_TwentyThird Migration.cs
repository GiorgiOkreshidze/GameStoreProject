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
    public partial class TwentyThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0ebd6758-8144-402e-99ee-74558b3cf7a3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("243885b4-70bb-4eb7-be7d-54eff270d9b3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("24b6dfc3-7b5f-4473-9531-6ed6a002145f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("38bdb1f9-18f7-4c2a-9eea-35a795fd1b68"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("41cde12e-f0dd-40ac-ac78-3da920afc067"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("95067e97-b5f6-4a19-8536-65f2affbdc54"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9cf2d1ca-b343-44be-824e-a90d00f9d973"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5fef7f1-5116-49bb-8227-517c8e7289ff"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d3b50d59-2792-4e03-896f-fe747380364d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("db07c7c8-a296-41af-8d0c-eac8ec63530a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e1950d6a-40c1-4434-ac73-7c1a921220a1"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa0d601a-b8ba-4552-b44b-6d6cde0423c2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9e8b97b5-77b5-4e56-a6a4-0e5300373f91"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d8230b2-85a5-478f-9bf7-681b770e8e05"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("14bc89b4-bd04-407c-94a0-7ba3242ccb12"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2073efa1-c2db-487a-bc35-611228e72078"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2073efa1-c2db-487a-bc35-611228e72078"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("23be567e-e029-436e-b2ff-c37cacfaef83"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2c67e983-4d7b-4b56-b25f-2c98830ff523"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2fb37999-579b-4c4b-8533-25699255c79c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2fb37999-579b-4c4b-8533-25699255c79c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4d72d646-f9c0-4ec9-9d08-ffb494f3da9e"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5af46546-8e33-48a4-9c71-d1283ff06820"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cf9b351-38b8-43fa-a9f5-e3587e25b8d8"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62fe16e6-394c-4248-8de3-2adadca88d40"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7627996e-2bce-4b70-8920-8c3902bcaabe"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7813fa0d-894d-41f3-baf1-ff20c95bec41"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c7ecb39-8356-4513-8b47-c27c9d4882c1"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("992e478a-e419-4ceb-b4c3-966292045cc7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c4fd900-2b49-4ebf-80d9-35ecb41b7858"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb220733-5798-41dd-84de-e130d422c5f0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb220733-5798-41dd-84de-e130d422c5f0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d76bbae6-326b-4a9a-a39d-0a279be1f3ff"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ed9b2b88-99cb-466d-bc02-3bfe2d7183e5"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1835a2f8-237d-40f2-b56c-0284c6da4e8c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("87a126d1-df94-4452-af30-b3fea5926805"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("ddf8f447-54c1-44e5-9ff8-ebe7fb2a8439"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("eb773d4d-a7bf-484d-a833-857c8f4b34af"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("13dda30c-1001-449f-8c8b-6af958356e07"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2eedd1d6-63a4-41ee-90c4-65e8fde2d193"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8015ca95-d1c9-4673-8c6c-29ee5111b1fe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("01a8ea89-ad69-467c-b459-22fabd559318"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0d8230b2-85a5-478f-9bf7-681b770e8e05"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1006ba07-5384-43fa-8578-2762e18975b7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("14bc89b4-bd04-407c-94a0-7ba3242ccb12"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2073efa1-c2db-487a-bc35-611228e72078"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("23be567e-e029-436e-b2ff-c37cacfaef83"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("26ca1038-8da9-497c-931f-0dba1037f290"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2c67e983-4d7b-4b56-b25f-2c98830ff523"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2fb37999-579b-4c4b-8533-25699255c79c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d72d646-f9c0-4ec9-9d08-ffb494f3da9e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5af46546-8e33-48a4-9c71-d1283ff06820"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5cf9b351-38b8-43fa-a9f5-e3587e25b8d8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("62fe16e6-394c-4248-8de3-2adadca88d40"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7627996e-2bce-4b70-8920-8c3902bcaabe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7813fa0d-894d-41f3-baf1-ff20c95bec41"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("88681641-26ef-4fe1-b35a-621be2c97784"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c7ecb39-8356-4513-8b47-c27c9d4882c1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("992e478a-e419-4ceb-b4c3-966292045cc7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c4fd900-2b49-4ebf-80d9-35ecb41b7858"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb220733-5798-41dd-84de-e130d422c5f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d6311013-9198-4b11-8bca-e7156b22383b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d76bbae6-326b-4a9a-a39d-0a279be1f3ff"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e2091643-98b2-497f-956b-251bae16e074"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ed9b2b88-99cb-466d-bc02-3bfe2d7183e5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("da291fd2-3785-4b4c-840a-507dd537ad98"));

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserEntities",
                newName: "PasswordHash");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"), "", "Races", null, "" },
                    { new Guid("404bce26-2c9e-421d-b5c8-c7848a7e1523"), "", "Puzzle & Skill", null, "" },
                    { new Guid("428452b3-576c-4a7b-b640-534f0612ca44"), "", "RPG", null, "" },
                    { new Guid("4d65f15c-81ad-4256-a8c6-42bb8f6d5089"), "", "Adventure", null, "" },
                    { new Guid("70f0e82a-6087-4df6-85d8-606b5b6bbb2e"), "", "Action", null, "" },
                    { new Guid("9d0bd241-43ba-45fe-9d92-65f440d6c629"), "", "Strategy", null, "" },
                    { new Guid("a60d54bd-e8cf-493d-8cd9-dcfae7c52aa3"), "", "Sports", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), "GetGenre" },
                    { new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"), "UpdateOrderDetailQuantity" },
                    { new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"), "UpdatePublisher" },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), "GetAllGenres" },
                    { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), "AddComment" },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), "DownloadGameFile" },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), "GetPublisherByCompanyName" },
                    { new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"), "UpdateGenre" },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), "GetAllPublishers" },
                    { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), "AddGameToOrderByKey" },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), "GetAllOrdersDetails" },
                    { new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"), "CreatePlatform" },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), "Platforms" },
                    { new Guid("350dda41-60fa-426a-b346-ed9a8766c7ce"), "UpdateRole" },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), "GetOrderById" },
                    { new Guid("3cdcf9c0-6587-40af-9dec-3f05635e1e07"), "AddUser" },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), "GetCart" },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), "GetGames" },
                    { new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"), "CreatePublisher" },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), "GetSortingOptions" },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), "GetGamesByGenreId" },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), "Platform" },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), "GetSubGenres" },
                    { new Guid("641d38c8-fb7e-4936-a37b-7d79283f006c"), "GetRoleById" },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), "Order" },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), "GetPlatformsOfGame" },
                    { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), "AddGameInCart" },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), "Games" },
                    { new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"), "DeleteGenre" },
                    { new Guid("6c6367c1-eabd-4674-9772-ff5a4f9aa05a"), "DeleteUserById" },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), "Publisher" },
                    { new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"), "DeletePublisher" },
                    { new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"), "UpdateGame" },
                    { new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"), "DeletePlatform" },
                    { new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"), "CreateGenre" },
                    { new Guid("784f6eb5-a117-4210-9b90-b211a843e359"), "GetPermissionsByRoleId" },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), "GetGameById" },
                    { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), "DeleteGameFromCart" },
                    { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), "BanUser" },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), "Orders" },
                    { new Guid("904c8cce-33ac-4629-a449-2483d789f360"), "ManageDeletedGames" },
                    { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), "ShipOrder" },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), "Genre" },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), "GetDateFilterOptions" },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), "GetPublisherOfGame" },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), "GetGamesByPlatformId" },
                    { new Guid("a38ed6d0-b278-4740-9d55-babeacf84992"), "GetAllRoles" },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), "Publishers" },
                    { new Guid("a836a764-e9f4-4854-a742-c9914bf6f143"), "ManageAllComments" },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), "Comments" },
                    { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), "DeleteComment" },
                    { new Guid("b47d4136-be76-45cd-8ae9-17a90f08bb79"), "GetRolesOfUser" },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), "Comment" },
                    { new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"), "CreateGame" },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), "GetAllOrders" },
                    { new Guid("baf93d29-eb54-4b40-99d0-102b05dc75c3"), "GetAllUsers" },
                    { new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"), "DeleteGame" },
                    { new Guid("d09dd282-b51b-4577-b968-331f2ce2f6c4"), "GetUserById" },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), "GetBanDurations" },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), "GetPaymentMethods" },
                    { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), "Buy" },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), "Game" },
                    { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), "Payment" },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), "GetComments" },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), "Genres" },
                    { new Guid("dc3abbac-3cac-43ca-8c60-e788081aa562"), "GetAllPermissions" },
                    { new Guid("dd0808ed-7058-43eb-a111-ac628562cd7f"), "DeleteRoleById" },
                    { new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"), "UpdatePlatform" },
                    { new Guid("e11480b6-d7a1-42ef-8e1b-15b6726032d6"), "SeeDeletedGames" },
                    { new Guid("e589e634-cc73-4f44-b87c-1ba1ebb6b69f"), "AddRole" },
                    { new Guid("e827e1fb-504e-47c6-b9a0-6038550cc6e4"), "UpdateUser" },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), "GetGamesByPublisherName" },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), "GetGenresOfGame" },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), "GetAllPlatforms" },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), "GetGameByKey" },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), "GetPlatformById" },
                    { new Guid("f3273173-f8b7-4d31-a654-9d535925629c"), "DeleteOrderDetails" },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), "GetPaginationOptions" },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), "GetAllGames" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("01e746fa-bbf1-44a1-bda5-2766c37ba24f"), "Mobile" },
                    { new Guid("629e35d3-8c93-4122-895f-ea9306346d41"), "Browser" },
                    { new Guid("77d038b8-b9b1-4087-b8fc-53e010e784d4"), "Desktop" },
                    { new Guid("989bf48f-28b8-4fd8-bd60-fa34bd1a3217"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d"), "Admin" },
                    { new Guid("58759d21-64b4-43de-bbb3-470e3e932349"), "Manager" },
                    { new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94"), "User" },
                    { new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2"), "Guest" },
                    { new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1"), "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("568b9b0d-59d2-4f78-98f6-8a3256246482"), "Admin", "$2a$11$8xGu5b6.s88T5pdAeT21buOrHJxE8YjXggPVyU9aUq.XqNDEzpr7O" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("12b4f1fb-3016-4448-ad31-84a1dde59184"), "", "FPS", new Guid("70f0e82a-6087-4df6-85d8-606b5b6bbb2e"), "" },
                    { new Guid("2eef0fdf-981d-4c96-a7fa-30cb28881fc4"), "", "TPS", new Guid("70f0e82a-6087-4df6-85d8-606b5b6bbb2e"), "" },
                    { new Guid("4d58349f-4a62-4b06-b76f-7bf43a3f6d34"), "", "TBS", new Guid("9d0bd241-43ba-45fe-9d92-65f440d6c629"), "" },
                    { new Guid("4e669c81-5b7f-4f56-ab65-12e0100c72e0"), "", "Off-road", new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"), "" },
                    { new Guid("a5d45927-0937-43e3-98a2-92162e354399"), "", "Arcade", new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"), "" },
                    { new Guid("b95f17b3-1fd9-40df-b7a5-1a0f365b63ec"), "", "Formula", new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"), "" },
                    { new Guid("e3530326-1f3f-4d20-910c-c1f0f7e58e0c"), "", "Rally", new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"), "" },
                    { new Guid("fb1958b7-4c83-4c05-a146-faaf4c956ba4"), "", "RTS", new Guid("9d0bd241-43ba-45fe-9d92-65f440d6c629"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("350dda41-60fa-426a-b346-ed9a8766c7ce"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("3cdcf9c0-6587-40af-9dec-3f05635e1e07"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("641d38c8-fb7e-4936-a37b-7d79283f006c"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("6c6367c1-eabd-4674-9772-ff5a4f9aa05a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("784f6eb5-a117-4210-9b90-b211a843e359"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("904c8cce-33ac-4629-a449-2483d789f360"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("a38ed6d0-b278-4740-9d55-babeacf84992"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("a836a764-e9f4-4854-a742-c9914bf6f143"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("b47d4136-be76-45cd-8ae9-17a90f08bb79"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("baf93d29-eb54-4b40-99d0-102b05dc75c3"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("d09dd282-b51b-4577-b968-331f2ce2f6c4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("dc3abbac-3cac-43ca-8c60-e788081aa562"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("dd0808ed-7058-43eb-a111-ac628562cd7f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("e589e634-cc73-4f44-b87c-1ba1ebb6b69f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("e827e1fb-504e-47c6-b9a0-6038550cc6e4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("f3273173-f8b7-4d31-a654-9d535925629c"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("f3273173-f8b7-4d31-a654-9d535925629c"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") },
                    { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d"), new Guid("568b9b0d-59d2-4f78-98f6-8a3256246482") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("12b4f1fb-3016-4448-ad31-84a1dde59184"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2eef0fdf-981d-4c96-a7fa-30cb28881fc4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("404bce26-2c9e-421d-b5c8-c7848a7e1523"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("428452b3-576c-4a7b-b640-534f0612ca44"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d58349f-4a62-4b06-b76f-7bf43a3f6d34"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4d65f15c-81ad-4256-a8c6-42bb8f6d5089"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e669c81-5b7f-4f56-ab65-12e0100c72e0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a5d45927-0937-43e3-98a2-92162e354399"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a60d54bd-e8cf-493d-8cd9-dcfae7c52aa3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b95f17b3-1fd9-40df-b7a5-1a0f365b63ec"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e3530326-1f3f-4d20-910c-c1f0f7e58e0c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb1958b7-4c83-4c05-a146-faaf4c956ba4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e11480b6-d7a1-42ef-8e1b-15b6726032d6"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("04826541-e212-4751-947c-60ded7094ee9"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19e3c989-b739-4744-98ad-3058551310ac"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("350dda41-60fa-426a-b346-ed9a8766c7ce"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3cdcf9c0-6587-40af-9dec-3f05635e1e07"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a162153-bad5-432c-ac50-8882d401c82e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51170b05-8cfd-479e-a615-92749a9525bf"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("641d38c8-fb7e-4936-a37b-7d79283f006c"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("692ace5d-c64f-49e1-852a-165864f1de67"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6c6367c1-eabd-4674-9772-ff5a4f9aa05a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("784f6eb5-a117-4210-9b90-b211a843e359"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8173a408-3798-46d4-958e-fe620d79e72b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("904c8cce-33ac-4629-a449-2483d789f360"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a38ed6d0-b278-4740-9d55-babeacf84992"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a836a764-e9f4-4854-a742-c9914bf6f143"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b47d4136-be76-45cd-8ae9-17a90f08bb79"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("baf93d29-eb54-4b40-99d0-102b05dc75c3"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d09dd282-b51b-4577-b968-331f2ce2f6c4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da652e82-972d-4dff-a43f-4934d4535179"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc3abbac-3cac-43ca-8c60-e788081aa562"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dd0808ed-7058-43eb-a111-ac628562cd7f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e589e634-cc73-4f44-b87c-1ba1ebb6b69f"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e827e1fb-504e-47c6-b9a0-6038550cc6e4"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3273173-f8b7-4d31-a654-9d535925629c"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3273173-f8b7-4d31-a654-9d535925629c"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("58759d21-64b4-43de-bbb3-470e3e932349") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"), new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("01e746fa-bbf1-44a1-bda5-2766c37ba24f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("629e35d3-8c93-4122-895f-ea9306346d41"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("77d038b8-b9b1-4087-b8fc-53e010e784d4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("989bf48f-28b8-4fd8-bd60-fa34bd1a3217"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d"), new Guid("568b9b0d-59d2-4f78-98f6-8a3256246482") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3e6d7441-28bb-45bd-908a-24c4ffd05128"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("70f0e82a-6087-4df6-85d8-606b5b6bbb2e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d0bd241-43ba-45fe-9d92-65f440d6c629"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("04826541-e212-4751-947c-60ded7094ee9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0837ebd4-7feb-4b96-b4aa-bab4717526b7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("099c4f31-a0cc-4ca0-b757-783f593b896e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("099c91da-5d87-4c40-a238-d9ebf2222154"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0a6afc99-83ef-44be-8f73-0c80ca4495a8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0d44d327-d3aa-41d3-a423-1f0fe8be2c27"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("10356e8a-4b17-48c1-95a4-9d87523bfd18"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("159678ac-b9b3-4df4-a8ca-4178d44929f4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("170b512d-d3c4-43fb-8256-ea06d00a99b5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("19e3c989-b739-4744-98ad-3058551310ac"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ee3a2d4-50ce-45cb-b62e-6e8407ad0e4b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("230be5d2-ed85-431f-b4cf-644b8d72aa62"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("25199c88-f493-4ca7-a1e1-26522e3339bc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("350dda41-60fa-426a-b346-ed9a8766c7ce"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("35ea3c67-abc0-43f0-a2d7-f409811b5d8a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3cdcf9c0-6587-40af-9dec-3f05635e1e07"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("42c3c760-06d2-4f1b-86f3-e5d3b4e2bd25"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a162153-bad5-432c-ac50-8882d401c82e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ca4db98-c8a3-4a15-960d-b9e2097e10fa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e938113-5d3e-4b4e-8629-91eb2085c87f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("51170b05-8cfd-479e-a615-92749a9525bf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5937bc69-0f76-40ad-9254-d28bde5108a8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("62b9f2d0-3e19-4937-99ca-51a6757063c3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("641d38c8-fb7e-4936-a37b-7d79283f006c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6568d2d4-c4df-4dbd-adf3-2e2662891dd7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("66603b45-e8d2-4b0e-86dc-53d089fd4075"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("692ace5d-c64f-49e1-852a-165864f1de67"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("69755e98-03c2-41a0-8cad-c1dea86469c2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6b89c09e-81e1-4720-be44-5603a1a96a09"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6c6367c1-eabd-4674-9772-ff5a4f9aa05a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7455306d-4c7a-4318-a9ab-c4d9c34a9b09"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7539b1af-1620-4d46-826a-d2f17f63ea67"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("76a4c921-5203-4acc-b757-1788fe4aaef6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("77127f4f-74cc-4b9d-a531-4760ee86da2e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("78112f28-5919-4dbb-9c45-e4327d598a5e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("784f6eb5-a117-4210-9b90-b211a843e359"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e9abfd2-6a51-4593-b2cf-5a91d90fc19a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("814b0152-5f00-4523-b94d-7c80f32e0932"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8173a408-3798-46d4-958e-fe620d79e72b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8778b605-ba06-47bd-843f-93c5f6353b9a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("904c8cce-33ac-4629-a449-2483d789f360"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("982325fb-ee43-47d0-bda3-52363fb48bfb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("99c1c508-2696-4f87-b2ad-d6f3bcabc04a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9aa3b12f-246d-4a3d-aed7-e0362afb771e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9b318df8-87ca-4db9-bdbc-1f9443b7886a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d4b95a0-7e93-4f51-b111-1553884f4d3e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a38ed6d0-b278-4740-9d55-babeacf84992"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a78e79f0-cafb-4a64-b265-40e9b5a62b2f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a836a764-e9f4-4854-a742-c9914bf6f143"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ac21bd5e-4a41-467d-88c2-f80c12772fd6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b3d82cfc-0c3d-4e4a-a1fe-e47945dd1fe0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b47d4136-be76-45cd-8ae9-17a90f08bb79"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b4bb1d83-93ee-453c-92a9-3ca1d036415b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8b03c2a-803f-43ef-ae36-b5ab907867e1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8d23776-84a9-4cd5-bcd7-564e1dcd6ada"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("baf93d29-eb54-4b40-99d0-102b05dc75c3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c7ada7b6-af36-420e-97df-de8ba1b5316d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d09dd282-b51b-4577-b968-331f2ce2f6c4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d448f528-6fcc-481a-9fb2-d65e7c82c2c5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d4b49aeb-cb45-4082-8295-decb2946c123"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d588af69-d1e0-4c30-b66c-205d3ac46a7d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d65aeca3-5ed3-42e5-8a97-25b56c0f8544"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("da652e82-972d-4dff-a43f-4934d4535179"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("da85d709-ce74-4ba8-adf8-aa30fbaab72e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dbbee29b-5903-4bfe-9321-fc2e13ef0dac"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc3abbac-3cac-43ca-8c60-e788081aa562"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dd0808ed-7058-43eb-a111-ac628562cd7f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("de1a1bbf-3a51-4f60-93a5-159337e84d87"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e589e634-cc73-4f44-b87c-1ba1ebb6b69f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e827e1fb-504e-47c6-b9a0-6038550cc6e4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e9abbe46-0949-42d9-a1a5-97b93ae0386a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("eb93ec47-43a4-498c-8365-878b161fba6d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ee0675f1-7f62-4e14-b384-0e85e81d9343"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ee9ff6b1-2c07-4735-9439-b2fc49c5d805"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("eedc5b42-79c5-42e3-af0c-be498fb5ac20"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3273173-f8b7-4d31-a654-9d535925629c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f32c9d18-ce64-4d9f-9d25-5e3937507837"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5f118b4-9d83-45ff-930e-012c4073639e"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b0eb8cd-02f2-472b-87e7-a12e1b23c02d"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("58759d21-64b4-43de-bbb3-470e3e932349"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("5e939364-16d4-4465-8ba6-f0ad0711ce94"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("93515343-d5c5-440e-9793-5c6d510ed7f2"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("b7c2b2ac-3454-45ae-b054-9e50df2026e1"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("568b9b0d-59d2-4f78-98f6-8a3256246482"));

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "UserEntities",
                newName: "Password");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0ebd6758-8144-402e-99ee-74558b3cf7a3"), "", "Puzzle & Skill", null, "" },
                    { new Guid("13dda30c-1001-449f-8c8b-6af958356e07"), "", "Races", null, "" },
                    { new Guid("243885b4-70bb-4eb7-be7d-54eff270d9b3"), "", "Sports", null, "" },
                    { new Guid("2eedd1d6-63a4-41ee-90c4-65e8fde2d193"), "", "Strategy", null, "" },
                    { new Guid("8015ca95-d1c9-4673-8c6c-29ee5111b1fe"), "", "Action", null, "" },
                    { new Guid("95067e97-b5f6-4a19-8536-65f2affbdc54"), "", "RPG", null, "" },
                    { new Guid("b5fef7f1-5116-49bb-8227-517c8e7289ff"), "", "Adventure", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), "AddComment" },
                    { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), "ShipOrder" },
                    { new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"), "DeleteOrderDetails" },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), "GetOrderById" },
                    { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), "Buy" },
                    { new Guid("0d8230b2-85a5-478f-9bf7-681b770e8e05"), "GetRolesOfUser" },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), "GetAllOrders" },
                    { new Guid("14bc89b4-bd04-407c-94a0-7ba3242ccb12"), "ManageAllComments" },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), "GetCart" },
                    { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), "Payment" },
                    { new Guid("2073efa1-c2db-487a-bc35-611228e72078"), "CreateGenre" },
                    { new Guid("23be567e-e029-436e-b2ff-c37cacfaef83"), "GetAllPermissions" },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), "GetSubGenres" },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), "Game" },
                    { new Guid("2c67e983-4d7b-4b56-b25f-2c98830ff523"), "GetAllRoles" },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), "GetAllOrdersDetails" },
                    { new Guid("2fb37999-579b-4c4b-8533-25699255c79c"), "UpdateGenre" },
                    { new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"), "DeletePlatform" },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), "GetPlatformsOfGame" },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), "GetDateFilterOptions" },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), "Platform" },
                    { new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"), "DeleteGame" },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), "GetGamesByGenreId" },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), "Games" },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), "GetAllPublishers" },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), "GetGames" },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), "GetPublisherOfGame" },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), "GetAllPlatforms" },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), "GetGameById" },
                    { new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"), "DeleteGenre" },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), "GetGamesByPlatformId" },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), "GetPaymentMethods" },
                    { new Guid("4d72d646-f9c0-4ec9-9d08-ffb494f3da9e"), "UpdateRole" },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), "GetGamesByPublisherName" },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), "GetAllGenres" },
                    { new Guid("5af46546-8e33-48a4-9c71-d1283ff06820"), "ManageDeletedGames" },
                    { new Guid("5cf9b351-38b8-43fa-a9f5-e3587e25b8d8"), "AddUser" },
                    { new Guid("62fe16e6-394c-4248-8de3-2adadca88d40"), "UpdateUser" },
                    { new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"), "CreatePublisher" },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), "Orders" },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), "Comment" },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), "GetPaginationOptions" },
                    { new Guid("7627996e-2bce-4b70-8920-8c3902bcaabe"), "AddRole" },
                    { new Guid("7813fa0d-894d-41f3-baf1-ff20c95bec41"), "GetRoleById" },
                    { new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"), "CreateGame" },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), "GetPlatformById" },
                    { new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"), "UpdateGame" },
                    { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), "AddGameInCart" },
                    { new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"), "CreatePlatform" },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), "GetPublisherByCompanyName" },
                    { new Guid("8c7ecb39-8356-4513-8b47-c27c9d4882c1"), "DeleteUserById" },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), "GetGenre" },
                    { new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"), "UpdatePlatform" },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), "DownloadGameFile" },
                    { new Guid("992e478a-e419-4ceb-b4c3-966292045cc7"), "GetPermissionsByRoleId" },
                    { new Guid("9c4fd900-2b49-4ebf-80d9-35ecb41b7858"), "DeleteRoleById" },
                    { new Guid("9e8b97b5-77b5-4e56-a6a4-0e5300373f91"), "SeeDeletedGames" },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), "GetComments" },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), "Comments" },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), "Publishers" },
                    { new Guid("cb220733-5798-41dd-84de-e130d422c5f0"), "DeletePublisher" },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), "GetGameByKey" },
                    { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), "DeleteGameFromCart" },
                    { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), "BanUser" },
                    { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), "AddGameToOrderByKey" },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), "Genres" },
                    { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), "DeleteComment" },
                    { new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"), "UpdatePublisher" },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), "GetAllGames" },
                    { new Guid("d76bbae6-326b-4a9a-a39d-0a279be1f3ff"), "GetUserById" },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), "Genre" },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), "GetGenresOfGame" },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), "Order" },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), "Publisher" },
                    { new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"), "UpdateOrderDetailQuantity" },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), "GetSortingOptions" },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), "GetBanDurations" },
                    { new Guid("ed9b2b88-99cb-466d-bc02-3bfe2d7183e5"), "GetAllUsers" },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), "Platforms" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1835a2f8-237d-40f2-b56c-0284c6da4e8c"), "Browser" },
                    { new Guid("87a126d1-df94-4452-af30-b3fea5926805"), "Console" },
                    { new Guid("ddf8f447-54c1-44e5-9ff8-ebe7fb2a8439"), "Desktop" },
                    { new Guid("eb773d4d-a7bf-484d-a833-857c8f4b34af"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee"), "Guest" },
                    { new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e"), "Admin" },
                    { new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236"), "Moderator" },
                    { new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29"), "User" },
                    { new Guid("da291fd2-3785-4b4c-840a-507dd537ad98"), "Manager" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("24b6dfc3-7b5f-4473-9531-6ed6a002145f"), "", "Rally", new Guid("13dda30c-1001-449f-8c8b-6af958356e07"), "" },
                    { new Guid("38bdb1f9-18f7-4c2a-9eea-35a795fd1b68"), "", "TBS", new Guid("2eedd1d6-63a4-41ee-90c4-65e8fde2d193"), "" },
                    { new Guid("41cde12e-f0dd-40ac-ac78-3da920afc067"), "", "FPS", new Guid("8015ca95-d1c9-4673-8c6c-29ee5111b1fe"), "" },
                    { new Guid("9cf2d1ca-b343-44be-824e-a90d00f9d973"), "", "RTS", new Guid("2eedd1d6-63a4-41ee-90c4-65e8fde2d193"), "" },
                    { new Guid("d3b50d59-2792-4e03-896f-fe747380364d"), "", "TPS", new Guid("8015ca95-d1c9-4673-8c6c-29ee5111b1fe"), "" },
                    { new Guid("db07c7c8-a296-41af-8d0c-eac8ec63530a"), "", "Arcade", new Guid("13dda30c-1001-449f-8c8b-6af958356e07"), "" },
                    { new Guid("e1950d6a-40c1-4434-ac73-7c1a921220a1"), "", "Formula", new Guid("13dda30c-1001-449f-8c8b-6af958356e07"), "" },
                    { new Guid("fa0d601a-b8ba-4552-b44b-6d6cde0423c2"), "", "Off-road", new Guid("13dda30c-1001-449f-8c8b-6af958356e07"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("00edcc18-1cef-4f5d-b69d-67c6b5dc3b69"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("01a8ea89-ad69-467c-b459-22fabd559318"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("048a699f-c299-4d86-97fc-b4ff426eb27c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("06454b21-1ca5-4998-9951-14f0b6edfb1f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("067b1afa-c0d4-4ebd-b6f4-66c28a35fcba"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("0d8230b2-85a5-478f-9bf7-681b770e8e05"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("1006ba07-5384-43fa-8578-2762e18975b7"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("14bc89b4-bd04-407c-94a0-7ba3242ccb12"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("1a3baec6-8bbc-4138-81d4-06bea1f44f9c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("1a3fd32a-3dbb-45e3-8d23-0f1a259a2d89"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("2073efa1-c2db-487a-bc35-611228e72078"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("2073efa1-c2db-487a-bc35-611228e72078"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("23be567e-e029-436e-b2ff-c37cacfaef83"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("26ca1038-8da9-497c-931f-0dba1037f290"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("2a8e7dff-bda4-4dd8-a8c4-64b00a8ae7fa"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("2c67e983-4d7b-4b56-b25f-2c98830ff523"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("2f3f589e-8af8-4e33-8ad0-ffd11627d630"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("2fb37999-579b-4c4b-8533-25699255c79c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("2fb37999-579b-4c4b-8533-25699255c79c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("30344a4a-8ff1-42c7-b01a-a382355336cd"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("306de29e-215c-4a1b-9bc0-bb0ae563a235"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("331e5cb1-cd4a-4b2e-aca0-a030ac4ee7e0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("34abfdef-ddb3-4c9b-8449-698c0dc2a4e2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("3725f3cf-12e7-4e5a-8956-293ff3349e46"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("37344498-1071-4eac-96f1-ac9d1dbf599f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("37c0d74c-5dc3-497e-9103-5f5960e8b4fb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("388e8233-71ea-46ac-90c7-1cbb3784edb0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("41487d2c-a5a7-436f-b3da-6d2c3fa8006c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("41a5c406-b2d9-46d2-8cc7-20b999abd364"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("425d370f-92fb-46a5-b2c6-d6acc8e2d742"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("434a188b-f945-41d6-ad88-fa9d79e3ab5f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("4418903a-1547-42e8-a0da-02d7ca0593d8"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("49d5bb9f-cb9e-4d46-9aa4-80caf3296fd5"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("4a221ac4-896a-4b32-a1c8-6c0cc42849b9"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("4d72d646-f9c0-4ec9-9d08-ffb494f3da9e"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("4eefbc8c-aaea-4931-9fd3-58913b1e9118"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("4ef2a4c1-4310-41ee-a698-c80169128ac7"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("5af46546-8e33-48a4-9c71-d1283ff06820"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("5cf9b351-38b8-43fa-a9f5-e3587e25b8d8"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("62fe16e6-394c-4248-8de3-2adadca88d40"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("64f4bf29-e8e4-4c61-836e-ee8a5e74ccca"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("65ddc788-877a-4ef9-baaf-3732c0f2c17d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("7448dd95-0ef3-4243-9dff-c4b51c778706"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("75734b63-c785-44ae-ad7c-072b12a9137a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("7627996e-2bce-4b70-8920-8c3902bcaabe"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("7813fa0d-894d-41f3-baf1-ff20c95bec41"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("79d00ca8-08ac-494f-947b-454122f8c0e0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("7e352e71-8498-4bf8-91ff-3db11bfe2eee"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("7e3aab93-39a0-4da4-9dba-5ce9f8897f7f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("88681641-26ef-4fe1-b35a-621be2c97784"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("889a816a-7a98-4179-96b4-358d2dc3ffbb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("8c656a91-e6ec-4cca-9abf-bfabc4873a9c"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("8c7ecb39-8356-4513-8b47-c27c9d4882c1"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("8e4b5942-f635-4fd9-a2cd-31fcbc426f1e"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("93ffed49-50e5-4c4a-96b4-985db549d1d2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("973c85a5-72e6-4284-b0e5-344eec3c4554"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("992e478a-e419-4ceb-b4c3-966292045cc7"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("9c4fd900-2b49-4ebf-80d9-35ecb41b7858"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("abef1f98-6fb6-4940-b66a-4e44c8d4303d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("af74d7c5-e4af-49c9-9830-78a2cfb2696d"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("c28a8d89-02c6-4cb9-a89d-f17701197fd4"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("cb220733-5798-41dd-84de-e130d422c5f0"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("cb220733-5798-41dd-84de-e130d422c5f0"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("cf026cf4-db6c-4246-9f0e-1a306ac7dd4a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("cf4bf26a-98a4-435c-8042-312c1cc97cb2"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d101f8d5-6006-4f73-8f43-cc6c148e2cdf"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("d108b664-3c38-4b98-a210-83da1bf46c09"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("d117a3ae-c5dc-4180-bc66-e3e77283ae6f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d1295aba-8208-46a5-8e75-2c442ef4736a"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d326d9d0-02c7-4a5c-a00c-ee7376bc76c3"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("d6311013-9198-4b11-8bca-e7156b22383b"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("d76bbae6-326b-4a9a-a39d-0a279be1f3ff"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("d9d6d88d-491c-45df-8ee5-0076fb1180dd"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("dafad8b7-d480-497c-9f18-4c86245bf928"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("dc4af2f0-f182-4ec9-a043-ea79a6cd4357"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("de6485ce-6471-461f-9122-82c2ff0ad1d4"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("e1a053b2-72f1-48d5-93a3-c9d8c69eeceb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("e2091643-98b2-497f-956b-251bae16e074"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("ece91c3b-d873-4a57-a832-e9209116d70f"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") },
                    { new Guid("ed9b2b88-99cb-466d-bc02-3bfe2d7183e5"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("343b83fc-777d-481c-87e1-cbb5ba506fee") },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("80a7ffcb-e003-4db7-9f73-e5e79c7ba07e") },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("a5b65f27-ea42-4d1d-a6a9-800924e0f236") },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("cc816fc0-7bd4-4387-b12c-adef15518c29") },
                    { new Guid("fd87ce64-86a9-4960-b6e0-eb1a427a8bdb"), new Guid("da291fd2-3785-4b4c-840a-507dd537ad98") }
                });
        }
    }
}
