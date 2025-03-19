using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniverstity.Migrations
{
    /// <inheritdoc />
    public partial class jinfa31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentDog",
                table: "Department",
                newName: "SuperImportantString");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuperImportantString",
                table: "Department",
                newName: "DepartmentDog");
        }
    }
}
