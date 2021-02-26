using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class StoreCo
    {
        [Key]
        public int StoreId { get; set; }

        [MaxLength(40)]
        public string StoreName { get; set; }

        [MaxLength(40)]
        public string StoreAddress { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(5)]
        public string Zip { get; set; }

        public virtual ICollection<SaleCo> Sales { get; set; }
    }
}
