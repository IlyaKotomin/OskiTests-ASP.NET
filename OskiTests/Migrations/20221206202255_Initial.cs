using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OskiTests.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionViewModels",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionViewModels", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_QuestionViewModels_QuizViewModels_QuizViewModelId",
                        column: x => x.QuizViewModelId,
                        principalTable: "QuizViewModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnswerViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionViewModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerViewModel_QuestionViewModels_QuestionViewModelQuestionId",
                        column: x => x.QuestionViewModelQuestionId,
                        principalTable: "QuestionViewModels",
                        principalColumn: "QuestionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerViewModel_QuestionViewModelQuestionId",
                table: "AnswerViewModel",
                column: "QuestionViewModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionViewModels_QuizViewModelId",
                table: "QuestionViewModels",
                column: "QuizViewModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerViewModel");

            migrationBuilder.DropTable(
                name: "QuestionViewModels");

            migrationBuilder.DropTable(
                name: "QuizViewModels");
        }
    }
}
