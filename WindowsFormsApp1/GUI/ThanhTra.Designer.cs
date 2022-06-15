namespace WindowsFormsApp1.GUI
{
    partial class ThanhTra
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.btnCSYT = new System.Windows.Forms.Button();
            this.btnHSBA = new System.Windows.Forms.Button();
            this.btnHSBA_DV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 340);
            this.dataGridView.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(46, 50);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(88, 23);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Location = new System.Drawing.Point(171, 50);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(106, 23);
            this.btnBenhNhan.TabIndex = 2;
            this.btnBenhNhan.Text = "Bệnh Nhân";
            this.btnBenhNhan.UseVisualStyleBackColor = true;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // btnCSYT
            // 
            this.btnCSYT.Location = new System.Drawing.Point(328, 50);
            this.btnCSYT.Name = "btnCSYT";
            this.btnCSYT.Size = new System.Drawing.Size(75, 23);
            this.btnCSYT.TabIndex = 3;
            this.btnCSYT.Text = "CSYT";
            this.btnCSYT.UseVisualStyleBackColor = true;
            this.btnCSYT.Click += new System.EventHandler(this.btnCSYT_Click);
            // 
            // btnHSBA
            // 
            this.btnHSBA.Location = new System.Drawing.Point(450, 50);
            this.btnHSBA.Name = "btnHSBA";
            this.btnHSBA.Size = new System.Drawing.Size(75, 23);
            this.btnHSBA.TabIndex = 4;
            this.btnHSBA.Text = "HSBA";
            this.btnHSBA.UseVisualStyleBackColor = true;
            this.btnHSBA.Click += new System.EventHandler(this.btnHSBA_Click);
            // 
            // btnHSBA_DV
            // 
            this.btnHSBA_DV.Location = new System.Drawing.Point(581, 50);
            this.btnHSBA_DV.Name = "btnHSBA_DV";
            this.btnHSBA_DV.Size = new System.Drawing.Size(107, 23);
            this.btnHSBA_DV.TabIndex = 5;
            this.btnHSBA_DV.Text = "HSBA_DV";
            this.btnHSBA_DV.UseVisualStyleBackColor = true;
            this.btnHSBA_DV.Click += new System.EventHandler(this.btnHSBA_DV_Click);
            // 
            // ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHSBA_DV);
            this.Controls.Add(this.btnHSBA);
            this.Controls.Add(this.btnCSYT);
            this.Controls.Add(this.btnBenhNhan);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.dataGridView);
            this.Name = "ThanhTra";
            this.Text = "Thanh Tra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Button btnCSYT;
        private System.Windows.Forms.Button btnHSBA;
        private System.Windows.Forms.Button btnHSBA_DV;
    }
}