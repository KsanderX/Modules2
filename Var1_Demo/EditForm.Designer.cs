namespace Var1_Demo
{
    partial class EditForm
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
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            txtDescription = new TextBox();
            cmdStatus = new ComboBox();
            cmdUser = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(3, 21);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(141, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(3, 75);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(141, 23);
            txtGenre.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(3, 133);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(141, 23);
            txtDescription.TabIndex = 2;
            // 
            // cmdStatus
            // 
            cmdStatus.FormattingEnabled = true;
            cmdStatus.Location = new Point(3, 228);
            cmdStatus.Name = "cmdStatus";
            cmdStatus.Size = new Size(141, 23);
            cmdStatus.TabIndex = 3;
            // 
            // cmdUser
            // 
            cmdUser.FormattingEnabled = true;
            cmdUser.Location = new Point(3, 283);
            cmdUser.Name = "cmdUser";
            cmdUser.Size = new Size(141, 23);
            cmdUser.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmdUser);
            Controls.Add(cmdStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtGenre;
        private TextBox txtDescription;
        private ComboBox cmdStatus;
        private ComboBox cmdUser;
        private DateTimePicker dateTimePicker1;
    }
}