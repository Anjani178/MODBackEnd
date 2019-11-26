using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HandsOnEFCore_CodeFirst.Models
{
    [Table("Employee")]
    class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Required]
        public string Ename { get; set; }
        [Column("Designation",TypeName = "varchar(20)")]
        public string Desig { get; set; }
        [Column("Salary")]
        public int? sal { get; set; }
        [ForeignKey("Dept")] // the class name of foriegn key
        public string Did { get; set; }

        //Navigation properties
        //one to many
        public Dept Dept { get; set; } 

    }
}
