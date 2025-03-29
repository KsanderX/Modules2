namespace Lab4
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
            btnMaterialsOpenDlg = new Button();
            btnProductOpenDlg = new Button();
            btnMaterialsCustomDlg = new Button();
            btnProductsCustomDlg = new Button();
            SuspendLayout();
            // 
            // btnMaterialsOpenDlg
            // 
            btnMaterialsOpenDlg.Location = new Point(23, 25);
            btnMaterialsOpenDlg.Name = "btnMaterialsOpenDlg";
            btnMaterialsOpenDlg.Size = new Size(143, 101);
            btnMaterialsOpenDlg.TabIndex = 0;
            btnMaterialsOpenDlg.Text = "Materials open dialog";
            btnMaterialsOpenDlg.UseVisualStyleBackColor = true;
            btnMaterialsOpenDlg.Click += btnMaterialsOpenDlg_Click;
            // 
            // btnProductOpenDlg
            // 
            btnProductOpenDlg.Location = new Point(255, 25);
            btnProductOpenDlg.Name = "btnProductOpenDlg";
            btnProductOpenDlg.Size = new Size(143, 101);
            btnProductOpenDlg.TabIndex = 1;
            btnProductOpenDlg.Text = "Products open dialog";
            btnProductOpenDlg.UseVisualStyleBackColor = true;
            btnProductOpenDlg.Click += btnProductOpenDlg_Click;
            // 
            // btnMaterialsCustomDlg
            // 
            btnMaterialsCustomDlg.Location = new Point(23, 187);
            btnMaterialsCustomDlg.Name = "btnMaterialsCustomDlg";
            btnMaterialsCustomDlg.Size = new Size(143, 99);
            btnMaterialsCustomDlg.TabIndex = 2;
            btnMaterialsCustomDlg.Text = "Materials custom open";
            btnMaterialsCustomDlg.UseVisualStyleBackColor = true;
            btnMaterialsCustomDlg.Click += btnMaterialsCustomDlg_Click;
            // 
            // btnProductsCustomDlg
            // 
            btnProductsCustomDlg.Location = new Point(255, 187);
            btnProductsCustomDlg.Name = "btnProductsCustomDlg";
            btnProductsCustomDlg.Size = new Size(143, 99);
            btnProductsCustomDlg.TabIndex = 3;
            btnProductsCustomDlg.Text = "Products custom open";
            btnProductsCustomDlg.UseVisualStyleBackColor = true;
            btnProductsCustomDlg.Click += btnProductsCustomDlg_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 310);
            Controls.Add(btnProductsCustomDlg);
            Controls.Add(btnMaterialsCustomDlg);
            Controls.Add(btnProductOpenDlg);
            Controls.Add(btnMaterialsOpenDlg);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMaterialsOpenDlg;
        private Button btnProductOpenDlg;
        private Button btnMaterialsCustomDlg;
        private Button btnProductsCustomDlg;
    }
}
