using ApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();

            users.Add(new User { Id = 1, Username = "Kleber", Password = "kleber", Role = "manager" });
            users.Add(new User { Id = 1, Username = "Luiz", Password = "luiz", Role = "employee" });

            return users
                .Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password)
                .FirstOrDefault();
        }
    }
}
