using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Navigation.Models;
using Navigation.Services;
using Navigation.ViewModels;
using Navigation.Views;

namespace Navigation
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            var service = new ServiceCollection();

            service.AddDbContext<AppDbContext>(options =>
             options.UseSqlite("Data source=./app.db"));

            service.AddTransient<MainWindow>();
            service.AddTransient<MainWindowMVVM>();
            service.AddTransient<AddProductWindow>();
            service.AddTransient<EditProductWindow>();

            service.AddTransient<ViewModelBase>();
            service.AddTransient<MVVM>();
            service.AddTransient<AddProductViewModel>();
            service.AddTransient<EditProductViewModel>();
            service.AddTransient<MainViewModel>();

            service.AddSingleton<IMVVMNavigationService, MVVMNavigationService>();
            service.AddScoped<IDbWork, DbWork>();

            _serviceProvider = service.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _serviceProvider.GetRequiredService<IMVVMNavigationService>().NavigateTo<MainViewModel>();

            var window = _serviceProvider.GetRequiredService<MainWindowMVVM>();
            var vm = _serviceProvider.GetRequiredService<MVVM>();
            window.DataContext = vm;
            window.Show();
        }
    }
}