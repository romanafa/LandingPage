using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class SeedsGroupsAndTenants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_ApplicationUserId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ApplicationUserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Groups");

            migrationBuilder.CreateTable(
                name: "ApplicationUserGroup",
                columns: table => new
                {
                    GroupsGroupId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGroup", x => new { x.GroupsGroupId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGroup_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGroup_Groups_GroupsGroupId",
                        column: x => x.GroupsGroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "3b885f36-19e1-44b8-9e1c-55d27c0b24be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "82058e82-898c-488e-81e0-83405ef5ef92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "10c53881-4b1a-480b-a133-98b86894f493");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21a10ca5-be41-403b-84a8-281fc1504638", "AQAAAAEAACcQAAAAEC/avH8sIN3eTFNSNieyJzaCP8qx1byQ4YC8jc7qeEGYthSt6Wn7Iftoo95M9Jt2vg==", "a567b8d9-b12c-4f55-a3b9-e940be022e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "693ecd47-1c98-49fc-ad72-93e5b3327227", "AQAAAAEAACcQAAAAEBEJCpEirRKl1qRZYGXeIO5UtgG1gXpA1kd6JGjWHTLJDpzphgIv2X1VRhb8ZAtYBw==", "e6ac4d40-c6bb-45e4-a963-8b9349b1eb61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44aed22f-a9dd-4311-aa6a-bd528d65992b", "AQAAAAEAACcQAAAAEAgwQRFW8Jo50vuXyiCdL8VtIIwdC2Uy6EutMyx95UenS5vSq6rTYPgULcojQrF7Eg==", "04bc2a70-1767-4e26-b0c6-0f2b96b724a2" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "IsActiveGroup" },
                values: new object[,]
                {
                    { 3, "Group1", true },
                    { 4, "Group2", true },
                    { 5, "Group3", true }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantId", "GroupId", "IsActive", "TenantName", "Url" },
                values: new object[] { 1, 3, true, "Tenant1", "tenant1url.no/activate" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantId", "GroupId", "IsActive", "TenantName", "Url" },
                values: new object[] { 2, 3, true, "Tenant2", "tenant2url.no/activate" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantId", "GroupId", "IsActive", "TenantName", "Url" },
                values: new object[] { 3, 4, true, "Tenant3", "tenant3url.no/activate" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGroup_UsersId",
                table: "ApplicationUserGroup",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserGroup");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Groups",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "ae610229-e516-4553-a4b2-3f255571b80f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "d4a93381-fb5c-4b36-80a6-64ea83afe51c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "0d215a35-5d2a-41bf-a088-78ad26662538");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "748ad0b1-a98a-4463-82f2-581b9090edfe", "AQAAAAEAACcQAAAAENTGizLEDWDbzIbCvT06+Hftw6+lxuUA1SoXpMGnsH3LDz5VkxTwwVuZP4qTH6mBdA==", "5d862b4c-10c9-4250-bf41-425dca5d7b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b0583ae-f93b-4ba7-bc90-19bbb7ca6c9c", "AQAAAAEAACcQAAAAEGyauZyv1rG7vZcu5ecxTMLewsLUVN9sCZ1aQdv/1sKFuBWqF05m6pSZeXGKLrWI2Q==", "9d515619-3183-465b-87b3-5a1cdf6fe81b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8f2799f-1142-4a54-98c9-04f8fcb7d348", "AQAAAAEAACcQAAAAEIpQlQ9KHWjqnP/b+i/p53RoHyGL0eicm687RVJCzrmzi8bJUW64Za8pKfNc0H0iww==", "cbf50947-02be-45bb-8887-30fcf5b7c49a" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ApplicationUserId",
                table: "Groups",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_ApplicationUserId",
                table: "Groups",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
