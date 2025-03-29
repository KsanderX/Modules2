using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Lab5;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;
    public App()
    {
        var services = new ServiceCollection();
        services.AddTransient<MainWindow>();
        _serviceProvider = services.BuildServiceProvider();
    }
    protected override void OnStartup(StartupEventArgs e)  //обработчик ивента startUp
    {
        var window = new MainWindow();
        window.Show();
    }
}

