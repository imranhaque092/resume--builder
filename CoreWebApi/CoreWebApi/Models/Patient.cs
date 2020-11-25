using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string PatientName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Phone { get; set; }
        [Required]

        public string Payment { get; set; }
    }
}
