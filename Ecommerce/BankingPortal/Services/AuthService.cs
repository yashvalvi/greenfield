using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingPortal.Models;
using BankingPortal.Repositories;

namespace BankingPortal.Services
{
   
        public class AuthService : IAuthService
        {
            List<User> users;
            List<Credential> credential;
        public string userFilePath = @"E:/bankuser.json";
        public string credFilePath = @"E:/creduser.json";
            public AuthService()
            {
                this.users = new List<User>();
                this.credential = new List<Credential>();


            }


            public bool Seeding()
            {
                bool status = true;
                List<User> users = new List<User>();   //// ID FirstName LastName Email contact
                                                       //retreive all products from file
                users.Add(new User { ID = 1, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com",ContactNo="705854643" ,password = "7058964631" ,Location="Pune" });
                users.Add(new User { ID = 2, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", ContactNo = "705854643", password = "7058964631",Location="Pune" });
                users.Add(new User { ID = 3, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", ContactNo = "705854643", password = "7058964631", Location = "Pune" });
                users.Add(new User { ID = 4, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", ContactNo = "705854643", password = "7058964631", Location = "Pune" });
                users.Add(new User { ID = 5, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", ContactNo = "705854643", password = "7058964631", Location = "Pune" });
                List<Credential> creds = new List<Credential>();
                creds.Add(new Credential { Email = "yashvalvi334@gmsil.com", Password = "ssaadsa" });
                creds.Add(new Credential { Email = "yashvalvi671@gmail.com", Password = "ssaadsd" });
                IDataRepository<User> repo = new JsonRepository<User>();
                 repo.Serialize(userFilePath, users);
                IDataRepository<Credential> cepo = new JsonRepository<Credential>();
                cepo.Serialize(credFilePath, creds);
                return status;

            }
            public bool ForgotPassword(string username)
            {
                throw new NotImplementedException();
            }

            public bool Login(string email, string password)
            {
                IDataRepository<Credential> repo = new JsonRepository<Credential>();
                List<Credential> creds = repo.Deserialize(credFilePath);
                foreach (Credential user in creds)
                {
                    if (user.Email == email && user.Password == password)
                    {
                        return true;
                    }
                }
                return false;

            }

            public bool Register(User user)
            {

            IDataRepository<User> repo = new JsonRepository<User>();
                List<User> allusers = repo.Deserialize(userFilePath);
                /*foreach (User u in allusers)
                {
                    if (u.ID == user.ID)
                    {

                        return false;
                    }


                }*/
           
                user.ID = allusers.Count()+1;
                allusers.Add(user);
                repo.Serialize(userFilePath, allusers);
                return true;


            }




           



            


        }
    }
