using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_LearningLanguages_LanguageId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_LearningSemesters_SemesterId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_LearningTargets_TargetId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_LanguageId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_SemesterId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_TargetId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Student",
                table: "Requests",
                newName: "Target");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Target",
                table: "Requests",
                newName: "Student");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LanguageId",
                table: "Requests",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SemesterId",
                table: "Requests",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TargetId",
                table: "Requests",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_LearningLanguages_LanguageId",
                table: "Requests",
                column: "LanguageId",
                principalTable: "LearningLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_LearningSemesters_SemesterId",
                table: "Requests",
                column: "SemesterId",
                principalTable: "LearningSemesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_LearningTargets_TargetId",
                table: "Requests",
                column: "TargetId",
                principalTable: "LearningTargets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
