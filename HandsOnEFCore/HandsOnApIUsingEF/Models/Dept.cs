using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnApIUsingEF.Models
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public string Did { get; set; }
        [StringLength(30)]
        public string Dname { get; set; }
    }
}
