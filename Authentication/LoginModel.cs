﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLogin.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage="UserName is Required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "UserName is Required")]
        public string Password { get; set; }
    }
}
