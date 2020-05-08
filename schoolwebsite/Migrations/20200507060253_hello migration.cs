using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class hellomigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studentdetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentsid = table.Column<int>(nullable: true),
                    Resultsid = table.Column<int>(nullable: true),
                    Subjectsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentdetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_Studentdetails_Results_Resultsid",
                        column: x => x.Resultsid,
                        principalTable: "Results",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Studentdetails_Students_Studentsid",
                        column: x => x.Studentsid,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Studentdetails_Subjects_Subjectsid",
                        column: x => x.Subjectsid,
                        principalTable: "Subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studentdetails_Resultsid",
                table: "Studentdetails",
                column: "Resultsid");

            migrationBuilder.CreateIndex(
                name: "IX_Studentdetails_Studentsid",
                table: "Studentdetails",
                column: "Studentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Studentdetails_Subjectsid",
                table: "Studentdetails",
                column: "Subjectsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentdetails");
        }
    }
}
