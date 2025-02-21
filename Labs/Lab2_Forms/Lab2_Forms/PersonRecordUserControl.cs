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
    public partial class PersonRecordUserControl : UserControl
    {
        public event EventHandler RecordDeleted;
        public event EventHandler RecordUpdated;

        private static int currentID = 0;

        public PersonRecordUserControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MiddleName { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Age { get; private set; }

        public PersonRecordUserControl(int id, string firstName, string lastName, string middleName, int age)
        {
            InitializeComponent();
            Id = ++currentID;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            tbID.Text = Id.ToString();
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbMiddleName.Text = MiddleName;
            tbAge.Text = Age.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            using (var dialog = new PersonRecordEditDialog(Id, FirstName, LastName, MiddleName, Age))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FirstName = dialog.FirstName;
                    LastName = dialog.LastName;
                    MiddleName = dialog.MiddleName;
                    Age = dialog.Age;
                    UpdateDisplay();
                    RecordUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RecordDeleted?.Invoke(this, EventArgs.Empty);
            this.Parent.Controls.Remove(this);
        }
    }
}
