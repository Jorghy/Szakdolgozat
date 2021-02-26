using System.ComponentModel.DataAnnotations;

namespace Szakdolgozat.DTO.Models
{
    public class JobCo
    {
        [Key]
        public short JobId { get; set; }

        [MaxLength(50)]
        public string JobDesc { get; set; }
    }
}
