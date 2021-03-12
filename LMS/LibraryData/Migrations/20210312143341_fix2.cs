using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatoOfBirth",
                table: "Patrons",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Patrons",
                newName: "DatoOfBirth");
        }
    }
}
