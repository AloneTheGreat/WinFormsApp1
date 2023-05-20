namespace library_MS
{
    partial class EditBookForm
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Edit Book ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 43);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(371, 386);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 34;
            button1.Text = "SaveChanges";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 358);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 33;
            label5.Text = "NCopies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 291);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 32;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 226);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 31;
            label3.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 148);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 30;
            label6.Text = "Book Publisher";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 81);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 29;
            label7.Text = "Book Name ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(191, 350);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(191, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 23);
            comboBox1.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 24;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}