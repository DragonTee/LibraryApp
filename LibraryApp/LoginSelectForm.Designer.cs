namespace LibraryApp
{
    partial class LoginSelectForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginReaderBtn = new System.Windows.Forms.Button();
            this.LoginLibrarianBtn = new System.Windows.Forms.Button();
            this.LoginDepartmentHeadBtn = new System.Windows.Forms.Button();
            this.LoginHeadManagerBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LoginReaderBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoginLibrarianBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginDepartmentHeadBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginHeadManagerBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(150);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LoginReaderBtn
            // 
            this.LoginReaderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginReaderBtn.Location = new System.Drawing.Point(153, 153);
            this.LoginReaderBtn.Name = "LoginReaderBtn";
            this.LoginReaderBtn.Size = new System.Drawing.Size(258, 29);
            this.LoginReaderBtn.TabIndex = 0;
            this.LoginReaderBtn.Text = "Login as Reader";
            this.LoginReaderBtn.UseVisualStyleBackColor = true;
            // 
            // LoginLibrarianBtn
            // 
            this.LoginLibrarianBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLibrarianBtn.Location = new System.Drawing.Point(153, 188);
            this.LoginLibrarianBtn.Name = "LoginLibrarianBtn";
            this.LoginLibrarianBtn.Size = new System.Drawing.Size(258, 29);
            this.LoginLibrarianBtn.TabIndex = 1;
            this.LoginLibrarianBtn.Text = "Login as Librarian";
            this.LoginLibrarianBtn.UseVisualStyleBackColor = true;
            // 
            // LoginDepartmentHeadBtn
            // 
            this.LoginDepartmentHeadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginDepartmentHeadBtn.Location = new System.Drawing.Point(153, 223);
            this.LoginDepartmentHeadBtn.Name = "LoginDepartmentHeadBtn";
            this.LoginDepartmentHeadBtn.Size = new System.Drawing.Size(258, 29);
            this.LoginDepartmentHeadBtn.TabIndex = 2;
            this.LoginDepartmentHeadBtn.Text = "Login as Department Head";
            this.LoginDepartmentHeadBtn.UseVisualStyleBackColor = true;
            // 
            // LoginHeadManagerBtn
            // 
            this.LoginHeadManagerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginHeadManagerBtn.Location = new System.Drawing.Point(153, 258);
            this.LoginHeadManagerBtn.Name = "LoginHeadManagerBtn";
            this.LoginHeadManagerBtn.Size = new System.Drawing.Size(258, 30);
            this.LoginHeadManagerBtn.TabIndex = 3;
            this.LoginHeadManagerBtn.Text = "Login as Head Manager";
            this.LoginHeadManagerBtn.UseVisualStyleBackColor = true;
            // 
            // LoginSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "LoginSelectForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button LoginDepartmentHeadBtn;
        private System.Windows.Forms.Button LoginHeadManagerBtn;
        private System.Windows.Forms.Button LoginLibrarianBtn;
        private System.Windows.Forms.Button LoginReaderBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}