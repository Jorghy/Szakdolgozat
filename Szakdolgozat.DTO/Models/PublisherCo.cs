using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class PublisherCo
    {
        [Key]
        public int PublisherId { get; set; }

        [MaxLength(40)]
        public string PublisherName { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(30)]
        public string Country { get; set; }

        public virtual ICollection<BookCo> Books { get; set; }
        public virtual ICollection<UserCo> Users { get; set; }
    }
}
