﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.ApplicationUser
{
    public class CurrentUser
    {
        public CurrentUser(string id, string email)
        {
            Id = id;
            Email = email;
        }

        public string Id { get; set; }
        public string Email { get; set; }
    }
}
