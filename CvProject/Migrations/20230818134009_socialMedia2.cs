using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvProject.Migrations
{
    public partial class socialMedia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialMedias");
        }
    }
}
