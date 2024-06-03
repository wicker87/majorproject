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
                name: "RAFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAFs", x => x.Id);
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
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormId = table.Column<int>(type: "int", nullable: true),
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
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfApproval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: true),
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
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberFive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormId = table.Column<int>(type: "int", nullable: true),
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
                name: "Hazards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HazardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    AddControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    Likelihood = table.Column<int>(type: "int", nullable: true),
                    RPN = table.Column<int>(type: "int", nullable: true),
                    ImplementingPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskEId = table.Column<int>(type: "int", nullable: true),
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
                table: "Activities",
                columns: new[] { "Id", "FormId", "RAFId", "WorkActivity" },
                values: new object[] { 1, null, null, "Use of MP facility (Lab) (Reference: ENG-TWSH-TS01-RA001)" });

            migrationBuilder.InsertData(
                table: "Approvals",
                columns: new[] { "Id", "Approved", "DateOfApproval", "FormId", "Name", "RAFId" },
                values: new object[] { 1, true, new DateTime(2024, 6, 3, 12, 14, 38, 412, DateTimeKind.Local).AddTicks(1100), null, "tom", null });

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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "bbaf49cd-0749-4f97-a801-3af2b65bd213", "IT Manager", "janedoe@gmail.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@GMAIL.COM", "JANEDOE@GMAIL.COM", "AQAAAAIAAYagAAAAEMNTG+z6dH7W/gogWRJ1K9GaFYOu7eyrCNyHuTuiItxcqRsj2IpUnLWulZZkrcp/WA==", "64841415", false, "697bc3fc-3311-4793-a913-d00ed615a663", false, "janedoe@gmail.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "ebeebdf0-92d2-47ee-b669-9c508f1a2b3e", "Safety Inspector", "tommyjones@gmail.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@GMAIL.COM", "TOMMYJONES@GMAIL.COM", "AQAAAAIAAYagAAAAECbbPEBWflLQC5ThUYTX+qnmTKlUgNeU6q/lFxaWxZ9eQU1Aq9mtU8H81bj9NTX5HQ==", "65325334", false, "80dfd901-74a3-4fe4-bf9d-c8beb175ec90", false, "tommyjones@gmail.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "d9cb1d3e-2c16-483f-82cd-647acc043dc1", "Safety Manager", "johnsmith@gmail.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@GMAIL.COM", "JOHNSMITH@GMAIL.COM", "AQAAAAIAAYagAAAAEHfgLiaqDX4aEyh3ZvVQfg8Q62SZO8crN8Lpk56u9qoLEptvGFMYXSBRT71jKJyElQ==", "67349033", false, "862d7a22-22fb-4571-9351-78a4240cb09f", false, "johnsmith@gmail.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "f66a6993-9b08-49bc-aebb-48735097762f", "Safety Manager", "benjaminscott@gmail.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@GMAIL.COM", "BENJAMINSCOTT@GMAIL.COM", "AQAAAAIAAYagAAAAEJ5x4RBNLzRB4fOJaJYzJrry/sh8pyOFpj8nIkS9eoTTqaqfbdy2Jkh0gRipVm6SLw==", "62610071", false, "e699a62f-9fc0-4ecb-bb50-d4c645b3e104", false, "benjaminscott@gmail.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "a134ea0b-8a47-426b-9aef-eb290a4c7afc", "Safety Inspector", "ninachoo@gmail.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@GMAIL.COM", "NINACHOO@GMAIL.COM", "AQAAAAIAAYagAAAAEOg6Zjxt7GHcW1+GCFuW8t6HU88HVs91d4PxcrqM0LPSg1i8KVcJ8HZ0i64Eqwh7mA==", "65366623", false, "2d820318-b806-4fe1-97b1-3f0d1315804f", false, "ninachoo@gmail.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "45b9f8ff-9610-4b4a-a224-1bc7938cb1f8", "Safety Inspector", "warrenyoung@gmail.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@GMAIL.COM", "WARRENYOUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEBE8Etr7kNV8wilCcBlmeG2w0pqyDyrFX5d5y9mRyfnYm96sePZUhXm9Hev5tccumw==", "63388585", false, "0ee7779f-887e-4bbf-af82-463066ac5f07", false, "warrenyoung@gmail.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "62f5455f-0b63-4e47-8ba6-8367195d75f3", "Safety Inspector", "stanleyhall@gmail.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@GMAIL.COM", "STANLEYHALL@GMAIL.COM", "AQAAAAIAAYagAAAAEB4hcAquE+XosOHq/j0x8NsnxMYMaoL4oT0N2oZ/Mv9yC2uFCVg/05HIKqNFebXEMw==", "63960815", false, "c5371cac-4007-4a31-adb8-5616b7ed335b", false, "stanleyhall@gmail.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "dccb11b2-0130-4556-946e-44662fac7cfd", "Safety Inspector", "kylethomas@gmail.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@GMAIL.COM", "KYLETHOMAS@GMAIL.COM", "AQAAAAIAAYagAAAAEDN1iOxzB54yOGmOYDv5bZpUj4jVy4UcheBeiRxr+yGMy5yRM8oM5TOfWDmwYaWL8g==", "67361183", false, "7190af5b-93d9-473d-afbc-4eb395ef533d", false, "kylethomas@gmail.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "422f4926-cc73-4927-9ac5-a29a63d659df", "Safety Inspector", "elizaross@gmail.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@GMAIL.COM", "ELIZAROSS@GMAIL.COM", "AQAAAAIAAYagAAAAEHahBeA94fvegw1PlQuVaFIiRswZGaVc2RIoqiPUwX7eg7ey4V5FdCjW4w7JnGuB4A==", "67780373", false, "61376544-bb43-41cf-bb63-87836afe0ed7", false, "elizaross@gmail.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "3028d1d0-200d-4f48-927d-ee71c89d785d", "Safety Inspector", "larryparker@gmail.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@GMAIL.COM", "LARRYPARKER@GMAIL.COM", "AQAAAAIAAYagAAAAEHaZMK+BSOUdW1QQahRU4np7NWcz0QkHIFGRloJe1ZeUHKwWMwfRwV7sH2yOBUa3Eg==", "67771504", false, "8c6fc6dd-fd98-4382-918a-0f2dceca6930", false, "larryparker@gmail.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "64f58d4b-1911-4733-a3e2-66104fa2c1e7", "Safety Inspector", "constancelee@gmail.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@GMAIL.COM", "CONSTANCELEE@GMAIL.COM", "AQAAAAIAAYagAAAAEPNQ22/KfKs3UvuPZtTlJ3lG4YDJC3QSqgV42mxUWE/tlNU4EuOIv2UrAbIph13gyQ==", "67457717", false, "ec339661-81b4-4f75-8add-d93f28eca9f4", false, "constancelee@gmail.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "792c33df-90b0-4b7d-bba2-c1476fd2ad90", "Safety Manager", "jennielow@gmail.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@GMAIL.COM", "JENNIELOW@GMAIL.COM", "AQAAAAIAAYagAAAAEOO52TxUepEognYRN2G4hLPu8RRwu5cHKB4Aw2SQSXtY+OWPbLsuLB0mFQWjtiKt1Q==", "62247473", false, "9dfd4029-158d-4367-b024-d16d57929168", false, "jennielow@gmail.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "c4b8f1a1-d748-4a92-9eeb-188c6f1f80da", "Safety Manager", "emilybrown@gmail.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@GMAIL.COM", "EMILYBROWN@GMAIL.COM", "AQAAAAIAAYagAAAAEMolQ7qmqqdbaP1FgTZ/bSF+aiACtVnMvoe/7lttk16kCWg1hl1SuKJfwfRYw9XIhw==", "67528856", false, "9fc197cd-beb6-470f-a470-b680ecb40293", false, "emilybrown@gmail.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "71a9bc7f-1984-4c71-9a77-a86e9f17ecab", "Safety Inspector", "jimmybaker@gmail.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@GMAIL.COM", "JIMMYBAKER@GMAIL.COM", "AQAAAAIAAYagAAAAEB+AJLPkdZs4Sqg+6hRZ9qgxjDiRUdkpvosNsGeLkOiNOySyJa+0GGqe45Ed+hQIRw==", "67789981", false, "80639be4-4199-41ee-a3e6-58522a03da66", false, "jimmybaker@gmail.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "6d75a914-e74d-482c-9d75-b41d27006a4c", "Safety Inspector", "bobbybrooks@gmail.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@GMAIL.COM", "BOBBYBROOKS@GMAIL.COM", "AQAAAAIAAYagAAAAEOL947pWoLq/fhyA9EbHZaEmCnmoMB0N3xZ9JBM5runiOdqWceUQAkDN28Bz/0Ch+A==", "62570046", false, "03ab37a5-b1ab-443c-bf49-96bb65ed8c7e", false, "bobbybrooks@gmail.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "4021901a-6dd6-4e8b-b4e4-6df689193398", "Safety Inspector", "bendanis@gmail.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@GMAIL.COM", "BENDANIS@GMAIL.COM", "AQAAAAIAAYagAAAAEEB7a96lZsshrPS8ScrxZM2U+zPg3SAF6/UNWuAC4wtb39a6OE1Bw5hV791RoXWEMQ==", "68626846", false, "dd2c1585-3d2f-4903-8cdd-417e7a038775", false, "bendanis@gmail.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "9c5d88bb-2d80-4b40-b4b0-b4935602c94c", "Safety Inspector", "maddietay@gmail.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@GMAIL.COM", "MADDIETAY@GMAIL.COM", "AQAAAAIAAYagAAAAEEDsVAmkCkZ9rfkAk02+nfbX6QL0zT/8w2wd/V5ZNDosco+1/NZVY02YsW4T2rawzA==", "63457266", false, "cba96148-ff82-4aa6-9d58-671d0b343609", false, "maddietay@gmail.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "dcbabbdc-5a18-4d97-baae-d74e34f20bb5", "Safety Manager", "kevinjones@gmail.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@GMAIL.COM", "KEVINJONES@GMAIL.COM", "AQAAAAIAAYagAAAAEPvups3UeyY0l7dO93gVMExg8xxAvfl1QSwU1qULtojRS5SwF+i2r25QETaCZQwKXg==", "68999888", false, "04b6cbe8-ad91-4783-a6a0-0db3ea83a273", false, "kevinjones@gmail.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "0731eda5-8d94-4a75-9a57-c1ff7c9e25f7", "Safety Inspector", "elenareed@gmail.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@GMAIL.COM", "ELENAREED@GMAIL.COM", "AQAAAAIAAYagAAAAEHLzeiSXJ79gwkRDUpG20PtTUgB2NeaNERAFhxID5IQUp5GDz3kJDFu2qtOORt737Q==", "63450508", false, "612e73d3-0146-48cf-bc70-5c3e9b82ce83", false, "elenareed@gmail.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "36f106eb-d759-4425-aa66-b3cd8329dde3", "Safety Inspector", "jakehoward@gmail.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@GMAIL.COM", "JAKEHOWARD@GMAIL.COM", "AQAAAAIAAYagAAAAEH/1GGy0zgiSdhxNq+z9efXhxYL+hJyKxUVSJ1vA83/+5UHrljfqTqctF5EE2Zdn3w==", "62678901", false, "ec9decae-45ba-4428-bf1b-889ff48ae456", false, "jakehoward@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Hazards",
                columns: new[] { "Id", "ActivityId", "HazardName", "PossibleInjury" },
                values: new object[] { 1, null, "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor", "Bodily Injuries" });

            migrationBuilder.InsertData(
                table: "RAFs",
                columns: new[] { "Id", "AssessmentDate", "Department", "LastReviewDate", "Location", "NextReviewDate", "Process" },
                values: new object[] { 1, new DateTime(2024, 6, 3, 12, 14, 38, 412, DateTimeKind.Local).AddTicks(1944), "TP Staff", new DateTime(2024, 6, 3, 12, 14, 38, 412, DateTimeKind.Local).AddTicks(1945), "EN10-2-15", new DateTime(2024, 6, 3, 12, 14, 38, 412, DateTimeKind.Local).AddTicks(1946), "CEN MP - April 2024" });

            migrationBuilder.InsertData(
                table: "RiskControls",
                columns: new[] { "Id", "AddControl", "DueDate", "ImplementingPerson", "Likelihood", "RPN", "Remarks", "RiskEId", "RiskEvaluationId", "Severity" },
                values: new object[] { 1, "", new DateTime(2024, 6, 3, 12, 14, 38, 412, DateTimeKind.Local).AddTicks(630), "", 0, 0, "", null, null, 0 });

            migrationBuilder.InsertData(
                table: "RiskEvaluations",
                columns: new[] { "Id", "ExistingRiskControls", "HazardId", "Likelihood", "RPN", "Severity" },
                values: new object[] { 1, "Trip and fall due to loose network and power extension cables, damaged floor tiles and wet floor", null, 1, 2, 2 });

            migrationBuilder.InsertData(
                table: "RiskTeams",
                columns: new[] { "Id", "FormId", "Leader", "MemberFive", "MemberFour", "MemberOne", "MemberThree", "MemberTwo", "RAFId" },
                values: new object[] { 1, null, "Mr Tan Cheng Khoon", "", "", "Chai Zhuo Lym Ryan", "Lim Yee Zhe", "Peh Jun Jie", null });

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
                name: "IX_Activities_RAFId",
                table: "Activities",
                column: "RAFId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_RAFId",
                table: "Approvals",
                column: "RAFId");

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
                name: "IX_RiskControls_RiskEvaluationId",
                table: "RiskControls",
                column: "RiskEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskEvaluations_HazardId",
                table: "RiskEvaluations",
                column: "HazardId");

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
                name: "RiskTeams");

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
                name: "RAFs");
        }
    }
}
