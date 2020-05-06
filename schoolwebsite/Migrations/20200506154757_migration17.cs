using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class migration17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "Studentsid",
                table: "Results",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "StudentsName",
                table: "Results",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results",
                column: "Studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "StudentsName",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "Studentsid",
                table: "Results",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results",
                column: "Studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
