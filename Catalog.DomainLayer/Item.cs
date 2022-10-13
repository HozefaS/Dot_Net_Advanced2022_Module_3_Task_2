﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DomainLayer
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ItemId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "text")]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [Required]
        public Category Category { get; set; }

        [Column(TypeName = "decimal")]
        [Required]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        [Required]
        public decimal Amount { get; set; }
    }
}
