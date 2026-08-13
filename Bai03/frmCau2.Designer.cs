namespace Bai03
{
    partial class frmCau2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNguyenDuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdbTinhTong = new System.Windows.Forms.RadioButton();
            this.btXemKetqua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập 1 số nguyên dương N";
            // 
            // txtSoNguyenDuong
            // 
            this.txtSoNguyenDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguyenDuong.Location = new System.Drawing.Point(383, 17);
            this.txtSoNguyenDuong.Name = "txtSoNguyenDuong";
            this.txtSoNguyenDuong.Size = new System.Drawing.Size(169, 30);
            this.txtSoNguyenDuong.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTinhGiaiThua);
            this.groupBox1.Controls.Add(this.rdbTinhTong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(257, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdbTinhGiaiThua
            // 
            this.rdbTinhGiaiThua.AutoSize = true;
            this.rdbTinhGiaiThua.Location = new System.Drawing.Point(14, 69);
            this.rdbTinhGiaiThua.Name = "rdbTinhGiaiThua";
            this.rdbTinhGiaiThua.Size = new System.Drawing.Size(212, 29);
            this.rdbTinhGiaiThua.TabIndex = 1;
            this.rdbTinhGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdbTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdbTinhTong
            // 
            this.rdbTinhTong.AutoSize = true;
            this.rdbTinhTong.Checked = true;
            this.rdbTinhTong.Location = new System.Drawing.Point(14, 34);
            this.rdbTinhTong.Name = "rdbTinhTong";
            this.rdbTinhTong.Size = new System.Drawing.Size(199, 29);
            this.rdbTinhTong.TabIndex = 0;
            this.rdbTinhTong.Text = "Tính tổng 1+2...+N";
            this.rdbTinhTong.UseVisualStyleBackColor = true;
            // 
            // btXemKetqua
            // 
            this.btXemKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemKetqua.Location = new System.Drawing.Point(307, 215);
            this.btXemKetqua.Name = "btXemKetqua";
            this.btXemKetqua.Size = new System.Drawing.Size(163, 43);
            this.btXemKetqua.TabIndex = 6;
            this.btXemKetqua.Text = "Xem kết quả";
            this.btXemKetqua.UseVisualStyleBackColor = true;
            this.btXemKetqua.Click += new System.EventHandler(this.btXemKetqua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(419, 275);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(26, 29);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "0";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // frmCau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXemKetqua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoNguyenDuong);
            this.Controls.Add(this.label1);
            this.Name = "frmCau2";
            this.Text = "frmCau2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNguyenDuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTinhGiaiThua;
        private System.Windows.Forms.RadioButton rdbTinhTong;
        private System.Windows.Forms.Button btXemKetqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}