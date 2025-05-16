using System.Windows;
using System.Windows.Controls;
using Authorization.DataBase;
using Authorization.Service;

namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private readonly UserService _userService;
        public RegistrationWindow()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password) ||
                string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля");
                return;
            }

            if (PasswordBox.Password != ConfirmPasswordBox.Password)
            {
                MessageBox.Show("Пароли не совпадают");                
            }
            var user = new User
            {
                Login = tbLogin.Text,
                Password = PasswordBox.Password,
                Email = tbEmail.Text,
                PhoneNumber = tbPhone.Text,
                FullName = new FullName
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Patronymic = tbPatronymic.Text
                }
            };

            try
            {
                await _userService.RegisterAsync(user);
                Close();
            }
            catch
            {
                MessageBox.Show("Регистрация не удалась");
            }
        }
    }
}
