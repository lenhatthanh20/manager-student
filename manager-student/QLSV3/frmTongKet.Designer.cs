namespace QLSV3
{
    partial class frmTongKet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongKet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChonNhom = new System.Windows.Forms.ComboBox();
            this.tTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(670, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 105.9645F;
            this.Column1.HeaderText = "Ho, tên lót";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 76.14214F;
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 105.9645F;
            this.Column3.HeaderText = "MSSV";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 105.9645F;
            this.Column4.HeaderText = "Nhóm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 105.9645F;
            this.Column5.HeaderText = "Điểm tổng kết";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn nhóm:";
            // 
            // cbChonNhom
            // 
            this.cbChonNhom.FormattingEnabled = true;
            this.cbChonNhom.Items.AddRange(new object[] {
            "Nhóm 1",
            "Nhóm 2",
            "Nhóm 3",
            "Nhóm 4",
            "Nhóm 5",
            "Nhóm 6",
            "Nhóm 7",
            "Nhóm 8",
            "Nhóm 9",
            "Nhóm 10",
            "Nhóm 11",
            "Nhóm 12",
            "Nhóm 13",
            "Nhóm 14",
            "Nhóm 15"});
            this.cbChonNhom.Location = new System.Drawing.Point(105, 21);
            this.cbChonNhom.Name = "cbChonNhom";
            this.cbChonNhom.Size = new System.Drawing.Size(73, 21);
            this.cbChonNhom.TabIndex = 4;
            this.cbChonNhom.SelectedIndexChanged += new System.EventHandler(this.cbChonNhom_SelectedIndexChanged);
            // 
            // tTimKiem
            // 
            this.tTimKiem.Location = new System.Drawing.Point(398, 21);
            this.tTimKiem.Multiline = true;
            this.tTimKiem.Name = "tTimKiem";
            this.tTimKiem.Size = new System.Drawing.Size(173, 30);
            this.tTimKiem.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tìm kiếm";
            // 
            // bTimKiem
            // 
            this.bTimKiem.Location = new System.Drawing.Point(577, 21);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(41, 30);
            this.bTimKiem.TabIndex = 30;
            this.bTimKiem.Text = "OK";
            this.bTimKiem.UseVisualStyleBackColor = true;
            this.bTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // frmTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 419);
            this.Controls.Add(this.bTimKiem);
            this.Controls.Add(this.tTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChonNhom);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTongKet";
            this.Text = "Chương trình quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmTongKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChonNhom;
        private System.Windows.Forms.TextBox tTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bTimKiem;
    }
}