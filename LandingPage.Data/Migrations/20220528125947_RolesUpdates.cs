using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class RolesUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "a6f4cfb8-e7da-4602-a40a-812f65e29ade");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "24a989a8-02d9-4746-9b4e-16f4dae9ee3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "bd15f2c6-110b-491f-aef4-a2c3b38bdb4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "f9768ff6-5a92-4ef3-8031-291604447d06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "860353ae-25eb-456c-8185-cd26199dc5cd", "AQAAAAEAACcQAAAAEF80Z9czoftpnycHpXovSO/9dySAC2beGt1D6Pb/866r0RSzE7ehAPVkrxD7kpYa7Q==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c917de11-a6bc-44cf-bf94-163f31e13ed4", "AQAAAAEAACcQAAAAEI67DCLOIuWTV+2OmZsQbi5vxaL2ti+VZ71rhgKtIUEst9sOrhI1sz1fqkkil5j1yg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7adb6da9-d16a-40a2-959a-15ec26621158", "AQAAAAEAACcQAAAAEF+j+KQv6Qd6Rknfq6pkICnGq/op00wQkKjKVtDSr49vKT/4oyr6eVtqYyOIKTsgrw==", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
