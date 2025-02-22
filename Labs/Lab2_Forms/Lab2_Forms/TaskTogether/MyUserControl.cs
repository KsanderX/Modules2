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
    public partial class MyUserControl : UserControl
    {
        [Browsable(true)] // Отображать свойство в PropertyGrid
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Сериализовать свойство
        [Category("1_myCategory")]
        public string Label
        {
            get => lbPassword.Text;
            set => lbPassword.Text = value;
        }
       
        [Browsable(true)] // Отображать свойство в PropertyGrid
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Сериализовать свойство
        [Category("1_myCategory")]
        public string SecretText
        {
            get => tbPassword.Text;
            set => tbPassword.Text = value;
        }
        public MyUserControl()
        {
            InitializeComponent();
        }

        private bool _showPassword = false;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            if (_showPassword)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
