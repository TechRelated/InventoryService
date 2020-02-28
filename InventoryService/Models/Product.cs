using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column("Name", TypeName = "string")]
        public string Name { get; set; }

        [Required]
        [Column("Category", TypeName = "string")]
        public string Category { get; set; }

        [Column("Color", TypeName = "string")]
        public string Color { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public int AvailableQuantity { get; set; }
    }
}
