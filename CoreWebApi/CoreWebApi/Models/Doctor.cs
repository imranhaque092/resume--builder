using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string DoctorName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Phone { get; set; }
        [Required]
        public int SpecialistID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Reviews { get; set; }
    }
}
