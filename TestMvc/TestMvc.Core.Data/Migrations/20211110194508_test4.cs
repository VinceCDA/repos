using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMvc.Core.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Sessions_SessionId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Sessions_SessionId1",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_SessionId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_SessionId1",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "SessionId1",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Members",
                newName: "MemberId");

            migrationBuilder.CreateTable(
                name: "MemberSession",
                columns: table => new
                {
                    ParticipantsMemberId = table.Column<int>(type: "int", nullable: false),
                    SessionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSession", x => new { x.ParticipantsMemberId, x.SessionsId });
                    table.ForeignKey(
                        name: "FK_MemberSession_Members_ParticipantsMemberId",
                        column: x => x.ParticipantsMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberSession_Sessions_SessionsId",
                        column: x => x.SessionsId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberSession_SessionsId",
                table: "MemberSession",
                column: "SessionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberSession");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Members",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionId1",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_SessionId",
                table: "Members",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_SessionId1",
                table: "Members",
                column: "SessionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Sessions_SessionId",
                table: "Members",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Sessions_SessionId1",
                table: "Members",
                column: "SessionId1",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
