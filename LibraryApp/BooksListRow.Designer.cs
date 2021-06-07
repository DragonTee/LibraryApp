using System.ComponentModel;

namespace LibraryApp
{
    partial class BooksListRow
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
            this.BookAuthor = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BookAuthor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookAuthor.Location = new System.Drawing.Point(323, 0);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(314, 40);
            this.BookAuthor.TabIndex = 1;
            this.BookAuthor.Text = "Author";
            this.BookAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookName
            // 
            this.BookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookName.Location = new System.Drawing.Point(3, 0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(314, 40);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "Book";
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BooksListRow";
            this.Text = "BooksListRow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}