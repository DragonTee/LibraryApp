using System.ComponentModel;

namespace LibraryApp
{
    partial class HeadManagerMenu
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
            this.ViewDepartmentsBtn = new System.Windows.Forms.Button();
            this.ViewHeadsBtn = new System.Windows.Forms.Button();
            this.AddDepartmentBtn = new System.Windows.Forms.Button();
            this.AddHeadBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ViewDepartmentsBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewHeadsBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddDepartmentBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddHeadBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SignOutBtn, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(150, 100, 150, 100);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ViewDepartmentsBtn
            // 
            this.ViewDepartmentsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDepartmentsBtn.Location = new System.Drawing.Point(153, 103);
            this.ViewDepartmentsBtn.Name = "ViewDepartmentsBtn";
            this.ViewDepartmentsBtn.Size = new System.Drawing.Size(258, 34);
            this.ViewDepartmentsBtn.TabIndex = 0;
            this.ViewDepartmentsBtn.Text = "View all departments";
            this.ViewDepartmentsBtn.UseVisualStyleBackColor = true;
            // 
            // ViewHeadsBtn
            // 
            this.ViewHeadsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewHeadsBtn.Location = new System.Drawing.Point(153, 143);
            this.ViewHeadsBtn.Name = "ViewHeadsBtn";
            this.ViewHeadsBtn.Size = new System.Drawing.Size(258, 34);
            this.ViewHeadsBtn.TabIndex = 1;
            this.ViewHeadsBtn.Text = "View all department heads";
            this.ViewHeadsBtn.UseVisualStyleBackColor = true;
            // 
            // AddDepartmentBtn
            // 
            this.AddDepartmentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDepartmentBtn.Location = new System.Drawing.Point(153, 183);
            this.AddDepartmentBtn.Name = "AddDepartmentBtn";
            this.AddDepartmentBtn.Size = new System.Drawing.Size(258, 34);
            this.AddDepartmentBtn.TabIndex = 2;
            this.AddDepartmentBtn.Text = "Add department";
            this.AddDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // AddHeadBtn
            // 
            this.AddHeadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeadBtn.Location = new System.Drawing.Point(153, 223);
            this.AddHeadBtn.Name = "AddHeadBtn";
            this.AddHeadBtn.Size = new System.Drawing.Size(258, 34);
            this.AddHeadBtn.TabIndex = 3;
            this.AddHeadBtn.Text = "Add department head";
            this.AddHeadBtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignOutBtn.Location = new System.Drawing.Point(153, 303);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(258, 35);
            this.SignOutBtn.TabIndex = 4;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            // 
            // HeadManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "HeadManagerMenu";
            this.Text = "HeadManagerMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddDepartmentBtn;
        private System.Windows.Forms.Button AddHeadBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewDepartmentsBtn;
        private System.Windows.Forms.Button ViewHeadsBtn;

        #endregion
    }
}