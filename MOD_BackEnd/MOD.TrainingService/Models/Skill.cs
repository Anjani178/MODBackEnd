using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Skills")]
    public class Skill
    {
        [Key]
        public string SId { get; set; }
        [Required]
        public string SName { get; set; }
        public string toc { get; set; }
        public string PreReq { get; set; }
        [Required]
        public Double Fees { get; set; }
        public string Duration { get; set; }

        public IEnumerable<Training> Training { get; set; }

}
}
