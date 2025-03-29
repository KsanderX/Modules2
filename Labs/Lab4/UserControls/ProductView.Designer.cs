namespace Lab4
{
    partial class ProductView
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
            tbId = new TextBox();
            tbName = new TextBox();
            tbPrice = new TextBox();
            cbMaterials = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(0, 34);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(131, 34);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(257, 34);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(100, 23);
            tbPrice.TabIndex = 2;
            // 
            // cbMaterials
            // 
            cbMaterials.FormattingEnabled = true;
            cbMaterials.Location = new Point(384, 34);
            cbMaterials.Name = "cbMaterials";
            cbMaterials.Size = new Size(121, 23);
            cbMaterials.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 16);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 16);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 16);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Materials";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbMaterials);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Name = "ProductView";
            Size = new Size(526, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbPrice;
        private ComboBox cbMaterials;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
