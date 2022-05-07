using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPupils.Data.Migrations
{
    public partial class PupilsSalaryMoneyForTeacherStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tolovlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sana = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tolovlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tolovlar");
        }
    }
}
