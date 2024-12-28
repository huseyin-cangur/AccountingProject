using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingProject.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class CompanyTableUpdateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatabaseName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatabasePassword",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatabaseServerName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DatabaseUserId",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatabaseName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DatabasePassword",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DatabaseServerName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DatabaseUserId",
                table: "Companies");
        }
    }
}
