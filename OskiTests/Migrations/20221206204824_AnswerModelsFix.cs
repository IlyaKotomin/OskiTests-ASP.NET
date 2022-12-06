using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class AnswerModelsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerViewModel",
                table: "AnswerViewModel");

            migrationBuilder.RenameTable(
                name: "AnswerViewModel",
                newName: "AnswerViewModels");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModel_QuestionViewModelId",
                table: "AnswerViewModels",
                newName: "IX_AnswerViewModels_QuestionViewModelId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerViewModels_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerViewModels",
                table: "AnswerViewModels");

            migrationBuilder.RenameTable(
                name: "AnswerViewModels",
                newName: "AnswerViewModel");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerViewModels_QuestionViewModelId",
                table: "AnswerViewModel",
                newName: "IX_AnswerViewModel_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerViewModel",
                table: "AnswerViewModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelId",
                table: "AnswerViewModel",
                column: "QuestionViewModelId",
                principalTable: "QuestionViewModels",
                principalColumn: "Id");
        }
    }
}
