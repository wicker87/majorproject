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
                name: "Alerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alerts_RiskAssessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "RiskAssessments",
                        principalColumn: "Id");
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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "17c0f03a-e374-4146-8eff-456862041bbf", "IT Manager", "janedoe@admin.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@ADMIN.COM", "JANEDOE@ADMIN.COM", "AQAAAAIAAYagAAAAEOvDjWpDkpRs/KmX2zB6kavPgVM3URqCW2WuzaAleEP+7WxUZDKKeQN4dpaR0SBsZg==", "64841415", false, "b8c22c41-e293-4408-aefe-8c0f7237113b", false, "janedoe@admin.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "39b9c9a2-127b-48cd-a2b2-358420ebb840", "Safety Inspector", "tommyjones@employee.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@EMPLOYEE.COM", "TOMMYJONES@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEGBFAp4/jOTmGtmpbiTIYz/XZpxDSbyGoyNYfwuYJZborswrpl6ObWErg9TmeI/XWw==", "65325334", false, "b7e5e92f-f0b0-4231-844a-e92c66f30a44", false, "tommyjones@employee.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "402a4e6d-c84a-46b5-9c2f-48a843403a0f", "Safety Manager", "johnsmith@manager.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@MANAGER.COM", "JOHNSMITH@MANAGER.COM", "AQAAAAIAAYagAAAAEGn30wPzF7w9oRm7IgpZhR1r9og3HiTiIKwPCgqa+0pnTMp148DuRxbauA2rZYGVzQ==", "67349033", false, "e9749b77-83d7-4ac0-895a-3f6a4ad5339f", false, "johnsmith@manager.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "9a47015a-973e-40f0-80fb-2794c7e3baf1", "Safety Manager", "benjaminscott@manager.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@MANAGER.COM", "BENJAMINSCOTT@MANAGER.COM", "AQAAAAIAAYagAAAAEIHe5rQa6ICwOg6BhmHG6lnIAwRyTUis6ZcEPQqSCG2gIJRO5QVwlKiyD0t5lfZsrw==", "62610071", false, "a449b91f-8dc0-4213-b3c9-52d9d3101e3f", false, "benjaminscott@manager.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "f8adc854-eb40-424e-ac50-4811f42fd876", "Safety Inspector", "ninachoo@employee.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@EMPLOYEE.COM", "NINACHOO@EMPLOYEE.COM", "AQAAAAIAAYagAAAAENxEOywYZc0tP0JB7EshmIVXZKKE0Ai84rqgx7tY+B1ucxOnM1JBUjeUoDB6Ek/Osg==", "65366623", false, "7e61705d-c2ea-42fc-ac5a-51708587163f", false, "ninachoo@employee.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "eed963b3-8a8d-4429-9eb5-7b68fd593415", "Safety Inspector", "warrenyoung@employee.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@EMPLOYEE.COM", "WARRENYOUNG@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEEBKpkEZeJD+c7WzVJJ2Spl7pIRTORdBgvfZ7KV6cnKbtE/v6QxE40EBkdjJJVIOow==", "63388585", false, "e71ede5e-42e3-4310-9c93-c586d969e9e1", false, "warrenyoung@employee.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "2c080f6e-10d2-416b-a8aa-9b9003f1f13c", "Safety Inspector", "stanleyhall@employee.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@EMPLOYEE.COM", "STANLEYHALL@EMPLOYEE.COM", "AQAAAAIAAYagAAAAECQvGd2wO7+pREaHelT/J8g7kWS+zxI4Pmjc3RbTHO5SAX8CLVRG+S+RMjNohYsUMA==", "63960815", false, "ab214650-c690-408d-bd26-de680372bc78", false, "stanleyhall@employee.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "1922254c-4d36-47a8-a44b-e0337dcb7fa3", "Safety Inspector", "kylethomas@employee.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@EMPLOYEE.COM", "KYLETHOMAS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEHYr/oTAMstIWS+DKx4hvIM8c9OH0MKcpo8i1uIyd3nnugOYShHOxw6soziUdrEHfQ==", "67361183", false, "1a4201a8-5f52-4c0c-829a-fda87e457611", false, "kylethomas@employee.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "39436c3c-ae47-4583-8a54-8ce49cbb6234", "Safety Inspector", "elizaross@employee.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@EMPLOYEE.COM", "ELIZAROSS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAECI/ejwnGPuZF6R5DllKDsDjHxiSRppfjMLyBDoSbr2nIqbBXlMFmscKtNCiFKYclw==", "67780373", false, "c53f08fc-52a4-4190-a1f7-5fe054a9e4ce", false, "elizaross@employee.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "8ef1066e-02c6-471c-8298-aa00a5bc0ff2", "Safety Inspector", "larryparker@employee.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@EMPLOYEE.COM", "LARRYPARKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEMUQRIyuqf0LGPuoZWasCNseqQqZv/rZeYY5rl+M1YfKG6c4I1kBtPwA1G51V5+Dgg==", "67771504", false, "318081a6-649a-40bd-8ac6-a128b675c421", false, "larryparker@employee.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "2cf02912-155e-4597-9442-d9646f2198e2", "Safety Inspector", "constancelee@employee.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@EMPLOYEE.COM", "CONSTANCELEE@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEPgsVTz5bE/+fLggznPHP5lm03jVQtug9mH4EJ+x36jNxemSXYxzEJFY5gYkWRmJpw==", "67457717", false, "b4398dd9-0710-4fd6-b907-ab013eb67544", false, "constancelee@employee.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "897a32b1-c87b-4a92-b534-abc9fc944c60", "Safety Manager", "jennielow@manager.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@MANAGER.COM", "JENNIELOW@MANAGER.COM", "AQAAAAIAAYagAAAAEHu262j6MYkZROc6CKgxTChG4G1uN1eHF1NP6j+QT0mpZme5aBNKunC8wyEdfdzV2A==", "62247473", false, "d7971881-8d28-44e7-9cc9-e78ef3f20234", false, "jennielow@manager.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "aa7d974f-44a3-4fea-a428-d62921331f3e", "Safety Manager", "emilybrown@manager.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@MANAGER.COM", "EMILYBROWN@MANAGER.COM", "AQAAAAIAAYagAAAAEOExHtFScUsfGeFFurVqsdRpGx3C1NOsLbPOp017N5O/2SH2URLY79Tzv1EcELEA7A==", "67528856", false, "aff9ed2c-71ba-4eed-ab99-f2cfe60ea01c", false, "emilybrown@manager.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "944a3b8f-c4e6-4659-b78c-28a42518f4cc", "Safety Inspector", "jimmybaker@employee.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@EMPLOYEE.COM", "JIMMYBAKER@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEECyj/ewA4BF6s2+m72NZCYL0UxL0oSOdFrrY4KVHPuUzJNkn7A3CI0r4Pk8cWG9DA==", "67789981", false, "04cb0ab2-eee0-4140-bfe9-6d640db492e3", false, "jimmybaker@employee.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "9d782f11-a3f3-4f39-9748-dca51d596556", "Safety Inspector", "bobbybrooks@employee.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@EMPLOYEE.COM", "BOBBYBROOKS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEARgpCZXMFJ2iX5U9+7KEetg1+0HtUNjp+aiNlX4Sq/BZf8/7MmfHP6q+capLPSlPg==", "62570046", false, "d0e22253-86f4-4e77-9a39-1bbceb47a104", false, "bobbybrooks@employee.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "d06218f2-edbf-48f3-ad37-0e1a57b2b7e9", "Safety Inspector", "bendanis@employee.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@EMPLOYEE.COM", "BENDANIS@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEFbTcXiQxBQNIFUF+iC5eHwu4QG2SnOIAoilapxnPMTpogG0XADX8xwePv5JacRFJw==", "68626846", false, "41af2025-65d1-44d8-a175-68676f24dc9a", false, "bendanis@employee.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "9b948782-a283-4653-90b5-1626cbfa917a", "Safety Inspector", "maddietay@employee.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@EMPLOYEE.COM", "MADDIETAY@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEKZhwxPiGtYbz8+vASx2+eoUy0knCH61BtWw1v79YLOOfKkMF/v8M6WNAwY+c5H+mg==", "63457266", false, "c7b25057-484e-4576-9dcd-e8690f6ec448", false, "maddietay@employee.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "68b1eb16-1868-40e3-a27b-880d4e92f75d", "Safety Manager", "kevinjones@manager.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@MANAGER.COM", "KEVINJONES@MANAGER.COM", "AQAAAAIAAYagAAAAECwE8ji5MhhSx6BGb/sdEmqqnrzleh3NyiPAFb0Lq7wEFL34Ch3XwSL5xNux5fEHew==", "68999888", false, "cc754b2c-9a5e-42fd-8756-7a1333a37750", false, "kevinjones@manager.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "52b19425-b870-49ca-9744-83a15dfaeab6", "Safety Inspector", "elenareed@employee.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@EMPLOYEE.COM", "ELENAREED@EMPLOYEE.COM", "AQAAAAIAAYagAAAAEE6tRen/hhPrsU2s/LcR8654p1ES3y8Zv3WNueGyB3TuQqTIC+pwQa0iuhc2Fp6a2A==", "63450508", false, "7c9566af-004e-42b3-a8e8-826f6e08c986", false, "elenareed@employee.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "798a331a-bf39-481b-90c9-320b99f1b109", "Safety Inspector", "jakehoward@employee.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@EMPLOYEE.COM", "JAKEHOWARD@EMPLOYEE.COM", "AQAAAAIAAYagAAAAELa0AL4Th7rimY8kp6BmBZKlZ9LL4JWM86tV1w/44o8W5Xs8bsZBh/I+EmvGBGLhOw==", "62678901", false, "760b7bbc-2e59-41a8-958d-dd3791bb6626", false, "jakehoward@employee.com" }
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
                    { 1, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "John Smith", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temasek Poly (ENG)", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN10-2-15", "CEN MP Risk Assessment", new DateTime(2027, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEN MP - April 2024", 2 },
                    { 2, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Benjamin Scott", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "School of Engineering", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "EN15-06-051, EN15-06-052, EN15-06-053, EN15-06-055, EN15-06-057, EN15-06-058", "TP-ENG Laboratories Risk Assessment", new DateTime(2027, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ELN/ CEN/ ABS/ IFM/ AEL/ AEG/ BME/ IIT/ MTN", 4 }
                });

            migrationBuilder.InsertData(
                table: "Alerts",
                columns: new[] { "Id", "AssessmentId", "DateTime", "Message" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 24, 10, 2, 30, 0, DateTimeKind.Unspecified), "📄A new risk assessment, CEN MP Risk Assessment, has been created." },
                    { 2, 1, new DateTime(2024, 4, 26, 17, 30, 28, 0, DateTimeKind.Unspecified), "✅John Smith (Manager) has approved the risk assessment, CEN MP Risk Assessment." },
                    { 3, 2, new DateTime(2024, 5, 10, 14, 12, 41, 0, DateTimeKind.Unspecified), "📄A new risk assessment, TP-ENG Laboratories Risk Assessment, has been created." },
                    { 4, 2, new DateTime(2024, 5, 13, 15, 20, 5, 0, DateTimeKind.Unspecified), "❎Benjamin Scott (Manager) has unapproved the risk assessment, TP-ENG Laboratories Risk Assessment." },
                    { 5, 2, new DateTime(2024, 5, 15, 18, 5, 21, 0, DateTimeKind.Unspecified), "✅Benjamin Scott (Manager) has approved the risk assessment, TP-ENG Laboratories Risk Assessment." }
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
                name: "IX_Alerts_AssessmentId",
                table: "Alerts",
                column: "AssessmentId");

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
                name: "Alerts");

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
