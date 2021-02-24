using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class RoleCo
    {
        public short RoleId { get; set; }
        public string RoleDesc { get; set; }

        public virtual ICollection<UserCo> Users { get; set; }
    }
}
