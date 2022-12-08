using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class LoginSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Users_UserViewModelId",
                table: "Quizzes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_UserViewModelId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "UserViewModelId",
                table: "Quizzes");

            migrationBuilder.CreateTable(
                name: "Loggins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggins", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loggins");

            migrationBuilder.AddColumn<int>(
                name: "UserViewModelId",
                table: "Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UserViewModelId",
                table: "Quizzes",
                column: "UserViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Users_UserViewModelId",
                table: "Quizzes",
                column: "UserViewModelId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
