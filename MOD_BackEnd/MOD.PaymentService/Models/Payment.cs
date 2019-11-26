using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    public class Payment
    {
        public string PaymentId { get; set; }
        [ForeignKey("User")]
        public string Uid { get; set; }
        [ForeignKey("Mentor")] // association name below
        public string Mid { get; set; }
        [ForeignKey("Training")]
        public string TId { get; set; }
        public float Amount { get; set; }
        public float AmountMentor { get; set; }

        public User User { get; set; }
        public Mentor Mentor { get; set; }

        public Training Training { get; set; }

    }

}
