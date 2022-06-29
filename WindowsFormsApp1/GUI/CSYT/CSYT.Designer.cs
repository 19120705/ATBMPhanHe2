namespace WindowsFormsApp1.GUI.CSYT
{
    partial class CSYT
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
            this.dataGridHSBA = new System.Windows.Forms.DataGridView();
            this.dataGridHSBA_DV = new System.Windows.Forms.DataGridView();
            this.themHSBA = new System.Windows.Forms.Button();
            this.xoaHSBA = new System.Windows.Forms.Button();
            this.themHSBA_DV = new System.Windows.Forms.Button();
            this.xoaHSBA_DV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refHSBA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHSBA
            // 
            this.dataGridHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA.Location = new System.Drawing.Point(3, 62);
            this.dataGridHSBA.Name = "dataGridHSBA";
            this.dataGridHSBA.RowHeadersWidth = 51;
            this.dataGridHSBA.RowTemplate.Height = 24;
            this.dataGridHSBA.Size = new System.Drawing.Size(567, 169);
            this.dataGridHSBA.TabIndex = 0;
            this.dataGridHSBA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHSBA_CellContentClick);
            // 
            // dataGridHSBA_DV
            // 
            this.dataGridHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA_DV.Location = new System.Drawing.Point(3, 268);
            this.dataGridHSBA_DV.Name = "dataGridHSBA_DV";
            this.dataGridHSBA_DV.RowHeadersWidth = 51;
            this.dataGridHSBA_DV.RowTemplate.Height = 24;
            this.dataGridHSBA_DV.Size = new System.Drawing.Size(567, 150);
            this.dataGridHSBA_DV.TabIndex = 1;
            // 
            // themHSBA
            // 
            this.themHSBA.Location = new System.Drawing.Point(614, 129);
            this.themHSBA.Name = "themHSBA";
            this.themHSBA.Size = new System.Drawing.Size(75, 23);
            this.themHSBA.TabIndex = 2;
            this.themHSBA.Text = "Thêm";
            this.themHSBA.UseVisualStyleBackColor = true;
            this.themHSBA.Click += new System.EventHandler(this.themHSBA_Click);
            // 
            // xoaHSBA
            // 
            this.xoaHSBA.Location = new System.Drawing.Point(614, 195);
            this.xoaHSBA.Name = "xoaHSBA";
            this.xoaHSBA.Size = new System.Drawing.Size(75, 23);
            this.xoaHSBA.TabIndex = 3;
            this.xoaHSBA.Text = "Xóa";
            this.xoaHSBA.UseVisualStyleBackColor = true;
            this.xoaHSBA.Click += new System.EventHandler(this.xoaHSBA_Click);
            // 
            // themHSBA_DV
            // 
            this.themHSBA_DV.Location = new System.Drawing.Point(614, 295);
            this.themHSBA_DV.Name = "themHSBA_DV";
            this.themHSBA_DV.Size = new System.Drawing.Size(75, 23);
            this.themHSBA_DV.TabIndex = 4;
            this.themHSBA_DV.Text = "Thêm";
            this.themHSBA_DV.UseVisualStyleBackColor = true;
            this.themHSBA_DV.Click += new System.EventHandler(this.themHSBA_DV_Click);
            // 
            // xoaHSBA_DV
            // 
            this.xoaHSBA_DV.Location = new System.Drawing.Point(614, 358);
            this.xoaHSBA_DV.Name = "xoaHSBA_DV";
            this.xoaHSBA_DV.Size = new System.Drawing.Size(75, 23);
            this.xoaHSBA_DV.TabIndex = 5;
            this.xoaHSBA_DV.Text = "Xóa";
            this.xoaHSBA_DV.UseVisualStyleBackColor = true;
            this.xoaHSBA_DV.Click += new System.EventHandler(this.xoaHSBA_DV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dịch vụ có trong hồ sơ bệnh án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hồ sơ bệnh án";
            // 
            // refHSBA
            // 
            this.refHSBA.Location = new System.Drawing.Point(614, 72);
            this.refHSBA.Name = "refHSBA";
            this.refHSBA.Size = new System.Drawing.Size(75, 23);
            this.refHSBA.TabIndex = 8;
            this.refHSBA.Text = "Refresh";
            this.refHSBA.UseVisualStyleBackColor = true;
            this.refHSBA.Click += new System.EventHandler(this.refHSBA_Click);
            // 
            // CSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refHSBA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoaHSBA_DV);
            this.Controls.Add(this.themHSBA_DV);
            this.Controls.Add(this.xoaHSBA);
            this.Controls.Add(this.themHSBA);
            this.Controls.Add(this.dataGridHSBA_DV);
            this.Controls.Add(this.dataGridHSBA);
            this.Name = "CSYT";
            this.Text = "CSYT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHSBA;
        private System.Windows.Forms.DataGridView dataGridHSBA_DV;
        private System.Windows.Forms.Button themHSBA;
        private System.Windows.Forms.Button xoaHSBA;
        private System.Windows.Forms.Button themHSBA_DV;
        private System.Windows.Forms.Button xoaHSBA_DV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refHSBA;
    }
}