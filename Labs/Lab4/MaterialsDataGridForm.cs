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
    public partial class MaterialsDataGridForm : Form
    {
        private readonly IDataService _dataService;
        public MaterialsDataGridForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = _dataService.GetMaterials().ToList();
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
