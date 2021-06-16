using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.ViewModels
{
    public class EditRoleVm
    {
        public EditRoleVm()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }
        
        [Required(ErrorMessage = "Kötelező kitölteni")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
