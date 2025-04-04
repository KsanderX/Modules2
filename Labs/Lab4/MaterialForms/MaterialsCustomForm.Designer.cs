namespace Lab4
{
    partial class MaterialsCustomForm
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
            btnSave = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(-1, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(499, 386);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(423, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MaterialsCustomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 479);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSave);
            Name = "MaterialsCustomForm";
            Text = "MaterialsCustomForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBack;
    }
}