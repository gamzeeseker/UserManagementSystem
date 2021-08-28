using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Model.DTOModels
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        [MinLength(10), MaxLength(11)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public DateTime Birthday { get; set; }
    }
}
