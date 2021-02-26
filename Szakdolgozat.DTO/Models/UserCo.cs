using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class UserCo
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        public short RoleId { get; set; }

        [Required]
        public int PublisherId { get; set; }

        public DateTime? HireDate { get; set; }

        public virtual PublisherCo Publisher { get; set; }
        public virtual RoleCo Role { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
