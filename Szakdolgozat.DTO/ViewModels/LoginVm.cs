using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.ViewModels
{
    public class LoginVm
    {
        [Required(ErrorMessage = "E-mail címet kötelező megadni")]
        [EmailAddress(ErrorMessage = "Nem megfelelő e-mail formátum")]
        [Display(Name = "E-mail cím")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Jelszót kötelező megadni")]
        [DataType(DataType.Password)]
        [Display(Name = "Jelszó")]
        public string Password { get; set; }
    }
}
