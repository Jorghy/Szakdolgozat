using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class RoleCo
    {
        [Key]
        public short RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleDesc { get; set; }

        public virtual ICollection<UserCo> Users { get; set; }
    }
}
