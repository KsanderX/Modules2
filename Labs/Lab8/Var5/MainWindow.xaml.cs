using System.Windows;
using Var5.Models;

namespace Var5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext _context;
        public MainWindow(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }
    }
}