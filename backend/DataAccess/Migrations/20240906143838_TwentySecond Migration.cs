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
    public partial class TwentySecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("13047bc5-2aaa-4578-87a8-6810a16105e9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b831629-1aa4-412d-a67a-3b232a69cdbe"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c337e7a-9fe5-462a-b55b-9a891c1d177a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6fa77865-26a6-4d94-9e37-2877e415d374"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("87e8602c-fd9a-453d-80d0-4f3d2a86c3cb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8a39695b-45fe-486e-a522-ca26bc9075cf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8f47da1d-b418-44b6-8eea-e827c676289c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ac2a31b-60e8-4cc9-90ad-c3f329f42e29"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a87955fc-28dc-469a-a6e3-c46228c914c2"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b14fb5b3-e4b2-4db8-a6fc-e992933d8c7e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf3545b6-442e-40e1-b7d6-0484d6691aa3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f72a1261-8bfc-40b9-86b6-cf42359f89c4"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1bd5a97e-20ce-4178-bc64-97a8a25a24a7"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("26f6f35c-ca18-46cb-b607-5151fd7506af"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4e1ff5-9ae6-4aea-9a7e-5ceb306d21b8"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("37603793-a633-48ee-9805-2cbec1878a32"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a2061c0-e980-4953-a95a-5a9952434133"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a2061c0-e980-4953-a95a-5a9952434133"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f3ea9c6-7e23-453a-a3de-b863a791cfca"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65c4b994-c3a3-44c3-b8e0-e184fbd6bdec"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("81fa755a-3f63-414a-b683-93346aeb3539"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("859afba9-04b8-4f16-989e-6991935222e0"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("90eaef95-01c2-4702-b645-0548ec46ca67"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a953eeea-1749-4565-bd51-60a8780a22f0"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bce985dd-14c3-4d09-8c0b-287bb2c1a71d"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9d525c2-c496-4d80-b6df-80941c4ee739"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4098416-c750-4eca-9627-ea49d556800e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d4098416-c750-4eca-9627-ea49d556800e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dd530dcc-475c-4a8e-a26c-136a1a119f00"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1936d15-c805-4d23-9a67-b91a767669da"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("24007133-bc18-4af6-b77b-2aebf82805df"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a3e95d6-dedc-4ea1-b8ad-dd0abff3f4cf"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("368fec19-8a7d-43dc-95ec-b654074a3978"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("eb6eed12-32b1-4317-bd65-238569854cde"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d88136e-246d-4b39-af5b-bf561e3abe02"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7ffe0bc2-cae6-4b24-ad2d-fb08536c7ad6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1bd5a97e-20ce-4178-bc64-97a8a25a24a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("26f6f35c-ca18-46cb-b607-5151fd7506af"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a4e1ff5-9ae6-4aea-9a7e-5ceb306d21b8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("34d43875-304d-40eb-b105-0881c5556ab5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("37603793-a633-48ee-9805-2cbec1878a32"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a2061c0-e980-4953-a95a-5a9952434133"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5f3ea9c6-7e23-453a-a3de-b863a791cfca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("60651563-2234-457e-a950-55ecf36d64bf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65c4b994-c3a3-44c3-b8e0-e184fbd6bdec"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68231035-9e53-466f-bc10-94059816d640"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("81fa755a-3f63-414a-b683-93346aeb3539"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("859afba9-04b8-4f16-989e-6991935222e0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("90eaef95-01c2-4702-b645-0548ec46ca67"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("969caaee-acb3-4138-a504-0550a75b0c34"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a953eeea-1749-4565-bd51-60a8780a22f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bce985dd-14c3-4d09-8c0b-287bb2c1a71d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c1c9675a-454e-4458-8d08-e889d846d522"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c9d525c2-c496-4d80-b6df-80941c4ee739"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d4098416-c750-4eca-9627-ea49d556800e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dd530dcc-475c-4a8e-a26c-136a1a119f00"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e2918202-fda4-4006-9503-1d5a9d909632"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1936d15-c805-4d23-9a67-b91a767669da"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"), "", "Races", null, "" },
                    { new Guid("3b831629-1aa4-412d-a67a-3b232a69cdbe"), "", "Adventure", null, "" },
                    { new Guid("7d88136e-246d-4b39-af5b-bf561e3abe02"), "", "Strategy", null, "" },
                    { new Guid("7ffe0bc2-cae6-4b24-ad2d-fb08536c7ad6"), "", "Action", null, "" },
                    { new Guid("87e8602c-fd9a-453d-80d0-4f3d2a86c3cb"), "", "Puzzle & Skill", null, "" },
                    { new Guid("8a39695b-45fe-486e-a522-ca26bc9075cf"), "", "Sports", null, "" },
                    { new Guid("a87955fc-28dc-469a-a6e3-c46228c914c2"), "", "RPG", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), "AddGameInCart" },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), "Genres" },
                    { new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"), "DeleteOrderDetails" },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), "GetPlatformById" },
                    { new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"), "UpdateGame" },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), "GetGenre" },
                    { new Guid("1bd5a97e-20ce-4178-bc64-97a8a25a24a7"), "DeleteRoleById" },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), "GetGamesByPublisherName" },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), "GetComments" },
                    { new Guid("26f6f35c-ca18-46cb-b607-5151fd7506af"), "CanSeeDeletedGames" },
                    { new Guid("2a4e1ff5-9ae6-4aea-9a7e-5ceb306d21b8"), "UpdateRole" },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), "GetAllPlatforms" },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), "Comment" },
                    { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), "Buy" },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), "GetPublisherOfGame" },
                    { new Guid("37603793-a633-48ee-9805-2cbec1878a32"), "GetAllUsers" },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), "GetDateFilterOptions" },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), "Order" },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), "GetPublisherByCompanyName" },
                    { new Guid("4a2061c0-e980-4953-a95a-5a9952434133"), "CreatePublisher" },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), "GetGames" },
                    { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), "ShipOrder" },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), "Games" },
                    { new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"), "CreatePlatform" },
                    { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), "DeleteComment" },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), "GetSubGenres" },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), "GetAllOrdersDetails" },
                    { new Guid("5f3ea9c6-7e23-453a-a3de-b863a791cfca"), "GetAllPermissions" },
                    { new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"), "UpdateOrderDetailQuantity" },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), "GetCart" },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), "Platform" },
                    { new Guid("65c4b994-c3a3-44c3-b8e0-e184fbd6bdec"), "GetUserById" },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), "Platforms" },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), "GetBanDurations" },
                    { new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"), "DeleteGame" },
                    { new Guid("81fa755a-3f63-414a-b683-93346aeb3539"), "UpdateUser" },
                    { new Guid("859afba9-04b8-4f16-989e-6991935222e0"), "AddRole" },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), "Publishers" },
                    { new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"), "CreateGenre" },
                    { new Guid("90eaef95-01c2-4702-b645-0548ec46ca67"), "GetAllRoles" },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), "GetGamesByGenreId" },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), "Orders" },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), "GetGenresOfGame" },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), "GetAllOrders" },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), "GetSortingOptions" },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), "GetAllGames" },
                    { new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"), "UpdatePublisher" },
                    { new Guid("a953eeea-1749-4565-bd51-60a8780a22f0"), "AddUser" },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), "GetPaginationOptions" },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), "GetAllGenres" },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), "GetGamesByPlatformId" },
                    { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), "BanUser" },
                    { new Guid("bce985dd-14c3-4d09-8c0b-287bb2c1a71d"), "GetRoleById" },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), "Genre" },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), "GetAllPublishers" },
                    { new Guid("c9d525c2-c496-4d80-b6df-80941c4ee739"), "GetRolesOfUser" },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), "Publisher" },
                    { new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"), "DeleteGenre" },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), "Game" },
                    { new Guid("d4098416-c750-4eca-9627-ea49d556800e"), "UpdateGenre" },
                    { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), "DeleteGameFromCart" },
                    { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), "AddComment" },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), "Comments" },
                    { new Guid("dd530dcc-475c-4a8e-a26c-136a1a119f00"), "DeleteUserById" },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), "GetGameByKey" },
                    { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), "Payment" },
                    { new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"), "UpdatePlatform" },
                    { new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"), "DeletePublisher" },
                    { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), "AddGameToOrderByKey" },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), "DownloadGameFile" },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), "GetPlatformsOfGame" },
                    { new Guid("f1936d15-c805-4d23-9a67-b91a767669da"), "GetPermissionsByRoleId" },
                    { new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"), "CreateGame" },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), "GetPaymentMethods" },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), "GetOrderById" },
                    { new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"), "DeletePlatform" },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), "GetGameById" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("24007133-bc18-4af6-b77b-2aebf82805df"), "Mobile" },
                    { new Guid("2a3e95d6-dedc-4ea1-b8ad-dd0abff3f4cf"), "Console" },
                    { new Guid("368fec19-8a7d-43dc-95ec-b654074a3978"), "Desktop" },
                    { new Guid("eb6eed12-32b1-4317-bd65-238569854cde"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a"), "Manager" },
                    { new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d"), "User" },
                    { new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747"), "Moderator" },
                    { new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213"), "Admin" },
                    { new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64"), "Guest" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("13047bc5-2aaa-4578-87a8-6810a16105e9"), "", "TPS", new Guid("7ffe0bc2-cae6-4b24-ad2d-fb08536c7ad6"), "" },
                    { new Guid("3c337e7a-9fe5-462a-b55b-9a891c1d177a"), "", "TBS", new Guid("7d88136e-246d-4b39-af5b-bf561e3abe02"), "" },
                    { new Guid("6fa77865-26a6-4d94-9e37-2877e415d374"), "", "Formula", new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"), "" },
                    { new Guid("8f47da1d-b418-44b6-8eea-e827c676289c"), "", "RTS", new Guid("7d88136e-246d-4b39-af5b-bf561e3abe02"), "" },
                    { new Guid("9ac2a31b-60e8-4cc9-90ad-c3f329f42e29"), "", "Arcade", new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"), "" },
                    { new Guid("b14fb5b3-e4b2-4db8-a6fc-e992933d8c7e"), "", "FPS", new Guid("7ffe0bc2-cae6-4b24-ad2d-fb08536c7ad6"), "" },
                    { new Guid("cf3545b6-442e-40e1-b7d6-0484d6691aa3"), "", "Off-road", new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"), "" },
                    { new Guid("f72a1261-8bfc-40b9-86b6-cf42359f89c4"), "", "Rally", new Guid("0c4317b0-e69b-436e-b665-064dddb3060a"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("0249a46c-b8f6-4f55-8043-ce18c179117c"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("07fe42f1-8c72-479d-9ce0-187c3025b4e6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("08d2720b-57aa-436d-b0c1-a87ad77ec991"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("12858932-c94a-4d6e-afe2-8c728ab51b74"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("1500bc45-dbbe-4d96-a3f3-5b64df4a66c6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("18c33426-29e8-4fe6-a7a6-44937325db1b"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("1bd5a97e-20ce-4178-bc64-97a8a25a24a7"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("1ce23b3f-95cb-41f8-b200-f40a71080c17"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("24a8380e-2813-4db7-839e-68c96885bb8f"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("26f6f35c-ca18-46cb-b607-5151fd7506af"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("2a4e1ff5-9ae6-4aea-9a7e-5ceb306d21b8"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("33ef9623-18cd-495a-b1ba-2b9953580681"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("34d43875-304d-40eb-b105-0881c5556ab5"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("34ed6cf1-96c2-4b8e-8acf-d92f8b959b1e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("3536f705-9bda-4379-97ee-0d719626c8f2"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("37603793-a633-48ee-9805-2cbec1878a32"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("38a8fdfc-70c7-489f-bd80-817d9cc15b77"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("3d798789-2e3b-4ef7-9e26-baa32e53236d"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("4469ff94-f739-4b43-bfc8-95dea0003b84"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("4a2061c0-e980-4953-a95a-5a9952434133"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("4a2061c0-e980-4953-a95a-5a9952434133"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("4b207dc0-d3ff-42af-a4ce-976963fc6cd9"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("4c92ec6b-8cc9-4389-b824-adf18b1f73a5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("5020cb3a-fc02-47d2-b6a7-28a5924cf466"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("51d7e608-c7f3-44e0-850d-b31900ee83a7"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("58ccafa3-48c9-41b5-a42a-c1bb1432234a"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("599a06c8-48ec-4e99-8178-9c756c906d58"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("5dfe5e47-f1d2-46b0-8877-0860d630fcd6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("5f3ea9c6-7e23-453a-a3de-b863a791cfca"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("5f52b39d-d225-4d66-ab2f-0d44cf464833"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("60651563-2234-457e-a950-55ecf36d64bf"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("615bd3bd-1189-4734-89b5-c296ee56cf56"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("65c4b994-c3a3-44c3-b8e0-e184fbd6bdec"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("68231035-9e53-466f-bc10-94059816d640"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("68a44247-a3b4-4b55-8ef1-70a0f03b6e65"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("79bdbd7b-1a2c-44fa-b5d7-7a8ccf53f2c9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("81fa755a-3f63-414a-b683-93346aeb3539"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("859afba9-04b8-4f16-989e-6991935222e0"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("8d74a35d-7cfd-4c6e-b513-4644344454ad"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("8d7d8a53-6d27-4326-b0c5-b83e73b9e717"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("90eaef95-01c2-4702-b645-0548ec46ca67"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("91f86300-4558-4c4e-ac76-80bac53ec451"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("91fabc89-4fb0-4ea0-93db-01e99a42673f"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("969caaee-acb3-4138-a504-0550a75b0c34"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("9f1182b5-1979-4969-959a-ceb8c80b07f8"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("a1f1f29d-2c28-423c-a744-76c17ce65677"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("a42dc69d-d2bb-4e76-a876-7b2e110354c6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("a5ba050b-4cec-4b8d-9ee5-3debd6ad8fd1"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("a953eeea-1749-4565-bd51-60a8780a22f0"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("ac99e6c6-0417-4618-8de2-9a49e3594216"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("ad03cb25-d9fc-4aea-b2f5-53ee6fe73292"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("b4c688ff-808d-426f-ba29-ff78b1ed95ab"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("bc4d983d-454f-44b8-b67f-f87a0b06b1a3"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("bce985dd-14c3-4d09-8c0b-287bb2c1a71d"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("c1c9675a-454e-4458-8d08-e889d846d522"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("c3e3295c-3ede-469c-971c-7dd73948058c"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("c9d525c2-c496-4d80-b6df-80941c4ee739"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("c9f9f459-fb7c-4871-a90a-0a38aab6d7dc"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("ccd6fcea-5e5f-4573-8450-4da5c716999e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("d206d943-37e8-4057-a3be-20c6ff849ec9"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("d4098416-c750-4eca-9627-ea49d556800e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("d4098416-c750-4eca-9627-ea49d556800e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("d9bb196d-3539-4b63-aa28-9bcbb126c450"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("dae48ce1-5f4f-441d-9158-729d99e2cb59"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("dbd839e4-ae79-41c8-b261-b24f864f5fca"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("dd530dcc-475c-4a8e-a26c-136a1a119f00"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("e0dd7c3d-62f1-4a8d-addd-ef97e231c9ae"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("e2918202-fda4-4006-9503-1d5a9d909632"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("e7d93f8e-9954-4386-98f9-00e3d3810e84"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("ede9e16f-a703-4bc6-9482-4c294e29cc2e"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("ef6f0c03-5244-4961-95b5-94a92d58737f"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f0be9749-a77d-4ca7-8765-c6757f6c4aa6"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f12829bf-acc2-47b2-8465-b2f2c2a1e475"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("f1936d15-c805-4d23-9a67-b91a767669da"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("f1b5b3da-0c61-4f2b-9b67-bc8f573d2512"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f2be93cc-234f-41a6-8c0e-7f2d8866be87"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("f9b147d7-6cb8-419d-bb14-6250c7f1e4b5"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") },
                    { new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("fb8ab393-6c90-4c08-acae-b5c50edaf129"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("148434d2-0bfe-4bb2-bef6-c8c5b711b92a") },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("4a0e3037-4908-408a-a2d4-be2095be9d9d") },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("a1492ed4-fd89-4c69-990b-75665e8ac747") },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("cc02a3bf-8414-44c0-ad45-f44eb271d213") },
                    { new Guid("fbe2a948-37cd-4d77-9592-c18aa6d43aa4"), new Guid("e19675e5-afaf-47aa-8b86-61534fe2eb64") }
                });
        }
    }
}
