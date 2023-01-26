using Domain;
using Infrastructura;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AuthService
    {
        private readonly IRepository<User> repository = DbContext.Users;

        public async Task<bool> Registry(User newUser)
        {
            try
            {
                await repository.CreateAsync(newUser);
            }
            catch (Exception) { return false; }
            return true;
        }
        public async Task<User> Login(string email, string password)
        {
            IEnumerable<User> users = await repository.GetAllAsync();
            return users.SingleOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
        }
    }
}
