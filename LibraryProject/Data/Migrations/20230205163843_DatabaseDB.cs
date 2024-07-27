using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class DatabaseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1d1d8404-86fc-4d58-981e-30245dfe6ef8", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dde09624-7324-4c10-aa86-9ae1e2877569", "1ee4adbe-9108-47aa-8811-1b74f86895d0" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee4adbe-9108-47aa-8811-1b74f86895d0",
                column: "ConcurrencyStamp",
                value: "e2694601-0148-4782-b0e4-c3f8ee29e82a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9",
                column: "ConcurrencyStamp",
                value: "ecf0961d-0e68-4548-aa6a-edbbe3466059");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "37195133-ba06-40b6-b1a7-c8cea8b8fa44", "1ee4adbe-9108-47aa-8811-1b74f86895d0" },
                    { "8e2638eb-1232-4751-bc38-3a38e8430d33", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37195133-ba06-40b6-b1a7-c8cea8b8fa44", "1ee4adbe-9108-47aa-8811-1b74f86895d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e2638eb-1232-4751-bc38-3a38e8430d33", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee4adbe-9108-47aa-8811-1b74f86895d0",
                column: "ConcurrencyStamp",
                value: "97538c36-3ad3-4cd2-b70a-9c96a6e919b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9",
                column: "ConcurrencyStamp",
                value: "b2548702-9cc8-4dbb-871a-09a17d235c5b");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "dde09624-7324-4c10-aa86-9ae1e2877569", "1ee4adbe-9108-47aa-8811-1b74f86895d0" },
                    { "1d1d8404-86fc-4d58-981e-30245dfe6ef8", "999c3ec4-bb0c-4a97-ba9a-c17b119170f9" }
                });
        }
    }
}
