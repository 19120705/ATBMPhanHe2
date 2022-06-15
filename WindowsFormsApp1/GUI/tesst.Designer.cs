namespace WindowsFormsApp1.GUI
{
    partial class tesst
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
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.clickTableNhanVien = new System.Windows.Forms.Button();
            this.clickKhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(12, 229);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.RowHeadersWidth = 51;
            this.dataGridViewTest.RowTemplate.Height = 24;
            this.dataGridViewTest.Size = new System.Drawing.Size(1336, 251);
            this.dataGridViewTest.TabIndex = 0;
            // 
            // clickTableNhanVien
            // 
            this.clickTableNhanVien.Location = new System.Drawing.Point(71, 72);
            this.clickTableNhanVien.Name = "clickTableNhanVien";
            this.clickTableNhanVien.Size = new System.Drawing.Size(107, 23);
            this.clickTableNhanVien.TabIndex = 1;
            this.clickTableNhanVien.Text = "Nhan Vien";
            this.clickTableNhanVien.UseVisualStyleBackColor = true;
            this.clickTableNhanVien.Click += new System.EventHandler(this.clickTableNhanVien_Click);
            // 
            // clickKhachHang
            // 
            this.clickKhachHang.Location = new System.Drawing.Point(243, 72);
            this.clickKhachHang.Name = "clickKhachHang";
            this.clickKhachHang.Size = new System.Drawing.Size(107, 23);
            this.clickKhachHang.TabIndex = 2;
            this.clickKhachHang.Text = "Khach Hang";
            this.clickKhachHang.UseVisualStyleBackColor = true;
            this.clickKhachHang.Click += new System.EventHandler(this.clickKhachHang_Click);
            // 
            // tesst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 520);
            this.Controls.Add(this.clickKhachHang);
            this.Controls.Add(this.clickTableNhanVien);
            this.Controls.Add(this.dataGridViewTest);
            this.Name = "tesst";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Button clickTableNhanVien;
        private System.Windows.Forms.Button clickKhachHang;
    }
}