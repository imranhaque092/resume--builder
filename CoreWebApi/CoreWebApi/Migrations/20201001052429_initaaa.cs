using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class initaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareerInformations",
                columns: table => new
                {
                    CareerInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyBusiness = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Startdate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerInformations", x => x.CareerInformationId);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInfomations",
                columns: table => new
                {
                    EducationalInfomationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LavelOfEducation = table.Column<string>(nullable: true),
                    ExamName = table.Column<string>(nullable: true),
                    MajorSubject = table.Column<string>(nullable: true),
                    InstituteName = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    YearOfPassing = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalInfomations", x => x.EducationalInfomationId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    PresentAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.PersonalInformationId);
                });

            migrationBuilder.CreateTable(
                name: "RefereeInformations",
                columns: table => new
                {
                    RefereeInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Relation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeInformations", x => x.RefereeInformationId);
                });

            migrationBuilder.CreateTable(
                name: "TrainingInfornation",
                columns: table => new
                {
                    TrainingInfornationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainingTitle = table.Column<string>(nullable: true),
                    TopicsCoverd = table.Column<string>(nullable: true),
                    Institute = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    TrainingYear = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingInfornation", x => x.TrainingInfornationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerInformations");

            migrationBuilder.DropTable(
                name: "EducationalInfomations");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "RefereeInformations");

            migrationBuilder.DropTable(
                name: "TrainingInfornation");
        }
    }
}
