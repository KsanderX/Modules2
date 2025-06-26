using Lab11.Models;

namespace Lab11.Services
{
    public class RegistrationService : IRegistrationService
    {
        private AppDbContext _context;
        public RegistrationService(AppDbContext context)
        {
            _context = context;
        }
        public void RegAccount(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

        }
    }
}  

