using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class cvcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Createdate",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "TrainingInfornationId",
                table: "TrainingInfornation",
                newName: "TrainingInfornationID");

            migrationBuilder.RenameColumn(
                name: "RefereeInformationId",
                table: "RefereeInformations",
                newName: "RefereeInformationID");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationId",
                table: "PersonalInformations",
                newName: "PersonalInformationID");

            migrationBuilder.RenameColumn(
                name: "EducationalInfomationId",
                table: "EducationalInfomations",
                newName: "EducationalInfomationID");

            migrationBuilder.RenameColumn(
                name: "TrainingInfornationId",
                table: "Candidates",
                newName: "TrainingInfornationID");

            migrationBuilder.RenameColumn(
                name: "RefereeInformationId",
                table: "Candidates",
                newName: "RefereeInformationID");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationId",
                table: "Candidates",
                newName: "PersonalInformationID");

            migrationBuilder.RenameColumn(
                name: "EducationalInfomationId",
                table: "Candidates",
                newName: "EducationalInfomationID");

            migrationBuilder.RenameColumn(
                name: "CareerInformationId",
                table: "Candidates",
                newName: "CareerInformationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainingInfornationID",
                table: "TrainingInfornation",
                newName: "TrainingInfornationId");

            migrationBuilder.RenameColumn(
                name: "RefereeInformationID",
                table: "RefereeInformations",
                newName: "RefereeInformationId");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationID",
                table: "PersonalInformations",
                newName: "PersonalInformationId");

            migrationBuilder.RenameColumn(
                name: "EducationalInfomationID",
                table: "EducationalInfomations",
                newName: "EducationalInfomationId");

            migrationBuilder.RenameColumn(
                name: "TrainingInfornationID",
                table: "Candidates",
                newName: "TrainingInfornationId");

            migrationBuilder.RenameColumn(
                name: "RefereeInformationID",
                table: "Candidates",
                newName: "RefereeInformationId");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationID",
                table: "Candidates",
                newName: "PersonalInformationId");

            migrationBuilder.RenameColumn(
                name: "EducationalInfomationID",
                table: "Candidates",
                newName: "EducationalInfomationId");

            migrationBuilder.RenameColumn(
                name: "CareerInformationID",
                table: "Candidates",
                newName: "CareerInformationId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Createdate",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Candidates",
                nullable: true);
        }
    }
}
