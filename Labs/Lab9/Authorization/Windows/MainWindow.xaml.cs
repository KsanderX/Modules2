using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Authorization.DataBase;
using Authorization.Service;
using Authorization.Windows;


namespace Authorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UserService _userService;
        private readonly CurrentUserService _currentUserService;
        public MainWindow()
        {
            InitializeComponent();
            _userService = new UserService();
            _currentUserService = CurrentUserService.Instance;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await UpdateUI();
        }
        private async Task UpdateUI()
        {
            if (_currentUserService.IsAuthenticated)
            {
                btnLogin.Visibility = Visibility.Collapsed;
                btnLogout.Visibility = Visibility.Visible;

                var users = await _userService.GetAllUsersAsync();
                UsersGrid.ItemsSource = users;
                UsersGrid.Visibility = Visibility.Visible;
            }
            else
            {
                btnLogin.Visibility = Visibility.Visible;
                btnLogout.Visibility = Visibility.Collapsed;
                UsersGrid.Visibility = Visibility.Collapsed;
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var authWindow = new AuthorizationWindow();
            authWindow.Owner = this;
            authWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            authWindow.ShowDialog();
            _ = UpdateUI();
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            _currentUserService.Logout();
            _ = UpdateUI();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}