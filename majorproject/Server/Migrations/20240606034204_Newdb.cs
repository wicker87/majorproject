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
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "ad103fd7-2dfb-4313-882b-0045133d7539", "IT Manager", "janedoe@admin.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@ADMIN.COM", "JANEDOE@ADMIN.COM", "AQAAAAIAAYagAAAAEP3y24nT55g65XQ8fLOiboR22MfhMDAnFErVG4jmIcOABV8oTvb2bCaA28JY9wfLdQ==", "64841415", false, "e91a272c-57b5-4ecb-a7ce-7d33e1142170", false, "janedoe@admin.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "859ab5e8-0f2d-4047-8cb8-c83f99953c54", "Safety Inspector", "tommyjones@employee.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@EMPLOYEE.COM", "TOMMYJONES@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEJ7KiZWFqPpuz+JZY2JYVYDEHAzBB4IRhWqcoOB5gt/FushNvQYChZcwqd5Che2z5A==", "65325334", false, "32149996-db0c-4c0c-8b17-f8007ea5b32c", false, "tommyjones@employee.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "d8a93375-45d6-49dd-bec7-fe1bad924ed9", "Safety Manager", "johnsmith@manager.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@MANAGER.COM", "JOHNSMITH@MANAGER.COM", "AQAAAAIAAYagAAAAEKcYgMlBnXi16AsCmFEv0xvwdeBBQAxBTVo5CPhn0fUW/AyDyTc7dkrPMYmxtt3xvQ==", "67349033", false, "3042db39-e4ea-4211-95a5-863a9615c23f", false, "johnsmith@manager.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "19c89133-f497-4c26-9159-7fcec0710a6b", "Safety Manager", "benjaminscott@manager.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@MANAGER.COM", "BENJAMINSCOTT@MANAGER.COM", "AQAAAAIAAYagAAAAEKmr2BMG9b4fhbMNMM9NPplzXV6OdwsvnPoijPfjUq//PA3KiEN6M3c2B0aEYs4+PA==", "62610071", false, "b2ba5347-d258-44a1-8f2e-8457ea513168", false, "benjaminscott@manager.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "1fa6c231-c2cb-46fc-ad7d-ace1d4a4b155", "Safety Inspector", "ninachoo@employee.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@EMPLOYEE.COM", "NINACHOO@EMPLOYEE.COM", "AQAAAAIAAYagAAAAELDvIl5Npmh6JlGJGyu1YX5k+E67pY/cuQNGby99oE9mIHiT9JsT3/E7KiCUIfXgXA==", "65366623", false, "216b22c2-0c27-4226-9f65-1168cfad781f", false, "ninachoo@employee.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "29538102-e8c8-4753-b3c5-fa307f01f857", "Safety Inspector", "warrenyoung@employee.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@EMPLOYEE.COM", "WARRENYOUNG@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEMa0rrEk12R7VY5cO63FiJxbF7TmL7GUYJXt8DsUfFzBft6r4SIVZgM4pNKpS4Gb/g==", "63388585", false, "a6cb22b3-d33f-4a3b-902d-b3ba07d100da", false, "warrenyoung@employee.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "40bc9a4a-66dd-4f6e-95ef-6fa05e663140", "Safety Inspector", "stanleyhall@employee.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@EMPLOYEE.COM", "STANLEYHALL@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEJryGz6fu/MM1jVvVIny+mBRSWZGUarPCAkxRqWaoPNaaXpwWqgbfNb9IkSMG5czcQ==", "63960815", false, "1c6bd6d8-14d2-4482-84da-c2335deda783", false, "stanleyhall@employee.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "30740a3a-2d83-49d5-ac64-21460e86c773", "Safety Inspector", "kylethomas@employee.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@EMPLOYEE.COM", "KYLETHOMAS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAENRwxkQMr0XXn7ppDWKgY1cM4H9IvIfSMC9s48MMYNKU/qxTZkYwj8OifbNg7XlsHA==", "67361183", false, "f9a39f9a-c285-4263-bb0f-69a5d0ab5290", false, "kylethomas@employee.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "01e243c0-49ca-4dab-8467-88aee3cc8a22", "Safety Inspector", "elizaross@employee.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@EMPLOYEE.COM", "ELIZAROSS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEOgevyttfoAsf2PjbXc94cIUw/GLvuTb8HBSBhZiKdfwlM+Cv1hswBXgbuuqbjxiOw==", "67780373", false, "955ea5df-7cde-4e39-8ec3-f3da5068fd2c", false, "elizaross@employee.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "152977d1-7e9c-47c8-94d8-85b04706cffe", "Safety Inspector", "larryparker@employee.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@EMPLOYEE.COM", "LARRYPARKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHKCcJuJIGNmvLi/FrJYxTCEJOV6XKT8V7C7q+6M1o4hJJbDOJRWDRCD+BF5kgUFyg==", "67771504", false, "d91b8445-3c2f-4bbc-b000-14ae51e20bf6", false, "larryparker@employee.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "8bda3d82-07c8-47f5-b652-0fbaec53df04", "Safety Inspector", "constancelee@employee.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@EMPLOYEE.COM", "CONSTANCELEE@EMPLOYEE.COM", "AQAAAAIAAYagAAAAECtUyfnTvaMXrflSKcCauWWIEVsp1w1WxmXNOtYxC/yt5ndn3u5WnRAaD9NwXxpT9A==", "67457717", false, "8329ae34-4fd2-4393-bec6-b0027e3f5623", false, "constancelee@employee.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "fdbdf8c1-73cc-498a-9d5f-8e9498aa3c4e", "Safety Manager", "jennielow@manager.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@MANAGER.COM", "JENNIELOW@MANAGER.COM", "AQAAAAIAAYagAAAAEHPLmh/xuPqwfLGBnuAGL6dp9wlvmkgWxRjBWF6XevJ09girpblkrY68HMF52N1hnQ==", "62247473", false, "2838649d-a423-4d63-a526-36ea5146a854", false, "jennielow@manager.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "b8e7ef9e-8598-4c10-9352-67a22c984be3", "Safety Manager", "emilybrown@manager.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@MANAGER.COM", "EMILYBROWN@MANAGER.COM", "AQAAAAIAAYagAAAAEMSAEIwrQCRt3fnUu8pogCC86kFcX7qoS62CF9EzkWOheQA8CNNEZpy+wwJ1XucFeg==", "67528856", false, "bf31d4e4-4d43-4e9c-936c-e63d528eaa98", false, "emilybrown@manager.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "68beb646-9805-4f15-9c67-a06f74bdbd3e", "Safety Inspector", "jimmybaker@employee.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@EMPLOYEE.COM", "JIMMYBAKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAELdzVaLnA8R5CwwAWz5lfhF3XrWtlKcjAePYifhan3KNfR32O6dr3VpN01LWrwutBA==", "67789981", false, "859d5f27-245a-4ead-b56b-89ca67922e78", false, "jimmybaker@employee.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "dc2037ef-e7a2-4d63-9a9b-3bf0609f23f0", "Safety Inspector", "bobbybrooks@employee.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@EMPLOYEE.COM", "BOBBYBROOKS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHNPY+DIkpq54XU/wYFDLuPuFzctCe/nHF45XBR2QhO2tpeK91sqG8uvl51sgDjGHA==", "62570046", false, "b4efb05c-2200-4204-872b-e3212b925948", false, "bobbybrooks@employee.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "cd7b25d8-271c-455f-bb69-292c074fe396", "Safety Inspector", "bendanis@employee.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@EMPLOYEE.COM", "BENDANIS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEDr7b2ItGG7ZzOB3JQ9bHXNVf5bo3k0eUc+ECiLPKYWV1QQZfeJIsFqik1lHQkVvjQ==", "68626846", false, "7a0707a9-143d-4f17-b4a6-96e5fb53a257", false, "bendanis@employee.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "f57bfa65-3c12-46d9-aacf-4dfef1c2430e", "Safety Inspector", "maddietay@employee.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@EMPLOYEE.COM", "MADDIETAY@EMPLOYEE.COM", "AQAAAAIAAYagAAAAED9KxwtdqgyvSi115t+s6ZxIYM04lJF0ieg7NpjA4M0JgQXbMGJ7QYRal8VNQia5ig==", "63457266", false, "0b3b7505-75b3-4d42-9431-f75b499b3d4a", false, "maddietay@employee.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "2c4da5bc-8482-4803-9dea-19db7ec7abfa", "Safety Manager", "kevinjones@manager.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@MANAGER.COM", "KEVINJONES@MANAGER.COM", "AQAAAAIAAYagAAAAEG1wqdIJ18RCkfTBhXwjMjmb2FbQfKlNFo7xW5HdAGUAt2HU76EgyAY6+gipF5UcsA==", "68999888", false, "2163c314-8b84-43a0-8efc-07dc9bd3ff2a", false, "kevinjones@manager.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "6ec76dfd-473b-4627-ac95-acf1fa607f9d", "Safety Inspector", "elenareed@employee.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@EMPLOYEE.COM", "ELENAREED@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEFU4bZ/iOKfv+rZkCuvHNaLGglmgUf0pm0+65gW3XVHfDHZ32r4Qcmxcp9kEqpY64g==", "63450508", false, "ca9c86e1-2a86-41c7-a6b4-27b1d7e06fe2", false, "elenareed@employee.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "eb02b48a-6b59-4789-ae6b-e135fbaf378a", "Safety Inspector", "jakehoward@employee.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@EMPLOYEE.COM", "JAKEHOWARD@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEP00Ppf8qC9q0vvArrQ05aDKPhywSouIBoi9FR67TDQCEaRUl2hWZaxKA1YOUoNerw==", "62678901", false, "2a6f9dfe-7bd3-40a9-a1d2-091bb8dd4b99", false, "jakehoward@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "RiskTeams",
                columns: new[] { "Id", "Leader", "Member1", "Member2", "Member3", "Member4", "Member5" },
                values: new object[,]
                {
                    { 1, "Eliza Ross", "Nina Choo", "Maddie Tay", "Stanley Hall", "Warren Young", "Jake Howard" },
                    { 2, "Kyle Thomas", "Constance Lee", "Bobby Brooks", null, null, null },
                    { 3, "Tommy Jones", "Elena Reed", "Ben Danis", "Larry Parker", "Jimmy Baker", null }
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
                values: new object[] { 1, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "John Smith", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temasek Poly (ENG)", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN10-2-15", "CEN MP Risk Assessment", new DateTime(2027, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEN MP - April 2024", 2 });

            migrationBuilder.InsertData(
                table: "WorkActivities",
                columns: new[] { "Id", "AssessmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Use of MP facility" },
                    { 2, 1, "Use of BYOD Notebooks, PCs, Equipment" },
                    { 3, 1, "Use of soldering iron in MP labs for hardware related projects" },
                    { 4, 1, "Handling of hand tools in MP Labs for hardware related projects" }
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
                    { 8, 4, "Trip and fall due to hand tools/equipment on the floor", "Head & Bodily Injuries" }
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
                    { 16, "Ensure all unused equipment/tools are kept properly when not in use or when away.", 8, 1, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "RiskControls",
                columns: new[] { "Id", "AdditionalControls", "DueDate", "EvaluationId", "ImplementingPerson", "Likelihood", "RPN", "Remarks", "Severity" },
                values: new object[] { 1, "All electrical appliances have proper electrical insulation.", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "David Young", 1, 2, null, 2 });

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
