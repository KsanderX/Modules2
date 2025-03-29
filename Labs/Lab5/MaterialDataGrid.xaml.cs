using Lab5.Services;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для MaterialDataGrid.xaml
    /// </summary>
    public partial class MaterialDataGrid : Page
    {
        private readonly IDataService _dataService;
        public MaterialDataGrid(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
        }
    }
}
