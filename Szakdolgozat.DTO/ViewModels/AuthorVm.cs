using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class AuthorVm
    {
        [Display(Name = "ID")]
        public int AuthorId { get; set; }

        [Display(Name = "Vezetéknév")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(40, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string LastName { get; set; }

        [Display(Name = "Keresztnév")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(20, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string FirstName { get; set; }

        [Display(Name = "Telefon szám")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(12, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Phone { get; set; }

        [Display(Name = "Cím")]
        public string Address { get; set; }

        [Display(Name = "Város")]
        public string City { get; set; }

        [Display(Name = "Állam")]
        public string State { get; set; }

        [Display(Name = "Irányítószám")]
        public string Zip { get; set; }

        [Display(Name = "E-mail cím")]
        public string EmailAddress { get; set; }

        public virtual ICollection<BookAuthorVm> BookAuthors { get; set; }
    }
}