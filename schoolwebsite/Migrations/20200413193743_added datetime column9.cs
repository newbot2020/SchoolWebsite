using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolwebsite.Migrations
{
    public partial class addeddatetimecolumn9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeCreated",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeCreated",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Students",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Students",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }
    }
}
