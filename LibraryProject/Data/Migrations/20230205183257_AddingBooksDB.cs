using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class AddingBooksDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<Guid>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

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
        }
    }
}
