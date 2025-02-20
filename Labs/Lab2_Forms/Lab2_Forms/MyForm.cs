namespace Lab2_Forms
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    var password = tbPassword.Text;
        //}

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Password => MyUserControl.tbPassword;

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            MyForm dialogForm = new MyForm();
            DialogResult result = dialogForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Пароль: " + dialogForm.Password);
            }
        }

    }
}
