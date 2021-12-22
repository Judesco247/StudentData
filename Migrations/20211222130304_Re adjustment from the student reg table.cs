using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentData.Migrations
{
    public partial class Readjustmentfromthestudentregtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "StudentReg");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "StudentReg",
                newName: "States");

            migrationBuilder.RenameColumn(
                name: "ReligionId",
                table: "StudentReg",
                newName: "Religion");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "StudentReg",
                newName: "Program");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "StudentReg",
                newName: "OtherNames");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "StudentReg",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "StudentReg",
                newName: "Course");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "States",
                table: "StudentReg",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "Religion",
                table: "StudentReg",
                newName: "ReligionId");

            migrationBuilder.RenameColumn(
                name: "Program",
                table: "StudentReg",
                newName: "ProgramId");

            migrationBuilder.RenameColumn(
                name: "OtherNames",
                table: "StudentReg",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "StudentReg",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "StudentReg",
                newName: "CourseId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "StudentReg",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
