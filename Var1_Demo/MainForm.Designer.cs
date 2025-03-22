namespace Var1_Demo
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
            btnAddBook = new Button();
            btnEditBook = new Button();
            btnDeleteBook = new Button();
            txtSearch = new TextBox();
            cmdSearchField = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(686, 39);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(102, 23);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Добавить";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(686, 87);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(102, 23);
            btnEditBook.TabIndex = 1;
            btnEditBook.Text = "Редактировать";
            btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(686, 132);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(102, 23);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "Удалить";
            btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(0, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 0;
            // 
            // cmdSearchField
            // 
            cmdSearchField.FormattingEnabled = true;
            cmdSearchField.Location = new Point(0, 71);
            cmdSearchField.Name = "cmdSearchField";
            cmdSearchField.Size = new Size(121, 23);
            cmdSearchField.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(668, 338);
            dataGridView1.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmdSearchField);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnEditBook);
            Controls.Add(btnAddBook);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private TextBox txtSearch;
        private ComboBox cmdSearchField;
        private DataGridView dataGridView1;
    }
}
