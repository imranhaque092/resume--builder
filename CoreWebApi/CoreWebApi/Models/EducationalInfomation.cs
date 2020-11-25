using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class EducationalInfomation
    {
        public int EducationalInfomationID { get; set; }

        public string LavelOfEducation { get; set; }
        public string ExamName { get; set; }
        public string MajorSubject { get; set; }
        public string InstituteName { get; set; }
        public string Result { get; set; }
        public string YearOfPassing { get; set; }
        public string Duration { get; set; }
    }
}
