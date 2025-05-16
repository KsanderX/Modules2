using Authorization.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Service
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService()
        {
            _context = new AppDbContext();
        }

        public async Task<User?> AuthenticateAsync(string login, string password)
        {
            return await _context.Users
                .Include(u => u.Role)
                .Include(u => u.FullName)
                .FirstOrDefaultAsync(u => u.Login == login && u.Password == password);
        }

        public async Task RegisterAsync(User user)
        {
            user.RoleId = 2;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(u => u.Role)
                .Include(u => u.FullName)
                .ToListAsync();
        }
    }
}
