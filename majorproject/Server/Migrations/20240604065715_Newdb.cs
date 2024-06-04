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
                    RiskTeamId = table.Column<int>(type: "int", nullable: true),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskAssessments_RiskTeams_RiskTeamId",
                        column: x => x.RiskTeamId,
                        principalTable: "RiskTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentId = table.Column<int>(type: "int", nullable: true),
                    RiskAssessmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_RiskAssessments_RiskAssessmentId",
                        column: x => x.RiskAssessmentId,
                        principalTable: "RiskAssessments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hazards",
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
                    table.PrimaryKey("PK_Hazards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hazards_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
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
                        name: "FK_RiskEvaluations_Hazards_HazardId",
                        column: x => x.HazardId,
                        principalTable: "Hazards",
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
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "e2fc5c8b-05b9-470e-aa0f-344fc356cc24", "IT Manager", "janedoe@gmail.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@GMAIL.COM", "JANEDOE@GMAIL.COM", "AQAAAAIAAYagAAAAEHkPne/ww9M3uBiMyloRZw6s8b/mzL/UuALw9bbjpjVVJ8Aqh0g81j3zmgCiVsYVaA==", "64841415", false, "38aae0f3-b9ba-46dd-a9ec-b88f4e15c93e", false, "janedoe@gmail.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "55c6b882-9a85-4a05-a843-29aab7d1a079", "Safety Inspector", "tommyjones@gmail.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@GMAIL.COM", "TOMMYJONES@GMAIL.COM", "AQAAAAIAAYagAAAAENwQ2ba7phOpi9A+e8rKIDlma/aC0a1P1zpZK2w0bJmZg1qogNOgdhQRUz/DLMnzpA==", "65325334", false, "8c23ceaf-a9c0-458f-a408-5137c6a2c2c8", false, "tommyjones@gmail.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "26e5f4dc-2d10-4fab-a6b9-426076fb5224", "Safety Manager", "johnsmith@gmail.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@GMAIL.COM", "JOHNSMITH@GMAIL.COM", "AQAAAAIAAYagAAAAEOAuWG58yu5SAmI/fmWpZ9ySirkg0o1c4lbA+IU1qi9DBv0wR5edvfd/NVVYeE3Tog==", "67349033", false, "72e468df-bca4-41e3-b33b-983bb69be3bf", false, "johnsmith@gmail.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "f1e95e21-6d92-4152-a565-9c7742d216ba", "Safety Manager", "benjaminscott@gmail.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@GMAIL.COM", "BENJAMINSCOTT@GMAIL.COM", "AQAAAAIAAYagAAAAEJCrxZdGPnHRmNfgVLpe8kpoZyjARqLv65uZzn6D+nL2ma3wAwvo6CFZrJz1EARfiA==", "62610071", false, "2f9ef320-e4dd-4453-adee-6ae2396b141d", false, "benjaminscott@gmail.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "d5091170-8a0b-4dbe-a63d-d69fc4df0c13", "Safety Inspector", "ninachoo@gmail.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@GMAIL.COM", "NINACHOO@GMAIL.COM", "AQAAAAIAAYagAAAAEFPxekOfppNCku4kxya7mE0WKcCWNCo6y5TACiv49WDLVPkiAH8V6zF62FHA57PQ2g==", "65366623", false, "e37a8047-6492-4fb7-89ae-1c8e3df3dbf8", false, "ninachoo@gmail.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "967a58ae-86d6-49a2-a4d3-24992d68545a", "Safety Inspector", "warrenyoung@gmail.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@GMAIL.COM", "WARRENYOUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEK/U8UrxKXc35JHg9J5+3Z0avvbL76oQ576LZZu2WCqgIAlipXDv/Lvn2YOmhNbdPQ==", "63388585", false, "1c44ff07-da7a-4c75-a956-d011f34f97a5", false, "warrenyoung@gmail.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "4fd4a6d6-d3b9-4460-9bd4-2733e9337358", "Safety Inspector", "stanleyhall@gmail.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@GMAIL.COM", "STANLEYHALL@GMAIL.COM", "AQAAAAIAAYagAAAAEIST+SeTDhSXnVoteEL12SN4oxSKHmJjtW4nkW6xwoBhT76/UPa0mKx3w/LJfNSg9g==", "63960815", false, "9feee28e-f633-40d2-a7e0-9551ed71b7f8", false, "stanleyhall@gmail.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "d52ec7ca-d939-40dc-acfd-ef358ab265e3", "Safety Inspector", "kylethomas@gmail.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@GMAIL.COM", "KYLETHOMAS@GMAIL.COM", "AQAAAAIAAYagAAAAEJ53aXepwknZm8yD+8zNBL1gwzE1HVduWOx5qE9sazReSkol6FMNIxY3QintEbdILw==", "67361183", false, "11906851-5e60-46c6-967a-bd8d7dda50e4", false, "kylethomas@gmail.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "8e76e174-2d2d-4368-910f-6d75eb7b0c8c", "Safety Inspector", "elizaross@gmail.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@GMAIL.COM", "ELIZAROSS@GMAIL.COM", "AQAAAAIAAYagAAAAEMwDnxRHPBCSHgf6e7ISntU2mOLlla5mo/vyYvkTRL0il7u6ppZJ2NMKFimfhEkCrw==", "67780373", false, "220e0f0a-7436-4e72-bb1c-6e818c6bf97b", false, "elizaross@gmail.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "301b8f3f-056d-4e1d-96c0-39ffebf7426f", "Safety Inspector", "larryparker@gmail.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@GMAIL.COM", "LARRYPARKER@GMAIL.COM", "AQAAAAIAAYagAAAAENIq+Vz80qlGBiFvUL9Lw5S6VhGrZX6kGH4Bgy/O+leR/V7wAEwuHUik4P59QBmucw==", "67771504", false, "d1d19e2b-778a-444a-aa0e-7ba2c5a9e855", false, "larryparker@gmail.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "29a4ca84-ed45-45d2-8199-292fb9dcc0ee", "Safety Inspector", "constancelee@gmail.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@GMAIL.COM", "CONSTANCELEE@GMAIL.COM", "AQAAAAIAAYagAAAAEDXItgdWPOh5odmKiYqPITugzXrZ/S6SPfjgIOb2MNhTQcuYywwsse5RbnsO0fSFyQ==", "67457717", false, "48a1c097-f0bb-4e24-b96d-3de1e008ea22", false, "constancelee@gmail.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "218691a2-2ac9-44b0-932c-c71786c86178", "Safety Manager", "jennielow@gmail.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@GMAIL.COM", "JENNIELOW@GMAIL.COM", "AQAAAAIAAYagAAAAEC+7fLsBiHpBPdxRlWFVPsJX8yu0laDcQvLDAstRJvWLcn9rAXuQEEPk7lEcmm3lNw==", "62247473", false, "939125e9-751e-41cf-a43a-a62d0472a67e", false, "jennielow@gmail.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "35ab4f3e-6abd-427a-860f-149534ba41c4", "Safety Manager", "emilybrown@gmail.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@GMAIL.COM", "EMILYBROWN@GMAIL.COM", "AQAAAAIAAYagAAAAEE4DHwV6uawYPp+y4Yig0Wizmd2/0TEOltuu3bleXEX0L6nlvWPZ6wLJpjy6I6g9mw==", "67528856", false, "26859201-941a-4850-b255-9045638ab955", false, "emilybrown@gmail.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "1443257b-b1a0-4f93-84fd-9e78355d1723", "Safety Inspector", "jimmybaker@gmail.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@GMAIL.COM", "JIMMYBAKER@GMAIL.COM", "AQAAAAIAAYagAAAAEKYDTKNLqf7Jjtl/Q7vpNU9WA5PwYbnyXp0KSr/IrtduAKve8xxnQn32NtgNjX3s5A==", "67789981", false, "b3fa1f07-e82d-4182-a719-ac97b5e5bda4", false, "jimmybaker@gmail.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "8f1417bf-86a7-476e-bb22-1f086f1b6650", "Safety Inspector", "bobbybrooks@gmail.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@GMAIL.COM", "BOBBYBROOKS@GMAIL.COM", "AQAAAAIAAYagAAAAED2XdvVTpZI2UYsvOjhy6ndBwIImggyPk8anN50d/kSyfvCBeb5XK2Flprwn3Cd4Wg==", "62570046", false, "35d530ba-c751-4d1a-b0f8-24fd0d2e07d6", false, "bobbybrooks@gmail.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "ec37b001-33eb-4033-a2b3-a4789bcb673b", "Safety Inspector", "bendanis@gmail.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@GMAIL.COM", "BENDANIS@GMAIL.COM", "AQAAAAIAAYagAAAAEJqPN4bWrvyowM0QZK0v/rtJ0COp+6B2vQLlLRBQkYIs1ozJ0bsc0GNUnG0w2nDnDQ==", "68626846", false, "9bb23b6d-76d8-478f-ad09-35f6b76bf4be", false, "bendanis@gmail.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "26bd16b3-7da6-469d-a55a-cfebb607eb32", "Safety Inspector", "maddietay@gmail.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@GMAIL.COM", "MADDIETAY@GMAIL.COM", "AQAAAAIAAYagAAAAEBd3xHQzcffcH+vioStMYFtvqPAKUIiWqXtrn8JiYy103DqJC77HTGUd5yD4VYxZvA==", "63457266", false, "e1df1aa1-8b7c-45e1-b638-c2ead3e53a01", false, "maddietay@gmail.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "10f9f04d-d02d-429c-a605-2645b9610580", "Safety Manager", "kevinjones@gmail.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@GMAIL.COM", "KEVINJONES@GMAIL.COM", "AQAAAAIAAYagAAAAEKXfoEym3qwm+RGXoD67A9Z/U/smLPBjvtyEDJeSHsSibvKsunDV62UQL9sZcoc+Xg==", "68999888", false, "c79d3a94-028c-45b6-8051-b4c3d4b550d3", false, "kevinjones@gmail.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "d58b6b20-e07c-4245-8d4b-4e5590ef3694", "Safety Inspector", "elenareed@gmail.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@GMAIL.COM", "ELENAREED@GMAIL.COM", "AQAAAAIAAYagAAAAEOEwzNAUDumsqhF6KKHwod2tOAVpr06j8LGbW1NFFP1gH/AAoSe24VU8+4BCVpYT6A==", "63450508", false, "a46ca23c-4ffe-4c2e-b6b6-59aa18cb4f1f", false, "elenareed@gmail.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "f7542cd8-7abf-4384-9cc8-ed3eea54b50e", "Safety Inspector", "jakehoward@gmail.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@GMAIL.COM", "JAKEHOWARD@GMAIL.COM", "AQAAAAIAAYagAAAAEKsdl/y/Ez9MQFmIEPaXKtoMuokony2TBTW+x90bS92mFwvxoIrwNpbObfLtmTcpZw==", "62678901", false, "74f5f6ad-99f0-4e4a-ad5f-98f015242c31", false, "jakehoward@gmail.com" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Activities_RiskAssessmentId",
                table: "Activities",
                column: "RiskAssessmentId");

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
                name: "IX_Hazards_ActivityId",
                table: "Hazards",
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
                name: "IX_RiskAssessments_RiskTeamId",
                table: "RiskAssessments",
                column: "RiskTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskControls_RiskEvaluationId",
                table: "RiskControls",
                column: "RiskEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskEvaluations_HazardId",
                table: "RiskEvaluations",
                column: "HazardId");
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
                name: "Hazards");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "RiskAssessments");

            migrationBuilder.DropTable(
                name: "RiskTeams");
        }
    }
}
