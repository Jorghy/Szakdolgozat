using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class BookCo
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public int PubId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royality { get; set; }
        public int? YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime PublishedDate { get; set; }

        public virtual PublisherCo Publisher { get; set; }
        public virtual ICollection<BookAuthorCo> BookAuthors { get; set; }
        public virtual ICollection<SaleCo> Sales { get; set; }
    }
}
