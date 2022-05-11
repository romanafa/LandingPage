using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPage.API.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Groups_GroupId",
                table: "Tenants");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Groups_GroupId",
                table: "Tenants",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Groups_GroupId",
                table: "Tenants");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Tenants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Groups_GroupId",
                table: "Tenants",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId");
        }
    }
}
