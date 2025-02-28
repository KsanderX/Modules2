using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ListAuthManager : IAuthManager
    {
        private readonly List<User> _users;
        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
        }        

        public ListAuthManager()
        {
            _users = new List<User>
            {
            new User { Id = 1, Login = "admin", Password = "admin" }
            };
        }

        public bool Login(string login, string password)
        {
            return _users.Any(user => user.Login == login && user.Password == password);
        }

        public void Register(string login, string password)
        {
            var newUser = new User { Id = _users.Count + 1, Login = login, Password = password };
            _users.Add(newUser);
        }

        public bool IsLoginTaken(string login)
        {
            return _users.Any(user => user.Login == login);
        }
    }

}
