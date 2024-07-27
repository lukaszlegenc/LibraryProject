using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class AddingEmployeeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c10ee8e7-7f03-4171-8f6a-885183a905b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ee4adbe-9108-47aa-8811-1b74f86895d0", "33a49407-ecd2-41e9-af49-7b00bae3fe8a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "999c3ec4-bb0c-4a97-ba9a-c17b119170f9", "b2c1890d-0ae2-49f5-ad29-b8c41bc014c2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "c10ee8e7-7f03-4171-8f6a-885183a905b6", "8f4bc119-59a7-44f8-bbc0-d0edf7f547fc", "Admin", "ADMIN" });
        }
    }
}
