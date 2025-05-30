using System.Windows;
using Lab11.Models;
using Lab11.Services;
using Lab11.ViewModel;
using Lab11.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new();
            services.AddDbContext<AppDbContext>();           
            services.AddTransient<AutorizationWindow>();
            services.AddTransient<MainWindow>();
            services.AddTransient<RegistrationWindow>();
            services.AddTransient<AddBookWindow>();
            services.AddTransient<AddBookViewModel>();
            services.AddScoped<IAutorizationService, AutorizationService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IAddBooksService, AddBooks>();   
            _serviceProvider = services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = _serviceProvider.GetRequiredService<AutorizationWindow>();
            window.Show();
        }
    }
}
