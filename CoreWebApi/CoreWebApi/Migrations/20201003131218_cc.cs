using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CareerInformationId",
                table: "CareerInformations",
                newName: "CareerInformationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CareerInformationID",
                table: "CareerInformations",
                newName: "CareerInformationId");
        }
    }
}
