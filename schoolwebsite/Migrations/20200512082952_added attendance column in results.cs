using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class addedattendancecolumninresults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studentdetails_Attendances_Attendancesid",
                table: "Studentdetails");

            migrationBuilder.DropIndex(
                name: "IX_Studentdetails_Attendancesid",
                table: "Studentdetails");

            migrationBuilder.DropColumn(
                name: "Attendancesid",
                table: "Studentdetails");

            migrationBuilder.DropColumn(
                name: "id2",
                table: "Studentdetails");

            migrationBuilder.AddColumn<int>(
                name: "Attendancesid",
                table: "Results",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_Attendancesid",
                table: "Results",
                column: "Attendancesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Attendances_Attendancesid",
                table: "Results",
                column: "Attendancesid",
                principalTable: "Attendances",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Attendances_Attendancesid",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_Attendancesid",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Attendancesid",
                table: "Results");

            migrationBuilder.AddColumn<int>(
                name: "Attendancesid",
                table: "Studentdetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id2",
                table: "Studentdetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Studentdetails_Attendancesid",
                table: "Studentdetails",
                column: "Attendancesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Studentdetails_Attendances_Attendancesid",
                table: "Studentdetails",
                column: "Attendancesid",
                principalTable: "Attendances",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
