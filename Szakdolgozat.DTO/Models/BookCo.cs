using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class BookCo
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        [MaxLength(12)]
        public string Type { get; set; }

        [Required]
        public int PublisherId { get; set; }

        public decimal? Price { get; set; }

        public int? Royality { get; set; }

        public int? YtdSales { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

        [Required]
        public DateTime PublishedDate { get; set; }

        public virtual PublisherCo Publisher { get; set; }
        public virtual ICollection<BookAuthorCo> BookAuthors { get; set; }
        public virtual ICollection<SaleCo> Sales { get; set; }
    }
}
