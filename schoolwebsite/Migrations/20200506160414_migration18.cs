using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class migration18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_Studentsid",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "StudentsName",
                table: "Results");

            migrationBuilder.AlterColumn<string>(
                name: "Studentsid",
                table: "Results",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Studentsid1",
                table: "Results",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_Studentsid1",
                table: "Results",
                column: "Studentsid1");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_Studentsid1",
                table: "Results",
                column: "Studentsid1",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_Studentsid1",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_Studentsid1",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Studentsid1",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "Studentsid",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "StudentsName",
                table: "Results",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Results_Studentsid",
                table: "Results",
                column: "Studentsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_Studentsid",
                table: "Results",
                column: "Studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
