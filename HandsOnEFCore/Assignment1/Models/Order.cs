using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment1.Models
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? DeliveryDate { get; set; }
        [ForeignKey("Item")] // the class name of foriegn key
        public int ItemId{ get; set; }

        //Navigation properties
      
        public Item Item { get; set; }
    }
}
