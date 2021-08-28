using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Domain.Entities
{
    public class UserEntity : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public override string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public override string Email { get; set; }

        [Required]
        public override string PasswordHash { get; set; }

        [Required]
        [MinLength(10),MaxLength(11)]
        public override string PhoneNumber { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}
