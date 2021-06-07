using System.ComponentModel;

namespace LibraryApp
{
    partial class ReaderMenu
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
            this.ViewBooksBtn = new System.Windows.Forms.Button();
            this.ViewTakenBooksBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ViewBooksBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewTakenBooksBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SignOutBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(150);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ViewBooksBtn
            // 
            this.ViewBooksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBooksBtn.Location = new System.Drawing.Point(153, 153);
            this.ViewBooksBtn.Name = "ViewBooksBtn";
            this.ViewBooksBtn.Size = new System.Drawing.Size(258, 29);
            this.ViewBooksBtn.TabIndex = 0;
            this.ViewBooksBtn.Text = "View all books";
            this.ViewBooksBtn.UseVisualStyleBackColor = true;
            // 
            // ViewTakenBooksBtn
            // 
            this.ViewTakenBooksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTakenBooksBtn.Location = new System.Drawing.Point(153, 188);
            this.ViewTakenBooksBtn.Name = "ViewTakenBooksBtn";
            this.ViewTakenBooksBtn.Size = new System.Drawing.Size(258, 29);
            this.ViewTakenBooksBtn.TabIndex = 1;
            this.ViewTakenBooksBtn.Text = "View taken books";
            this.ViewTakenBooksBtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignOutBtn.Location = new System.Drawing.Point(153, 258);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(258, 30);
            this.SignOutBtn.TabIndex = 2;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            // 
            // ReaderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "ReaderMenu";
            this.Text = "ReaderMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewBooksBtn;
        private System.Windows.Forms.Button ViewTakenBooksBtn;

        #endregion
    }
}