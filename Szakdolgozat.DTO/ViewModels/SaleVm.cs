using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.ViewModels
{
    public class SaleVm
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Üzlet")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public int StoreId { get; set; }

        [Display(Name = "Rendelés szám")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(40, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string OrderNum { get; set; }

        [Display(Name = "Rendelés dátuma")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Mennyiség")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public short Quantity { get; set; }

        [Display(Name = "Fizetési feltételek")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public string PayTerms { get; set; }

        [Display(Name = "Könyv")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public int BookId { get; set; }

        public virtual BookVm Book { get; set; }
        public virtual StoreVm Store { get; set; }
    }
}
