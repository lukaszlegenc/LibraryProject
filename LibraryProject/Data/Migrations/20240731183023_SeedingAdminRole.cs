using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class SeedingAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityRole<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<Guid>",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<Guid>", x => new { x.UserId, x.RoleId });
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole<Guid>");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<Guid>");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bdd04c0-5772-459d-a48b-b7459c75b531");

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
    }
}
