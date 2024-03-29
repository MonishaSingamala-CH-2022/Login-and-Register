﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLogin.Authentication
{
    public class RegisterModel
    {

        [Required(ErrorMessage="USer Name is required")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is requires")]
        public string Password { get; set; }
    }
}
