using Microsoft.EntityFrameworkCore;
using System.Windows;
using Var1.DataBase;

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext _appDbContext;
        public MainWindow(AppDbContext appDbContext)
        {
            InitializeComponent();
            _appDbContext = appDbContext;
        }
        
        private void Load()
        {

        }
    }
}
