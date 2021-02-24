using System;
using System.Collections.Generic;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class RefreshToken
    {
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual UserCo User { get; set; }
    }
}
