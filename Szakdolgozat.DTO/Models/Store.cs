using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class Store
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string StoreName { get; set; }

        [MaxLength(40)]
        public string StoreAddress { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(5)]
        public string Zip { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
