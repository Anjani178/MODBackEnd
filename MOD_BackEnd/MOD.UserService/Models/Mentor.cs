using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public string Mid { get; set; }
        [Required]
        [StringLength(30)]
        public string MUserName { get; set; }
        [Required]
        [StringLength(30)]
        public string MEmail { get; set; }
        [Required]
        [StringLength(30)]
        [MaxLength(5)]
        public string MPassword { get; set; }
        [MaxLength(10)]
        public string Contact { get; set; }
        public string Facilities { get; set; }
        public string Technologies { get; set; }
        public string Role { get; set; }
        public string TimeSlot { get; set; }
        public string linkedinUrl { get; set; }
        public int? yearOfExperience { get; set; }
        public string Active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}