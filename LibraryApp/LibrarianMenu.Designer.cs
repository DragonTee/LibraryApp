using System.ComponentModel;

namespace LibraryApp
{
    partial class LibrarianMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.ViewBooksBtn = new System.Windows.Forms.Button();
            this.ViewUsersBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AddBookBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ViewBooksBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewUsersBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddUserBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SignOutBtn, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(150, 125, 150, 125);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBookBtn.Location = new System.Drawing.Point(153, 221);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(258, 25);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Add new book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            // 
            // ViewBooksBtn
            // 
            this.ViewBooksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBooksBtn.Location = new System.Drawing.Point(153, 128);
            this.ViewBooksBtn.Name = "ViewBooksBtn";
            this.ViewBooksBtn.Size = new System.Drawing.Size(258, 25);
            this.ViewBooksBtn.TabIndex = 0;
            this.ViewBooksBtn.Text = "View all books";
            this.ViewBooksBtn.UseVisualStyleBackColor = true;
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewUsersBtn.Location = new System.Drawing.Point(153, 159);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(258, 25);
            this.ViewUsersBtn.TabIndex = 1;
            this.ViewUsersBtn.Text = "View all users";
            this.ViewUsersBtn.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserBtn.Location = new System.Drawing.Point(153, 190);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(258, 25);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "Add new user";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignOutBtn.Location = new System.Drawing.Point(153, 283);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(258, 30);
            this.SignOutBtn.TabIndex = 3;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            // 
            // LibrarianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "LibrarianMenu";
            this.Text = "LibrarianMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewBooksBtn;
        private System.Windows.Forms.Button ViewUsersBtn;

        #endregion
    }
}