using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMvc.Core.Data.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberSubBooklet");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "SubBooklets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubBooklets_MemberId",
                table: "SubBooklets",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubBooklets_Members_MemberId",
                table: "SubBooklets",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubBooklets_Members_MemberId",
                table: "SubBooklets");

            migrationBuilder.DropIndex(
                name: "IX_SubBooklets_MemberId",
                table: "SubBooklets");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "SubBooklets");

            migrationBuilder.CreateTable(
                name: "MemberSubBooklet",
                columns: table => new
                {
                    MembersMemberId = table.Column<int>(type: "int", nullable: false),
                    SubBookletsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSubBooklet", x => new { x.MembersMemberId, x.SubBookletsId });
                    table.ForeignKey(
                        name: "FK_MemberSubBooklet_Members_MembersMemberId",
                        column: x => x.MembersMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberSubBooklet_SubBooklets_SubBookletsId",
                        column: x => x.SubBookletsId,
                        principalTable: "SubBooklets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberSubBooklet_SubBookletsId",
                table: "MemberSubBooklet",
                column: "SubBookletsId");
        }
    }
}
