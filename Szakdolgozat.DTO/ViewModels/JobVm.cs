using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class JobVm
    {
        [Display(Name = "ID")]
        public short JobId { get; set; }

        [Display(Name = "Pozició")]
        [MaxLength(50, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string JobDesc { get; set; }
    }
}
