using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class AddCoursePriceTableAndMakeCoursePriceForeginKeyInCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursePriceId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CoursePrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePrice", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoursePriceId",
                table: "Courses",
                column: "CoursePriceId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Courses_CoursePrice_CoursePriceId",
            //    table: "Courses",
            //    column: "CoursePriceId",
            //    principalTable: "CoursePrice",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CoursePrice_CoursePriceId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CoursePrice");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CoursePriceId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursePriceId",
                table: "Courses");
        }
    }
}
