using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class CareerInformation
    {
        public int CareerInformationID { get; set; }

        public string CompanyName { get; set; }
        public string CompanyBusiness { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
    }
}
