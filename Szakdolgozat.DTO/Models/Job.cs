using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class Job
    {
        public short Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string JobDesc { get; set; }
    }
}
