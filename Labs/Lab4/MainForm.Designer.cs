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
            btnMaterialsOpenDlg.Location = new Point(95, 82);
            btnMaterialsOpenDlg.Name = "btnMaterialsOpenDlg";
            btnMaterialsOpenDlg.Size = new Size(143, 101);
            btnMaterialsOpenDlg.TabIndex = 0;
            btnMaterialsOpenDlg.Text = "Materials open dialog";
            btnMaterialsOpenDlg.UseVisualStyleBackColor = true;
            btnMaterialsOpenDlg.Click += btnMaterialsOpenDlg_Click;
            // 
            // btnProductOpenDlg
            // 
            btnProductOpenDlg.Location = new Point(353, 82);
            btnProductOpenDlg.Name = "btnProductOpenDlg";
            btnProductOpenDlg.Size = new Size(143, 101);
            btnProductOpenDlg.TabIndex = 1;
            btnProductOpenDlg.Text = "Products open dialog";
            btnProductOpenDlg.UseVisualStyleBackColor = true;
            btnProductOpenDlg.Click += btnProductOpenDlg_Click;
            // 
            // btnMaterialsCustomDlg
            // 
            btnMaterialsCustomDlg.Location = new Point(95, 244);
            btnMaterialsCustomDlg.Name = "btnMaterialsCustomDlg";
            btnMaterialsCustomDlg.Size = new Size(143, 99);
            btnMaterialsCustomDlg.TabIndex = 2;
            btnMaterialsCustomDlg.Text = "Materials custom open";
            btnMaterialsCustomDlg.UseVisualStyleBackColor = true;
            // 
            // btnProductsCustomDlg
            // 
            btnProductsCustomDlg.Location = new Point(353, 244);
            btnProductsCustomDlg.Name = "btnProductsCustomDlg";
            btnProductsCustomDlg.Size = new Size(143, 99);
            btnProductsCustomDlg.TabIndex = 3;
            btnProductsCustomDlg.Text = "Products custom open";
            btnProductsCustomDlg.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 421);
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
