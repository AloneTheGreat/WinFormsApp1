namespace WinFormsApp1
{
    partial class BooksForm
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            grdBooks = new DataGridView();
            book_details = new DataGridViewButtonColumn();
            panel1 = new Panel();
            categories = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnAddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grdBooks
            // 
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Columns.AddRange(new DataGridViewColumn[] { book_details });
            grdBooks.Dock = DockStyle.Fill;
            grdBooks.Location = new Point(0, 57);
            grdBooks.Name = "grdBooks";
            grdBooks.RowTemplate.Height = 25;
            grdBooks.Size = new Size(800, 331);
            grdBooks.TabIndex = 4;
            grdBooks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // book_details
            // 
            book_details.HeaderText = "book_details";
            book_details.Name = "book_details";
            book_details.Text = "details";
            // 
            // panel1
            // 
            panel1.Controls.Add(categories);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 5;
            // 
            // categories
            // 
            categories.FormattingEnabled = true;
            categories.Location = new Point(28, 18);
            categories.Name = "categories";
            categories.Size = new Size(192, 23);
            categories.TabIndex = 6;
            categories.Text = "Categories";
            categories.SelectedIndexChanged += categories_SelectedIndexChanged;
            // 
            // button2
            // 
            btnSearch.Location = new Point(639, 11);
            btnSearch.Name = "button2";
            btnSearch.Size = new Size(134, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button2_Click;
            // 
            // textBox1
            // 
            txtSearch.Location = new Point(236, 18);
            txtSearch.Name = "textBox1";
            txtSearch.Size = new Size(384, 23);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "searchText";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddBook);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 62);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            btnAddBook.Location = new Point(28, 8);
            btnAddBook.Name = "button1";
            btnAddBook.Size = new Size(136, 45);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add new book ";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grdBooks);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksForm";
            Text = "Books";
            WindowState = FormWindowState.Maximized;
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView grdBooks;
        private DataGridViewButtonColumn book_details;
        private Panel panel1;
        private ComboBox categories;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel2;
        private Button btnAddBook;
    }
}