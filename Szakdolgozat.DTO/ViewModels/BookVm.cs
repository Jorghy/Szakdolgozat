using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class BookVm
    {
        [Display(Name = "ID")]
        public int BookId { get; set; }

        [Display(Name = "Könyv címe")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(80, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Title { get; set; }

        [Display(Name = "Kategória")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(12, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Type { get; set; }

        [Display(Name = "Kiadó")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public int PublisherId { get; set; }

        [Display(Name = "Ára ($)")]
        public decimal? Price { get; set; }

        [Display(Name = "Szerzői díj (%)")]
        public int? Royality { get; set; }

        [Display(Name = "Eladott példányszám (DB)")]
        public int? YtdSales { get; set; }

        [Display(Name = "Megjegyzés")]
        [MaxLength(200, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Notes { get; set; }

        [Display(Name = "Kiadás dátuma")]
        [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public DateTime PublishedDate { get; set; }

        public virtual PublisherVm Publisher { get; set; }
        public virtual ICollection<BookAuthorVm> BookAuthors { get; set; }
        public virtual ICollection<SaleVm> Sales { get; set; }
    }
}
