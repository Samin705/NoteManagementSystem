using NoteManagementSystem.DTO;
using NoteManagementSystem.IRepo;
using NoteManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteManagementSystem.Repo
{
    public class LoginRegistration : ILoginRegistration
    {

        IList<User> user = new List<User>();
     

        public  CreateUserDTO CreateUser(CreateUserDTO obj)
        {
            try
            {
                var u = new User
                {
                    DateOfBirth = obj.DateOfBirth,
                    UserName = obj.UserName,
                    UserId = new Guid(),
                    Email = obj.Email,
                    PassWord = obj.PassWord
                };
                user.Add(u);

                return obj;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UserLogin(Guid UserId, string Password)
        {
            var data = (from u in user
                        where u.UserId == UserId && u.PassWord == Password
                        select u).FirstOrDefault();
            if (data != null)
                return true;
            else
                throw new Exception("Login Failed");
        }
    }
}
