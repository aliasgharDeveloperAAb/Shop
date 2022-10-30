using Microsoft.EntityFrameworkCore.Migrations;

namespace DgKala.Migrations
{
    public partial class mignewcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable",
                column: "ParentID");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryGroupsEnumerable_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable",
                column: "ParentID",
                principalTable: "CategoryGroupsEnumerable",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryGroupsEnumerable_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable");

            migrationBuilder.DropIndex(
                name: "IX_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable");
        }
    }
}
