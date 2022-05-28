using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupTenant_Groups_GroupId",
                table: "GroupTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupTenant_Tenants_TenantId",
                table: "GroupTenant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupTenant",
                table: "GroupTenant");

            migrationBuilder.RenameTable(
                name: "GroupTenant",
                newName: "GroupTenants");

            migrationBuilder.RenameIndex(
                name: "IX_GroupTenant_TenantId",
                table: "GroupTenants",
                newName: "IX_GroupTenants_TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupTenants",
                table: "GroupTenants",
                columns: new[] { "GroupId", "TenantId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "ef4651e4-582c-476a-a3c7-15e0a0dc3bc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "e69ff015-cdf8-4f80-85d6-dc7dff90a081");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "905e435a-b04b-495a-9738-82824c9194ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "5d2da787-eb61-4d04-b967-0fbb95c94555");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b213add4-67aa-4c8d-94f3-1d9ea8f44d93", "AQAAAAEAACcQAAAAEFN9rCapHLLmdAcsxLz//qKOqHVYQppUXQxfK71cdl9N73Z9pUXgrBeeVkWOqms5Mw==", "07a8ba5a-46ef-4d87-8312-b0bd2685baca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5fc0c1f-afbc-4899-8a6d-94def56b276b", "AQAAAAEAACcQAAAAEOErS6iifK4YfGKTkky8BGgWfJrXBBD8USkaiVOaHXZVj7fDdvhntuWPS8VYmDNV1A==", "5937256b-2640-4997-b049-45b03f69e0e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db9551e1-2ff9-443e-bf6d-858f8ba8fd46", "AQAAAAEAACcQAAAAEPttdjNrhlAfh00/wAzEnZBiy+QO+KVo4+6MzJ5UCmOamsgBnQtJS06MBJviES3/eA==", "d667427d-0c3c-4745-81f1-590426fe9bc6" });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupTenants_Groups_GroupId",
                table: "GroupTenants",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupTenants_Tenants_TenantId",
                table: "GroupTenants",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "TenantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupTenants_Groups_GroupId",
                table: "GroupTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupTenants_Tenants_TenantId",
                table: "GroupTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupTenants",
                table: "GroupTenants");

            migrationBuilder.RenameTable(
                name: "GroupTenants",
                newName: "GroupTenant");

            migrationBuilder.RenameIndex(
                name: "IX_GroupTenants_TenantId",
                table: "GroupTenant",
                newName: "IX_GroupTenant_TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupTenant",
                table: "GroupTenant",
                columns: new[] { "GroupId", "TenantId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "c0d2da19-7000-41c9-9ad6-65008a73cec3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "89641299-78f4-4917-9de5-008aa4c4d84b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "66e2689b-92aa-4a47-ba27-4e4b5eb5484e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "f6214a44-e61e-4759-825d-80bba88aeadb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a83588-5026-4a75-a21d-90b7ca185e5b", "AQAAAAEAACcQAAAAEPYawO0l3jyF3TJpTD0U0NZ/WfU9lvgAitJn/Lt4bY5V6r48az3EN8oc1HjlJQlsNg==", "10570f9f-49ed-4539-80dd-2ed57f6d3a38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab7d8b8-86c3-41fb-bc78-3789aa93d8fb", "AQAAAAEAACcQAAAAEHk3oq/GNSaJOfZz/mGllVSIqYZXN6PWi+dEJoe9Jggvu7AO4APdqSNzYN73qLdYxA==", "8bdce654-ddd6-4b38-ac79-c1c3872ddcc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cefd343-ac11-4e0d-84f6-09ae40c42d75", "AQAAAAEAACcQAAAAEMLjSULCjIyzxRJ1zIE/xqP3Wq82/UsY9VNHS1Efqn6/4hLnMGjhQa3QWAODNFJyng==", "50dbb2af-170c-4b23-8ce4-a0cad9b7982f" });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupTenant_Groups_GroupId",
                table: "GroupTenant",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupTenant_Tenants_TenantId",
                table: "GroupTenant",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "TenantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
