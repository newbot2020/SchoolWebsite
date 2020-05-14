using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class addedattendancecolumninstudentdeatails3 : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "Studentdetailsid",
                table: "Attendances",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_Studentdetailsid",
                table: "Attendances",
                column: "Studentdetailsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Studentdetails_Studentdetailsid",
                table: "Attendances",
                column: "Studentdetailsid",
                principalTable: "Studentdetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Studentdetails_Studentdetailsid",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_Studentdetailsid",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Studentdetailsid",
                table: "Attendances");

            migrationBuilder.AddColumn<int>(
                name: "Attendancesid",
                table: "Studentdetails",
                type: "int",
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
    }
}
