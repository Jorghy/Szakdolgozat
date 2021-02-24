using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class PublisherCo
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<BookCo> Books { get; set; }
        public virtual ICollection<UserCo> Users { get; set; }
    }
}
