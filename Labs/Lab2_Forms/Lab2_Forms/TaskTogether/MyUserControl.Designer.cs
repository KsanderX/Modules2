namespace Lab2_Forms
{
    partial class MyUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tbPassword = new TextBox();
            lbPassword = new Label();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(3, 18);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(94, 23);
            tbPassword.TabIndex = 0;
            // 
            // lbPassword
            // 
            lbPassword.Dock = DockStyle.Top;
            lbPassword.Location = new Point(0, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(150, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Anchor = AnchorStyles.Right;
            btnShowPassword.Location = new Point(100, 18);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(47, 23);
            btnShowPassword.TabIndex = 3;
            btnShowPassword.Text = "✳";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // MyUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShowPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbPassword);
            MaximumSize = new Size(10000, 50);
            MinimumSize = new Size(150, 50);
            Name = "MyUserControl";
            Size = new Size(150, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private Label lbPassword;
        private Button btnShowPassword;
    }
}
