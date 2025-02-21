namespace Lab2_Forms
{
    partial class PersonRecordEditDialog
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
            tbAge = new TextBox();
            tbMiddleName = new TextBox();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbAge
            // 
            tbAge.Location = new Point(12, 251);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(43, 23);
            tbAge.TabIndex = 16;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(12, 194);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(122, 23);
            tbMiddleName.TabIndex = 15;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(12, 136);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(122, 23);
            tbFirstName.TabIndex = 14;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(12, 80);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(122, 23);
            tbLastName.TabIndex = 13;
            // 
            // tbID
            // 
            tbID.Location = new Point(12, 27);
            tbID.Name = "tbID";
            tbID.Size = new Size(32, 23);
            tbID.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 233);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 21;
            label5.Text = "Лет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 20;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 19;
            label3.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 18;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(59, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PersonRecordEditDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 326);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAge);
            Controls.Add(tbMiddleName);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Controls.Add(tbID);
            Name = "PersonRecordEditDialog";
            Text = "Изменить данные";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAge;
        private TextBox tbMiddleName;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
    }
}