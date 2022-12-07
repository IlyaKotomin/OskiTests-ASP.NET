using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class UserModelsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModels_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModels");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionViewModels_QuizViewModels_QuizViewModelId",
                table: "QuestionViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizViewModels",
                table: "QuizViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionViewModels",
                table: "QuestionViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerViewModels",
                table: "AnswerViewModels");

            migrationBuilder.RenameTable(
                name: "QuizViewModels",
                newName: "QuizModels");

            migrationBuilder.RenameTable(
                name: "QuestionViewModels",
                newName: "QuestionModels");

            migrationBuilder.RenameTable(
                name: "AnswerViewModels",
                newName: "AnswerModels");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionViewModels_QuizViewModelId",
                table: "QuestionModels",
                newName: "IX_QuestionModels_QuizViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModels_QuestionViewModelId",
                table: "AnswerModels",
                newName: "IX_AnswerModels_QuestionViewModelId");

            migrationBuilder.AddColumn<int>(
                name: "UserViewModelId",
                table: "QuizModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizModels",
                table: "QuizModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionModels",
                table: "QuestionModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerModels",
                table: "AnswerModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizModels_UserViewModelId",
                table: "QuizModels",
                column: "UserViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerModels_QuestionModels_QuestionViewModelId",
                table: "AnswerModels",
                column: "QuestionViewModelId",
                principalTable: "QuestionModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModels_QuizModels_QuizViewModelId",
                table: "QuestionModels",
                column: "QuizViewModelId",
                principalTable: "QuizModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizModels_UserModels_UserViewModelId",
                table: "QuizModels",
                column: "UserViewModelId",
                principalTable: "UserModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerModels_QuestionModels_QuestionViewModelId",
                table: "AnswerModels");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModels_QuizModels_QuizViewModelId",
                table: "QuestionModels");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizModels_UserModels_UserViewModelId",
                table: "QuizModels");

            migrationBuilder.DropTable(
                name: "UserModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizModels",
                table: "QuizModels");

            migrationBuilder.DropIndex(
                name: "IX_QuizModels_UserViewModelId",
                table: "QuizModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionModels",
                table: "QuestionModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerModels",
                table: "AnswerModels");

            migrationBuilder.DropColumn(
                name: "UserViewModelId",
                table: "QuizModels");

            migrationBuilder.RenameTable(
                name: "QuizModels",
                newName: "QuizViewModels");

            migrationBuilder.RenameTable(
                name: "QuestionModels",
                newName: "QuestionViewModels");

            migrationBuilder.RenameTable(
                name: "AnswerModels",
                newName: "AnswerViewModels");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionModels_QuizViewModelId",
                table: "QuestionViewModels",
                newName: "IX_QuestionViewModels_QuizViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerModels_QuestionViewModelId",
                table: "AnswerViewModels",
                newName: "IX_AnswerViewModels_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizViewModels",
                table: "QuizViewModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionViewModels",
                table: "QuestionViewModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerViewModels",
                table: "AnswerViewModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerViewModels_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModels",
                column: "QuestionViewModelId",
                principalTable: "QuestionViewModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionViewModels_QuizViewModels_QuizViewModelId",
                table: "QuestionViewModels",
                column: "QuizViewModelId",
                principalTable: "QuizViewModels",
                principalColumn: "Id");
        }
    }
}
