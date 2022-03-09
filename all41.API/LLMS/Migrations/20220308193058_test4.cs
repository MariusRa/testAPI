using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Classrooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_UserId",
                table: "Classrooms",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Users_UserId",
                table: "Classrooms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Users_UserId",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Classrooms_UserId",
                table: "Classrooms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Classrooms");
        }
    }
}
