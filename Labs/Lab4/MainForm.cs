using Lab4.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Lab4
{
    public partial class MainForm : Form
    {

        private readonly IDataService _dataService;
        public MainForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }
        private void btnMaterialsOpenDlg_Click(object sender, EventArgs e)
        {
            var materials = new MaterialsDataGridForm(_dataService);
            this.Hide();
            materials.ShowDialog();
            this.Close();
        }

        private void btnProductOpenDlg_Click(object sender, EventArgs e)
        {
            var materials = new ProductsDataGridForm(_dataService);
            this.Hide();
            materials.ShowDialog();
            this.Close();
        }

    }
}
