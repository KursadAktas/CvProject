using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvProject.Migrations
{
    public partial class @byte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Ratio",
                table: "Talents",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "Talents");
        }
    }
}
