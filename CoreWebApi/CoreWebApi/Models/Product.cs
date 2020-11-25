using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string ProductPrice { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Coment { get; set; }
    }
}
