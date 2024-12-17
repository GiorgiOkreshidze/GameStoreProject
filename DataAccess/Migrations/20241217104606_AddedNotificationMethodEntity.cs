using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotificationMethodEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "NotificationMethodEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationMethodEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserNotificationMethods",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotificationMethods", x => new { x.UserId, x.NotificationMethodId });
                    table.ForeignKey(
                        name: "FK_UserNotificationMethods_NotificationMethodEntities_NotificationMethodId",
                        column: x => x.NotificationMethodId,
                        principalTable: "NotificationMethodEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotificationMethods_UserEntities_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMethodEntities_Type",
                table: "NotificationMethodEntities",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationMethods_NotificationMethodId",
                table: "UserNotificationMethods",
                column: "NotificationMethodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNotificationMethods");

            migrationBuilder.DropTable(
                name: "NotificationMethodEntities");

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
    }
}
