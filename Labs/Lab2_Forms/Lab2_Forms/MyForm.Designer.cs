namespace Lab2_Forms
{
    partial class MyForm
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
            myUserControl2 = new MyUserControl();
            btnOK = new Button();
            btnShowDialog = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // myUserControl2
            // 
            myUserControl2.Label = "Password";
            myUserControl2.Location = new Point(55, 39);
            myUserControl2.MaximumSize = new Size(10000, 50);
            myUserControl2.MinimumSize = new Size(150, 50);
            myUserControl2.Name = "myUserControl2";
            myUserControl2.SecretText = "";
            myUserControl2.Size = new Size(160, 50);
            myUserControl2.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(386, 84);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnShowDialog
            // 
            btnShowDialog.Location = new Point(386, 113);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(89, 23);
            btnShowDialog.TabIndex = 3;
            btnShowDialog.Text = "ShowDialog";
            btnShowDialog.UseVisualStyleBackColor = true;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(405, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnShowDialog);
            Controls.Add(btnOK);
            Controls.Add(myUserControl2);
            Name = "MyForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MyUserControl myUserControl2;
        private Button btnOK;
        private Button btnShowDialog;
        private Button btnAdd;
    }
}
