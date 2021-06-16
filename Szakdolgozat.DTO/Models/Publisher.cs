using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string PublisherName { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
