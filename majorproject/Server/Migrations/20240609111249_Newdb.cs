using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace majorproject.Server.Migrations
{
    /// <inheritdoc />
    public partial class Newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "RiskTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiskAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedStatus = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskAssessments_RiskTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "RiskTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkActivities_RiskAssessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "RiskAssessments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Identifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PossibleInjury = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifications_WorkActivities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "WorkActivities",
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
                    HazardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskEvaluations_Identifications_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Identifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RiskControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalControls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    Likelihood = table.Column<int>(type: "int", nullable: true),
                    RPN = table.Column<int>(type: "int", nullable: true),
                    ImplementingPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskControls_RiskEvaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "RiskEvaluations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", null, "Employee", "EMPLOYEE" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", null, "Manager", "MANAGER" },
                    { "ce6c922d-a075-41ba-928b-ab718da843f4", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Designation", "Email", "EmailConfirmed", "EmployeeID", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "357d3f92-3608-48ee-a00b-0ce64ae1db4c", "IT Manager", "janedoe@admin.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@ADMIN.COM", "JANEDOE@ADMIN.COM", "AQAAAAIAAYagAAAAEDY6tMSyeVYyUTCT2IpTjQNFF8QftIrl8kAEOlKjPvleMmLVaRyzy4VyFRBnCtCv1g==", "64841415", false, "55619b72-2411-4437-98a4-0ed3c3fcfb91", false, "janedoe@admin.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "ddbd062a-9ca6-47b0-a13a-4ef02c663281", "Safety Inspector", "tommyjones@employee.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@EMPLOYEE.COM", "TOMMYJONES@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEKLo9dw9L7zXm1G+MBNdTmcUBzYH/atdhJz0hBNo/mOdryI8nsUvWL2Q67S94ZL9+g==", "65325334", false, "ca9a6bc6-5954-4dad-a0ee-1154049efb16", false, "tommyjones@employee.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "81d3c935-bd34-41c6-a807-d1a7ea06740d", "Safety Manager", "johnsmith@manager.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@MANAGER.COM", "JOHNSMITH@MANAGER.COM", "AQAAAAIAAYagAAAAEOLCXUc0iK3/+vIwJ+2UAX+RI6Npk9zCnrp12v2Kb1z21mdrUdVXfdswbQ4icpz/Uw==", "67349033", false, "66a3cc13-23a4-419a-b2d9-c6f19929b0cc", false, "johnsmith@manager.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "9a1d323c-c07d-4a14-abad-e1cff88d0de2", "Safety Manager", "benjaminscott@manager.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@MANAGER.COM", "BENJAMINSCOTT@MANAGER.COM", "AQAAAAIAAYagAAAAEOEGbd9sXUDl+5BDpf0Z7vj+vJ6GBoRziwNjdt+hJp2z+/Z5KXVnt7E+5COxhDUEWg==", "62610071", false, "05e7231e-6f90-4bf7-9701-5ee38e965249", false, "benjaminscott@manager.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "4727dde0-6c42-4bdf-a7e9-2ce6c582d984", "Safety Inspector", "ninachoo@employee.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@EMPLOYEE.COM", "NINACHOO@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEKmAC1CjtnJZK9/A6LmVh6Wpq9k0fIowf9xe4eGLxRaEsjOQL8ltvZspHs1ce71mUw==", "65366623", false, "19b18422-d0c2-4975-8418-0744b1751ddb", false, "ninachoo@employee.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "1f4ffb75-8120-4a51-a476-1c4372685d10", "Safety Inspector", "warrenyoung@employee.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@EMPLOYEE.COM", "WARRENYOUNG@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEI8tl18x4e7lQaFARNn++RBCRQmSaF1/A2PUhOOm9yDgNFUFv4vrlGIb66FGGOaa/A==", "63388585", false, "c410a324-ee1d-416c-b243-55b7dd317ae7", false, "warrenyoung@employee.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "833617e0-add8-4259-a5be-e2801116f259", "Safety Inspector", "stanleyhall@employee.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@EMPLOYEE.COM", "STANLEYHALL@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEOqk/ZHYDJSikYq5QoE1vPCTypbOuac60xZeR5cHyzVktDe+w89WRx6pstWLosze7w==", "63960815", false, "12eb8d6e-9172-4391-a22b-4a6be5450cb6", false, "stanleyhall@employee.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "6b540870-332f-473c-ac77-1668b28a4bda", "Safety Inspector", "kylethomas@employee.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@EMPLOYEE.COM", "KYLETHOMAS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEOfSUJJl9e7WFvjNPUS4nYDazyWE8harALtSzEKAO1+BgX48ZW9/MyTheFQjPFQssg==", "67361183", false, "b63ab065-b7ed-4a21-ba78-14a79aa2b3e4", false, "kylethomas@employee.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "5b001800-2a93-4580-b4f3-e73f93bcfdda", "Safety Inspector", "elizaross@employee.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@EMPLOYEE.COM", "ELIZAROSS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEP0CnQXkYjlcUm5xNmX0I/c+NkJ7AnK6IWzaNp9gO88EdcUvJyHC990Yo9mnNCioTQ==", "67780373", false, "4a4db279-a952-4b35-8e90-b68d8619a155", false, "elizaross@employee.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "03e16a80-d3c6-4cec-8d1f-ea215c60e1f7", "Safety Inspector", "larryparker@employee.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@EMPLOYEE.COM", "LARRYPARKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEP/RoCQ72PrR9wgtQNcP7aGuSOkb7Ao6g4UEB5HczpGWJvrugCyMVyq9MvKH4k4G/g==", "67771504", false, "7d128c6b-b4d4-4d33-bcd4-10da2d6e95ac", false, "larryparker@employee.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "5218dbf3-3915-43a7-90fe-698269effb75", "Safety Inspector", "constancelee@employee.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@EMPLOYEE.COM", "CONSTANCELEE@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHRbxOg4OJWrnJY+ssIf+opVMThvFclQs+9hmKsdyuNM+WJyMiW8pgZLdsUkDFF1Yw==", "67457717", false, "ea13c254-85f9-42ca-850b-b33f3962047c", false, "constancelee@employee.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "0cb4cf23-e468-48c2-ac03-a0c23f843b2a", "Safety Manager", "jennielow@manager.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@MANAGER.COM", "JENNIELOW@MANAGER.COM", "AQAAAAIAAYagAAAAEBEw2UKr6jT4/UnNL9FSRotHaZQM41AJ0AcNkZuCtUXRgMKt9y38KWYs+9Wk66shWA==", "62247473", false, "1bd54ff0-0dec-4dd0-b15f-643b33f706ca", false, "jennielow@manager.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "7c7aa67d-0aab-419c-b44d-c9ac3609ed78", "Safety Manager", "emilybrown@manager.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@MANAGER.COM", "EMILYBROWN@MANAGER.COM", "AQAAAAIAAYagAAAAECUxa3bLVmMggafWWP4CvvFaGOx6MfKiqGseronHiZbeaV9XASYKMyUxxHa9+CWWdg==", "67528856", false, "21ffec2a-1e30-4fa4-83c4-cd22c9a18ac0", false, "emilybrown@manager.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "9e49fec7-8782-43a4-a4d0-355e79c87af7", "Safety Inspector", "jimmybaker@employee.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@EMPLOYEE.COM", "JIMMYBAKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEKfcCs5T81jvdn+NbGkEUGjkR57K4TuRs4caoLpoCjjyd5ipWxgmG1ZirDd3jXqV7g==", "67789981", false, "e7a7fa5d-bccf-4304-8c2c-92e81e1b269b", false, "jimmybaker@employee.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "b38906f2-a210-41f6-af21-992b02ed845f", "Safety Inspector", "bobbybrooks@employee.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@EMPLOYEE.COM", "BOBBYBROOKS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAENVP3vXqymXZq2VZpg8Ex3WWJYo1ayfqPRt5wyMQg77sj3mFNrxIVwa7Ce3TbWwIvw==", "62570046", false, "7f1e93fe-0090-4858-b114-84ff09a89938", false, "bobbybrooks@employee.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "1f3c407b-5152-46d8-8187-33baac2e49b4", "Safety Inspector", "bendanis@employee.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@EMPLOYEE.COM", "BENDANIS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEKV8yjkchvNM1PouRviRVDBgYViEbev7CT82uvPrBKKOC3G4Yn6/Z0Z+J1b2g1TIBg==", "68626846", false, "6818a61c-8c37-45b8-891e-afc826359202", false, "bendanis@employee.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "a97a511c-fd03-4576-9215-be728d003ab8", "Safety Inspector", "maddietay@employee.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@EMPLOYEE.COM", "MADDIETAY@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEJrFKgG09+dbaNn5/KLKvs7crlwvqGHldDJH06q9DfAl3Cpl/Lit052aPE6kmbc9fQ==", "63457266", false, "d56c6d89-132e-4f8c-aae1-1b09d0120a14", false, "maddietay@employee.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "d87d798f-d1df-4644-969f-e52996d0942c", "Safety Manager", "kevinjones@manager.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@MANAGER.COM", "KEVINJONES@MANAGER.COM", "AQAAAAIAAYagAAAAEDNTkkvaYVv2inwYwTdMdGOE3TZr4XxrSjn06IFTXSN7R1HJv6FyDDi+/VSlSFFpCg==", "68999888", false, "45dd65f6-2faf-44e8-ac58-4fa349cb6570", false, "kevinjones@manager.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "fefba265-7998-4cf1-947a-c85ad9feac0a", "Safety Inspector", "elenareed@employee.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@EMPLOYEE.COM", "ELENAREED@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEBK3Gn8622uWrV19RHtQSG+TG13ogGWEtG5Q3dYDohGWKqkTtHW9pbvAe2ZGb3lfDA==", "63450508", false, "79a34112-4da8-409e-b3de-877fde10ab30", false, "elenareed@employee.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "94fef079-1c9d-446c-87ad-2a5233cdb805", "Safety Inspector", "jakehoward@employee.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@EMPLOYEE.COM", "JAKEHOWARD@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHDOqPbbEpJLm/Xi6kRl7/RsFB5lpFkSxPwtnO0QKn8kD/sKw7gikahQIYDi/TDFmw==", "62678901", false, "f92c5d2c-5604-4859-8dfc-049e5d84a0e9", false, "jakehoward@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "RiskTeams",
                columns: new[] { "Id", "Leader", "Member1", "Member2", "Member3", "Member4", "Member5" },
                values: new object[,]
                {
                    { 1, "Eliza Ross", "Nina Choo", "Maddie Tay", "Stanley Hall", "Warren Young", "Jake Howard" },
                    { 2, "Kyle Thomas", "Constance Lee", "Bobby Brooks", null, null, null },
                    { 3, "Tommy Jones", "Elena Reed", "Ben Danis", "Larry Parker", "Jimmy Baker", null },
                    { 4, "Stanley Hall", "Jake Howard", "Constance Lee", "Tommy Jones", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ce6c922d-a075-41ba-928b-ab718da843f4", "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "1519fcce-c355-4cad-8b22-01b76b762ffc" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", "23cdf685-e508-4fc6-84cc-c860af2dd301" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "33a4bc04-9b10-49a5-8cb6-8dea48b122c4" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "5258daf7-0bf7-4460-a854-4b3f427312c7" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "5859b058-1d6e-4b79-8040-9bbd204c0dc5" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "63929151-0e12-4c5c-a03c-01c34642856a" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "6f84b324-5cc8-48b6-a348-57c74b3d5294" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "77ea0c8c-fa62-4e13-980a-63ed5336f0b2" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", "8d06620d-3d31-4c1c-9449-7eaac032f6bd" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", "911dd5ac-5093-444e-bd8d-b6fed36dcada" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "b57e892b-0bdb-4469-afd9-e6522fea2f25" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "cda313e3-33c1-4e6e-982b-3c5eb9ff9565" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "e5e8acfe-c59a-4b4d-bba4-d40057aecef4" },
                    { "b61949be-76be-449f-bc66-535bddbf7b90", "e7b4016a-fa59-4669-969f-36601182f51c" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "f53bf9d9-95d1-42af-804e-e5edacdc9c74" },
                    { "a7b95d75-9c36-45cf-993f-504090b554cc", "fe8964fa-aac1-4db1-97bb-017e0905242f" }
                });

            migrationBuilder.InsertData(
                table: "RiskAssessments",
                columns: new[] { "Id", "ApprovalDate", "ApprovedStatus", "Approver", "AssessmentDate", "Department", "LastReviewDate", "Location", "Name", "NextReviewDate", "Process", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "John Smith", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temasek Poly (ENG)", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN10-2-15", "CEN MP Risk Assessment", new DateTime(2027, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEN MP - April 2024", 2 },
                    { 2, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Benjamin Scott", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "School of Engineering", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN15-06-051, EN15-06-052, EN15-06-053, EN15-06-055, EN15-06-057, EN15-06-058, EN16-03-35, EN16-03-42", "TP-ENG Laboratories Risk Assessment", new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELN/CEN/ABS/IFM/AEL/AEG//BME/IIT/MTN", 4 }
                });

            migrationBuilder.InsertData(
                table: "WorkActivities",
                columns: new[] { "Id", "AssessmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Use of MP facility" },
                    { 2, 1, "Use of BYOD Notebooks, PCs, Equipment" },
                    { 3, 1, "Use of soldering iron in MP labs for hardware related projects" },
                    { 4, 1, "Handling of hand tools in MP Labs for hardware related projects" },
                    { 5, 2, "Use of facility" },
                    { 6, 2, "Use of PCs in Laboratory" },
                    { 7, 2, "Maintenance and operation of lab equipment" },
                    { 8, 2, "Handling component and lab materials" },
                    { 9, 2, "Hand soldering" },
                    { 10, 2, "Transportation of lab equipment" }
                });

            migrationBuilder.InsertData(
                table: "Identifications",
                columns: new[] { "Id", "ActivityId", "Name", "PossibleInjury" },
                values: new object[,]
                {
                    { 1, 1, "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor", "Bodily Injuries" },
                    { 2, 1, "Falling ceiling board and and lights holding", "Head & Bodily Injuries" },
                    { 3, 2, "Contact with electrical parts and faulty cables with live exposed wires", "Electrocution" },
                    { 4, 3, "Contact with hot surface / soldering iron", "Burns to exposed skin" },
                    { 5, 3, "Piercing by soldering iron tip", "Minor Cuts" },
                    { 6, 3, "Inhaling fumes from soldering", "Eye, nose and throat irritation" },
                    { 7, 4, "Contact with sharp edges and pointed tips", "Injury to exposed skin/hand" },
                    { 8, 4, "Trip and fall due to hand tools/equipment on the floor", "Head & Bodily Injuries" },
                    { 9, 5, "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor", "Bodily Injuries" },
                    { 10, 5, "Falling ceiling board and lights holding", "Head & Bodily Injuries" },
                    { 11, 6, "Contact with electrical parts and faulty cables with live exposed wires", "Electrocution" },
                    { 12, 7, "Heavy equipment falling to ground", "Injury & bruises" },
                    { 13, 7, "Awkward working posture", "Back injury" },
                    { 14, 7, "Electrical", "Electrical shock, burns, electrocution" },
                    { 15, 8, "Contact with sharp edges", "Minor cuts" },
                    { 16, 9, "Contact with hot surface", "Skin burns" },
                    { 17, 9, "Pierced by soldering iron tip", "Minor cuts" },
                    { 18, 9, "Inhalation of soldering fume", "Respiratory Irritation from soldering fume" },
                    { 19, 9, "Ingesting lead dust on solder", "Ill-heath effect from Lead poisoning" },
                    { 20, 10, "Heavy equipment fall to ground Physical-forceful exertions", "Leg injury, Back and arm injuries" }
                });

            migrationBuilder.InsertData(
                table: "RiskEvaluations",
                columns: new[] { "Id", "ExistingRiskControls", "HazardId", "Likelihood", "RPN", "Severity" },
                values: new object[,]
                {
                    { 1, "Loose network / power extension cables on the floor are taped", 1, 1, 2, 2 },
                    { 2, "Visual check of the lab for any damages floor tiles and report to EFM @ 67805955 for repair and temporary taped up the damaged floor tiles", 1, 2, 4, 2 },
                    { 3, "Get cleaner to mop the floor, report to EFM @ 67805955", 1, 1, 3, 3 },
                    { 4, "Visual check of the lab for any damages and report to EFM @ 67805955 for repair", 2, 1, 3, 3 },
                    { 5, "Do not touch electrical appliances with wet hands", 3, 1, 5, 5 },
                    { 6, "Ensure there is no frayed or exposed wiring, report EFM @ 67805955 or Staff-in-charge immediately", 3, 1, 5, 5 },
                    { 7, "Switch off the power when plugging/unplugging the power plug from the wall socket", 3, 1, 5, 5 },
                    { 8, "Conduct briefing on proper use of soldering iron prior to first-time use.", 4, 2, 4, 2 },
                    { 9, "Remain focused on the soldering task and not engage in conversation.", 4, 2, 4, 2 },
                    { 10, "Soldering iron must be returned to is holder and be placed in its holder when not in use.", 4, 2, 4, 2 },
                    { 11, "Return soldering iron to stand after use", 5, 1, 2, 2 },
                    { 12, "Avoid the “head-bent-over-project” soldering posture.", 6, 3, 6, 2 },
                    { 13, "Ensure adequate ventilation in the lab when soldering.", 6, 3, 6, 2 },
                    { 14, "Using of solder fume extractor.", 6, 3, 6, 2 },
                    { 15, "Adopt safe working practices when handling sharp tools.", 7, 2, 4, 2 },
                    { 16, "Ensure all unused equipment/tools are kept properly when not in use or when away.", 8, 1, 3, 3 },
                    { 17, "Loose network / power extension cables on the floor are taped.", 9, 1, 3, 3 },
                    { 18, "Visual check of the lab for any damages floor tiles and report to EFM @67805955 for repair and temporary taped up the damaged floor tiles.", 9, 1, 3, 3 },
                    { 19, "Get cleaner to mop the floor, report to EFM @ 67805955.", 9, 1, 3, 3 },
                    { 20, "Visual check of the lab for any damages and report to EFM @ 67805955 for repair.", 10, 1, 3, 3 },
                    { 21, "Alternative location for classes when the needs arise due to severity of situation.", 10, 1, 3, 3 },
                    { 22, "Do not touch electrical appliances with wet hands.", 11, 1, 4, 4 },
                    { 23, "Ensure there is no frayed or exposed wiring, report EFM @ 67805955 or Staff-in-charge immediately.", 11, 1, 4, 4 },
                    { 24, "Switch off the power when plugging/unplugging the power plug from the wall socket.", 11, 1, 4, 4 },
                    { 25, "Wear Safety Shoe.", 12, 2, 6, 3 },
                    { 26, "Use of trolley for carrying heavy items.", 12, 2, 6, 3 },
                    { 27, "Seek additional help if unable to handle the equipment.", 12, 2, 6, 3 },
                    { 28, "Always use leg muscles and keep back straight while lifting, adopt the correct lifting posture.", 13, 2, 6, 3 },
                    { 29, "Electrical ELCB are installed in the laboratory", 14, 1, 5, 5 },
                    { 30, "Power off and unplug the power from the equipment when not in use.", 14, 1, 5, 5 },
                    { 31, "Wear proper safety footwear.", 14, 1, 5, 5 },
                    { 32, "Proper handling (use of electronic tools)", 15, 2, 6, 3 },
                    { 33, "Switch off soldering iron after used", 16, 2, 6, 3 },
                    { 34, "Return iron to stand after used", 16, 2, 6, 3 },
                    { 35, "Return iron to stand after used.", 17, 1, 3, 3 },
                    { 36, "Laboratory to be well ventilated during soldering.", 18, 2, 6, 3 },
                    { 37, "Wash hands with soap immediately after soldering before going for meals.", 19, 1, 4, 4 },
                    { 38, "Safety briefing to staff on soldering safety if lead based solders are used.", 19, 1, 4, 4 },
                    { 39, "Consider using lead-free solder.", 19, 1, 4, 4 },
                    { 40, "Practice good housekeeping to remove soldering remnants on benches by sweeping and cleaning.", 19, 1, 4, 4 },
                    { 41, "Wear safety shoes", 20, 2, 6, 3 },
                    { 42, "Use trolley for transportation of equipment", 20, 2, 6, 3 },
                    { 43, "Limit weight stacked on trolley, trained on manual handling techniques", 20, 2, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "RiskControls",
                columns: new[] { "Id", "AdditionalControls", "DueDate", "EvaluationId", "ImplementingPerson", "Likelihood", "RPN", "Remarks", "Severity" },
                values: new object[,]
                {
                    { 1, "All electrical appliances have proper water proofing.", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "David Young", 1, 2, null, 2 },
                    { 2, "Conduct monthly checks on the electrical wiring.", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "David Young", 1, 2, null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_ActivityId",
                table: "Identifications",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_RiskAssessments_TeamId",
                table: "RiskAssessments",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskControls_EvaluationId",
                table: "RiskControls",
                column: "EvaluationId",
                unique: true,
                filter: "[EvaluationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RiskEvaluations_HazardId",
                table: "RiskEvaluations",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkActivities_AssessmentId",
                table: "WorkActivities",
                column: "AssessmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "RiskControls");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RiskEvaluations");

            migrationBuilder.DropTable(
                name: "Identifications");

            migrationBuilder.DropTable(
                name: "WorkActivities");

            migrationBuilder.DropTable(
                name: "RiskAssessments");

            migrationBuilder.DropTable(
                name: "RiskTeams");
        }
    }
}
