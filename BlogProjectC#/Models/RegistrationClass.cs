using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BlogProjectC_.Models
{
    public class RegistrationClass
    {
        [Required(ErrorMessage = "Enter Your Name...")]
        [Display(Name = "Enter your name...")]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Username length must be max 20 & min 3")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "Please Enter Your email....")]
        [Display(Name = "Email id....")]
        public string Uemail { get; set; }

        [Required(ErrorMessage = "Enter the password...")]
        [Display(Name = "Password...")]
        [DataType(DataType.Password)]
        public string Upass { get; set; }

        [Required(ErrorMessage = "Enter the password again...")]
        [Display(Name = "Re-Password...")]
        [DataType(DataType.Password)]
        [Compare("Upass")]
        public string Repass { get; set; }

        [Required(ErrorMessage = "Select The Gender....")]
        [Display(Name = "Select your gender...")]
        public char Ugender { get; set; }
    }
}