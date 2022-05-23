using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class SeedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "128f4ed6-c54d-4702-b3d7-e143a17c88fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "d29ef65c-a439-41d0-9d49-ddbd9f696013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "d90ce834-7c74-4299-92eb-506132e9d856");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e229e60-a76b-4088-a262-bfa9d8e1a6cd", "251f4897-1a0f-40a3-92b9-3179f280e1ff", "NewTenant", "NEWTENANT" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c00bd7a-858d-4d8c-8d85-a3427dad7a69", "AQAAAAEAACcQAAAAEOhD665HdtRHw3XUocMOovoavZKJ6x6HzCtjm9gpzk+eXOC4dtxNID+dpVivZyWJUw==", "5469f78d-3bfe-489e-9af1-ef589419a59c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e6ad1f-e42d-4356-aeb9-9e8951a3258f", "AQAAAAEAACcQAAAAECJmNWd0G/BRBKK0VkMyyXpKt6nnRPBFbVcAaKvJlTPUF3g8e7dGjioSIixYIoZOdA==", "0cab6d5c-91c3-473a-afb7-ab3e4a1d2dd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "689f9949-24fc-4e1c-bd97-efe970031df4", "AQAAAAEAACcQAAAAEFyxuN4qUqFBgtBSv+lFaiu2D6hnR6yf9nh72mVoHs6x29HrIx9YKCUAJkP2cuKxoA==", "26a2ec2a-43d7-4800-8b77-b24bbc09e4a8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd");

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
        }
    }
}
