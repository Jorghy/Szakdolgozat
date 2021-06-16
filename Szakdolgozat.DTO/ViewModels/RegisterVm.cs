using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.ViewModels
{
    public class RegisterVm
    {
        [Required]
        [EmailAddress(ErrorMessage = "Nem megfelelő e-mail formátum")]
        [Display(Name = "E-mail cím")]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Jelszó")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Jelszó megismétlése")]
        [Compare("Password", ErrorMessage = "A két jelszó mező nem egyezik!")]
        public string ConfirmPassword { get; set; }
    }
}
