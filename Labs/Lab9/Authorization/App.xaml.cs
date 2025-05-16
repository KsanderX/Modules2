using System.Configuration;
using System.Data;
using System.Windows;
using Authorization.DataBase;
using Authorization.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace Authorization
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
         
        public App()
        {
            ServiceCollection services = new();
            services.AddDbContext<AppDbContext>();

            services.AddTransient<MainWindow>();
            services.AddTransient<AuthorizationWindow>();
            services.AddTransient<RegistrationWindow>();

            _serviceProvider = services.BuildServiceProvider();
        }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = _serviceProvider.GetService<MainWindow>();
            if (window != null)
            {
                window.Show();
            }
            else
            {
                MessageBox.Show("Не удалось создать окно MainWindow.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }
    }

}
