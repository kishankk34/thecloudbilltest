using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thecloudbilltest.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string LoginName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required]
        public String LoginPassword { get; set; }
    }
}
