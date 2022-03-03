using Microsoft.EntityFrameworkCore.Migrations;

namespace LLMS.Migrations
{
    public partial class defaultUserAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserEmail", "UserName", "UserRole" },
                values: new object[] { "fd262146-b53c-47b3-afc2-6484643c68d1", "admin.test@kitm.lt", "Admin Akademija IT test", "Coordinator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "fd262146-b53c-47b3-afc2-6484643c68d1");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Users");
        }
    }
}
