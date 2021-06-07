using System.ComponentModel;

namespace LibraryApp
{
    partial class UsersListRow
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
            this.UserAccess = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.UserAccess, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserName.Location = new System.Drawing.Point(68, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(450, 40);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Name";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserAccess
            // 
            this.UserAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAccess.Location = new System.Drawing.Point(524, 0);
            this.UserAccess.Name = "UserAccess";
            this.UserAccess.Size = new System.Drawing.Size(59, 40);
            this.UserAccess.TabIndex = 2;
            this.UserAccess.Text = "Access Level";
            this.UserAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserId
            // 
            this.UserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserId.Location = new System.Drawing.Point(3, 0);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(59, 40);
            this.UserId.TabIndex = 1;
            this.UserId.Text = "ID";
            this.UserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsersListRow";
            this.Text = "UsersListRow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UserAccess;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label UserName;

        #endregion
    }
}