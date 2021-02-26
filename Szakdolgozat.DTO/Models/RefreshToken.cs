using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class RefreshToken
    {
        [Key]
        public int TokenId { get; set; }

        public int UserId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Token { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        public virtual UserCo User { get; set; }
    }
}
