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
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
