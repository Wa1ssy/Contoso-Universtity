using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniverstity.Migrations
{
    /// <inheritdoc />
    public partial class jinfa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Student_StudentId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_StudentId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Aadress",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Department",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Department",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Course",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                newName: "IX_Course_DepartmentID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentDog",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                table: "Instructor",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DepartmentID",
                table: "Instructor",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DepartmentID",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_DepartmentID",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DepartmentDog",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "Department",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Department",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Course",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentID",
                table: "Course",
                newName: "IX_Course_DepartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Aadress",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_StudentId",
                table: "Department",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Student_StudentId",
                table: "Department",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }
    }
}
