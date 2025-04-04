using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
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
using Lab5.Models;
using Lab5.Services;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для DataGridWindow.xaml
    /// </summary>
    public partial class DataGridWindow : Window
    {
        private IEnumerable _itemsSource;
        private AppDbContext _appDbContext;
       
        public DataGridWindow(IEnumerable itemsSource, AppDbContext appDbContext )
        {
            InitializeComponent();
            _itemsSource = itemsSource;          
            dataGrid.ItemsSource = _itemsSource;
            _appDbContext = appDbContext;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _appDbContext.SaveChanges();
        }
    }
}
