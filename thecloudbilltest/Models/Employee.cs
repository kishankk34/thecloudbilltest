﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thecloudbilltest.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId  { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public String Address { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public String Location { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string City { get; set; }
    }
}
