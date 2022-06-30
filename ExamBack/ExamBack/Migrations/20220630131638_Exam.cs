using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamBack.Migrations
{
    public partial class Exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Twitter = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
