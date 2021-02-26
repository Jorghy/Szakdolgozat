using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class PublisherVm
    {
        [Display(Name = "ID")]
        public int PublisherId { get; set; }

        [Display(Name = "Kiadó neve")]
        [MaxLength(40, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string PublisherName { get; set; }

        [Display(Name = "Város")]
        [MaxLength(20, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string City { get; set; }

        [Display(Name = "Állam")]
        [MaxLength(2, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string State { get; set; }

        [Display(Name = "Ország")]
        [MaxLength(30, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Country { get; set; }

        public virtual ICollection<BookVm> Books { get; set; }
        public virtual ICollection<UserVm> Users { get; set; }
    }
}
