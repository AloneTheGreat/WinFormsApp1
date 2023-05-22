namespace WinFormsApp1
{
    partial class DeleteBookForm
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
            nudCopies = new NumericUpDown();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCopies).BeginInit();
            SuspendLayout();
            // 
            // nudCopies
            // 
            nudCopies.Location = new Point(325, 150);
            nudCopies.Name = "nudCopies";
            nudCopies.Size = new Size(157, 23);
            nudCopies.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 121);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Copies to Delete:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(325, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // DeleteBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(nudCopies);
            Name = "DeleteBookForm";
            Text = "Delete Book";
            ((System.ComponentModel.ISupportInitialize)nudCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCopies;
        private Label label1;
        private Button btnDelete;
    }
}