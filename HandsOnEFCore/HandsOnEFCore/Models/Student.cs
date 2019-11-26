using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnEFCore_CodeFirst.Models
{
    //Data annotations
    [Table("Student1")] //change table name as custom 
    class Student
    {
        [Key]
        public int ID { get; set; }

        [Required] //applied not null constraint
        [StringLength(30)]
        public string Name { get; set; }
        public int? Age { get; set; } //set as null
        [Column("Std",TypeName = "varchar(20)")] //change column properties
        [StringLength(20)]
        public string Class { get; set; }
        [Column(TypeName ="char(20)")] //takes this datatype instead of String
        [StringLength(20)]
        public string School { get; set; }

        //[Column(TypeName ="Date")]
        //public DateTime? JoinDate { get; set; }

    }
}
