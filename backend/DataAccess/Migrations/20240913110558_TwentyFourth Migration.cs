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
    public partial class TwentyFourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "", "Races", null, "" },
                    { new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "", "Action", null, "" },
                    { new Guid("3ea863d6-e1fd-4716-81db-abc6f6ce65ab"), "", "Puzzle & Skill", null, "" },
                    { new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "", "Strategy", null, "" },
                    { new Guid("559c6d9f-1c6c-4d28-8a1f-f7cba459c43c"), "", "RPG", null, "" },
                    { new Guid("5c4576b4-d0b6-409b-a00c-371a84621349"), "", "Sports", null, "" },
                    { new Guid("feddc288-3702-4b93-8fa1-9cab60f3bd41"), "", "Adventure", null, "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), "GetSortingOptions" },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), "GetGamesByPlatformId" },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), "CreateGenre" },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), "Genres" },
                    { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), "Users" },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), "GetAllPublishers" },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), "GetAllGames" },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), "AddGameToOrderByKey" },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), "GetDateFilterOptions" },
                    { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), "GetAllPermissions" },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), "Buy" },
                    { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), "User" },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), "DeleteGameFromCart" },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), "GetAllOrders" },
                    { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), "GetRolesOfUser" },
                    { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), "GetPermissionsByRoleId" },
                    { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), "Roles" },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), "Games" },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), "Publisher" },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), "DeletePlatform" },
                    { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), "GetUserById" },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), "GetComments" },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), "GetAllGenres" },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), "Order" },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), "GetBanDurations" },
                    { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), "GetAllRoles" },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), "GetGenresOfGame" },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), "GetGenre" },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), "GetAllOrdersDetails" },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), "UpdateGame" },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), "DeleteGame" },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), "UpdatePublisher" },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), "Orders" },
                    { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), "ManageAllComments" },
                    { new Guid("6a7383c9-a73b-43e4-b0ff-fe766764c15b"), "SeeDeletedGames" },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), "DownloadGameFile" },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), "DeleteComment" },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), "BanUser" },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), "Platform" },
                    { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), "ManageDeletedGames" },
                    { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), "GetRoleById" },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), "GetCart" },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), "GetGameByKey" },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), "DeletePublisher" },
                    { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), "Role" },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), "Comments" },
                    { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), "UpdateRole" },
                    { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), "UpdateUser" },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), "GetPlatformById" },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), "GetPublisherByCompanyName" },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), "CreatePublisher" },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), "GetGames" },
                    { new Guid("a4312c74-87c6-4bb6-ad6d-7cc43e30a64a"), "History" },
                    { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), "DeleteRoleById" },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), "GetAllPlatforms" },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), "GetPaymentMethods" },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), "GetOrders" },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), "DeleteGenre" },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), "Comment" },
                    { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), "AddRole" },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), "Genre" },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), "GetSubGenres" },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), "Publishers" },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), "Game" },
                    { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), "GetAllUsers" },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), "AddComment" },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), "GetGamesByPublisherName" },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), "GetPublisherOfGame" },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), "CreateGame" },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), "UpdatePlatform" },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), "GetGameById" },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), "CreatePlatform" },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), "GetOrderById" },
                    { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), "DeleteUserById" },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), "DeleteOrderDetails" },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), "GetGamesByGenreId" },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), "Platforms" },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), "ShipOrder" },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), "UpdateOrderDetailQuantity" },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), "GetPlatformsOfGame" },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), "Payment" },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), "UpdateGenre" },
                    { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), "AddUser" },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), "GetPaginationOptions" },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), "AddGameInCart" }
                });

            migrationBuilder.InsertData(
                table: "PlatformEntities",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("430b74f9-8911-4d0e-8608-8e29a2a2e4ef"), "Console" },
                    { new Guid("57a9efc2-965f-48a9-bb51-5e440dcbf819"), "Desktop" },
                    { new Guid("a2d90a47-f6dd-4a2b-884e-65926ca19693"), "Mobile" },
                    { new Guid("e6f56830-89a6-421a-b69d-b425206f27c5"), "Browser" }
                });

            migrationBuilder.InsertData(
                table: "RoleEntities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), "Admin" },
                    { new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676"), "Moderator" },
                    { new Guid("bb84982e-a25f-4573-8218-08f3174fd66d"), "Guest" },
                    { new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8"), "Manager" },
                    { new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e"), "User" }
                });

            migrationBuilder.InsertData(
                table: "UserEntities",
                columns: new[] { "Id", "Name", "PasswordHash" },
                values: new object[] { new Guid("8397daf4-dea7-4213-b21b-877deff4815f"), "Admin", "$2a$11$mX6bLHQmyQdl8yJQU9ZQKOCgUfPra4o86FQh9CoHgXUVMd0HJClsu" });

            migrationBuilder.InsertData(
                table: "GenreEntities",
                columns: new[] { "Id", "Description", "Name", "ParentGenreId", "Picture" },
                values: new object[,]
                {
                    { new Guid("06caf581-7c4d-498d-9850-149c09d049d7"), "", "Rally", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("0da343c5-be15-4583-b748-4f4140f2a616"), "", "TBS", new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "" },
                    { new Guid("14038d79-1193-4b52-9e26-729345a47d00"), "", "TPS", new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "" },
                    { new Guid("2762d31a-19bf-4385-a072-31b9d88d52f0"), "", "Off-road", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("4cb5de89-4bf7-4c76-9206-102a3c4dea5d"), "", "RTS", new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"), "" },
                    { new Guid("5fdd4f2f-021a-44a3-8d8a-f069d1a8273d"), "", "FPS", new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"), "" },
                    { new Guid("6f66163d-2216-4209-87e1-e3859165d37d"), "", "Formula", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" },
                    { new Guid("ea14c9db-2a5d-4e3b-9297-f5526a9f64de"), "", "Arcade", new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"), "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionRoles",
                columns: new[] { "PermissionEntityId", "RoleEntityId" },
                values: new object[,]
                {
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") },
                    { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleEntityId", "UserEntityId" },
                values: new object[] { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), new Guid("8397daf4-dea7-4213-b21b-877deff4815f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("06caf581-7c4d-498d-9850-149c09d049d7"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("0da343c5-be15-4583-b748-4f4140f2a616"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("14038d79-1193-4b52-9e26-729345a47d00"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("2762d31a-19bf-4385-a072-31b9d88d52f0"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("3ea863d6-e1fd-4716-81db-abc6f6ce65ab"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("4cb5de89-4bf7-4c76-9206-102a3c4dea5d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("559c6d9f-1c6c-4d28-8a1f-f7cba459c43c"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c4576b4-d0b6-409b-a00c-371a84621349"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("5fdd4f2f-021a-44a3-8d8a-f069d1a8273d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("6f66163d-2216-4209-87e1-e3859165d37d"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("ea14c9db-2a5d-4e3b-9297-f5526a9f64de"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("feddc288-3702-4b93-8fa1-9cab60f3bd41"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a7383c9-a73b-43e4-b0ff-fe766764c15b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a4312c74-87c6-4bb6-ad6d-7cc43e30a64a"));

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("000bfe38-c230-45db-a072-9ba9febbb848"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1916055f-41aa-490c-bde2-2d5603833e56"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19833ab6-efa2-4564-b086-93d63c56f673"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("327b7fd6-625d-492f-8639-70a635856ef7"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("45a54225-4517-472c-802a-a9fca83a05c1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("7f622100-a378-483c-80f9-d495ee4bceca"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8c5bda9e-8afe-4445-b784-42400452c884"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("929c66a1-712d-4947-8d89-4641440877b4"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("acc56866-f457-461d-ad52-ffe917878ca8"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ae623b64-9078-4195-802a-25a7c1d95553"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d2cc7559-23de-4121-965a-9975e2010082"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("bb84982e-a25f-4573-8218-08f3174fd66d") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8") });

            migrationBuilder.DeleteData(
                table: "PermissionRoles",
                keyColumns: new[] { "PermissionEntityId", "RoleEntityId" },
                keyValues: new object[] { new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"), new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e") });

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("430b74f9-8911-4d0e-8608-8e29a2a2e4ef"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("57a9efc2-965f-48a9-bb51-5e440dcbf819"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("a2d90a47-f6dd-4a2b-884e-65926ca19693"));

            migrationBuilder.DeleteData(
                table: "PlatformEntities",
                keyColumn: "Id",
                keyValue: new Guid("e6f56830-89a6-421a-b69d-b425206f27c5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleEntityId", "UserEntityId" },
                keyValues: new object[] { new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"), new Guid("8397daf4-dea7-4213-b21b-877deff4815f") });

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("18a41ea9-fad2-4de1-8f68-60a78d9e8cc5"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("30b879a9-7384-4fad-b587-c05bbabfd859"));

            migrationBuilder.DeleteData(
                table: "GenreEntities",
                keyColumn: "Id",
                keyValue: new Guid("444e58d5-112d-466d-b6e7-42e3fb0c8fa3"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("000bfe38-c230-45db-a072-9ba9febbb848"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0050f796-4851-4aaf-b155-9fcc4071b37d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("02629ad8-2f54-4d41-b315-05db7d68ffaa"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("0c457a26-c64d-4dec-84bc-f110f21c08bf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("10c85c11-3657-4c94-9c4b-1fb4969f1376"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1916055f-41aa-490c-bde2-2d5603833e56"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("19833ab6-efa2-4564-b086-93d63c56f673"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("19f0b2ef-94e4-406b-aaad-98ff105c44ae"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d18e075-e678-4383-9a23-40d0f6ad0880"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d6d202f-4d5c-4ac0-a8c3-a9510cf2ce6d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1e52dd3a-2966-4730-ae2b-b76439c94390"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("1fda5f69-9654-409b-a866-4a71e58d551a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("222a11bc-c2aa-4534-8157-c013a5dfb953"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2a4926dc-8d17-4f68-bcd9-0dacfae23dd7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2f5a0b64-84ce-4ea2-afc8-fedcb7eb7585"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("2fef62f6-83cb-4b68-b36d-7f0f71ee8432"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("30eb284f-21a0-4ac5-88d1-41a6985e9a89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("327b7fd6-625d-492f-8639-70a635856ef7"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("38076470-8ecf-4a79-ace9-a53b7d291087"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d154db9-4373-4f68-9b66-543d7f322aa6"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("3e908c50-3f03-4ebb-be0b-0eea67451893"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("441dd084-cc69-41d7-8571-8cb4d1d72df5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("45a54225-4517-472c-802a-a9fca83a05c1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("4a6bbac4-a2cf-4da2-b6cc-f5185fdb71dc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5469d1d9-8fdb-4154-8db8-d0be23723a4d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("560e033f-da9d-43ff-b30e-b81d0c24fa75"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("57b3e7b1-3026-4ae8-82e3-72a6b804bafe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5971f5e6-bc4b-4a67-8a89-eae27d030c79"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5b6b2f52-7195-461e-b8e5-5c561fff97f0"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5cb73b7e-ef01-4bac-beb3-3410bc61a47e"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5d4cdd00-3135-4687-8175-a8df178e5465"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5e100f9a-1526-4159-8ba4-f80b3253c232"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("5f420b25-5022-4de9-bf6b-9ab4ff5aa6ee"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("65de5645-2c07-468c-bab8-7d5c550f06f2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6a8c84ef-e985-4d90-8e80-33a6514d22c5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6d78cf62-424a-40d0-9d02-ee7e8fd60e9f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("6ee237d9-a7f1-4fc1-809a-cecbb7c79775"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("724efae8-0be0-4d4c-bf64-5958dfdcb79d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("72bf1ed9-42b1-4476-be0a-d2080f3de649"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7885b43c-c317-4a03-942d-0f6d1a974567"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7c95e8d3-a4f2-46ec-9782-e4e25c0eb890"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7e05ff39-3dbe-49ff-8c9a-d742190150f5"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("7f622100-a378-483c-80f9-d495ee4bceca"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("87b64bd1-69ba-4fee-adea-9855a24280f1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8bd7f19a-6611-4fad-a6fd-942622e8cc2d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c5bda9e-8afe-4445-b784-42400452c884"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("8ea67597-46cf-4a57-b47c-260f22f21861"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("929c66a1-712d-4947-8d89-4641440877b4"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("945c1420-7957-4c3f-a048-86fcd5bd9a69"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9c92f711-d9f8-49e2-a45f-aac6aef0d215"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("9fc93f6f-b28a-4f96-9531-634b06e6663c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a52e6cba-033a-4c01-a024-449aedeaabbe"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("a54426cb-68f7-40c4-aa8d-fe4d8dfe8972"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ac0a438e-3d27-4d2d-abc7-4164663f5069"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("acc56866-f457-461d-ad52-ffe917878ca8"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae623b64-9078-4195-802a-25a7c1d95553"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bc770d13-3ae4-44a5-80e2-84ebdd65f8cc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("bfb48f78-e9ad-4280-8bf8-7447aaa34e46"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("c3203a3a-6a44-4692-a076-c90c55f5239d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cb5f1233-b249-4f52-a6ba-58f1fcb4e827"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("cd2737ba-1450-4fc0-b80f-afa2a67c3724"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d02e14f7-30a2-4871-b0dd-1c94ef6f314b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d2cc7559-23de-4121-965a-9975e2010082"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d49ae259-a911-45dc-b0ad-d68849507e89"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7434e17-1f20-4e6d-ab54-d737d41a4cf1"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d7ff7024-55bd-4be6-b076-31d29365d3cf"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d91c4669-ede8-4c3a-a6ae-b385aa29548f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("d96b8ee2-3973-4fba-a76d-5744302a745a"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("db65c394-b03b-433c-85ad-9bd561f46f5b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dc0bbbda-471e-4e2d-bfe2-4bfcd765bf72"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("dcfc5177-4e5d-46ad-8a6d-573a791d9027"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("df5d6c98-9012-4304-aec6-bbcaca37e726"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("e0eda51d-7a07-4636-89fe-08307618c0fb"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ef09642a-0915-4e3d-84c9-e974eb9c4934"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0810544-2767-4d4f-b681-7c553c25db1d"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f3f436df-af88-46c8-a91e-c77643b36ef2"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6374c48-03cc-4c69-ab03-679efa22d159"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6463eea-4006-41b4-8b9a-3860ff521b4c"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("f66155a5-dae8-4520-b4be-8ebdfaa5c66f"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fa89b268-f238-409d-87f7-e7e904a862fc"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fea20e11-28c7-4f12-9571-fdfd742bd0ed"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("fede7841-d7e9-40b3-918b-b5225e16734b"));

            migrationBuilder.DeleteData(
                table: "PermissionEntities",
                keyColumn: "Id",
                keyValue: new Guid("ff6ad393-ce27-45fe-9406-08202c0e9e45"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("8e7d902a-de57-4e38-8c6e-88b7d99267be"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("a3a6ee2a-b9e4-4fbb-9b99-4fc858bff676"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("bb84982e-a25f-4573-8218-08f3174fd66d"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("c0cd2910-42c2-483c-8c24-0d1d3ac0c4e8"));

            migrationBuilder.DeleteData(
                table: "RoleEntities",
                keyColumn: "Id",
                keyValue: new Guid("cf98bb7c-709f-4f6d-96b2-13a91fe57a2e"));

            migrationBuilder.DeleteData(
                table: "UserEntities",
                keyColumn: "Id",
                keyValue: new Guid("8397daf4-dea7-4213-b21b-877deff4815f"));

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
    }
}
