namespace WinFormsApp1
{
    partial class UserDetailForm
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
            grdBorrowed = new DataGridView();
            btnReturn = new DataGridViewButtonColumn();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdBorrowed).BeginInit();
            SuspendLayout();
            // 
            // grdBorrowed
            // 
            grdBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBorrowed.Columns.AddRange(new DataGridViewColumn[] { btnReturn });
            grdBorrowed.Location = new Point(12, 223);
            grdBorrowed.Name = "grdBorrowed";
            grdBorrowed.RowTemplate.Height = 25;
            grdBorrowed.Size = new Size(776, 215);
            grdBorrowed.TabIndex = 0;
            grdBorrowed.CellContentClick += grdBorrowed_CellContentClick;
            // 
            // btnReturn
            // 
            btnReturn.HeaderText = "";
            btnReturn.Name = "btnReturn";
            btnReturn.Text = "Return";
            btnReturn.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "User Detils";
            // 
            // button1
            // 
            button1.Location = new Point(227, 124);
            button1.Name = "button1";
            button1.Size = new Size(249, 72);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 3;
            // 
            // UserDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(grdBorrowed);
            Name = "UserDetailForm";
            Text = "UserDetail";
            ((System.ComponentModel.ISupportInitialize)grdBorrowed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView grdBorrowed;

        #endregion

        private DataGridViewButtonColumn btnReturn;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
    }
}