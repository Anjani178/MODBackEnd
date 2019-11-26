using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TechnologyService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public string TId { get; set; }
        [Required]
        public string TName { get; set; }
        public int TimeDuration { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }
        public int Rating { get; set; }
        public float CommissionFee { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public string Mid { get; set; }
        [Required]
        [ForeignKey("User")]
        public string Uid { get; set; }
        [Required]
        [ForeignKey("Skills")]
        public string SId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime EndTime { get; set; }

        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Skill Skills { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}
