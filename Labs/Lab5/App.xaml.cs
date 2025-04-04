using Lab5.Services;
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
    protected override void OnStartup(StartupEventArgs e)  //обработчик ивента startUp
    {
        var services = new ServiceCollection();
        services.AddTransient<MainWindow>();
        services.AddTransient<DataGridWindow>();
        services.AddScoped<IDbWorker, DataWorker>();

        var serviceProvider = services.BuildServiceProvider();

        var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}

