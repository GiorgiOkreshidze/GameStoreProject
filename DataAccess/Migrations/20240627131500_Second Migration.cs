using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("056c55ea-4f32-4a10-b002-615568469c19"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0f444308-dd13-42b1-8cc3-af4ed8e89bd3"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1902c41b-310b-4efc-81c4-7a3ff7820337"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b8b72f1-042a-429b-ba5c-09697a4fdf72"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2734ae8a-9dc3-4367-955a-429f425b6198"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("342fa136-fa19-47e1-96d1-53e75ed85a0e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("66ec2d72-6208-4178-9ea0-9f0c66d98293"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7ae46eee-aa6a-448a-a1c6-d20daa2bc506"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b22e712c-34ce-422f-9fde-614e0d69664f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5117a1c-28d3-4d91-a96c-244fb41f20e9"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("cd615658-4c0f-4acc-b3c3-9ab3fb7a2bd5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("fae914d8-1a86-42c8-992d-f7f12d1138f4"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("4249a843-f8f3-4147-8b9c-8022dc03222e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("90a1e9e8-e3de-4298-a4b3-936c7d99451e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("924dc40d-1f67-44dc-af83-aad13124186e"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("95e2b27c-3c93-4c7c-95a8-52affc9c04ff"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c33edf2-3698-4000-b1fb-462129d0c954"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("836301c7-7b07-4dcf-83ec-705b25946c63"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547"));

            migrationBuilder.RenameColumn(
                name: "description",
                table: "GameEntities",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "PlatformEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GenreEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "GameEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf"), "Races", null },
                    { new Guid("690d7e38-2752-4b79-9b7b-3d5e218cd9bd"), "Adventure", null },
                    { new Guid("7a5d9ca3-2a8b-4c22-923b-b9f08432e8c4"), "RPG", null },
                    { new Guid("8096feab-2415-4b4b-82b9-c37e0f367535"), "Puzzle & Skill", null },
                    { new Guid("86921cfe-7eed-4fe1-8171-c315825ff38b"), "Sports", null },
                    { new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71"), "Strategy", null },
                    { new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96"), "Action", null }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("34ef5e1c-cefa-499a-b770-da4752ecf826"), "Console" },
                    { new Guid("8dfd6dce-51c7-464e-939b-6c0170bf954f"), "Browser" },
                    { new Guid("c10e61e0-dc44-4195-80f3-e227b51b3586"), "Desktop" },
                    { new Guid("cf6fb34c-ac9a-4af9-aaf2-2a4e3f0a4790"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("05c723dd-dfb5-4e2a-8ef2-2a3f2a0e0258"), "FPS", new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96") },
                    { new Guid("4598a335-3f58-459e-bc10-044d2f121f8e"), "Rally", new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf") },
                    { new Guid("55a74458-3aa5-4aa0-aced-1aca041edc8c"), "TBS", new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71") },
                    { new Guid("68344482-1cf7-47a8-8133-4d896cd60ffc"), "TPS", new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96") },
                    { new Guid("7744e708-10db-4a68-b002-9eedc1195e18"), "Formula", new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf") },
                    { new Guid("7aa18673-2b49-4c0a-824c-774e5cc4147f"), "RTS", new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71") },
                    { new Guid("8d8115c3-fe7a-4b2d-80c2-56358fd7daeb"), "Off-road", new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf") },
                    { new Guid("d58d611e-ecdf-4b15-911a-cfcc1417e3ba"), "Arcade", new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlatformEntities_Type",
                table: "PlatformEntities",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreEntities_Name",
                table: "GenreEntities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameEntities_Key",
                table: "GameEntities",
                column: "Key",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PlatformEntities_Type",
                table: "PlatformEntities");

            migrationBuilder.DropIndex(
                name: "IX_GenreEntities_Name",
                table: "GenreEntities");

            migrationBuilder.DropIndex(
                name: "IX_GameEntities_Key",
                table: "GameEntities");

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("05c723dd-dfb5-4e2a-8ef2-2a3f2a0e0258"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4598a335-3f58-459e-bc10-044d2f121f8e"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("55a74458-3aa5-4aa0-aced-1aca041edc8c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("68344482-1cf7-47a8-8133-4d896cd60ffc"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("690d7e38-2752-4b79-9b7b-3d5e218cd9bd"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7744e708-10db-4a68-b002-9eedc1195e18"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7a5d9ca3-2a8b-4c22-923b-b9f08432e8c4"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("7aa18673-2b49-4c0a-824c-774e5cc4147f"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8096feab-2415-4b4b-82b9-c37e0f367535"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("86921cfe-7eed-4fe1-8171-c315825ff38b"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("8d8115c3-fe7a-4b2d-80c2-56358fd7daeb"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("d58d611e-ecdf-4b15-911a-cfcc1417e3ba"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("34ef5e1c-cefa-499a-b770-da4752ecf826"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("8dfd6dce-51c7-464e-939b-6c0170bf954f"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("c10e61e0-dc44-4195-80f3-e227b51b3586"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf6fb34c-ac9a-4af9-aaf2-2a4e3f0a4790"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2664d92e-382b-4ce7-be57-5beacb642aaf"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("e6b02ab2-12a7-4105-ac60-f388186f8c71"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ecb19068-a2db-4eb2-b871-0664e3e23b96"));

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "GameEntities",
                newName: "description");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "PlatformEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GenreEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "GameEntities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("1b8b72f1-042a-429b-ba5c-09697a4fdf72"), "Sports", null },
                    { new Guid("2734ae8a-9dc3-4367-955a-429f425b6198"), "RPG", null },
                    { new Guid("342fa136-fa19-47e1-96d1-53e75ed85a0e"), "Adventure", null },
                    { new Guid("3c33edf2-3698-4000-b1fb-462129d0c954"), "Races", null },
                    { new Guid("836301c7-7b07-4dcf-83ec-705b25946c63"), "Action", null },
                    { new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547"), "Strategy", null },
                    { new Guid("cd615658-4c0f-4acc-b3c3-9ab3fb7a2bd5"), "Puzzle & Skill", null }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("4249a843-f8f3-4147-8b9c-8022dc03222e"), "Desktop" },
                    { new Guid("90a1e9e8-e3de-4298-a4b3-936c7d99451e"), "Mobile" },
                    { new Guid("924dc40d-1f67-44dc-af83-aad13124186e"), "Browser" },
                    { new Guid("95e2b27c-3c93-4c7c-95a8-52affc9c04ff"), "Console" }
                });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Name", "ParentGenreId" },
                values: new object[,]
                {
                    { new Guid("056c55ea-4f32-4a10-b002-615568469c19"), "FPS", new Guid("836301c7-7b07-4dcf-83ec-705b25946c63") },
                    { new Guid("0f444308-dd13-42b1-8cc3-af4ed8e89bd3"), "RTS", new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547") },
                    { new Guid("1902c41b-310b-4efc-81c4-7a3ff7820337"), "Formula", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("66ec2d72-6208-4178-9ea0-9f0c66d98293"), "Rally", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("7ae46eee-aa6a-448a-a1c6-d20daa2bc506"), "Off-road", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("b22e712c-34ce-422f-9fde-614e0d69664f"), "Arcade", new Guid("3c33edf2-3698-4000-b1fb-462129d0c954") },
                    { new Guid("b5117a1c-28d3-4d91-a96c-244fb41f20e9"), "TBS", new Guid("8678fa5c-2ae8-4443-8d26-e4ff10689547") },
                    { new Guid("fae914d8-1a86-42c8-992d-f7f12d1138f4"), "TPS", new Guid("836301c7-7b07-4dcf-83ec-705b25946c63") }
                });
        }
    }
}
