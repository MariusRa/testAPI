using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class _1try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LearningLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningSemesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningSemesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningTargets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Student = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    TargetId = table.Column<int>(type: "int", nullable: true),
                    SemesterId = table.Column<int>(type: "int", nullable: true),
                    CostCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_LearningLanguages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "LearningLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_LearningSemesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "LearningSemesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_LearningTargets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "LearningTargets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Users_RequestorUserId",
                        column: x => x.RequestorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LanguageId",
                table: "Requests",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestorUserId",
                table: "Requests",
                column: "RequestorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SemesterId",
                table: "Requests",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TargetId",
                table: "Requests",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "LearningLanguages");

            migrationBuilder.DropTable(
                name: "LearningSemesters");

            migrationBuilder.DropTable(
                name: "LearningTargets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
