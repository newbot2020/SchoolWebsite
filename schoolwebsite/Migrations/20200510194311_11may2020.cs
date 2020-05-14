using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class _11may2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isabsent",
                table: "Attendances");

            migrationBuilder.AddColumn<string>(
                name: "Absent",
                table: "Attendances",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Absent",
                table: "Attendances");

            migrationBuilder.AddColumn<bool>(
                name: "isabsent",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
