﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityWebApp.ViewModel
{
    public class CreateViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }

    }

    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
    }
}
