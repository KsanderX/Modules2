namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogIn = new Button();
            btRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btLogIn
            // 
            btLogIn.Location = new Point(93, 101);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(88, 23);
            btLogIn.TabIndex = 0;
            btLogIn.Text = "Вход";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += btLogIn_Click;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(93, 153);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(88, 23);
            btRegister.TabIndex = 1;
            btRegister.Text = "Регистрация";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 41);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Добро пожаловать! ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 213);
            Controls.Add(label1);
            Controls.Add(btRegister);
            Controls.Add(btLogIn);
            MaximumSize = new Size(311, 252);
            MinimumSize = new Size(311, 252);
            Name = "MainForm";
            Text = "Главная страница";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogIn;
        private Button btRegister;
        private Label label1;
    }
}
