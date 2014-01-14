using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameThatWrap.Models
{
    public class SignInModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public int WrapID { get; set; }
    }
}