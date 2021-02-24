using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class UserCo
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Source { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short RoleId { get; set; }
        public int PublisherId { get; set; }
        public DateTime? HireDate { get; set; }

        public virtual PublisherCo Publisher { get; set; }
        public virtual RoleCo Role { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
