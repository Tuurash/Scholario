using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Scholar.Models
{
    public class LoginViewmodel
    {
        [Required(ErrorMessage = "Must type User Email correctly!")]
        public string userMail { get; set; }

        [Required(ErrorMessage = "Must Type Password correctly!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}