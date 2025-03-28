namespace Lab3
{
    partial class LoginDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogIn = new Button();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // btLogIn
            // 
            btLogIn.AutoSize = true;
            btLogIn.Location = new Point(12, 132);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(75, 25);
            btLogIn.TabIndex = 0;
            btLogIn.Text = "Войти";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += btLogIn_Click;
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(12, 27);
            tbLogin.MaximumSize = new Size(200, 23);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(97, 23);
            tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(12, 94);
            tbPassword.MaximumSize = new Size(200, 23);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(97, 23);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Anchor = AnchorStyles.Right;
            btnShowPassword.Location = new Point(116, 94);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(57, 23);
            btnShowPassword.TabIndex = 5;
            btnShowPassword.Text = "🎈";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // LoginDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 181);
            Controls.Add(btnShowPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(btLogIn);
            MaximumSize = new Size(300, 220);
            MinimumSize = new Size(200, 220);
            Name = "LoginDialog";
            Text = "Вход";
            Load += LoginDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogIn;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnShowPassword;
    }
}