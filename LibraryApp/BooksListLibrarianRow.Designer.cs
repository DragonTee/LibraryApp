using System.ComponentModel;

namespace LibraryApp
{
    partial class BooksListLibrarianRow
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
            this.BookTaken = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.WriteOffBtn = new System.Windows.Forms.Button();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.BookTaken, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.WriteOffBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookAuthor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BookTaken
            // 
            this.BookTaken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookTaken.Location = new System.Drawing.Point(341, 0);
            this.BookTaken.Name = "BookTaken";
            this.BookTaken.Size = new System.Drawing.Size(50, 40);
            this.BookTaken.TabIndex = 9;
            this.BookTaken.Text = "Taken";
            this.BookTaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderBtn.Location = new System.Drawing.Point(453, 3);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(50, 34);
            this.OrderBtn.TabIndex = 8;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnBtn.Location = new System.Drawing.Point(509, 3);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(52, 34);
            this.ReturnBtn.TabIndex = 7;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // WriteOffBtn
            // 
            this.WriteOffBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteOffBtn.Location = new System.Drawing.Point(397, 3);
            this.WriteOffBtn.Name = "WriteOffBtn";
            this.WriteOffBtn.Size = new System.Drawing.Size(50, 34);
            this.WriteOffBtn.TabIndex = 6;
            this.WriteOffBtn.Text = "Write -\r\n Off\r\n";
            this.WriteOffBtn.UseVisualStyleBackColor = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookAuthor.Location = new System.Drawing.Point(172, 0);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(163, 40);
            this.BookAuthor.TabIndex = 3;
            this.BookAuthor.Text = "Author";
            this.BookAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookName
            // 
            this.BookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookName.Location = new System.Drawing.Point(3, 0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(163, 40);
            this.BookName.TabIndex = 2;
            this.BookName.Text = "Book name";
            this.BookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksListLibrarianRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BooksListLibrarianRow";
            this.Text = "BooksListLibrarianRow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label BookTaken;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button WriteOffBtn;

        #endregion
    }
}