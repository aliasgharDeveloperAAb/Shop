using Microsoft.EntityFrameworkCore.Migrations;

namespace DgKala.Migrations
{
    public partial class migtag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Categories",
                maxLength: 700,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Categories");
        }
    }
}
