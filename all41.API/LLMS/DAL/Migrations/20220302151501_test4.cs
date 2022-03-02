using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "Approval",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approval",
                table: "Requests");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Requests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
