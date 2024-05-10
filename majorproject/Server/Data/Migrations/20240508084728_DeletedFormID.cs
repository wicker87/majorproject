using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace majorproject.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeletedFormID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormId",
                table: "RAFs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "RAFs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
