namespace WinFormsApp1
{
    partial class UsersForm
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
            grdUser = new DataGridView();
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnAddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)grdUser).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grdUser
            // 
            grdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUser.Dock = DockStyle.Fill;
            grdUser.Location = new Point(0, 47);
            grdUser.Name = "grdUser";
            grdUser.RowTemplate.Height = 25;
            grdUser.Size = new Size(800, 337);
            grdUser.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(370, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(331, 23);
            txtSearch.TabIndex = 2;
            txtSearch.Tag = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddUser);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 66);
            panel2.TabIndex = 4;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 8);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 51);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grdUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Users";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)grdUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView grdUser;
        private Panel panel1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel2;
        private Button btnAddUser;
    }
}