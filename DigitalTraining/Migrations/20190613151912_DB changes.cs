using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalTraining.Migrations
{
    public partial class DBchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificationTrainingDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProcedureName = table.Column<string>(nullable: true),
                    ProcedureNumber = table.Column<string>(nullable: true),
                    Rev = table.Column<string>(nullable: true),
                    Employee = table.Column<string>(nullable: true),
                    Training = table.Column<string>(nullable: true),
                    Manager = table.Column<string>(nullable: true),
                    DateTrainingBegun = table.Column<DateTime>(nullable: false),
                    Distinguish = table.Column<string>(nullable: true),
                    Identify = table.Column<string>(nullable: true),
                    Describe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTrainingDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCertificationTrainingTemplates",
                columns: table => new
                {
                    GeneralCertificationTemplateId = table.Column<Guid>(nullable: false),
                    ProceedureNameTemplate = table.Column<string>(nullable: true),
                    ProceedureNumberTemplate = table.Column<string>(nullable: true),
                    RevisionTemplate = table.Column<string>(nullable: true),
                    DistinguishTemplate = table.Column<string>(nullable: true),
                    IdentifyTemplate = table.Column<string>(nullable: true),
                    DescribeTemplate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCertificationTrainingTemplates", x => x.GeneralCertificationTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "CertificationTrainingDocumentQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionDescription = table.Column<string>(nullable: true),
                    ExpectedAnswer = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CertificationTrainingDocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTrainingDocumentQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificationTrainingDocumentQuestions_CertificationTrainingDocuments_CertificationTrainingDocumentId",
                        column: x => x.CertificationTrainingDocumentId,
                        principalTable: "CertificationTrainingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CertificationTrainingDocumentTopics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TopicDescription = table.Column<string>(nullable: true),
                    EmployeeDateSigned = table.Column<DateTime>(nullable: false),
                    EmployeeInitial = table.Column<string>(nullable: true),
                    TrainerDateSigned = table.Column<DateTime>(nullable: false),
                    TrainerInitial = table.Column<string>(nullable: true),
                    ManagerDateSigned = table.Column<DateTime>(nullable: false),
                    ManagerDate = table.Column<string>(nullable: true),
                    CertificationTrainingDocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTrainingDocumentTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificationTrainingDocumentTopics_CertificationTrainingDocuments_CertificationTrainingDocumentId",
                        column: x => x.CertificationTrainingDocumentId,
                        principalTable: "CertificationTrainingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCertificationQuestionTemplates",
                columns: table => new
                {
                    QuestionTemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionDescriptionTemplate = table.Column<string>(nullable: true),
                    ExpectedAnswerTemplate = table.Column<string>(nullable: true),
                    GeneralCertificationTrainingTemplateGeneralCertificationTemplateId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCertificationQuestionTemplates", x => x.QuestionTemplateId);
                    table.ForeignKey(
                        name: "FK_GeneralCertificationQuestionTemplates_GeneralCertificationTrainingTemplates_GeneralCertificationTrainingTemplateGeneralCerti~",
                        column: x => x.GeneralCertificationTrainingTemplateGeneralCertificationTemplateId,
                        principalTable: "GeneralCertificationTrainingTemplates",
                        principalColumn: "GeneralCertificationTemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCertificationTopicTemplates",
                columns: table => new
                {
                    TopicTemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TopicDescriptionTemplate = table.Column<string>(nullable: true),
                    GeneralCertificationTrainingTemplateGeneralCertificationTemplateId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCertificationTopicTemplates", x => x.TopicTemplateId);
                    table.ForeignKey(
                        name: "FK_GeneralCertificationTopicTemplates_GeneralCertificationTrainingTemplates_GeneralCertificationTrainingTemplateGeneralCertific~",
                        column: x => x.GeneralCertificationTrainingTemplateGeneralCertificationTemplateId,
                        principalTable: "GeneralCertificationTrainingTemplates",
                        principalColumn: "GeneralCertificationTemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTrainingDocumentQuestions_CertificationTrainingDocumentId",
                table: "CertificationTrainingDocumentQuestions",
                column: "CertificationTrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationTrainingDocumentTopics_CertificationTrainingDocumentId",
                table: "CertificationTrainingDocumentTopics",
                column: "CertificationTrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCertificationQuestionTemplates_GeneralCertificationTrainingTemplateGeneralCertificationTemplateId",
                table: "GeneralCertificationQuestionTemplates",
                column: "GeneralCertificationTrainingTemplateGeneralCertificationTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralCertificationTopicTemplates_GeneralCertificationTrainingTemplateGeneralCertificationTemplateId",
                table: "GeneralCertificationTopicTemplates",
                column: "GeneralCertificationTrainingTemplateGeneralCertificationTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificationTrainingDocumentQuestions");

            migrationBuilder.DropTable(
                name: "CertificationTrainingDocumentTopics");

            migrationBuilder.DropTable(
                name: "GeneralCertificationQuestionTemplates");

            migrationBuilder.DropTable(
                name: "GeneralCertificationTopicTemplates");

            migrationBuilder.DropTable(
                name: "CertificationTrainingDocuments");

            migrationBuilder.DropTable(
                name: "GeneralCertificationTrainingTemplates");
        }
    }
}
