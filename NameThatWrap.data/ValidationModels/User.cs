using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NameThatWrap.data
{

        [MetadataType(typeof(UserMetaData))]
        public partial class User
        {
        }

        public class UserMetaData
        {
            [Required(ErrorMessage = "Please enter your first name.")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Please enter your last name.")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Please enter a valid email address.")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please enter your password.")]
            public string Password { get; set; }

        }

    }
