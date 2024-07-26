using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace majorproject.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewDb : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskAssessments_RiskTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "RiskTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<long>(type: "bigint", nullable: true),
                    Base64String = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromptAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentId = table.Column<int>(type: "int", nullable: true),
                    RiskAssessmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageSources_RiskAssessments_RiskAssessmentId",
                        column: x => x.RiskAssessmentId,
                        principalTable: "RiskAssessments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: true),
                    RiskAssessmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkActivities_RiskAssessments_RiskAssessmentId",
                        column: x => x.RiskAssessmentId,
                        principalTable: "RiskAssessments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Identifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ExistingRiskControls = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    AdditionalControls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    Likelihood = table.Column<int>(type: "int", nullable: true),
                    RPN = table.Column<int>(type: "int", nullable: true),
                    ImplementingPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluationId = table.Column<int>(type: "int", nullable: true),
                    RiskEvaluationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskControls_RiskEvaluations_RiskEvaluationId",
                        column: x => x.RiskEvaluationId,
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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "2912ef02-3ebd-4495-8675-9f57152a6a62", "IT Manager", "janedoe@admin.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@ADMIN.COM", "JANEDOE@ADMIN.COM", "AQAAAAIAAYagAAAAEPuOnr/Z6mSivJGC8I2gRfd7CscrBR3VHiwWVYft5XwSHU4ObKjkpy2HBRRVW0IU/g==", "64841415", false, "10eb4527-879a-4c6e-b56c-01e2916a5e11", false, "janedoe@admin.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "7d4f69a7-1d18-4b43-84e8-ca81e942aa73", "Safety Inspector", "tommyjones@employee.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@EMPLOYEE.COM", "TOMMYJONES@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEBHxccihyPcnNCGx414Z5jJAeJnhcp36Av6VRL4v1DGs8lYMpO/4ooglXZcV6fcLvw==", "65325334", false, "e5c643ef-9b87-4e4e-b6a1-9cdcc52ad702", false, "tommyjones@employee.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "4aa9738e-de6e-442a-89cb-a308cd695566", "Safety Manager", "johnsmith@manager.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@MANAGER.COM", "JOHNSMITH@MANAGER.COM", "AQAAAAIAAYagAAAAECuGHr7pe6jP3pidJe4fzGEtDt1bFWIuzrXXiQbqCVIkqGJMAKuux9dPIGkLsLLDFQ==", "67349033", false, "3c98ba6e-a978-4b44-a020-8d9b751daf30", false, "johnsmith@manager.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "cf1de03e-91a6-4110-bb39-be84db34618f", "Safety Manager", "benjaminscott@manager.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@MANAGER.COM", "BENJAMINSCOTT@MANAGER.COM", "AQAAAAIAAYagAAAAEDCV60dT2fBeadx1qRgC6Y9GrytDHzjocwjRA3Rm4KxeNhl0ohoIH7xQz4ZvoKBR7A==", "62610071", false, "474177a7-3e96-43f2-981a-38a9ac259492", false, "benjaminscott@manager.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "110e6852-76d3-45b5-9643-0cd5cff04bd2", "Safety Inspector", "ninachoo@employee.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@EMPLOYEE.COM", "NINACHOO@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEE+cbIppgWVktStgSVTmzcFa8BOnJ8kgXUcXjpvx+BT4d5ZUUVoxSsvBZuBOkPPo1A==", "65366623", false, "37d317c6-94dc-4b1c-a63d-5aec949e9a3a", false, "ninachoo@employee.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "6f249c4f-8504-484b-b94e-029facb6768f", "Safety Inspector", "warrenyoung@employee.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@EMPLOYEE.COM", "WARRENYOUNG@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEAugus3a2fT9zdDTshkuABR9QlObYDurLw8Dvgg/C9GiRMkemJjRdz7uZ+7XRKmyIA==", "63388585", false, "27aa1256-2453-4853-8b46-6dfe50ceb5bf", false, "warrenyoung@employee.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "59740058-b6d0-4def-9626-b11cbcfe66fb", "Safety Inspector", "stanleyhall@employee.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@EMPLOYEE.COM", "STANLEYHALL@EMPLOYEE.COM", "AQAAAAIAAYagAAAAELhECu0XJaZomfntAA55k7VVD0jxizaxIZTlr47JKnJoa8Pg8gYuCOqp/eIWgAdhLg==", "63960815", false, "98003874-7b06-48de-ac4f-78194d2d8631", false, "stanleyhall@employee.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "b5141e5a-9acd-4e55-a5db-4683d0349352", "Safety Inspector", "kylethomas@employee.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@EMPLOYEE.COM", "KYLETHOMAS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEAO0JZuhmGpK65MZ5K6phnF0YSs/mnGgoAr1Xfw/7QRJfWZQRiJZryvgtZI6jqpLmw==", "67361183", false, "9270f64a-796f-4c01-a22c-543d2a927e76", false, "kylethomas@employee.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "d9079871-d294-4fed-8231-37b7749c74e0", "Safety Inspector", "elizaross@employee.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@EMPLOYEE.COM", "ELIZAROSS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEIn88KcmPBO0qFQBHhNumn1LmlYLtrJ38x/kMDZSP0BgR+2SS5G6IoVRRvxv3cye/w==", "67780373", false, "04db5162-8864-4470-98ef-a1f04f587886", false, "elizaross@employee.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "c4faf183-7a6f-4b45-9fc4-db6f595061fe", "Safety Inspector", "larryparker@employee.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@EMPLOYEE.COM", "LARRYPARKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEMIOx6Y+X7jPVCo6cXkAFmCpxVVNRAAjpy0tyvHksJilEGI8cK/Cj8POBbbA5ZFsyA==", "67771504", false, "6b2a9b13-c469-427b-8104-6944b7a8901b", false, "larryparker@employee.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "d572ecfa-ff8c-49aa-8870-401aba99da2a", "Safety Inspector", "constancelee@employee.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@EMPLOYEE.COM", "CONSTANCELEE@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEJKlXgsgSfvonoWdrMnZbFVkh8IO5f194fgJe+pCB72ce+KJ9XK5+lKZzlGfDbPohA==", "67457717", false, "9809a003-f9b1-43a7-9744-78923d08cfad", false, "constancelee@employee.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "a16c8725-e016-48ff-857f-b2ad753540d3", "Safety Manager", "jennielow@manager.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@MANAGER.COM", "JENNIELOW@MANAGER.COM", "AQAAAAIAAYagAAAAEHA8JfO15hdts31EzoL+O0XUVcV2oukLZhlodqskQFXjMxEtHCsJ50NKf2q8Aq9c/A==", "62247473", false, "781f6471-a470-48f9-81f0-750eadb478b7", false, "jennielow@manager.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "8f4d9584-0a88-422b-b8bd-852cad2da3c5", "Safety Manager", "emilybrown@manager.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@MANAGER.COM", "EMILYBROWN@MANAGER.COM", "AQAAAAIAAYagAAAAEFBDlgIGobEf9+gotmbOZP68eJxoyMiJugzKcbbg9zeZwdOzlF02eaJzWnzvda57Gg==", "67528856", false, "4a2c02b7-bffa-4e5d-8302-1df81284e15f", false, "emilybrown@manager.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "411cbbb7-ba92-4163-8fc1-86e810b2da02", "Safety Inspector", "jimmybaker@employee.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@EMPLOYEE.COM", "JIMMYBAKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEB/tRxQuwfjDfNxSD6/8aEiZyUSz/AWT6fADNJGjmmQh/PK6wFcj1RFdMtOHViMxhA==", "67789981", false, "900e1d06-4012-4cd1-b8d0-5228372fdfc3", false, "jimmybaker@employee.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "d29ba092-0018-447d-98f6-fd925568887f", "Safety Inspector", "bobbybrooks@employee.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@EMPLOYEE.COM", "BOBBYBROOKS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEAEDqi2AuyBClkuBgkriU3Su4mYujhKuXsLda/WTQsX+E0WBTAUqo8iVR9UkLcXE4g==", "62570046", false, "64658782-ab94-43fe-ac9a-f79019a6bf72", false, "bobbybrooks@employee.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "e2b27d5d-9623-4af6-a254-d781dfb4cc8a", "Safety Inspector", "bendanis@employee.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@EMPLOYEE.COM", "BENDANIS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEC6ZgzAa98+58cwbY2pxRVVTAKGHFoIJmiZz+VQrCsFx8JNGbMj3b11sWzJ9cKRXog==", "68626846", false, "3449a323-4a2d-444f-ae54-42fd746356d2", false, "bendanis@employee.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "bff520b8-219e-49e3-bcfb-7a206481e3d0", "Safety Inspector", "maddietay@employee.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@EMPLOYEE.COM", "MADDIETAY@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEC9gl9wBKbNHbZUSom7JSkNu82rxmW5ELp2KQEwO2ugHuCjETWJnT5BEGwyfCxzB4A==", "63457266", false, "6d0b33de-5e3e-4cfb-97b6-8650dc764426", false, "maddietay@employee.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "0c9b3313-3945-4c65-9b8a-5d2aa051a242", "Safety Manager", "kevinjones@manager.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@MANAGER.COM", "KEVINJONES@MANAGER.COM", "AQAAAAIAAYagAAAAELg4qpRLHi4XEMWHquegifSF1XiMmmDwNfXdPNooPJiruvDvI0PdV4h+qzmgim7LUQ==", "68999888", false, "6885d61e-bbea-4205-95ac-9a1d412cea3c", false, "kevinjones@manager.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "a4260808-3270-4a56-b158-593dd5a89321", "Safety Inspector", "elenareed@employee.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@EMPLOYEE.COM", "ELENAREED@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHsDAjjYIY2zH8DdhQ8eFrV6/ew/2Op+oP1fdY9OCLz+QazgEw6LU0ZtOj/MwovFRQ==", "63450508", false, "3d0aa71c-cee0-4306-a801-fc61c195187c", false, "elenareed@employee.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "780b8dc9-521a-401c-a23b-65fb409f6693", "Safety Inspector", "jakehoward@employee.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@EMPLOYEE.COM", "JAKEHOWARD@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEF7Mn0yxuOCfJCHJyj1fdQ9xeBSOnotTO3QDTA6OrQinf7aCnIL+BtZkf3gg42sa6g==", "62678901", false, "90ab84a2-c488-47c0-91f4-e399a68d0094", false, "jakehoward@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "RiskControls",
                columns: new[] { "Id", "AdditionalControls", "DueDate", "EvaluationId", "ImplementingPerson", "Likelihood", "RPN", "Remarks", "RiskEvaluationId", "Severity" },
                values: new object[,]
                {
                    { 1, "All electrical appliances have proper water proofing.", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "David Young", 1, 2, null, null, 2 },
                    { 2, "Conduct monthly checks on the electrical wiring.", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "David Young", 1, 2, null, null, 2 }
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
                table: "WorkActivities",
                columns: new[] { "Id", "AssessmentId", "Name", "RiskAssessmentId" },
                values: new object[,]
                {
                    { 1, 1, "Use of MP facility", null },
                    { 2, 1, "Use of BYOD Notebooks, PCs, Equipment", null },
                    { 3, 1, "Use of soldering iron in MP labs for hardware related projects", null },
                    { 4, 1, "Handling of hand tools in MP Labs for hardware related projects", null },
                    { 5, 2, "Use of facility", null },
                    { 6, 2, "Use of PCs in Laboratory", null },
                    { 7, 2, "Maintenance and operation of lab equipment", null },
                    { 8, 2, "Handling component and lab materials", null },
                    { 9, 2, "Hand soldering", null },
                    { 10, 2, "Transportation of lab equipment", null }
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
                table: "RiskAssessments",
                columns: new[] { "Id", "ApprovalDate", "ApprovedStatus", "Approver", "AssessmentDate", "Department", "LastReviewDate", "Location", "Name", "NextReviewDate", "Process", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "John Smith", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temasek Poly (ENG)", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN10-2-15", "CEN MP Risk Assessment", new DateTime(2027, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEN MP - April 2024", 2 },
                    { 2, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Benjamin Scott", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "School of Engineering", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN15-06-051, EN15-06-052, EN15-06-053, EN15-06-055, EN15-06-057, EN15-06-058, EN16-03-35, EN16-03-42", "TP-ENG Laboratories Risk Assessment", new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELN/CEN/ABS/IFM/AEL/AEG//BME/IIT/MTN", 4 }
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
                name: "IX_ImageSources_RiskAssessmentId",
                table: "ImageSources",
                column: "RiskAssessmentId");

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
                name: "IX_RiskControls_RiskEvaluationId",
                table: "RiskControls",
                column: "RiskEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskEvaluations_HazardId",
                table: "RiskEvaluations",
                column: "HazardId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkActivities_RiskAssessmentId",
                table: "WorkActivities",
                column: "RiskAssessmentId");
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
                name: "ImageSources");

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
