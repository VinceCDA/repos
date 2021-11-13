using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMvc.Core.Data.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberSub");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Subs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subs_MemberId",
                table: "Subs",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subs_Members_MemberId",
                table: "Subs",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subs_Members_MemberId",
                table: "Subs");

            migrationBuilder.DropIndex(
                name: "IX_Subs_MemberId",
                table: "Subs");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Subs");

            migrationBuilder.CreateTable(
                name: "MemberSub",
                columns: table => new
                {
                    MembersMemberId = table.Column<int>(type: "int", nullable: false),
                    SubsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSub", x => new { x.MembersMemberId, x.SubsId });
                    table.ForeignKey(
                        name: "FK_MemberSub_Members_MembersMemberId",
                        column: x => x.MembersMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberSub_Subs_SubsId",
                        column: x => x.SubsId,
                        principalTable: "Subs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberSub_SubsId",
                table: "MemberSub",
                column: "SubsId");
        }
    }
}
