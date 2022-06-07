using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "e6c3991b-9f41-452e-b618-1977ff26397b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "7a8d850e-079c-4146-a13a-a4f1ba0a89d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "573dde34-8492-4beb-bde6-f1fb782064a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "9dfa02f9-d363-4803-9539-741988efe168");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5021aac-a1e3-4fb5-a31e-6e6ff0fc5d90", "AQAAAAEAACcQAAAAEBlWTOvkkZN2YHKipcBxR9nhZSR5GENTvm9ojoaJoCPO94lZuK5rq6jRsWaqXWrUEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e1580b3-85a0-4e05-b735-090439c5b5b7", "AQAAAAEAACcQAAAAEJ5yWygz+Ks+wFkSLa+WSLgUvEkTUzO8bwoJikrD9trvCPz8qEF2fz6WC/eK0s8+KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e416b8fd-e886-4acf-abe7-293288c02c73", "AQAAAAEAACcQAAAAEFVnQgjVkxElx3MtG9mR97RECciuldKl7F+Wbxd/SRpG2kJSqzq7vzpAdEwciTti+w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "860353ae-25eb-456c-8185-cd26199dc5cd", "AQAAAAEAACcQAAAAEF80Z9czoftpnycHpXovSO/9dySAC2beGt1D6Pb/866r0RSzE7ehAPVkrxD7kpYa7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c917de11-a6bc-44cf-bf94-163f31e13ed4", "AQAAAAEAACcQAAAAEI67DCLOIuWTV+2OmZsQbi5vxaL2ti+VZ71rhgKtIUEst9sOrhI1sz1fqkkil5j1yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7adb6da9-d16a-40a2-959a-15ec26621158", "AQAAAAEAACcQAAAAEF+j+KQv6Qd6Rknfq6pkICnGq/op00wQkKjKVtDSr49vKT/4oyr6eVtqYyOIKTsgrw==" });
        }
    }
}
