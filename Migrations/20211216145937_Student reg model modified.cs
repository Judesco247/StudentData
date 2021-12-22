using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentData.Migrations
{
    public partial class Studentregmodelmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "LGA",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "Program",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "StudentReg");

            migrationBuilder.RenameColumn(
                name: "StateOfOrigin",
                table: "StudentReg",
                newName: "LocalGovt");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "StudentReg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "StudentReg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "StudentReg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "StudentReg",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "StudentReg",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "StudentReg");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "StudentReg");

            migrationBuilder.RenameColumn(
                name: "LocalGovt",
                table: "StudentReg",
                newName: "StateOfOrigin");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "StudentReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "StudentReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LGA",
                table: "StudentReg",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Program",
                table: "StudentReg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "StudentReg",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }
    }
}
