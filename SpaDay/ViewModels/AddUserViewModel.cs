using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Please enter the username")]
        [StringLength(15, MinimumLength =5, ErrorMessage ="Username should be 5 to 15 characters long")]

        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength =6, ErrorMessage ="Username should be 6 to 20 characters long")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string VerifyPassword { get; set; }
    }
}
