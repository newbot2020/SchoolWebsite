using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class addedattendancecolumninstudentdeatails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studentdetails_Attendances_attendanceid",
                table: "Studentdetails");

            migrationBuilder.DropIndex(
                name: "IX_Studentdetails_attendanceid",
                table: "Studentdetails");

            migrationBuilder.DropColumn(
                name: "attendanceid",
                table: "Studentdetails");

            migrationBuilder.AddColumn<int>(
                name: "Attendancesid",
                table: "Studentdetails",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "attendanceid",
                table: "Studentdetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Studentdetails_attendanceid",
                table: "Studentdetails",
                column: "attendanceid");

            migrationBuilder.AddForeignKey(
                name: "FK_Studentdetails_Attendances_attendanceid",
                table: "Studentdetails",
                column: "attendanceid",
                principalTable: "Attendances",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
