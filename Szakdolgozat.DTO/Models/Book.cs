using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required]
        [MaxLength(12)]
        public string Type { get; set; }

        [Required]
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public int Royalty { get; set; }
        public int YtdSales { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

        [Required]
        public DateTime PublishedDate { get; set; }

        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
