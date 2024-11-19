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
    public partial class Twentyfirstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a71180c-ceb2-43de-b75c-116fa008585e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3b044478-027c-4e1f-844c-988c76d640bb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3be3d294-550a-4dd6-ba09-05ef907f37af"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6c38b607-ada9-4ca8-a4d7-51dc1b15fa63"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("809f1d59-4175-4f1b-b88f-214cd32ba754"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("81b497e4-79fc-4052-9b2b-1875ca7346f0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("91243d3a-dab9-4d4e-8fc1-2b89f2845fd7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a2e456d4-8627-424f-ad3e-c7f996bf4f58"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("af0e3070-3943-438e-9c90-7a1b316a90d6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b991789b-d61a-44f9-b862-1fd6da77fe11"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("da3be1bd-e063-4469-84a3-22adb6551647"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("f145c03e-8fb7-4fde-bc4d-70f7aed57864"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f4c2fe7-5f63-4f61-9562-15c2c957f8cd"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("1230d4bc-44b1-4451-a098-e88296c9285c"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b04855e2-5b9d-4685-8367-0a8b1af0bbf4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5ca5f97-3a4c-4238-b399-daa8f84e53ea"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoleEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PermissionEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserEntities_Name",
                table: "UserEntities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleEntities_Name",
                table: "RoleEntities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntities_Name",
                table: "PermissionEntities",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserEntities_Name",
                table: "UserEntities");

            migrationBuilder.DropIndex(
                name: "IX_RoleEntities_Name",
                table: "RoleEntities");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntities_Name",
                table: "PermissionEntities");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoleEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PermissionEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("1a71180c-ceb2-43de-b75c-116fa008585e"), "", "RPG", null, "" },
                    { new Guid("6c38b607-ada9-4ca8-a4d7-51dc1b15fa63"), "", "Puzzle & Skill", null, "" },
                    { new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "", "Strategy", null, "" },
                    { new Guid("af0e3070-3943-438e-9c90-7a1b316a90d6"), "", "Adventure", null, "" },
                    { new Guid("b991789b-d61a-44f9-b862-1fd6da77fe11"), "", "Sports", null, "" },
                    { new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "", "Races", null, "" },
                    { new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "", "Action", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("0f4c2fe7-5f63-4f61-9562-15c2c957f8cd"), "Mobile" },
                    { new Guid("1230d4bc-44b1-4451-a098-e88296c9285c"), "Desktop" },
                    { new Guid("b04855e2-5b9d-4685-8367-0a8b1af0bbf4"), "Console" },
                    { new Guid("b5ca5f97-3a4c-4238-b399-daa8f84e53ea"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("3b044478-027c-4e1f-844c-988c76d640bb"), "", "TBS", new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "" },
                    { new Guid("3be3d294-550a-4dd6-ba09-05ef907f37af"), "", "TPS", new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "" },
                    { new Guid("809f1d59-4175-4f1b-b88f-214cd32ba754"), "", "Rally", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("81b497e4-79fc-4052-9b2b-1875ca7346f0"), "", "FPS", new Guid("effd16bf-1acb-491c-b450-5a7c41f8965a"), "" },
                    { new Guid("91243d3a-dab9-4d4e-8fc1-2b89f2845fd7"), "", "Formula", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("a2e456d4-8627-424f-ad3e-c7f996bf4f58"), "", "Arcade", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("da3be1bd-e063-4469-84a3-22adb6551647"), "", "Off-road", new Guid("d4169bda-ff17-4840-a95c-a21303dc6bd6"), "" },
                    { new Guid("f145c03e-8fb7-4fde-bc4d-70f7aed57864"), "", "RTS", new Guid("a55aa2ee-e1d1-41b5-842f-8626fb854ec4"), "" }
                });
        }
    }
}
