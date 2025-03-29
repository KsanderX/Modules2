using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.DataBase;
using Lab4.Service;

namespace Lab4
{
    public partial class ProductCustomForm : Form
    {
        private readonly IDataService _dataService;
        private readonly List<Material> _materials;
        private readonly List<Product> _products;
        public ProductCustomForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            _materials = _dataService.GetMaterials();
            _products = _dataService.GetProducts();
            LoadProducts();
        }
        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in _products)
            {
                var productView = new ProductView(product, _materials);
                flowLayoutPanel1.Controls.Add(productView);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dataService.SaveChanges();
            MessageBox.Show("Save Changes");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(_dataService);
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
