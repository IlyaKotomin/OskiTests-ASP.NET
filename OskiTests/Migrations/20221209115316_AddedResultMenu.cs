using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class AddedResultMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionViewModelId",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "AnswerViewModel");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionViewModelId",
                table: "AnswerViewModel",
                newName: "IX_AnswerViewModel_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerViewModel",
                table: "AnswerViewModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerViewModel_Questions_QuestionViewModelId",
                table: "AnswerViewModel",
                column: "QuestionViewModelId",
                principalTable: "Questions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModel_Questions_QuestionViewModelId",
                table: "AnswerViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerViewModel",
                table: "AnswerViewModel");

            migrationBuilder.RenameTable(
                name: "AnswerViewModel",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModel_QuestionViewModelId",
                table: "Answers",
                newName: "IX_Answers_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionViewModelId",
                table: "Answers",
                column: "QuestionViewModelId",
                principalTable: "Questions",
                principalColumn: "Id");
        }
    }
}
