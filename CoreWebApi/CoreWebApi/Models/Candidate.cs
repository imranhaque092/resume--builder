using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Candidate
    {
       
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }

        public string LavelOfEducation { get; set; }
        public string ExamName { get; set; }
        public string MajorSubject { get; set; }
        public string InstituteName { get; set; }
        public string Result { get; set; }
        public string YearOfPassing { get; set; }
        public string Duration { get; set; }
        public string CompanyName { get; set; }
        public string CompanyBusiness { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
    }
}
