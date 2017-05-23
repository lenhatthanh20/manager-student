namespace QLSV3
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tMatKhau = new System.Windows.Forms.TextBox();
            this.tTaiKhoan = new System.Windows.Forms.TextBox();
            this.bDangNhap = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản:";
            // 
            // tMatKhau
            // 
            this.tMatKhau.Location = new System.Drawing.Point(121, 129);
            this.tMatKhau.Name = "tMatKhau";
            this.tMatKhau.Size = new System.Drawing.Size(167, 20);
            this.tMatKhau.TabIndex = 3;
            this.tMatKhau.UseSystemPasswordChar = true;
            // 
            // tTaiKhoan
            // 
            this.tTaiKhoan.Location = new System.Drawing.Point(121, 88);
            this.tTaiKhoan.Name = "tTaiKhoan";
            this.tTaiKhoan.Size = new System.Drawing.Size(167, 20);
            this.tTaiKhoan.TabIndex = 1;
            // 
            // bDangNhap
            // 
            this.bDangNhap.Location = new System.Drawing.Point(49, 194);
            this.bDangNhap.Name = "bDangNhap";
            this.bDangNhap.Size = new System.Drawing.Size(89, 33);
            this.bDangNhap.TabIndex = 5;
            this.bDangNhap.Text = "Đăng nhập";
            this.bDangNhap.UseVisualStyleBackColor = true;
            this.bDangNhap.Click += new System.EventHandler(this.bDangNhap_Click);
            // 
            // bThoat
            // 
            this.bThoat.Location = new System.Drawing.Point(198, 194);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(90, 33);
            this.bThoat.TabIndex = 6;
            this.bThoat.Text = "Thoat";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.bDangNhap);
            this.Controls.Add(this.tTaiKhoan);
            this.Controls.Add(this.tMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.Text = "Chương trình quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tMatKhau;
        private System.Windows.Forms.TextBox tTaiKhoan;
        private System.Windows.Forms.Button bDangNhap;
        private System.Windows.Forms.Button bThoat;
    }
}

