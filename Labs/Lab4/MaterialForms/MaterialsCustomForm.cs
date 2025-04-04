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
    public partial class MaterialsCustomForm : Form
    {
        private readonly IDataService _dataService;
        private readonly List<Material> _materials;
        public MaterialsCustomForm(IDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            _materials = _dataService.GetMaterials();
            LoadMaterials();
        }
        private void LoadMaterials()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var material in _materials)
            {
                var materialView = new MaterialsView(material, OpenProductsByMaterial);
                flowLayoutPanel1.Controls.Add(materialView);
            }
        }
        private void OpenProductsByMaterial(int materialId)
        {
            var productForm = new ProductCustomForm(_dataService);
            this.Hide();
            productForm.ShowDialog();
            this.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _dataService.SaveChanges();
            MessageBox.Show("Save Changed");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new MainForm(_dataService);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
