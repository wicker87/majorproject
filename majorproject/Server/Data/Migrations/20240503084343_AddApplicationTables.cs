using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace majorproject.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RAFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assessment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextReview = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    Likelihood = table.Column<int>(type: "int", nullable: true),
                    RPN = table.Column<int>(type: "int", nullable: true),
                    ImplementingPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: false),
                    RAFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_RAFs_RAFId",
                        column: x => x.RAFId,
                        principalTable: "RAFs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: false),
                    RAFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approvals_RAFs_RAFId",
                        column: x => x.RAFId,
                        principalTable: "RAFs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RiskTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: false),
                    RAFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTeams_RAFs_RAFId",
                        column: x => x.RAFId,
                        principalTable: "RAFs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RiskEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExistingRiskControls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    Likelihood = table.Column<int>(type: "int", nullable: true),
                    RPN = table.Column<int>(type: "int", nullable: true),
                    RiskCID = table.Column<int>(type: "int", nullable: false),
                    RiskControlId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskEvaluations_RiskControls_RiskControlId",
                        column: x => x.RiskControlId,
                        principalTable: "RiskControls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hazards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HazardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PossibleInjury = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkID = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    RiskEID = table.Column<int>(type: "int", nullable: false),
                    RiskEvaluationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hazards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hazards_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hazards_RiskEvaluations_RiskEvaluationId",
                        column: x => x.RiskEvaluationId,
                        principalTable: "RiskEvaluations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_RAFId",
                table: "Activities",
                column: "RAFId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_RAFId",
                table: "Approvals",
                column: "RAFId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_ActivityId",
                table: "Hazards",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hazards_RiskEvaluationId",
                table: "Hazards",
                column: "RiskEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskEvaluations_RiskControlId",
                table: "RiskEvaluations",
                column: "RiskControlId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTeams_RAFId",
                table: "RiskTeams",
                column: "RAFId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "Hazards");

            migrationBuilder.DropTable(
                name: "RiskTeams");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "RiskEvaluations");

            migrationBuilder.DropTable(
                name: "RAFs");

            migrationBuilder.DropTable(
                name: "RiskControls");
        }
    }
}
