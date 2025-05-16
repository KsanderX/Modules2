using Authorization.DataBase;

namespace Authorization.Service
{
    public class CurrentUserService
    {
        private static CurrentUserService? _instance;
        public static CurrentUserService Instance => _instance ??= new CurrentUserService();

        public User? CurrentUser { get; private set; }
        public bool IsAuthenticated => CurrentUser != null;

        private CurrentUserService() { }

        public void Login(User user)
        {
            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
