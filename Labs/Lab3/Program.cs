using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Windows.Forms;
using System;

namespace Lab3
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddTransient<MainForm>();
            services.AddTransient<LoginDialog>();
            services.AddTransient<RegisterDialog>();

            services.AddScoped<IAuthManager, RealAuthManager>();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data source=./app.db"));

            _serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(_serviceProvider.GetRequiredService<MainForm>());                      
        }


    }
}