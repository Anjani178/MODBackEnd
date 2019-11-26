using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public string Uid { get; set; }
        [Required]
        [StringLength(30)]
        public string UEmail { get; set; }
        [Required]
        [StringLength(30)]
        [MaxLength(5)]
        public string UPassword { get; set; }
        [MaxLength(10)]
        public string Contact { get; set; }
        public string Role { get; set; }
        public string Active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
