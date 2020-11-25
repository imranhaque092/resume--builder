using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class ccdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountHolder",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "BankID",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "IFSC",
                table: "BankAccounts");

            migrationBuilder.AddColumn<string>(
                name: "CompanyBusiness",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "BankAccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Startdate",
                table: "BankAccounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyBusiness",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "Startdate",
                table: "BankAccounts");

            migrationBuilder.AddColumn<string>(
                name: "AccountHolder",
                table: "BankAccounts",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "BankAccounts",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BankID",
                table: "BankAccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IFSC",
                table: "BankAccounts",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");
        }
    }
}
