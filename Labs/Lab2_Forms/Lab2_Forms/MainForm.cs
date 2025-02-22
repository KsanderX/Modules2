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
        private int nextID = 1;
        public MainForm()
        {
            InitializeComponent();
            UpdateStatistics();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl personRecord = new PersonRecordUserControl();

            personRecord.Id = nextID.ToString();
            personRecord.LastName = "Александров";
            personRecord.FirstName = "Александр";
            personRecord.MiddleName = "Александрович";
            personRecord.Age = 20;


            personRecord.EditClicked += PersonRecord_EditClicked;
            personRecord.DeleteClicked += PersonRecord_DeleteClicked;

            flowLayoutPanel1.Controls.Add(personRecord);         

            nextID++;

            UpdateStatistics();
        }
        private void PersonRecord_EditClicked(object sender, EventArgs e)
        {
            PersonRecordUserControl personRecord = (PersonRecordUserControl)sender;

            PersonRecordEditDialog editDialog = new PersonRecordEditDialog(
                personRecord.Id,
                personRecord.LastName,
                personRecord.FirstName,
                personRecord.MiddleName,
                personRecord.Age
            );

            if (editDialog.ShowDialog() == DialogResult.OK)
            {
                personRecord.Id = editDialog.Id;
                personRecord.LastName = editDialog.LastName;
                personRecord.FirstName = editDialog.FirstName;
                personRecord.MiddleName = editDialog.MiddleName;
                personRecord.Age = editDialog.Age;

                UpdateStatistics();
            }
        }

        private void PersonRecord_DeleteClicked(object sender, EventArgs e)
        {
            PersonRecordUserControl personRecord = (PersonRecordUserControl)sender;

            // Отписываемся от событий
            personRecord.EditClicked -= PersonRecord_EditClicked;
            personRecord.DeleteClicked -= PersonRecord_DeleteClicked;

            flowLayoutPanel1.Controls.Remove(personRecord);

            UpdateStatistics();
        }
        private void UpdateStatistics()
        {
            int recordCount = flowLayoutPanel1.Controls.Count;
            int totalAge = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PersonRecordUserControl personRecord)
                {
                    totalAge += personRecord.Age;
                }
            }

            lbtotalRecords.Text = $"{recordCount}";
            lbtotalAges.Text = $"{totalAge}";
        }

    }
}
