using Microsoft.EntityFrameworkCore.Migrations;

namespace DgKala.Migrations
{
    public partial class migrgc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryGroupsEnumerable_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryGroupsEnumerable",
                table: "CategoryGroupsEnumerable");

            migrationBuilder.RenameTable(
                name: "CategoryGroupsEnumerable",
                newName: "CategoryGroups");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroups",
                newName: "IX_CategoryGroups_ParentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryGroups",
                table: "CategoryGroups",
                column: "GroupId");

            migrationBuilder.CreateTable(
                name: "CategoryAttributes",
                columns: table => new
                {
                    AttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeTitle = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAttributes", x => x.AttributeId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryStatus",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStatus", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    SubGroup = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false),
                    TheSellerId = table.Column<int>(nullable: false),
                    CategoryTitle = table.Column<string>(maxLength: 200, nullable: false),
                    CategoryDescription = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CategoryImageName = table.Column<string>(maxLength: 50, nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    CategoryStatusStatusId = table.Column<int>(nullable: true),
                    CategoryAttributesAttributeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryAttributes_CategoryAttributesAttributeId",
                        column: x => x.CategoryAttributesAttributeId,
                        principalTable: "CategoryAttributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryStatus_CategoryStatusStatusId",
                        column: x => x.CategoryStatusStatusId,
                        principalTable: "CategoryStatus",
                        principalColumn: "StatusId",
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
                        name: "FK_Categories_Users_TheSellerId",
                        column: x => x.TheSellerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryAttributesAttributeId",
                table: "Categories",
                column: "CategoryAttributesAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryStatusStatusId",
                table: "Categories",
                column: "CategoryStatusStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GroupId",
                table: "Categories",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubGroup",
                table: "Categories",
                column: "SubGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TheSellerId",
                table: "Categories",
                column: "TheSellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryGroups_CategoryGroups_ParentID",
                table: "CategoryGroups",
                column: "ParentID",
                principalTable: "CategoryGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryGroups_CategoryGroups_ParentID",
                table: "CategoryGroups");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryAttributes");

            migrationBuilder.DropTable(
                name: "CategoryStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryGroups",
                table: "CategoryGroups");

            migrationBuilder.RenameTable(
                name: "CategoryGroups",
                newName: "CategoryGroupsEnumerable");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryGroups_ParentID",
                table: "CategoryGroupsEnumerable",
                newName: "IX_CategoryGroupsEnumerable_ParentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryGroupsEnumerable",
                table: "CategoryGroupsEnumerable",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryGroupsEnumerable_CategoryGroupsEnumerable_ParentID",
                table: "CategoryGroupsEnumerable",
                column: "ParentID",
                principalTable: "CategoryGroupsEnumerable",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
