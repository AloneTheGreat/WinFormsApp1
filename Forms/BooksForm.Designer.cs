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
            panel1 = new Panel();
            btnAddBook = new Button();
            categories = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grdBooks
            // 
            grdBooks.BackgroundColor = Color.DimGray;
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Dock = DockStyle.Fill;
            grdBooks.Location = new Point(0, 57);
            grdBooks.Name = "grdBooks";
            grdBooks.RowTemplate.Height = 25;
            grdBooks.Size = new Size(800, 393);
            grdBooks.TabIndex = 4;
            grdBooks.RowHeaderMouseDoubleClick += GrdBooks_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnAddBook);
            panel1.Controls.Add(categories);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBook.BackColor = Color.RoyalBlue;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(699, 12);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(89, 33);
            btnAddBook.TabIndex = 7;
            btnAddBook.Text = "Add book ";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += BtnAddBook_Click;
            // 
            // categories
            // 
            categories.BackColor = Color.LightGray;
            categories.FormattingEnabled = true;
            categories.Location = new Point(28, 18);
            categories.Name = "categories";
            categories.Size = new Size(192, 23);
            categories.TabIndex = 6;
            categories.Text = "Categories";
            categories.SelectedIndexChanged += categories_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.LightGray;
            txtSearch.Location = new Point(236, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(203, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grdBooks);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksForm";
            Text = "Books";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView grdBooks;
        private Panel panel1;
        private ComboBox categories;
        private TextBox txtSearch;
        private Button btnAddBook;
    }
}