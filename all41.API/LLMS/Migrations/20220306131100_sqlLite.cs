using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class sqlLite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_RequestorUserId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "RequestorUserId",
                table: "Requests",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_RequestorUserId",
                table: "Requests",
                newName: "IX_Requests_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Requests",
                newName: "RequestorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                newName: "IX_Requests_RequestorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_RequestorUserId",
                table: "Requests",
                column: "RequestorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
