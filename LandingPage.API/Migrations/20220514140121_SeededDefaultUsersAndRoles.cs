using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "ae610229-e516-4553-a4b2-3f255571b80f", "Merchant", "MERCHANT" },
                    { "a998f9ea-d2ef-4835-8744-590e2f4157eb", "d4a93381-fb5c-4b36-80a6-64ea83afe51c", "Admin", "ADMIN" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "0d215a35-5d2a-41bf-a088-78ad26662538", "Tenant", "TENANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb", 0, "748ad0b1-a98a-4463-82f2-581b9090edfe", "merchant@merchant.com", false, "Forhandler", true, "Bruker", false, null, "MERCHANT@MERCHANT.COM", "MERCHANT@MERCHANT.COM", "AQAAAAEAACcQAAAAENTGizLEDWDbzIbCvT06+Hftw6+lxuUA1SoXpMGnsH3LDz5VkxTwwVuZP4qTH6mBdA==", null, false, "5d862b4c-10c9-4250-bf41-425dca5d7b68", false, "merchant@merchant.com" },
                    { "e20119f7-b5cb-43b3-8183-3f814334b160", 0, "6b0583ae-f93b-4ba7-bc90-19bbb7ca6c9c", "tenant@tenant.no", false, "Tenant", true, "Bruker", false, null, "TENANT@TENANT.NO", "TENANT@TENANT.NO", "AQAAAAEAACcQAAAAEGyauZyv1rG7vZcu5ecxTMLewsLUVN9sCZ1aQdv/1sKFuBWqF05m6pSZeXGKLrWI2Q==", null, false, "9d515619-3183-465b-87b3-5a1cdf6fe81b", false, "tenant@tenant.no" },
                    { "e9caf277-b4f7-48d9-a97f-c2533e6adbe3", 0, "d8f2799f-1142-4a54-98c9-04f8fcb7d348", "admin@admin.no", false, "Admin", true, "Bruker", false, null, "ADMIN@ADMIN.NO", "ADMIN@ADMIN.NO", "AQAAAAEAACcQAAAAEIpQlQ9KHWjqnP/b+i/p53RoHyGL0eicm687RVJCzrmzi8bJUW64Za8pKfNc0H0iww==", null, false, "cbf50947-02be-45bb-8887-30fcf5b7c49a", false, "admin@admin.no" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "e20119f7-b5cb-43b3-8183-3f814334b160" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a998f9ea-d2ef-4835-8744-590e2f4157eb", "e9caf277-b4f7-48d9-a97f-c2533e6adbe3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "e20119f7-b5cb-43b3-8183-3f814334b160" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a998f9ea-d2ef-4835-8744-590e2f4157eb", "e9caf277-b4f7-48d9-a97f-c2533e6adbe3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3");
        }
    }
}
