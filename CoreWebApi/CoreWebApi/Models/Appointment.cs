using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string DoctorID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public int PatientID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required]

        public int SpecialistID { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string AppointmentTime { get; set; }
        [Required]

        public string Amount { get; set; }
    }
}
