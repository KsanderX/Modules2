using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class RegisterDialog : Form
    {

        private readonly IAuthManager _authManager;
        public RegisterDialog(IAuthManager authManager)
        {
            InitializeComponent();
            _authManager = authManager;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;
            var confirmPassword = tbConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (_authManager.IsLoginTaken(login))
            {
                MessageBox.Show("Логин уже занят");
                return;
            }

            _authManager.Register(login, password);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
