using System.ComponentModel;

namespace LibraryApp
{
    partial class LibrariansListRow
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserName.Location = new System.Drawing.Point(83, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(554, 40);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Name";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserId
            // 
            this.UserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserId.Location = new System.Drawing.Point(3, 0);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(74, 40);
            this.UserId.TabIndex = 1;
            this.UserId.Text = "ID";
            this.UserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.RemoveBtn, 2);
            this.RemoveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveBtn.Location = new System.Drawing.Point(643, 3);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(154, 34);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // LibrariansListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LibrariansListRow";
            this.Text = "LibrariansListRow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label UserName;

        #endregion
    }
}