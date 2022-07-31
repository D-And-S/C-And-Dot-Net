using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class RenameTitleToNameInCourseTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("Update Courses Set Name=Title");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.Sql("Update Courses Set Title=Name");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Courses");
        }
    }
}
