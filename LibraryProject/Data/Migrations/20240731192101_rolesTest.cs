using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class rolesTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole<Guid>");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bdd04c0-5772-459d-a48b-b7459c75b531");

            migrationBuilder.DeleteData(
                table: "IdentityUserRole<Guid>",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6bdd04c0-5772-459d-a48b-b7459c75b531"), new Guid("b150b57e-9e94-4d1e-8e28-587614609a3c") });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d8ca72f-c02f-423b-bbff-2cba58622dc9", "a161cccd-009a-455e-8f91-a66ccd06765f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6c433051-111a-435b-adb9-798875f11984", 0, "622a4f28-bae9-4f7a-82c0-ea4ed3f1fe97", "admin@websiteadmin.com", true, false, null, null, "ADMIN@WEBSITEADMIN.COM", "AQAAAAEAACcQAAAAEPgKNfUKfkIzPYvMFoYHXqTi01IqWT70FzFyxKgOhWXtyq6wcw24sUpHXDpSgCYsXw==", null, false, "", false, "admin@websiteadmin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6c433051-111a-435b-adb9-798875f11984", "0d8ca72f-c02f-423b-bbff-2cba58622dc9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6c433051-111a-435b-adb9-798875f11984", "0d8ca72f-c02f-423b-bbff-2cba58622dc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d8ca72f-c02f-423b-bbff-2cba58622dc9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c433051-111a-435b-adb9-798875f11984");

            migrationBuilder.CreateTable(
                name: "IdentityRole<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<Guid>", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bdd04c0-5772-459d-a48b-b7459c75b531", 0, "7adf968a-03ce-459b-8dd0-44bbf589d025", "admin@websiteadmin.com", true, false, null, null, "ADMIN@WEBSITEADMIN.COM", "AQAAAAEAACcQAAAAENt97lxEEHOZ1MlTvE66rw85ZbMVqI8j4iGASLYSjoiEglVolOP5jHG1vmH5JrCJ5Q==", null, false, "", false, "admin@websiteadmin.com" });

            migrationBuilder.InsertData(
                table: "IdentityRole<Guid>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b150b57e-9e94-4d1e-8e28-587614609a3c"), "b530ff34-70b2-40f6-9fa2-9eef5b697cc7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityUserRole<Guid>",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("6bdd04c0-5772-459d-a48b-b7459c75b531"), new Guid("b150b57e-9e94-4d1e-8e28-587614609a3c") });
        }
    }
}
