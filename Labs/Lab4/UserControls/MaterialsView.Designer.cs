namespace Lab4
{
    partial class MaterialsView
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
            btnOpenProducts = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(17, 26);
            tbId.Name = "tbId";
            tbId.Size = new Size(105, 23);
            tbId.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(158, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(105, 23);
            tbName.TabIndex = 1;
            // 
            // btnOpenProducts
            // 
            btnOpenProducts.Location = new Point(309, 26);
            btnOpenProducts.Name = "btnOpenProducts";
            btnOpenProducts.Size = new Size(75, 23);
            btnOpenProducts.TabIndex = 2;
            btnOpenProducts.Text = "Products";
            btnOpenProducts.UseVisualStyleBackColor = true;
            btnOpenProducts.Click += btnOpenProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 8);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // MaterialsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenProducts);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Name = "MaterialsView";
            Size = new Size(420, 66);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private TextBox tbName;
        private Button btnOpenProducts;
        private Label label1;
        private Label label2;
    }
}
