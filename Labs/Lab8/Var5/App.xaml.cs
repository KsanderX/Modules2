using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Var5.Models;
using Var5.Views;

namespace Var5
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
            services.AddTransient<RequestView>();
            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var window = serviceProvider.GetRequiredService<RequestView>();
            window.Show();
        }
    }

}
