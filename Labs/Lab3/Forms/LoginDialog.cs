using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.AuthManager;

namespace Lab3
{
    public partial class LoginDialog : Form
    {

        private readonly IAuthManager _authManager;
        public LoginDialog(IAuthManager authManager)
        {
            InitializeComponent();
            _authManager = authManager;
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;

            if (_authManager.Login(login, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

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

        private void LoginDialog_Load(object sender, EventArgs e)
        {

        }
    }


}
