using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class hellomigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Subjects_Subjectsid",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectsid",
                table: "Results",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Subjects_Subjectsid",
                table: "Results",
                column: "Subjectsid",
                principalTable: "Subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Subjects_Subjectsid",
                table: "Results");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectsid",
                table: "Results",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Subjects_Subjectsid",
                table: "Results",
                column: "Subjectsid",
                principalTable: "Subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
