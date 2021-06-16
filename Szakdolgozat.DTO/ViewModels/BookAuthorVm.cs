using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class BookAuthorVm
    {
        public int Id { get; set; }

        [Display(Name = "Író azonosító")]
        public int AuthorId { get; set; }

        [Display(Name = "Könyv azonosító")]
        public int BookId { get; set; }

        [Display(Name = "Író példányszám")]
        public byte? AuthorOrder { get; set; }

        [Display(Name = "Jogdíj")]
        public int? RoyalityPercentage { get; set; }

        public virtual AuthorVm Author { get; set; }
        public virtual BookVm Book { get; set; }
    }
}
