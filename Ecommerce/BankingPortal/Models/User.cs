﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingPortal.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Location { get; set; }
        public string password { get; set; }

    }
}