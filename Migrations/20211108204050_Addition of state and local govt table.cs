using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentData.Migrations
{
    public partial class Additionofstateandlocalgovttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegNumber",
                table: "StudentReg",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNumber",
                table: "StudentReg");
        }
    }
}
