using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdolgozat.DTO.Models
{
    public class BookAuthorCo
    {
        [Key]
        public int BookAuthorId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public byte? AuthorOrder { get; set; }
        public int? RoyalityPercentage { get; set; }

        public virtual AuthorCo Author { get; set; }
        public virtual BookCo Book { get; set; }
    }
}
