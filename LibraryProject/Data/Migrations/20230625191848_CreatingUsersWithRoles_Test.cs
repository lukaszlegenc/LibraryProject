using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class CreatingUsersWithRoles_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37195133-ba06-40b6-b1a7-c8cea8b8fa44", "1ee4adbe-9108-47aa-8811-1b74f86895d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e2638eb-1232-4751-bc38-3a38e8430d33", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("19dcd87e-9dc9-44e6-94d0-954e000ad645"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("b281aec3-4f2c-43df-be58-44dbe6eea2f0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee4adbe-9108-47aa-8811-1b74f86895d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "739e4171-454f-4c34-a9c7-cbc2e5fff3b2", "f2bbfc76-469b-48c9-ba13-05ed70f6a411", "Admin", "ADMIN" },
                    { "1b7ef68f-6306-4358-961d-14fe44f7e472", "358501b9-86c9-4b40-8a6e-eee1266f7dee", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c7087a64-0f2b-45c9-9027-5a917481dc49", 0, "2e85e6af-05ad-4d11-920d-e350c0535a05", "admin@websiteadmin.com", true, true, null, null, "ADMIN@WEBSITEADMIN.COM", "AQAAAAEAACcQAAAAEI/tEodNZh5k32ypJIqfYBb453glQZtDdNsaUfK8H+3ZwOgedKOjoJNVOm1vHsg3PQ==", null, false, "PJT225JMNX52X76CTIHQAECWQ6OTUPLN", false, "admin@websiteadmin.com" },
                    { "da272db6-4319-409c-a638-b59eb38c0bdc", 0, "2d98871a-c656-4ea6-8545-e015a7cb7a6d", "employee@websiteemployee.com", true, true, null, null, "EMPLOYEE@WEBSITEEMPLOYEE.COM", "AQAAAAEAACcQAAAAEALKqgsJS/svrlZECuMjOBmV52/DPzF5sbccfyHNpOn6qzFRPJl9KJDdzXBvZwjWsg==", null, false, "MHCYXXHRGO2UODBVZFASZDAHCW5ZQ2LO", false, "employee@websiteemployee.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c7087a64-0f2b-45c9-9027-5a917481dc49", "739e4171-454f-4c34-a9c7-cbc2e5fff3b2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "da272db6-4319-409c-a638-b59eb38c0bdc", "1b7ef68f-6306-4358-961d-14fe44f7e472" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c7087a64-0f2b-45c9-9027-5a917481dc49", "739e4171-454f-4c34-a9c7-cbc2e5fff3b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "da272db6-4319-409c-a638-b59eb38c0bdc", "1b7ef68f-6306-4358-961d-14fe44f7e472" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b7ef68f-6306-4358-961d-14fe44f7e472");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "739e4171-454f-4c34-a9c7-cbc2e5fff3b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7087a64-0f2b-45c9-9027-5a917481dc49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da272db6-4319-409c-a638-b59eb38c0bdc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ee4adbe-9108-47aa-8811-1b74f86895d0", "32dd7aa9-27d6-4833-b42e-0c5b5344ba07", "Admin", "ADMIN" },
                    { "999c3ec4-bb0c-4a97-ba9a-c17b119170f9", "71d4e2da-09fe-4fb0-9fe4-91271f44e535", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "ImgPath", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("b281aec3-4f2c-43df-be58-44dbe6eea2f0"), "Henryk Sienkiewicz", "Description", "asd", 20.5, "W pustyni i w puszczy" },
                    { new Guid("19dcd87e-9dc9-44e6-94d0-954e000ad645"), "Stanisław Wyspiański", "Description", "asd", 30.5, "Wesele" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "37195133-ba06-40b6-b1a7-c8cea8b8fa44", "1ee4adbe-9108-47aa-8811-1b74f86895d0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e2638eb-1232-4751-bc38-3a38e8430d33", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" });
        }
    }
}
