using Lab4.DataBase;
using Lab4.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lab4
{
    internal static class Program
    {
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
            services.AddTransient<ProductsDataGridForm>();
            services.AddTransient<MaterialsDataGridForm>();

            services.AddScoped<IDataService, DataService>();
            services.AddDbContext<AppDbContext>(options =>
              options.UseSqlite("Data source=./app.db")
           );

            var _serviceProvider = services.BuildServiceProvider();

            var mainForm = _serviceProvider.GetService<MainForm>();

            Application.Run(mainForm);

        }
    }
}