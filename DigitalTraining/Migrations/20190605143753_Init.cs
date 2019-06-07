using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalTraining.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingCourseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateOfTraining = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    ProcedureNumber = table.Column<string>(nullable: true),
                    RevisionNumber = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    Instructor = table.Column<string>(nullable: true),
                    TrainingCourseTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingDocuments_TrainingCourseTypes_TrainingCourseTypeId",
                        column: x => x.TrainingCourseTypeId,
                        principalTable: "TrainingCourseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SocketName = table.Column<string>(nullable: true),
                    Theme = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    OperatorId = table.Column<string>(nullable: true),
                    UserPreferencesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_UserPreferences_UserPreferencesId",
                        column: x => x.UserPreferencesId,
                        principalTable: "UserPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingHRDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tuition = table.Column<string>(nullable: true),
                    Books = table.Column<string>(nullable: true),
                    Grades = table.Column<string>(nullable: true),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    TrainingDocumentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingHRDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingHRDocuments_TrainingDocuments_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "TrainingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingRosters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeNumber = table.Column<string>(nullable: true),
                    CostCenter = table.Column<string>(nullable: true),
                    PreTestScore = table.Column<string>(nullable: true),
                    PostTestScore = table.Column<string>(nullable: true),
                    TrainingDocumentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingRosters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingRosters_TrainingDocuments_TrainingDocumentId",
                        column: x => x.TrainingDocumentId,
                        principalTable: "TrainingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_UserPreferencesId",
                table: "ApplicationUsers",
                column: "UserPreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDocuments_TrainingCourseTypeId",
                table: "TrainingDocuments",
                column: "TrainingCourseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingHRDocuments_TrainingDocumentId",
                table: "TrainingHRDocuments",
                column: "TrainingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingRosters_TrainingDocumentId",
                table: "TrainingRosters",
                column: "TrainingDocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "TrainingHRDocuments");

            migrationBuilder.DropTable(
                name: "TrainingRosters");

            migrationBuilder.DropTable(
                name: "UserPreferences");

            migrationBuilder.DropTable(
                name: "TrainingDocuments");

            migrationBuilder.DropTable(
                name: "TrainingCourseTypes");
        }
    }
}
