using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Membership;
namespace MembershipTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthService svc = new AuthService();
            svc.Seeding();
            
            
        }
    }
}
