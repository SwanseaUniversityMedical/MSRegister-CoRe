using Microsoft.EntityFrameworkCore.Migrations;

namespace MSRegister_CoRe.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DominantHand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id = table.Column<int>(type: "int", nullable: false),
                    NumberOfQuestions = table.Column<int>(type: "int", nullable: false),
                    SuccessfulAnswers = table.Column<int>(type: "int", nullable: false),
                    EndStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Test_Root_RootID",
                        column: x => x.RootID,
                        principalTable: "Root",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<int>(type: "int", nullable: false),
                    CurrentScore = table.Column<int>(type: "int", nullable: false),
                    ScoreStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeRemaining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolChoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoiceCommand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceOrientation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Score_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Score_TestID",
                table: "Score",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RootID",
                table: "Test",
                column: "RootID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Root");
        }
    }
}
