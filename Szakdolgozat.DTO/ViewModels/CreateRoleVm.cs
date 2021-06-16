using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.ViewModels
{
    public class CreateRoleVm
    {
        [Required]
        [Display(Name = "Szerepkör")]
        public string RoleName { get; set; }
    }
}
