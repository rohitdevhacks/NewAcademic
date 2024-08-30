using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicsWebsiteProject.Migrations
{
    /// <inheritdoc />
    public partial class mg24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink1 = table.Column<int>(type: "int", nullable: false),
                    VideoLink2 = table.Column<int>(type: "int", nullable: false),
                    VideoLink3 = table.Column<int>(type: "int", nullable: false),
                    VideoLink4 = table.Column<int>(type: "int", nullable: false),
                    VideoLink5 = table.Column<int>(type: "int", nullable: false),
                    VideoLink6 = table.Column<int>(type: "int", nullable: false),
                    VideoLink7 = table.Column<int>(type: "int", nullable: false),
                    VideoLink8 = table.Column<int>(type: "int", nullable: false),
                    VideoLink9 = table.Column<int>(type: "int", nullable: false),
                    VideoLink10 = table.Column<int>(type: "int", nullable: false),
                    VideoLink11 = table.Column<int>(type: "int", nullable: false),
                    VideoLink12 = table.Column<int>(type: "int", nullable: false),
                    VideoLink13 = table.Column<int>(type: "int", nullable: false),
                    VideoLink14 = table.Column<int>(type: "int", nullable: false),
                    VideoLink15 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addCourse", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addCourse");
        }
    }
}
