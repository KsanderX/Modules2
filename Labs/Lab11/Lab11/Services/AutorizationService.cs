using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11.Models;

namespace Lab11.Services
{
    public class AutorizationService : IAutorizationService
    {
        public AppDbContext _context;
        private User _user;
        public AutorizationService()
        {
            _context = new AppDbContext();
            _user = null!;
        }
        public bool Autorization(string login, string password)
        {
           User? user = _context.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();

            if (user != null)
            {
                _user = user;
                return true;
            }
            else
            {
                return false;
            }
        }        
    }  
}
