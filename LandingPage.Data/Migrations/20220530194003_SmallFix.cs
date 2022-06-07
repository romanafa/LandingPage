using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class SmallFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "a7303827-59ab-44e8-9df4-da7f071f530b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "14e99c22-82c2-42fc-8f6f-0fd5e505b10f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "b9432e0e-7dd1-493e-ba6f-6989abaf8c30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "3f30da6f-d75f-4aa8-a389-ff999a82d8d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6389978c-b9a7-438b-85c4-98aaeb2fcad6", "AQAAAAEAACcQAAAAEIDUFK1t1R1eTaUU0KsLgt4uni0rInvmgXGucgWG7S+Kab7eR+TjEDNa4dPbQkiZzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81cd48ce-f5bb-4e05-983e-bdc0ccbb7e5e", "AQAAAAEAACcQAAAAEMM/SQbJj5BmDv6VVRfFBDucG5oPbHMH2PzOknJtnKInBZTqlZ+73/ZFQN3zwR6ngA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf134cbb-d3a2-416a-a49b-c707a98f334d", "AQAAAAEAACcQAAAAEJ1znqJd1H/ifNpsBSFPgbrEJVNiP8CZoJBnNDIua1kkMzMHgJ8ndv4tnJufqnFDbQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
