namespace Lab3
{
    partial class RegisterDialog
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
            btRegister = new Button();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btRegister
            // 
            btRegister.Location = new Point(31, 203);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(130, 23);
            btRegister.TabIndex = 0;
            btRegister.Text = "Зарегистрироваться";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(42, 37);
            tbLogin.MaximumSize = new Size(200, 23);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(109, 23);
            tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(42, 92);
            tbPassword.MaximumSize = new Size(200, 23);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(109, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbConfirmPassword.Location = new Point(42, 152);
            tbConfirmPassword.MaximumSize = new Size(200, 23);
            tbConfirmPassword.MinimumSize = new Size(109, 23);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(109, 23);
            tbConfirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 74);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 134);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Повторите пароль";
            // 
            // RegisterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 246);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(btRegister);
            MaximumSize = new Size(316, 285);
            MinimumSize = new Size(223, 285);
            Name = "RegisterDialog";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRegister;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}