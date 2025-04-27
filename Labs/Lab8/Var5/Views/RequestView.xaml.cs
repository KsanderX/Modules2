using System.Windows;
using Var5.Models;


namespace Var5.Views
{
    /// <summary>
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class RequestView : Window
    {
        private AppDbContext _context;
        public RequestView(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }
    }
}
