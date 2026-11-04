using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class enumAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipType",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MembershipType",
                table: "Members");
        }
    }
}
