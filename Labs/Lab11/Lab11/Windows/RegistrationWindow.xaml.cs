using System.Windows;
using Lab11.Models;
using Lab11.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private IServiceProvider _serviceProvider;
        private IRegistrationService _registrationService;
        private AppDbContext _context;

        public RegistrationWindow(IServiceProvider serviceProvider, IRegistrationService service, AppDbContext dbContext)
        {
            InitializeComponent();                       
            _serviceProvider = serviceProvider;
            _registrationService = service;
            _context = dbContext;
        }
        
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Login = tbLogin.Text,
                Password = pbPassword.Password,
                Name = tbName.Text,
                PhoneNumber = tbPhone.Text,
                RegistrationDate = DateOnly.FromDateTime(DateTime.Now)
            };
            _registrationService.RegAccount(user);
            MessageBox.Show("Пользователь успешно зарегистрирован!");
            var autorizationWindow = _serviceProvider.GetRequiredService<AutorizationWindow>();
            this.Close();
            autorizationWindow.ShowDialog();
        }
    }
}
