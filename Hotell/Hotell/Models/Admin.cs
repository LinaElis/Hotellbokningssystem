﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotell.Models
{
    public class Admin
    {
        public int AdminID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool SignedIn { get; set; }
    }
}