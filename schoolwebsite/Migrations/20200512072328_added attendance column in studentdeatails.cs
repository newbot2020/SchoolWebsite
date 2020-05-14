using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class addedattendancecolumninstudentdeatails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "attendanceid",
                table: "Studentdetails",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
