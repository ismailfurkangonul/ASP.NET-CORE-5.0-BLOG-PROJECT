using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please Write Your Username!")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please Write Your Password!")]
        public string password { get; set; }
    }
}
