namespace WindowsFormsApp1
{
    partial class PhanHe1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textRole = new System.Windows.Forms.Button();
            this.textDanhsach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textCrePassword = new System.Windows.Forms.TextBox();
            this.textCreUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textRolename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnTable = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 453);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTable);
            this.tabPage1.Controls.Add(this.textRole);
            this.tabPage1.Controls.Add(this.textDanhsach);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách người dùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(199, 28);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(152, 23);
            this.textRole.TabIndex = 2;
            this.textRole.Text = "Xem danh sách role";
            this.textRole.UseVisualStyleBackColor = true;
            this.textRole.Click += new System.EventHandler(this.textRole_Click);
            // 
            // textDanhsach
            // 
            this.textDanhsach.Location = new System.Drawing.Point(22, 28);
            this.textDanhsach.Name = "textDanhsach";
            this.textDanhsach.Size = new System.Drawing.Size(152, 23);
            this.textDanhsach.TabIndex = 1;
            this.textDanhsach.Text = "Xem danh sách user";
            this.textDanhsach.UseVisualStyleBackColor = true;
            this.textDanhsach.Click += new System.EventHandler(this.textDanhsach_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quyền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(785, 412);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(777, 383);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "User";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Collumn Privileges";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Table Privileges";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(774, 304);
            this.dataGridView2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "System Privileges";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(777, 383);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Role";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(203, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Table Privileges";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(774, 304);
            this.dataGridView3.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "System Privileges";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cài đặt User/Role";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(3, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(785, 412);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textCrePassword);
            this.tabPage6.Controls.Add(this.textCreUsername);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.button11);
            this.tabPage6.Controls.Add(this.button8);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.dataGridView4);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(777, 383);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "User";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textCrePassword
            // 
            this.textCrePassword.Location = new System.Drawing.Point(398, 79);
            this.textCrePassword.Name = "textCrePassword";
            this.textCrePassword.Size = new System.Drawing.Size(216, 22);
            this.textCrePassword.TabIndex = 12;
            this.textCrePassword.UseSystemPasswordChar = true;
            // 
            // textCreUsername
            // 
            this.textCreUsername.Location = new System.Drawing.Point(398, 32);
            this.textCreUsername.Name = "textCreUsername";
            this.textCreUsername.Size = new System.Drawing.Size(216, 22);
            this.textCreUsername.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "User name";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 31);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "Refresh";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(398, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 70);
            this.button8.TabIndex = 7;
            this.button8.Text = "Drop User";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Edit User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(633, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 70);
            this.button7.TabIndex = 5;
            this.button7.Text = "Create User";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 76);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(281, 304);
            this.dataGridView4.TabIndex = 4;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textRolename);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Controls.Add(this.button9);
            this.tabPage7.Controls.Add(this.button10);
            this.tabPage7.Controls.Add(this.button12);
            this.tabPage7.Controls.Add(this.button13);
            this.tabPage7.Controls.Add(this.dataGridView5);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(777, 383);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Role";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textRolename
            // 
            this.textRolename.Location = new System.Drawing.Point(392, 28);
            this.textRolename.Name = "textRolename";
            this.textRolename.Size = new System.Drawing.Size(216, 22);
            this.textRolename.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Role name";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(439, 289);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 70);
            this.button10.TabIndex = 12;
            this.button10.Text = "Drop Role";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(439, 173);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(138, 70);
            this.button12.TabIndex = 11;
            this.button12.Text = "Edit Role";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(439, 62);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(138, 70);
            this.button13.TabIndex = 10;
            this.button13.Text = "Create Role";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1, 62);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(291, 320);
            this.dataGridView5.TabIndex = 9;
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(382, 28);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(152, 23);
            this.btnTable.TabIndex = 3;
            this.btnTable.Text = "Xem danh sách table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // PhanHe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PhanHe1";
            this.Text = "Quản trị hệ thống";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button textDanhsach;
        private System.Windows.Forms.Button textRole;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textCrePassword;
        private System.Windows.Forms.TextBox textCreUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textRolename;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnTable;
    }
}

