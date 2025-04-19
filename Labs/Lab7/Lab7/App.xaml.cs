using Lab7.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Lab7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            services.AddTransient<PeopleView>();
            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = serviceProvider.GetRequiredService<PeopleView>();
            window.Show();
        }
    }

}
