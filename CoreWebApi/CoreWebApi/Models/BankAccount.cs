using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class BankAccount
    {

        [Key]
        public int BankAccountID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyBusiness { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
        //[Column(TypeName = "nvarchar(20)")]
        //[Required]
        //public string AccountNumber { get; set; }
        //[Column(TypeName = "nvarchar(100)")]
        //[Required]
        //public string AccountHolder { get; set; }
        //[Required]
        //public int BankID { get; set; }
        //[Column(TypeName = "nvarchar(20)")]
        //[Required]
        //public string IFSC { get; set; }
    }
}
