namespace Lab2_Forms
{
    partial class PersonRecordUserControl
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
            label1 = new Label();
            btnDelete = new Button();
            btnChange = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbID = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbMiddleName = new TextBox();
            tbAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(446, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(446, 17);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(77, 23);
            btnChange.TabIndex = 1;
            btnChange.Text = "Изменить";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 6;
            label5.Text = "Лет";
            // 
            // tbID
            // 
            tbID.Location = new Point(0, 17);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(32, 23);
            tbID.TabIndex = 7;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(38, 18);
            tbLastName.Name = "tbLastName";
            tbLastName.ReadOnly = true;
            tbLastName.Size = new Size(100, 23);
            tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(155, 18);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.ReadOnly = true;
            tbFirstName.Size = new Size(100, 23);
            tbFirstName.TabIndex = 9;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(270, 18);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.ReadOnly = true;
            tbMiddleName.Size = new Size(100, 23);
            tbMiddleName.TabIndex = 10;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(376, 19);
            tbAge.Name = "tbAge";
            tbAge.ReadOnly = true;
            tbAge.Size = new Size(50, 23);
            tbAge.TabIndex = 11;
            // 
            // PersonRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbAge);
            Controls.Add(tbMiddleName);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Controls.Add(tbID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(label1);
            Name = "PersonRecordUserControl";
            Size = new Size(547, 82);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDelete;
        private Button btnChange;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbID;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private TextBox tbMiddleName;
        private TextBox tbAge;
    }
}
