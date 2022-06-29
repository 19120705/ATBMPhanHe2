namespace WindowsFormsApp1.GUI
{
    partial class YBacSi
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridHSBA_DV = new System.Windows.Forms.DataGridView();
            this.dataGridHSBA = new System.Windows.Forms.DataGridView();
            this.refHSBA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hồ sơ bệnh án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dịch vụ có trong hồ sơ bệnh án";
            // 
            // dataGridHSBA_DV
            // 
            this.dataGridHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA_DV.Location = new System.Drawing.Point(12, 264);
            this.dataGridHSBA_DV.Name = "dataGridHSBA_DV";
            this.dataGridHSBA_DV.RowHeadersWidth = 51;
            this.dataGridHSBA_DV.RowTemplate.Height = 24;
            this.dataGridHSBA_DV.Size = new System.Drawing.Size(567, 150);
            this.dataGridHSBA_DV.TabIndex = 9;
            // 
            // dataGridHSBA
            // 
            this.dataGridHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA.Location = new System.Drawing.Point(12, 58);
            this.dataGridHSBA.Name = "dataGridHSBA";
            this.dataGridHSBA.RowHeadersWidth = 51;
            this.dataGridHSBA.RowTemplate.Height = 24;
            this.dataGridHSBA.Size = new System.Drawing.Size(567, 169);
            this.dataGridHSBA.TabIndex = 8;
            // 
            // refHSBA
            // 
            this.refHSBA.Location = new System.Drawing.Point(504, 22);
            this.refHSBA.Name = "refHSBA";
            this.refHSBA.Size = new System.Drawing.Size(75, 23);
            this.refHSBA.TabIndex = 12;
            this.refHSBA.Text = "Refresh";
            this.refHSBA.UseVisualStyleBackColor = true;
            this.refHSBA.Click += new System.EventHandler(this.refHSBA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thông tin bênh nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập mã bệnh nhân hoặc cmnd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // YBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.refHSBA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHSBA_DV);
            this.Controls.Add(this.dataGridHSBA);
            this.Name = "YBacSi";
            this.Text = "YBacSi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridHSBA_DV;
        private System.Windows.Forms.DataGridView dataGridHSBA;
        private System.Windows.Forms.Button refHSBA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}