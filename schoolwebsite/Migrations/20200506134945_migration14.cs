using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_StudentsID",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "StudentsID",
                table: "Subjects",
                newName: "Studentsid");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_StudentsID",
                table: "Subjects",
                newName: "IX_Subjects_Studentsid");

            migrationBuilder.AlterColumn<int>(
                name: "Studentsid",
                table: "Subjects",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentsid = table.Column<int>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    Result1 = table.Column<string>(nullable: true),
                    Result2 = table.Column<string>(nullable: true),
                    Result3 = table.Column<string>(nullable: true),
                    Result4 = table.Column<string>(nullable: true),
                    Result5 = table.Column<string>(nullable: true),
                    Result6 = table.Column<string>(nullable: true),
                    Result7 = table.Column<string>(nullable: true),
                    Result8 = table.Column<string>(nullable: true),
                    Result9 = table.Column<string>(nullable: true),
                    Result10 = table.Column<string>(nullable: true),
                    Result11 = table.Column<string>(nullable: true),
                    Result12 = table.Column<string>(nullable: true),
                    Subjectsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.id);
                    table.ForeignKey(
                        name: "FK_Results_Students_Studentsid",
                        column: x => x.Studentsid,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Subjects_Subjectsid",
                        column: x => x.Subjectsid,
                        principalTable: "Subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_Studentsid",
                table: "Results",
                column: "Studentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Results_Subjectsid",
                table: "Results",
                column: "Subjectsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_Studentsid",
                table: "Subjects",
                column: "Studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Students_Studentsid",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.RenameColumn(
                name: "Studentsid",
                table: "Subjects",
                newName: "StudentsID");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_Studentsid",
                table: "Subjects",
                newName: "IX_Subjects_StudentsID");

            migrationBuilder.AlterColumn<int>(
                name: "StudentsID",
                table: "Subjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Students_StudentsID",
                table: "Subjects",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
