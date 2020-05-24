using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class _20may2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Absent",
                table: "Attendances");

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Attendances",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Attendances",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Attendances");

            migrationBuilder.AddColumn<string>(
                name: "Absent",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
