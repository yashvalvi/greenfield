﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
   public interface IAuthService
    {
        bool Login(string username, string password);
        bool Register(User user);
        bool ForgotPassword(string username);
        bool ResetPassword(string username, string oldpassword, string newpassword);
    }
}
