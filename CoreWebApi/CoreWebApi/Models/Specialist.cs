using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Specialist
    {
        [Key]
        public int SpecialistID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SpecialistName { get; set; }
    }
}
