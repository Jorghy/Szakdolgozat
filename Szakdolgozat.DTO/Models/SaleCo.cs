using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class SaleCo
    {
        public int SaleId { get; set; }
        public string StoreId { get; set; }
        public string OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public short Quantity { get; set; }
        public string PayTerms { get; set; }
        public int BookId { get; set; }

        public virtual BookCo Book { get; set; }
        public virtual StoreCo Store { get; set; }
    }
}
