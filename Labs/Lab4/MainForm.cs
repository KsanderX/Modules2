using Lab4.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Lab4
{
    public partial class MainForm : Form
    {

        private readonly IDataService _dataService;
        public MainForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
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

        private void btnMaterialsCustomDlg_Click(object sender, EventArgs e)
        {
            var materialsForm = new MaterialsCustomForm(_dataService);
            this.Hide();
            materialsForm.ShowDialog();
            this.Show();
        }

        private void btnProductsCustomDlg_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductCustomForm(_dataService);
            this.Hide();
            productsForm.ShowDialog();
            this.Show();
        }
    }
}
