using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class RenameProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizModels",
                table: "QuizModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionModels",
                table: "QuestionModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerModels",
                table: "AnswerModels");

            migrationBuilder.RenameTable(
                name: "UserModels",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "QuizModels",
                newName: "Quizzes");

            migrationBuilder.RenameTable(
                name: "QuestionModels",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "AnswerModels",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_QuizModels_UserViewModelId",
                table: "Quizzes",
                newName: "IX_Quizzes_UserViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionModels_QuizViewModelId",
                table: "Questions",
                newName: "IX_Questions_QuizViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerModels_QuestionViewModelId",
                table: "Answers",
                newName: "IX_Answers_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quizzes",
                table: "Quizzes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizzes_QuizViewModelId",
                table: "Questions",
                column: "QuizViewModelId",
                principalTable: "Quizzes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Users_UserViewModelId",
                table: "Quizzes",
                column: "UserViewModelId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionViewModelId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizzes_QuizViewModelId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Users_UserViewModelId",
                table: "Quizzes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quizzes",
                table: "Quizzes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserModels");

            migrationBuilder.RenameTable(
                name: "Quizzes",
                newName: "QuizModels");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "QuestionModels");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "AnswerModels");

            migrationBuilder.RenameIndex(
                name: "IX_Quizzes_UserViewModelId",
                table: "QuizModels",
                newName: "IX_QuizModels_UserViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_QuizViewModelId",
                table: "QuestionModels",
                newName: "IX_QuestionModels_QuizViewModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionViewModelId",
                table: "AnswerModels",
                newName: "IX_AnswerModels_QuestionViewModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserModels",
                table: "UserModels",
                column: "Id");

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
    }
}
