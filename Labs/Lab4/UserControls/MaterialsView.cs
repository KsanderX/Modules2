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
    public partial class MaterialsView : UserControl
    {
        private readonly Material _material;
        private readonly Action<int> _openProductsByMaterial;
        public MaterialsView(Material material, Action<int> openProductsByMaterial)
        {
            InitializeComponent();
            _material = material;
            _openProductsByMaterial = openProductsByMaterial;
            LoadData();
        }
        private void LoadData()
        {
            tbId.Text = _material.Id.ToString();
            tbName.Text = _material.Name;
        }

        private void btnOpenProducts_Click(object sender, EventArgs e)
        {
            _openProductsByMaterial(_material.Id);
        }
    }
}
