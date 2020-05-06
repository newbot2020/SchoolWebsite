using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class indentityuserclasshasbeenadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentsID = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Exam = table.Column<string>(nullable: true),
                    Subject1 = table.Column<string>(nullable: true),
                    Subject2 = table.Column<string>(nullable: true),
                    Subject3 = table.Column<string>(nullable: true),
                    Subject4 = table.Column<string>(nullable: true),
                    Subject5 = table.Column<string>(nullable: true),
                    Subject6 = table.Column<string>(nullable: true),
                    Subject7 = table.Column<string>(nullable: true),
                    Subject8 = table.Column<string>(nullable: true),
                    Subject9 = table.Column<string>(nullable: true),
                    Subject10 = table.Column<string>(nullable: true),
                    Subject11 = table.Column<string>(nullable: true),
                    Subject12 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_Subjects_Students_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentsID",
                table: "Subjects",
                column: "StudentsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
