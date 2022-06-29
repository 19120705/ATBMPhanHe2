namespace WindowsFormsApp1.GUI.CSYT
{
    partial class themHSBA_DV
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
            this.textMAKTV = new System.Windows.Forms.TextBox();
            this.textMADV = new System.Windows.Forms.TextBox();
            this.textHSBA = new System.Windows.Forms.TextBox();
            this.ngayHSBA_DV = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.richTextBox_KetQua = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMAKTV
            // 
            this.textMAKTV.Location = new System.Drawing.Point(192, 117);
            this.textMAKTV.Name = "textMAKTV";
            this.textMAKTV.Size = new System.Drawing.Size(238, 22);
            this.textMAKTV.TabIndex = 19;
            // 
            // textMADV
            // 
            this.textMADV.Location = new System.Drawing.Point(160, 76);
            this.textMADV.Name = "textMADV";
            this.textMADV.Size = new System.Drawing.Size(270, 22);
            this.textMADV.TabIndex = 18;
            // 
            // textHSBA
            // 
            this.textHSBA.Location = new System.Drawing.Point(160, 39);
            this.textHSBA.Name = "textHSBA";
            this.textHSBA.Size = new System.Drawing.Size(270, 22);
            this.textHSBA.TabIndex = 17;
            // 
            // ngayHSBA_DV
            // 
            this.ngayHSBA_DV.Location = new System.Drawing.Point(535, 39);
            this.ngayHSBA_DV.Name = "ngayHSBA_DV";
            this.ngayHSBA_DV.Size = new System.Drawing.Size(200, 22);
            this.ngayHSBA_DV.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã người thực hiện dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã hồ sơ bệnh án";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(631, 300);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 23;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(483, 300);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 22;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // richTextBox_KetQua
            // 
            this.richTextBox_KetQua.Location = new System.Drawing.Point(160, 187);
            this.richTextBox_KetQua.Name = "richTextBox_KetQua";
            this.richTextBox_KetQua.Size = new System.Drawing.Size(575, 96);
            this.richTextBox_KetQua.TabIndex = 21;
            this.richTextBox_KetQua.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kết quả";
            // 
            // themHSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.richTextBox_KetQua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMAKTV);
            this.Controls.Add(this.textMADV);
            this.Controls.Add(this.textHSBA);
            this.Controls.Add(this.ngayHSBA_DV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "themHSBA_DV";
            this.Text = "themHSBA_DV";
            this.Load += new System.EventHandler(this.themHSBA_DV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMAKTV;
        private System.Windows.Forms.TextBox textMADV;
        private System.Windows.Forms.TextBox textHSBA;
        private System.Windows.Forms.DateTimePicker ngayHSBA_DV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.RichTextBox richTextBox_KetQua;
        private System.Windows.Forms.Label label8;
    }
}