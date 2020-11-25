using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class PersonalInformation
    {
        public int PersonalInformationID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
    }
}
