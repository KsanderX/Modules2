using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Var5.Models;

namespace Var5.Views
{
    /// <summary>
    /// Логика взаимодействия для AddRequestView.xaml
    /// </summary>
    public partial class AddRequestView : Window
    {
        private AppDbContext _context;
        public AddRequestView(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }
    }
}
