using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPupils.Data.Migrations
{
    public partial class TableOfPupilsStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Sana",
                table: "PupilStatuss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sana",
                table: "PupilStatuss");
        }
    }
}
