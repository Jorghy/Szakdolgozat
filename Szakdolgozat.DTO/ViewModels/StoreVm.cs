using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class StoreVm
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Üzlet neve")]
        [MaxLength(40, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string StoreName { get; set; }

        [Display(Name = "Üzlet címe")]
        [MaxLength(40, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string StoreAddress { get; set; }

        [Display(Name = "Város")]
        [MaxLength(20, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string City { get; set; }

        [Display(Name = "Állam")]
        [MaxLength(2, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string State { get; set; }

        [Display(Name = "Irányítószám")]
        [MaxLength(5, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Zip { get; set; }

        public virtual ICollection<SaleVm> Sales { get; set; }
    }
}
