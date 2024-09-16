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
    public partial class TwentySixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "AllowedOnGuest",
                table: "PermissionEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AllowedOnGuest",
                table: "PermissionEntities");

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
    }
}
