using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BlogProjectC_.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Enter Your Name...")]
        [Display(Name = "Enter your name...")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter the password...")]
        [Display(Name = "Password...")]
        [DataType(DataType.Password)]
        public string UserPass { get; set; }
    }
}