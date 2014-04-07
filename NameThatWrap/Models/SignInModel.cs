using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NameThatWrap.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public bool LoggedIn { get; set; }
        public int WrapID { get; set; }
    }
}