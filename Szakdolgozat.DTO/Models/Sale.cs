using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class Sale
    {
        public int Id { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(20)]
        public string OrderNum { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public short Quantity { get; set; }

        [Required]
        [MaxLength(12)]
        public string PayTerms { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Store Store { get; set; }
    }
}
