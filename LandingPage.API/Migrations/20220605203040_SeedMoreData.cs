using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class SeedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20119f7-b5cb-43b3-8183-3f814334b160");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e229e60-a76b-4088-a262-bfa9d8e1a6cd",
                column: "ConcurrencyStamp",
                value: "594892c6-7219-4133-a3b5-9c65f2882d6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6115c-a79d-444a-b92a-2f4496e2f175",
                column: "ConcurrencyStamp",
                value: "9fc8f25a-6168-49de-b600-f8dfb1132ece");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a998f9ea-d2ef-4835-8744-590e2f4157eb",
                column: "ConcurrencyStamp",
                value: "31a59e00-9c75-4aba-b898-2edabe7bc1a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebef473b-b328-426b-b5b7-40008974384c",
                column: "ConcurrencyStamp",
                value: "e47025d4-4088-41a2-a0ed-8f613babd585");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b575d83e-27e5-4f5e-8a3d-a607a5bdc0fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b469786-18df-4605-bf7e-548fd36fbaff", "AQAAAAEAACcQAAAAEN9amndl9Y3N6I4Otp6ZMbrb5zxi9aJPR0DcY3jvrgrgnAME+tKEySKHUuNPvBBHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c75e011-091b-42b5-be46-1b827205d389", "AQAAAAEAACcQAAAAEEmWgppdH/Qz88i5pd6xmkkrMfTCqyxaPzWYUklDHthcW+lZn6RropX1Bp9Shk41PA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e3aef22-513f-4e24-90d8-c41beb1e8942", 0, "7753487c-06af-4a17-9944-3a2cd328ebe8", "tenant2@tenant.no", false, "Tenant2", false, "Bruker2", false, null, "TENANT2@TENANT.NO", "TENANT2@TENANT.NO", "AQAAAAEAACcQAAAAECrMz3TC9HQagMxJaa+ApVcffcaNhUdJ1I9h6Xk4yr84ZCAtPdwZ8vRGKtyYbbxKpw==", null, false, "356abc0a-28f3-44ac-8fa9-d6d9779e9c3f", false, "tenant2@tenant.no" },
                    { "10baaefa-d3f0-45a5-a348-ac991898e3fe", 0, "4eab71bb-7b22-4fb1-a693-2b136b960f53", "kari@tenant.no", false, "Kari", false, "Nordmann", false, null, "KARI@TENANT.NO", "KARI@TENANT.NO", "AQAAAAEAACcQAAAAEMIVVwq9inpKvXMcKfkLoAOrvGKvoPvwhCc6S95l9dFbr5nh8voiiV+Ttmo2EZkw0A==", null, false, null, false, "kari@tenant.no" },
                    { "1273ff89-5875-4e1f-944c-dfc2223b06e9", 0, "6f35e961-5c74-441f-841c-c46001ff2cf0", "tenant5@tenant.no", false, "Tenant5", true, "Bruker5", false, null, "TENANT5@TENANT.NO", "TENANT5@TENANT.NO", "AQAAAAEAACcQAAAAEHJNhS1hABopDIcyuYuSVxUx9lz1/nFupJQIC+JL+Xt/wJlMNJ2wZC2SrPzBUn203Q==", null, false, "8ec2092b-8022-4edc-b8de-4b9c76ad47b1", false, "tenant5@tenant.no" },
                    { "20f6ed72-6071-4ca2-be2d-caff78a84edd", 0, "cbc4f11c-c961-484d-99c4-8cfb621e820c", "tenant7@tenant.no", false, "Tenant7", true, "Bruker7", false, null, "TENANT7@TENANT.NO", "TENANT7@TENANT.NO", "AQAAAAEAACcQAAAAEF7ioi2mNnDL1uek8u2JoiTC7o14QnOWWHO43xR5PZKuxdmjw5y0wyFFXIbm1mgRBw==", null, false, "ddaf48dd-74bb-4317-be0c-8cd1bec6ae61", false, "tenant7@tenant.no" },
                    { "2dd414a1-2be5-4896-ad64-d6012f06505d", 0, "68d306ab-e13d-4e94-bf71-b4270ffc9946", "tenant6@tenant.no", false, "Tenant6", true, "Bruker6", false, null, "TENANT6@TENANT.NO", "TENANT6@TENANT.NO", "AQAAAAEAACcQAAAAEPrqBmXHltwgOky/CnzUSMzKhe3pxwerjqyYwF7XTuvAS0aZrRQpA+53VcGfJoqSJQ==", null, false, "cfb1ff6f-1677-4e95-b038-7af2dba6f71e", false, "tenant6@tenant.no" },
                    { "3f391255-44a0-49d6-803c-555296633ed1", 0, "21d46d36-c741-4896-a6ec-92217b937a9a", "tenant4@tenant.no", false, "Tenant4", true, "Bruker4", false, null, "TENANT4@TENANT.NO", "TENANT4@TENANT.NO", "AQAAAAEAACcQAAAAELbgJ7iLwRlPB25x3sguiqcSTzH0nkeyjtASklUf9fVcTFUe2p9FJYefOMlGLC22Rw==", null, false, "0a256f91-7c17-49b1-9d50-fd332ea09be5", false, "tenant4@tenant.no" },
                    { "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b", 0, "eb9eb0db-f5fb-46f6-93a6-f2ccd5bfb6f1", "tenant12@tenant.no", false, "Tenant12", false, "Bruker12", false, null, "TENANT12@TENANT.NO", "TENANT12@TENANT.NO", "AQAAAAEAACcQAAAAEA/0iQjHjU7gHMeAGj4n5JUMRnt43WfVVWFYJsapEAzaEgmTYaIQb0IP6jjJP2LvyA==", null, false, "ded2a439-57fa-4b52-8a39-5e00962553fa", false, "tenant12@tenant.no" },
                    { "9a48960c-57c6-4577-a926-5cd8e0e7478c", 0, "8dcf018b-35aa-458f-bc3c-42fa1e2639da", "tenant3@tenant.no", false, "Tenant3", true, "Bruker3", false, null, "TENANT3@TENANT.NO", "TENANT3@TENANT.NO", "AQAAAAEAACcQAAAAEIo5b012BefLNcoqP66PlPe6yQYa6taPwsH6Y4eROEdblXhC6nOg2fhQgLT3RFOTzA==", null, false, "2f9dc137-0f0e-4ecb-8fc9-e7934bc18d1e", false, "tenant3@tenant.no" },
                    { "ae4cf9c8-69fb-48fc-9845-e96402dc5647", 0, "e49b3a4c-14ae-4346-8376-032c8442b321", "tenant9@tenant.no", false, "Tenant9", true, "Bruker9", false, null, "TENANT9@TENANT.NO", "TENANT9@TENANT.NO", "AQAAAAEAACcQAAAAEGZrFFrCpfadS7/KNIykrTyYyLoo6c/Z8R41NvIVlTx8LJDykGqswYpxtW6DRdSKCw==", null, false, "57da4253-ce54-4b55-a784-a4f94c5e0447", false, "tenant9@tenant.no" },
                    { "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1", 0, "b7a00bcd-9524-4540-be54-eb17c2f70786", "tenant10@tenant.no", false, "Tenant10", true, "Bruker10", false, null, "TENANT10@TENANT.NO", "TENANT10@TENANT.NO", "AQAAAAEAACcQAAAAEO0y64sYpk5lv55cmkWDve+yUdoGi7hjiwU79pF610oCgypizpLmcsEp4j0GUATrFw==", null, false, "bf9103a8-57ef-4684-8aa8-25c7af4a4f00", false, "tenant10@tenant.no" },
                    { "becb3779-8931-4068-ac03-28ccf509db3d", 0, "2ef0a5a0-62b2-4c16-93b0-b2cd683ca8c3", "tenant11@tenant.no", false, "Tenant11", false, "Bruker11", false, null, "TENANT11@TENANT.NO", "TENANT11@TENANT.NO", "AQAAAAEAACcQAAAAEF/ZezIuEyHGkf9f2pvJNR0qp9fLBVdK1e+M7ZTUyyjGu4rhgYLxry9wfIpJQH2eBg==", null, false, "05900cca-74df-4f0f-b36f-806fe539568c", false, "tenant11@tenant.no" },
                    { "cc3eafff-5099-405e-b73e-b8a2da435e7d", 0, "68b737b3-716e-4540-b6c4-31bd07e7d9c6", "tenant8@tenant.no", false, "Tenant8", true, "Bruker8", false, null, "TENANT8@TENANT.NO", "TENANT8@TENANT.NO", "AQAAAAEAACcQAAAAENoUoQUYXOFuG1icMFfbww/+fQwwHAwAy6A9HdLONPxrKt0rzq0Ohph5uZCc6pb+5g==", null, false, "eb173e2e-4f68-4bdb-a26d-321e54e77c2c", false, "tenant8@tenant.no" },
                    { "cdf19c52-c8f0-4207-a682-36bbc27930fd", 0, "5ec25aaa-11cf-423e-b585-1927ea63b764", "ola@forhandler.no", false, "Ola", true, "Nordmann", false, null, "OLA@FORHANDLER.NO", "OLA@FORHANDLER.NO", "AQAAAAEAACcQAAAAEO5dtGast5ovbdT9wS6eNtoAsEiYD6/hLuM64W57TOBwKt5I/QrdnuPQGcU6eRskXQ==", null, false, "60855191-ab42-4930-964c-e50033193198", false, "ola@forhandler.no" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "IsActiveGroup" },
                values: new object[,]
                {
                    { 10, "Group10", false },
                    { 11, "Group11", true },
                    { 12, "Group12", true },
                    { 13, "Group13", false },
                    { 14, "Group14", true },
                    { 15, "Group15", true },
                    { 16, "Group16", true }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantId", "IsActive", "TenantName", "Url" },
                values: new object[,]
                {
                    { 8, true, "Tenant8", "tenant8url.no/activate" },
                    { 9, true, "Tenant9", "tenant9url.no/activate" },
                    { 10, false, "Tenant10", "tenant10url.no/activate" },
                    { 11, false, "Tenant11", "tenant11url.no/activate" },
                    { 12, true, "Tenant12", "tenant12url.no/activate" },
                    { 13, true, "Tenant13", "tenant13url.no/activate" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebef473b-b328-426b-b5b7-40008974384c", "0e3aef22-513f-4e24-90d8-c41beb1e8942" },
                    { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "10baaefa-d3f0-45a5-a348-ac991898e3fe" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "1273ff89-5875-4e1f-944c-dfc2223b06e9" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "20f6ed72-6071-4ca2-be2d-caff78a84edd" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "2dd414a1-2be5-4896-ad64-d6012f06505d" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "3f391255-44a0-49d6-803c-555296633ed1" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "9a48960c-57c6-4577-a926-5cd8e0e7478c" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "ae4cf9c8-69fb-48fc-9845-e96402dc5647" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "becb3779-8931-4068-ac03-28ccf509db3d" },
                    { "ebef473b-b328-426b-b5b7-40008974384c", "cc3eafff-5099-405e-b73e-b8a2da435e7d" },
                    { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "cdf19c52-c8f0-4207-a682-36bbc27930fd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "0e3aef22-513f-4e24-90d8-c41beb1e8942" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "10baaefa-d3f0-45a5-a348-ac991898e3fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "1273ff89-5875-4e1f-944c-dfc2223b06e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "20f6ed72-6071-4ca2-be2d-caff78a84edd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "2dd414a1-2be5-4896-ad64-d6012f06505d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "3f391255-44a0-49d6-803c-555296633ed1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "9a48960c-57c6-4577-a926-5cd8e0e7478c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "ae4cf9c8-69fb-48fc-9845-e96402dc5647" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "becb3779-8931-4068-ac03-28ccf509db3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebef473b-b328-426b-b5b7-40008974384c", "cc3eafff-5099-405e-b73e-b8a2da435e7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5c6115c-a79d-444a-b92a-2f4496e2f175", "cdf19c52-c8f0-4207-a682-36bbc27930fd" });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e3aef22-513f-4e24-90d8-c41beb1e8942");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10baaefa-d3f0-45a5-a348-ac991898e3fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1273ff89-5875-4e1f-944c-dfc2223b06e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20f6ed72-6071-4ca2-be2d-caff78a84edd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dd414a1-2be5-4896-ad64-d6012f06505d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f391255-44a0-49d6-803c-555296633ed1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c3ff3ae-f201-4189-a082-9e3bf7bb6e8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a48960c-57c6-4577-a926-5cd8e0e7478c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae4cf9c8-69fb-48fc-9845-e96402dc5647");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b99dd035-d9b7-4fe6-ac8c-bdbfb94224d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "becb3779-8931-4068-ac03-28ccf509db3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3eafff-5099-405e-b73e-b8a2da435e7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdf19c52-c8f0-4207-a682-36bbc27930fd");

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
                keyValue: "e9caf277-b4f7-48d9-a97f-c2533e6adbe3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf134cbb-d3a2-416a-a49b-c707a98f334d", "AQAAAAEAACcQAAAAEJ1znqJd1H/ifNpsBSFPgbrEJVNiP8CZoJBnNDIua1kkMzMHgJ8ndv4tnJufqnFDbQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e20119f7-b5cb-43b3-8183-3f814334b160", 0, "81cd48ce-f5bb-4e05-983e-bdc0ccbb7e5e", "tenant@tenant.no", false, "Tenant", true, "Bruker", false, null, "TENANT@TENANT.NO", "TENANT@TENANT.NO", "AQAAAAEAACcQAAAAEMM/SQbJj5BmDv6VVRfFBDucG5oPbHMH2PzOknJtnKInBZTqlZ+73/ZFQN3zwR6ngA==", null, false, null, false, "tenant@tenant.no" });
        }
    }
}
