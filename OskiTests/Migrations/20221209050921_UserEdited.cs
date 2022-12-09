using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class UserEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Quizzes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_ApplicationUserId",
                table: "Quizzes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_AspNetUsers_ApplicationUserId",
                table: "Quizzes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_AspNetUsers_ApplicationUserId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_ApplicationUserId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Quizzes");
        }
    }
}
