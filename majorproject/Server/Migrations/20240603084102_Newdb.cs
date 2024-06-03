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
                    { "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc", 0, "abb08e54-cc86-4e1f-a9e4-3201634d386a", "IT Manager", "janedoe@gmail.com", false, 1003, "Jane", "Doe", false, null, "JANEDOE@GMAIL.COM", "JANEDOE@GMAIL.COM", "AQAAAAIAAYagAAAAEJOZgtbzttvOMHPcs8AZaHciZbkyFkEYhs+nHHY80/vM0LQWnqWPa6eG4KPOfeujEQ==", "64841415", false, "f15100ca-dffc-4bac-80c3-915d37fdf287", false, "janedoe@gmail.com" },
                    { "1519fcce-c355-4cad-8b22-01b76b762ffc", 0, "5e9bee21-f59f-44a9-af24-47b15173367d", "Safety Inspector", "tommyjones@gmail.com", false, 1886, "Tommy", "Jones", false, null, "TOMMYJONES@GMAIL.COM", "TOMMYJONES@GMAIL.COM", "AQAAAAIAAYagAAAAEHOG5MROLN2/6F+daT1y3XB/8mox0a1vwu49zhbsniVR9vpOR0Lug1PszGCaNwfkhA==", "65325334", false, "9d5bd219-c794-49e2-9bf7-849f71f64925", false, "tommyjones@gmail.com" },
                    { "23cdf685-e508-4fc6-84cc-c860af2dd301", 0, "e65279e9-3a09-4f66-9eea-ceb1c28f0495", "Safety Manager", "johnsmith@gmail.com", false, 2010, "John", "Smith", false, null, "JOHNSMITH@GMAIL.COM", "JOHNSMITH@GMAIL.COM", "AQAAAAIAAYagAAAAEHqCV67+V7TRIvimzhZWSG0c2lGRLpIxfCkBhLBD9w4K/mkVx7+Nuim/CdjpRgdCTA==", "67349033", false, "22bddebf-8903-4782-a927-52bcc958d592", false, "johnsmith@gmail.com" },
                    { "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5", 0, "0e3ebd51-f13c-4e88-84cd-d911c3c6661b", "Safety Manager", "benjaminscott@gmail.com", false, 1794, "Benjamin", "Scott", false, null, "BENJAMINSCOTT@GMAIL.COM", "BENJAMINSCOTT@GMAIL.COM", "AQAAAAIAAYagAAAAEPGsr66SADl/9qSXQMroy2PkrEEPSNfvI7qqvIqJNE3U0LfZmeFYJOSiWRZvYqSq7g==", "62610071", false, "41f2a2e9-5a6d-4524-b4b3-bb2eff5bcaa5", false, "benjaminscott@gmail.com" },
                    { "33a4bc04-9b10-49a5-8cb6-8dea48b122c4", 0, "41333700-a4e3-414d-b402-2890b5df233f", "Safety Inspector", "ninachoo@gmail.com", false, 1170, "Nina", "Choo", false, null, "NINACHOO@GMAIL.COM", "NINACHOO@GMAIL.COM", "AQAAAAIAAYagAAAAEHyyZGhSYxTAx6C1wIB0igyoKoNbxAHLLJxHdwUCrynJKiZJV9CJQ5E24NtlL+OaAg==", "65366623", false, "c818bc77-2489-4163-8849-d6b67e1c652c", false, "ninachoo@gmail.com" },
                    { "5258daf7-0bf7-4460-a854-4b3f427312c7", 0, "fd8246d7-86e0-494c-8f67-c3715d6cf5f3", "Safety Inspector", "warrenyoung@gmail.com", false, 1331, "Warren", "Young", false, null, "WARRENYOUNG@GMAIL.COM", "WARRENYOUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEMyy/ZAQ97GEEAdwP6dn7Abdt5kNX8hEP07bA9cpxcEfNsv3fCeyXOF8pyJ7MJ538g==", "63388585", false, "3c1b60c4-f04d-4542-ae48-3c5613174458", false, "warrenyoung@gmail.com" },
                    { "5859b058-1d6e-4b79-8040-9bbd204c0dc5", 0, "d7bd2ec8-0865-4820-9451-65ee8be52df6", "Safety Inspector", "stanleyhall@gmail.com", false, 1243, "Stanley", "Hall", false, null, "STANLEYHALL@GMAIL.COM", "STANLEYHALL@GMAIL.COM", "AQAAAAIAAYagAAAAEJc+3SOSS/SiTg/53Ey12+U30uXcHEdlGUwbB3lntQmPeN3+603W0Z6DEDZNFiJMKQ==", "63960815", false, "7581e2fa-97aa-4d9c-9ba3-2d10f729b557", false, "stanleyhall@gmail.com" },
                    { "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28", 0, "014145c8-d389-4c01-b11b-802ea8ecb7e9", "Safety Inspector", "kylethomas@gmail.com", false, 1426, "Kyle", "Thomas", false, null, "KYLETHOMAS@GMAIL.COM", "KYLETHOMAS@GMAIL.COM", "AQAAAAIAAYagAAAAEGYS80J7RNdVODmAG+SjO2MaLDOEfbGjXWirbZCUhbBVHTosklzX/WL+98EfLydd3g==", "67361183", false, "f8d6aa1a-7b7b-4290-bae0-9217a5edb879", false, "kylethomas@gmail.com" },
                    { "63929151-0e12-4c5c-a03c-01c34642856a", 0, "58e7565b-d140-4ac7-b8e5-735c2b2ec3e2", "Safety Inspector", "elizaross@gmail.com", false, 1140, "Eliza", "Ross", false, null, "ELIZAROSS@GMAIL.COM", "ELIZAROSS@GMAIL.COM", "AQAAAAIAAYagAAAAEH59rLMkIe7hMrQksZQ23J8F7MW3G7ZaK3681TLAdavOi2cbWlnGzfD/1sFCKh8DlA==", "67780373", false, "c0386d88-6e6f-431a-a8bc-91217c95db8a", false, "elizaross@gmail.com" },
                    { "6f84b324-5cc8-48b6-a348-57c74b3d5294", 0, "ee4dc9a3-120a-433d-a3e6-45ffe0020d13", "Safety Inspector", "larryparker@gmail.com", false, 2144, "Larry", "Parker", false, null, "LARRYPARKER@GMAIL.COM", "LARRYPARKER@GMAIL.COM", "AQAAAAIAAYagAAAAEAq+pJXxcve01GbNdtcYfikLoLElCK3Di2RkGcFFfP7q2WpXFgqGfRgY2Qi5N050eQ==", "67771504", false, "19eafbdb-d43c-47e5-88d0-51226906d870", false, "larryparker@gmail.com" },
                    { "77ea0c8c-fa62-4e13-980a-63ed5336f0b2", 0, "b1bb9110-8b1e-42b7-a28b-ca6c8cc7869a", "Safety Inspector", "constancelee@gmail.com", false, 1483, "Constance", "Lee", false, null, "CONSTANCELEE@GMAIL.COM", "CONSTANCELEE@GMAIL.COM", "AQAAAAIAAYagAAAAEJoXPKOnpcAOIYmaM3WVKff6KkQFrt/SFx4UDqMdXARYnw34lPcYlOQZdLozBkL3sw==", "67457717", false, "52266161-f1dd-4d13-97de-3bf37e65fa90", false, "constancelee@gmail.com" },
                    { "8d06620d-3d31-4c1c-9449-7eaac032f6bd", 0, "3ad6b258-20e0-4e6f-a140-bf4805168d58", "Safety Manager", "jennielow@gmail.com", false, 1748, "Jennie", "Low", false, null, "JENNIELOW@GMAIL.COM", "JENNIELOW@GMAIL.COM", "AQAAAAIAAYagAAAAEIu+/BdJyqqyicEOfWakjkzIRJipjBdjDcmEEOQX/XeVh8QLROwQsxxSVbsuQ+Ex5Q==", "62247473", false, "02a8ad39-cd12-425a-9cde-7a348d439bda", false, "jennielow@gmail.com" },
                    { "911dd5ac-5093-444e-bd8d-b6fed36dcada", 0, "d873bd80-93d5-4015-b1ab-8ab091062371", "Safety Manager", "emilybrown@gmail.com", false, 1061, "Emily", "Brown", false, null, "EMILYBROWN@GMAIL.COM", "EMILYBROWN@GMAIL.COM", "AQAAAAIAAYagAAAAENxzuk3bah66szjrzGPVVJ67Th7zsIP4lwwvWgTcOTmI05uvSVf0ksYkPZRcqs2Sug==", "67528856", false, "d1a01757-5c3b-48fc-9c6b-49538e784a88", false, "emilybrown@gmail.com" },
                    { "b57e892b-0bdb-4469-afd9-e6522fea2f25", 0, "de0e1e89-1951-4044-a85a-21a40d3663e4", "Safety Inspector", "jimmybaker@gmail.com", false, 2156, "Jimmy", "Baker", false, null, "JIMMYBAKER@GMAIL.COM", "JIMMYBAKER@GMAIL.COM", "AQAAAAIAAYagAAAAEBJ4OXozbTUjzGrJudQjzYZnFZP8I4eqPkiFxIzez9h+xHSXbqtGcjJ2QlL1bgFSEQ==", "67789981", false, "b7aa9aa6-1b9a-4bfb-9482-4be44c448471", false, "jimmybaker@gmail.com" },
                    { "cda313e3-33c1-4e6e-982b-3c5eb9ff9565", 0, "0fc0e5eb-b2e8-4952-bab4-9d990c0cfdf0", "Safety Inspector", "bobbybrooks@gmail.com", false, 1507, "Bobby", "Brooks", false, null, "BOBBYBROOKS@GMAIL.COM", "BOBBYBROOKS@GMAIL.COM", "AQAAAAIAAYagAAAAEFB+tAAFRKc2dhsBeWNOgd3yVtWSfpky/b4Cm4HzohssgQkk+6nqdB8VmZflnrUoGA==", "62570046", false, "2647c284-6524-4875-8310-c3bc94ba4d51", false, "bobbybrooks@gmail.com" },
                    { "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563", 0, "a61527dd-1715-46ae-b8f7-2b60652f9ea5", "Safety Inspector", "bendanis@gmail.com", false, 2024, "Ben", "Danis", false, null, "BENDANIS@GMAIL.COM", "BENDANIS@GMAIL.COM", "AQAAAAIAAYagAAAAELBJULNS6/1hzmCe8xvPs5pOjoe6egNOflQnnExT3DLYAa4LCkWIRmxJXUR+kHI9iw==", "68626846", false, "f93b3f95-be51-410e-a5f6-d3b0fc517b8d", false, "bendanis@gmail.com" },
                    { "e5e8acfe-c59a-4b4d-bba4-d40057aecef4", 0, "0cbe4e19-17c8-4798-8749-4240ff4a7775", "Safety Inspector", "maddietay@gmail.com", false, 1224, "Maddie", "Tay", false, null, "MADDIETAY@GMAIL.COM", "MADDIETAY@GMAIL.COM", "AQAAAAIAAYagAAAAEP9l0aYl/Yl9utGfWQMSmecyPiiGn8jNTihz6lgiIs0OCSVqofK5N9k11z4FAtzmyg==", "63457266", false, "bc22b3c5-30c2-4f9d-8eb0-2837622d60a9", false, "maddietay@gmail.com" },
                    { "e7b4016a-fa59-4669-969f-36601182f51c", 0, "64b6ea00-60c1-41bd-bae3-548cba090894", "Safety Manager", "kevinjones@gmail.com", false, 1991, "Kevin", "Jones", false, null, "KEVINJONES@GMAIL.COM", "KEVINJONES@GMAIL.COM", "AQAAAAIAAYagAAAAEONW4HBaReSm5gtrABq8EL4qI0e+osXsQy9BE1j56bu735qEIPo3n3UjEP1BPX18Fw==", "68999888", false, "3713ca3b-34fe-4184-b0dc-80a4f66c8190", false, "kevinjones@gmail.com" },
                    { "f53bf9d9-95d1-42af-804e-e5edacdc9c74", 0, "1f5e2941-e5aa-4688-8ccb-31b16de598c4", "Safety Inspector", "elenareed@gmail.com", false, 1953, "Elena", "Reed", false, null, "ELENAREED@GMAIL.COM", "ELENAREED@GMAIL.COM", "AQAAAAIAAYagAAAAEHiZ0Wts9C7f97ATwgmHCdFtsK4ERmXoUgeV8UE6jiVIyJ5IrMbfEB3p7C0PXxstmA==", "63450508", false, "fd8022c3-da38-4ca3-a66b-411a188769b8", false, "elenareed@gmail.com" },
                    { "fe8964fa-aac1-4db1-97bb-017e0905242f", 0, "f107e725-d7e8-4abf-b26e-d702f56138b9", "Safety Inspector", "jakehoward@gmail.com", false, 1397, "Jake", "Howard", false, null, "JAKEHOWARD@GMAIL.COM", "JAKEHOWARD@GMAIL.COM", "AQAAAAIAAYagAAAAEG8GXENJaqGDS2+2hwKNEK1WioDgjpz+bGL1STInpFRdJCQJ1aSJBKxO0bjmmDLRHA==", "62678901", false, "ccfc3f86-4c98-4448-b8f6-45a834f50641", false, "jakehoward@gmail.com" }
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
