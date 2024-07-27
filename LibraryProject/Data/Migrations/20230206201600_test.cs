using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("9a6213c9-658e-4dca-810d-ea357f5be86c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("ef9d58f0-5418-4649-a422-f056cb9b0f95"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee4adbe-9108-47aa-8811-1b74f86895d0",
                column: "ConcurrencyStamp",
                value: "32dd7aa9-27d6-4833-b42e-0c5b5344ba07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9",
                column: "ConcurrencyStamp",
                value: "71d4e2da-09fe-4fb0-9fe4-91271f44e535");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "ImgPath", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("b281aec3-4f2c-43df-be58-44dbe6eea2f0"), "Henryk Sienkiewicz", "Description", "asd", 20.5, "W pustyni i w puszczy" },
                    { new Guid("19dcd87e-9dc9-44e6-94d0-954e000ad645"), "Stanisław Wyspiański", "Description", "asd", 30.5, "Wesele" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("19dcd87e-9dc9-44e6-94d0-954e000ad645"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("b281aec3-4f2c-43df-be58-44dbe6eea2f0"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee4adbe-9108-47aa-8811-1b74f86895d0",
                column: "ConcurrencyStamp",
                value: "8b9d55d3-a895-4db5-a647-484473b9f306");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c3ec4-bb0c-4a97-ba9a-c17b119170f9",
                column: "ConcurrencyStamp",
                value: "f291bbf2-4d92-469b-ad92-9b5676d496d1");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "ImgPath", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("9a6213c9-658e-4dca-810d-ea357f5be86c"), "Henryk Sienkiewicz", "Description", "asd", 20.5, "W pustyni i w puszczy" },
                    { new Guid("ef9d58f0-5418-4649-a422-f056cb9b0f95"), "Stanisław Wyspiański", "Description", "asd", 30.5, "Wesele" }
                });
        }
    }
}
