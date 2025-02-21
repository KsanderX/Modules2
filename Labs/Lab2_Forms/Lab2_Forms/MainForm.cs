using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Forms
{
    public partial class MainForm : Form
    {
        private int totalRecords = 0;
        private int totalAges = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var personControl = new PersonRecordEditDialog(1, "Имя", "Фамилия", "Отчество", 20);

            personControl.RecordDeleted += RecordDeletedHandler;
            personControl.RecordUpdated += RecordUpdatedHandler;

            flowLayoutPanel1.Controls.Add(personControl);

            totalRecords++;
            totalAges++;

            UpdateTotalDisplay();
        }

        private void RecordDeletedHandler(object sender, EventArgs e)
        {
            totalRecords--;
            if(sender is PersonRecordUserControl record)
            {
                totalAges -= record.Age;
            }
            UpdateTotalDisplay();
        }
        private void RecordUpdatedHandler(object sender, EventArgs e)
        {
            RecalculateTotalAge();
        }

        private void UpdateTotalDisplay()
        {
            lbtotalRecords.Text = $"{totalRecords}";
            lbtotalAges.Text = $"{totalAges}";
        }

        private void RecalculateTotalAge()
        {
            totalAges = 0;
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is PersonRecordUserControl record)
                {
                    totalAges += record.Age;
                }
            }
            UpdateTotalDisplay();
        }

    }
}
