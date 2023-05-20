namespace library_MS
{
    partial class AllBookdetailsForm
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
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            button2 = new Button();
            categories = new ComboBox();
            dataGridView1 = new DataGridView();
            book_details = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 402);
            button1.Name = "button1";
            button1.Size = new Size(136, 45);
            button1.TabIndex = 0;
            button1.Text = "Add new book ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "searchText";
            // 
            // button2
            // 
            button2.Location = new Point(633, 12);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 2;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            // 
            // categories
            // 
            categories.FormattingEnabled = true;
            categories.Location = new Point(22, 19);
            categories.Name = "categories";
            categories.Size = new Size(192, 23);
            categories.TabIndex = 3;
            categories.Text = "categiruous";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { book_details });
            dataGridView1.Location = new Point(22, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 333);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // book_details
            // 
            book_details.HeaderText = "book_details";
            book_details.Name = "book_details";
            book_details.Text = "details";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(categories);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private BindingSource bindingSource1;
        private TextBox textBox1;
        private Button button2;
        private ComboBox categories;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn book_details;
    }
}