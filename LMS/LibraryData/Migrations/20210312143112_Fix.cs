using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "LibraryBranches",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "LibraryBranches",
                newName: "Adress");
        }
    }
}
