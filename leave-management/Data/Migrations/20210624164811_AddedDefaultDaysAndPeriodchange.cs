using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class AddedDefaultDaysAndPeriodchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "defaultDays",
                table: "LeaveTypes",
                newName: "DefaultDays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultDays",
                table: "LeaveTypes",
                newName: "defaultDays");
        }
    }
}
