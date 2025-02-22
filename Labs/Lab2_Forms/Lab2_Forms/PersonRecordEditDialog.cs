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
        public string Id
        {
            get { return tbID.Text; }
            set { tbID.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName
        {
            get { return tbLastName.Text; }
            set { tbLastName.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName
        {
            get { return tbFirstName.Text; }
            set { tbFirstName.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MiddleName
        {
            get { return tbMiddleName.Text; }
            set { tbMiddleName.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Age
        {
            get
            {
                if (int.TryParse(tbAge.Text, out int age))
                {
                    return age;
                }
                return 0;
            }
            set { tbAge.Text = value.ToString(); }
        }

        public PersonRecordEditDialog(string id, string lastName, string firstName, string middleName, int age)
        {
            InitializeComponent();
            tbID.Text = id;
            tbLastName.Text = lastName;
            tbFirstName.Text = firstName;
            tbMiddleName.Text = middleName;
            tbAge.Text = age.ToString();
        }
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbAge.Text, out int age))
            {
                MessageBox.Show("Ошибка ввода!", "Введите корректный возраст.");
                return;
            }
            if (age < 0)
            {
                MessageBox.Show("Ошибка ввода!", "Возраст не должен быть отрицательным.");
                return;
            }
            if (age > 150)
            {
                MessageBox.Show("Ого! Вы старше, чем сама идея пенсии! Давайте уложимся в 150 лет, ладно?");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
