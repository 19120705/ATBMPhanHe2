namespace WindowsFormsApp1.GUI
{
    partial class NghienCuu
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
            this.refHSBA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridHSBA_DV = new System.Windows.Forms.DataGridView();
            this.dataGridHSBA = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // refHSBA
            // 
            this.refHSBA.Location = new System.Drawing.Point(659, 65);
            this.refHSBA.Name = "refHSBA";
            this.refHSBA.Size = new System.Drawing.Size(75, 23);
            this.refHSBA.TabIndex = 21;
            this.refHSBA.Text = "Refresh";
            this.refHSBA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hồ sơ bệnh án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dịch vụ có trong hồ sơ bệnh án";
            // 
            // dataGridHSBA_DV
            // 
            this.dataGridHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA_DV.Location = new System.Drawing.Point(14, 271);
            this.dataGridHSBA_DV.Name = "dataGridHSBA_DV";
            this.dataGridHSBA_DV.RowHeadersWidth = 51;
            this.dataGridHSBA_DV.RowTemplate.Height = 24;
            this.dataGridHSBA_DV.Size = new System.Drawing.Size(607, 150);
            this.dataGridHSBA_DV.TabIndex = 18;
            // 
            // dataGridHSBA
            // 
            this.dataGridHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHSBA.Location = new System.Drawing.Point(14, 65);
            this.dataGridHSBA.Name = "dataGridHSBA";
            this.dataGridHSBA.RowHeadersWidth = 51;
            this.dataGridHSBA.RowTemplate.Height = 24;
            this.dataGridHSBA.Size = new System.Drawing.Size(607, 169);
            this.dataGridHSBA.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refHSBA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHSBA_DV);
            this.Controls.Add(this.dataGridHSBA);
            this.Name = "NghienCuu";
            this.Text = "NghienCuu";
            this.Load += new System.EventHandler(this.NghienCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA_DV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refHSBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridHSBA_DV;
        private System.Windows.Forms.DataGridView dataGridHSBA;
        private System.Windows.Forms.Button button1;
    }
}