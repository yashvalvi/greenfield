using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryDataRepositoryLib;
using Specification;
namespace Membership
{
    public class AuthService : IAuthService
    {
        List<User> users;
        List<Credential> credential;
        public AuthService()
        {
            this.users = new List<User>();
            this.credential = new List<Credential>();
        }


        public bool Seeding()
        {
            bool status = false;
            List<User> users = new List<User>();   //// ID FirstName LastName Email contact
            //retreive all products from file
            users.Add(new User { ID = 1, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", password = "7058964631" });
            users.Add(new User { ID = 2, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", password = "7058964631" });
            users.Add(new User { ID = 3, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", password = "7058964631" });
            users.Add(new User { ID = 4, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", password = "7058964631" });
            users.Add(new User { ID = 5, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", password = "7058964631" });

            IDataRepository<User> repo = new BinaryRepository<User>();
            status = repo.Serialize("users.dat", users);
            return status;

        }
        public bool ForgotPassword(string username)
        {
            throw new NotImplementedException();
        }

        public bool Login(string email, string password)
        {
            IDataRepository<User> repo = new BinaryRepository<User>();
            List<User> allusers = repo.Deserialize("users.dat");
            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;

        }

        public bool Register(User user)
        {
            IDataRepository<User> repo = new BinaryRepository<User>();
            List<User> allusers = repo.Deserialize("users.dat");
            foreach(User u in allusers)
            {
                if(u.ID == user.ID)
                {

                    return false;
                }
               

            }
            allusers.Add(user);
            repo.Serialize("users.dat", allusers);
            return true; ;
            

        }




        public bool ResetPassword(string username, string oldpassword, string newpassword, string Email)
        {
            IDataRepository<User> repo = new BinaryRepository<User>();
            List<User> allusers = repo.Deserialize("users.dat");
            foreach (User user in allusers)
            {
                if (user.Email == Email && user.password == oldpassword)
                {
                    user.password = newpassword;

                }
                return true;
            }
            return false;




        }

    }
}