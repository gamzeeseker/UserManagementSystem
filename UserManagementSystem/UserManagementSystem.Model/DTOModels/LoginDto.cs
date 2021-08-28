using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Model.DTOModels
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        [MaxLength(50, ErrorMessage = "Maksimum alan aşıldı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
