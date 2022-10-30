using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DgKala.Migrations
{
    public partial class migNNEwsatatues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryStatuesEnumerable",
                columns: table => new
                {
                    StatuesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatuesTitle = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStatuesEnumerable", x => x.StatuesId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    SubGroup = table.Column<int>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false),
                    StatuesId = table.Column<int>(nullable: false),
                    CategoryTitle = table.Column<string>(maxLength: 450, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryPrice = table.Column<int>(nullable: false),
                    Tags = table.Column<string>(maxLength: 700, nullable: true),
                    IsFree = table.Column<bool>(nullable: false),
                    Attributes = table.Column<string>(maxLength: 600, nullable: false),
                    CategoryImageName = table.Column<string>(maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CategoryStatuesStatuesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryStatuesEnumerable_CategoryStatuesStatuesId",
                        column: x => x.CategoryStatuesStatuesId,
                        principalTable: "CategoryStatuesEnumerable",
                        principalColumn: "StatuesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "CategoryGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryGroups_SubGroup",
                        column: x => x.SubGroup,
                        principalTable: "CategoryGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Users_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryStatuesStatuesId",
                table: "Categories",
                column: "CategoryStatuesStatuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GroupId",
                table: "Categories",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubGroup",
                table: "Categories",
                column: "SubGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TeacherId",
                table: "Categories",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryStatuesEnumerable");
        }
    }
}
