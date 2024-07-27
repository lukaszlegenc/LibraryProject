using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class AddingUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "33a49407-ecd2-41e9-af49-7b00bae3fe8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9",
                column: "ConcurrencyStamp",
                value: "b2c1890d-0ae2-49f5-ad29-b8c41bc014c2");
        }
    }
}
