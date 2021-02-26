﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Szakdolgozat.DTO.Models
{
    public class AuthorCo
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(12)]
        public string Phone { get; set; }

        [MaxLength(40)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }

        [MaxLength(5)]
        public string Zip { get; set; }

        [MaxLength(100)]
        public string EmailAddress { get; set; }

        public virtual ICollection<BookAuthorCo> BookAuthors { get; set; }
    }
}
