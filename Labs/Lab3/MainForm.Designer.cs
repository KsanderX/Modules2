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
            btSignIn = new Button();
            btSignUp = new Button();
            SuspendLayout();
            // 
            // btSignIn
            // 
            btSignIn.Location = new Point(74, 54);
            btSignIn.Name = "btSignIn";
            btSignIn.Size = new Size(75, 23);
            btSignIn.TabIndex = 0;
            btSignIn.Text = "Вход";
            btSignIn.UseVisualStyleBackColor = true;
            // 
            // btSignUp
            // 
            btSignUp.Location = new Point(74, 98);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(88, 23);
            btSignUp.TabIndex = 1;
            btSignUp.Text = "Регистрация";
            btSignUp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSignUp);
            Controls.Add(btSignIn);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btSignIn;
        private Button btSignUp;
    }
}
