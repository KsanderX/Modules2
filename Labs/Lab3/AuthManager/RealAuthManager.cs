using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AuthManager
{
    public class RealAuthManager : IAuthManager
    {
        private readonly AppDbContext _dbContext;

        public RealAuthManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public bool Login(string login, string password)
        {
            return _dbContext.Users.Any(user => user.Login == login && user.Password == password);
        }

        public void Register(string login, string password)
        {
            if (IsLoginTaken(login))
                throw new InvalidOperationException("Логин уже занят");

            var newUser = new User { Login = login, Password = password };
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
        }

        public bool IsLoginTaken(string login)
        {
            return _dbContext.Users.Any(user => user.Login == login);
        }
    }
}
