using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.EF.Migrations
{
    public partial class contactNewVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
