using System.Windows;
using System.Windows.Controls;
using Lab11.Models;
using Lab11.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11.Windows
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        private IAutorizationService _autorizationService;
        private IServiceProvider _serviceProvider;

        public AutorizationWindow(IAutorizationService autorizationService, IServiceProvider service, AppDbContext dbContext)
        {
            InitializeComponent();
            _serviceProvider = service;
            _autorizationService = autorizationService;
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Password;

            bool isAuthorized = _autorizationService.Autorization(login, password);

            if (isAuthorized)
            {
                MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
                this.Close();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var registrationWindow = _serviceProvider.GetRequiredService<RegistrationWindow>();
            this.Close();
            registrationWindow.ShowDialog();
        }
    }
}

     
