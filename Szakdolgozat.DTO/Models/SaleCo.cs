using System;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class SaleCo
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(40)]
        public string OrderNum { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public short Quantity { get; set; }

        [Required]
        public string PayTerms { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual BookCo Book { get; set; }
        public virtual StoreCo Store { get; set; }
    }
}
