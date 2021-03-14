using Microsoft.EntityFrameworkCore.Migrations;

namespace SvalbardUniversity.Migrations
{
    public partial class NameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "Last Name");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "First Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Last Name",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Student",
                newName: "FirstMidName");
        }
    }
}
