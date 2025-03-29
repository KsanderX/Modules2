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

namespace Lab4
{
    public partial class ProductView : UserControl
    {
        private readonly Product _product;
        private readonly List<Material> _materials;
        public ProductView( Product product, List<Material> materials)
        {
            InitializeComponent();
            _product = product;
            _materials = materials;
            LoadData();
        }
        private void LoadData()
        {
            tbId.Text = _product.Id.ToString();
            tbName.Text = _product.Name;
            tbPrice.Text = _product.Price.ToString();

            cbMaterials.DataSource = _materials;
            cbMaterials.DisplayMember = "Name";
            cbMaterials.ValueMember = "Id";
            cbMaterials.SelectedValue = _product.MaterialId;
        }
    }
}
