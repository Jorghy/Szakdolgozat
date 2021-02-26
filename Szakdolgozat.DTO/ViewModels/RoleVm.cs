using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.ViewModels
{
    public class RoleVm
    {
        [Display(Name = "ID")]
        public short RoleId { get; set; }

        [Display(Name = "Szerepkör")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(50, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string RoleDesc { get; set; }

        public virtual ICollection<UserVm> Users { get; set; }
    }
}
