using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentData.Migrations
{
    public partial class quickchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "States",
                table: "StudentReg",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "LocalGovt",
                table: "StudentReg",
                newName: "LocalGovtArea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "StudentReg",
                newName: "States");

            migrationBuilder.RenameColumn(
                name: "LocalGovtArea",
                table: "StudentReg",
                newName: "LocalGovt");
        }
    }
}
