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
    public partial class PersonRecordEditDialog : Form
    {
        public PersonRecordEditDialog()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MiddleName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Age { get; private set; }

        public PersonRecordEditDialog(int id,string firstName, string lastName, string middleName, int age)
        {
            InitializeComponent();
            tbID.Text = id.ToString();
            tbLastName.Text = lastName;
            tbFirstName.Text = firstName;
            tbMiddleName.Text = middleName;
            tbAge.Text = age.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text;
            LastName = tbLastName.Text;
            MiddleName = tbMiddleName.Text;
            Age = int.Parse(tbAge.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
