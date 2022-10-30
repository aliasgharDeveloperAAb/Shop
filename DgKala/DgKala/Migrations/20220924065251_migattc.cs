using Microsoft.EntityFrameworkCore.Migrations;

namespace DgKala.Migrations
{
    public partial class migattc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryAttributes_CategoryAttributesAttributeId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryAttributesAttributeId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryAttributesAttributeId",
                table: "Categories");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AttributeId",
                table: "Categories",
                column: "AttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryAttributes_AttributeId",
                table: "Categories",
                column: "AttributeId",
                principalTable: "CategoryAttributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryAttributes_AttributeId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AttributeId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryAttributesAttributeId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryAttributesAttributeId",
                table: "Categories",
                column: "CategoryAttributesAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryAttributes_CategoryAttributesAttributeId",
                table: "Categories",
                column: "CategoryAttributesAttributeId",
                principalTable: "CategoryAttributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
