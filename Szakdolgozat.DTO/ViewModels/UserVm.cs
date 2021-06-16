using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Szakdolgozat.DTO.Models;

namespace Szakdolgozat.DTO.ViewModels
{
    public class UserVm
    {
        [Display(Name = "ID")]
        public int UserId { get; set; }

        [Display(Name = "E-mail cím")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(100, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string EmailAddress { get; set; }

        [Display(Name = "Jelszó")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        [MaxLength(100, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string Password { get; set; }

        [Display(Name = "Keresztnév")]
        [MaxLength(20, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string FirstName { get; set; }

        [Display(Name = "Vezetéknév")]
        [MaxLength(30, ErrorMessage = "A(z) {0} mező {1}-nél hosszabb nem lehet!")]
        public string LastName { get; set; }

        [Display(Name = "Szerepkör")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public short RoleId { get; set; }

        [Display(Name = "Kiadó")]
        [Required(ErrorMessage = "A(z) {0} mezőt kötelező kitölteni!")]
        public int PubId { get; set; }

        [Display(Name = "Munkaviszony kezdete")]
        public DateTime? HireDate { get; set; }

        public virtual PublisherVm Publisher { get; set; }
        public virtual RoleVm Role { get; set; }
        //public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
