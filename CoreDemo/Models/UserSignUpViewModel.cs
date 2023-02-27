using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Please Write Your Name And Surname.")]
        public string NameSurname { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Write Your Password.")]
        public string Password { get; set; }
        [Display(Name = "Rewrite Password")]
        [Compare("Password", ErrorMessage = "Passwords Aren't Match.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail Adress")]
        [Required(ErrorMessage = "Please Write Your Mail Adress")]
        public string Mail { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Write Your Username.")]
        public string UserName { get; set; }
        public bool IsAcceptTheContract { get; set; }
    }
}
