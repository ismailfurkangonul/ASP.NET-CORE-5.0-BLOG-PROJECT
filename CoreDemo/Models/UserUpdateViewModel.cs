using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserUpdateViewModel
    {
        [Required(ErrorMessage = "Please Write Your Name And Surname.")]
        public string namesurname { get; set; }
        public string username { get; set; }

        [Required(ErrorMessage = "Please Writer Your Mail Adress.")]
        public string mail { get; set; }
        public string imageurl { get; set; }
        public string password { get; set; }

    }
}
