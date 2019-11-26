using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HandsOnEFCore_CodeFirst.Models
{
    [Table("Dept")]
    class Dept
    {
        [Key]
        public string Did { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Dname { get; set; }

        //navigation prop
        //one to many
        public ICollection<Employee> Employees { get; set; }
    }
}
