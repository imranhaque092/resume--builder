using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class dsds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareerInformationID",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "EducationalInfomationID",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "PersonalInformationID",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "RefereeInformationID",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "TrainingInfornationID",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Candidates",
                newName: "CandidateID");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Candidates",
                newName: "YearOfPassing");

            migrationBuilder.RenameColumn(
                name: "ContactMobileNo",
                table: "Candidates",
                newName: "Startdate");

            migrationBuilder.AddColumn<string>(
                name: "CompanyBusiness",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExamName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstituteName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LavelOfEducation",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MajorSubject",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Candidates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyBusiness",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ExamName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "InstituteName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "LavelOfEducation",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "MajorSubject",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "CandidateID",
                table: "Candidates",
                newName: "CandidateId");

            migrationBuilder.RenameColumn(
                name: "YearOfPassing",
                table: "Candidates",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Startdate",
                table: "Candidates",
                newName: "ContactMobileNo");

            migrationBuilder.AddColumn<int>(
                name: "CareerInformationID",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EducationalInfomationID",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalInformationID",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RefereeInformationID",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingInfornationID",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);
        }
    }
}
