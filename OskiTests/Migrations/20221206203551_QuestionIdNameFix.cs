using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class QuestionIdNameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelQuestionId",
                table: "AnswerViewModel");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "QuestionViewModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "QuestionViewModelQuestionId",
                table: "AnswerViewModel",
                newName: "QuestionViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModel_QuestionViewModelQuestionId",
                table: "AnswerViewModel",
                newName: "IX_AnswerViewModel_QuestionViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModel",
                column: "QuestionViewModelId",
                principalTable: "QuestionViewModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModel");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "QuestionViewModels",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "QuestionViewModelId",
                table: "AnswerViewModel",
                newName: "QuestionViewModelQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModel_QuestionViewModelId",
                table: "AnswerViewModel",
                newName: "IX_AnswerViewModel_QuestionViewModelQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelQuestionId",
                table: "AnswerViewModel",
                column: "QuestionViewModelQuestionId",
                principalTable: "QuestionViewModels",
                principalColumn: "QuestionId");
        }
    }
}
