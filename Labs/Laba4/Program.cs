using Microsoft.Extensions.DependencyInjection;
using Lab4.Savices;
using Lab4.Views;

namespace Laba4
{
    internal static class Program
    {
        static private IServiceProvider _serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new IServiceCollection();

            services.AddDbContext<AppDbContext>(options  =>
            options.Use)

            services.AddTransient<MainForm>();

            _serviceProvider = services.BuildServiceProvider();
            
            ApplicationConfiguration.Initialize();
            Application.Run(_serviceProvider.GetRequiredService(MainForm));
        }
    }
}