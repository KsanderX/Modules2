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
using Lab5.Services;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для MaterialsDataGridWindow.xaml
    /// </summary>
    public partial class MaterialsDataGridWindow : Window
    {
        private IDbWorker _bWorker;
        public MaterialsDataGridWindow(IDbWorker dbWorker)
        {
            InitializeComponent();
            _bWorker = dbWorker;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
