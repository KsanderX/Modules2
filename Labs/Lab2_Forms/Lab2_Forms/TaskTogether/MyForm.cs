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
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            MyForm dialog = new MyForm();
            DialogResult result = dialog.ShowDialog();

            MessageBox.Show($"Result {result}");

            if (result == DialogResult.OK) 
            {
                string password = dialog.myUserControl.SecretText;
                MessageBox.Show($"Password: {password}");
            }
        }
        public string SecretText
        {
            get => myUserControl.SecretText; 
        }

        //string Password => MyUserControl.SecretText;

        //private void btnShowDialog_Click(object sender, EventArgs e)
        //{
        //    MyForm dialogForm = new MyForm();
        //    DialogResult result = dialogForm.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        MessageBox.Show("Пароль: " + dialogForm.Password);
        //    }
        //}

    }
}
