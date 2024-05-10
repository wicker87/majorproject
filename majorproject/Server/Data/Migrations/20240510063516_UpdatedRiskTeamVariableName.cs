using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace majorproject.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRiskTeamVariableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PTwo",
                table: "RiskTeams",
                newName: "MemberTwo");

            migrationBuilder.RenameColumn(
                name: "PThree",
                table: "RiskTeams",
                newName: "MemberThree");

            migrationBuilder.RenameColumn(
                name: "POne",
                table: "RiskTeams",
                newName: "MemberOne");

            migrationBuilder.RenameColumn(
                name: "PFour",
                table: "RiskTeams",
                newName: "MemberFour");

            migrationBuilder.RenameColumn(
                name: "PFive",
                table: "RiskTeams",
                newName: "MemberFive");

            migrationBuilder.RenameColumn(
                name: "Lead",
                table: "RiskTeams",
                newName: "Leader");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "497a8212-f23e-46b4-94d1-ce41af08a402", "AQAAAAIAAYagAAAAEAZ0Kx2k1DLU0/pa45ma8pkSe1co0Cn9NyOVZvhtTM99aVTgGeR73NhEWSiVocEwGA==", "1bfad495-0fd9-4ef2-8093-b59132b5e3c0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MemberTwo",
                table: "RiskTeams",
                newName: "PTwo");

            migrationBuilder.RenameColumn(
                name: "MemberThree",
                table: "RiskTeams",
                newName: "PThree");

            migrationBuilder.RenameColumn(
                name: "MemberOne",
                table: "RiskTeams",
                newName: "POne");

            migrationBuilder.RenameColumn(
                name: "MemberFour",
                table: "RiskTeams",
                newName: "PFour");

            migrationBuilder.RenameColumn(
                name: "MemberFive",
                table: "RiskTeams",
                newName: "PFive");

            migrationBuilder.RenameColumn(
                name: "Leader",
                table: "RiskTeams",
                newName: "Lead");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f0b49b-f38d-4621-8685-cf7316172673", "AQAAAAIAAYagAAAAEI+Ib3vxII9CKA8e6WCvhnB0yNui61jK5ggdqnCX7KI1M+GO6klIhn6fMqSmkZ1fng==", "6c92f920-4ddd-445a-8597-9c542d91c5aa" });
        }
    }
}
