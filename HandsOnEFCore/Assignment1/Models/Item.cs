using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment1.Models
{
    [Table("Item")]
    class Item
    {  
        [Key]
        public int ItemId { get; set; }
        [Required]
        [Column("IName", TypeName = "varchar(20)")]
        public string IName { get; set; }
        public Double Price { get; set; }

        public IEnumerable<Order> Order { get; set; }
    }
}
