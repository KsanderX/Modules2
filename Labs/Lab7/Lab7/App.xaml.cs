using Lab7.Views;
using Lab7.ViewsMVVM;
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
            services.AddTransient<PeopleViewMVVM>();
            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = serviceProvider.GetRequiredService<PeopleViewMVVM>();
            window.Show();
        }
    }

}
