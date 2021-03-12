using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class FIx3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Directior",
                table: "LibraryAssets",
                newName: "Director");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "LibraryAssets",
                newName: "Directior");
        }
    }
}
