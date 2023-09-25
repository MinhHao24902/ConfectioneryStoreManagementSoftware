namespace QLCuaHangBanhKeo
{
    partial class frmHangHoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dateNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.ColMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà SX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày SX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(128, 52);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(289, 37);
            this.txtTenHang.TabIndex = 6;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(128, 170);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(289, 37);
            this.txtNhaSX.TabIndex = 7;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(128, 110);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(289, 37);
            this.txtMaHang.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgayHH);
            this.groupBox1.Controls.Add(this.dateNgaySX);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtNhaSX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1289, 239);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng";
            // 
            // dateNgayHH
            // 
            this.dateNgayHH.CustomFormat = "yyyy-MM-dd";
            this.dateNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayHH.Location = new System.Drawing.Point(553, 170);
            this.dateNgayHH.Name = "dateNgayHH";
            this.dateNgayHH.Size = new System.Drawing.Size(288, 37);
            this.dateNgayHH.TabIndex = 21;
            // 
            // dateNgaySX
            // 
            this.dateNgaySX.CustomFormat = "yyyy-MM-dd";
            this.dateNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySX.Location = new System.Drawing.Point(553, 112);
            this.dateNgaySX.Name = "dateNgaySX";
            this.dateNgaySX.Size = new System.Drawing.Size(288, 37);
            this.dateNgaySX.TabIndex = 20;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(934, 114);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(314, 37);
            this.txtGia.TabIndex = 19;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(872, 118);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(56, 25);
            this.lblGia.TabIndex = 18;
            this.lblGia.Text = "Giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngày HH:";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(934, 170);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(314, 37);
            this.txtMota.TabIndex = 15;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(934, 56);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(314, 37);
            this.txtDVT.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(853, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mô tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(871, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "DVT:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(553, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(288, 37);
            this.txtSoLuong.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimMa);
            this.groupBox2.Controls.Add(this.txtTimTen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1342, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 239);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm hàng";
            // 
            // txtTimMa
            // 
            this.txtTimMa.Location = new System.Drawing.Point(162, 103);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(255, 37);
            this.txtTimMa.TabIndex = 17;
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(160, 52);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(255, 37);
            this.txtTimTen.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tìm theo mã:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tìm theo tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(703, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(465, 43);
            this.label11.TabIndex = 15;
            this.label11.Text = "Danh sách các mặt hàng";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaHang,
            this.ColTenHang,
            this.ColNhaSX,
            this.ColSoLuong,
            this.ColNgaySX,
            this.ColNgayHH,
            this.ColDVT,
            this.ColGia,
            this.ColMoTa});
            this.dgvMatHang.Location = new System.Drawing.Point(30, 466);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersWidth = 62;
            this.dgvMatHang.RowTemplate.Height = 28;
            this.dgvMatHang.Size = new System.Drawing.Size(1738, 328);
            this.dgvMatHang.TabIndex = 16;
            this.dgvMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellClick);
            // 
            // ColMaHang
            // 
            this.ColMaHang.DataPropertyName = "MaHang";
            this.ColMaHang.HeaderText = "Mã hàng";
            this.ColMaHang.MinimumWidth = 8;
            this.ColMaHang.Name = "ColMaHang";
            this.ColMaHang.Width = 120;
            // 
            // ColTenHang
            // 
            this.ColTenHang.DataPropertyName = "TenHang";
            this.ColTenHang.HeaderText = "Tên hàng";
            this.ColTenHang.MinimumWidth = 8;
            this.ColTenHang.Name = "ColTenHang";
            this.ColTenHang.Width = 180;
            // 
            // ColNhaSX
            // 
            this.ColNhaSX.DataPropertyName = "NhaSX";
            this.ColNhaSX.HeaderText = "Nhà sản xuất";
            this.ColNhaSX.MinimumWidth = 8;
            this.ColNhaSX.Name = "ColNhaSX";
            this.ColNhaSX.Width = 180;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.DataPropertyName = "SoLuong";
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.MinimumWidth = 8;
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.Width = 150;
            // 
            // ColNgaySX
            // 
            this.ColNgaySX.DataPropertyName = "NgaySX";
            this.ColNgaySX.HeaderText = "Ngày sản xuất";
            this.ColNgaySX.MinimumWidth = 8;
            this.ColNgaySX.Name = "ColNgaySX";
            this.ColNgaySX.Width = 170;
            // 
            // ColNgayHH
            // 
            this.ColNgayHH.DataPropertyName = "NgayHH";
            this.ColNgayHH.HeaderText = "Ngày hết hạn";
            this.ColNgayHH.MinimumWidth = 8;
            this.ColNgayHH.Name = "ColNgayHH";
            this.ColNgayHH.Width = 170;
            // 
            // ColDVT
            // 
            this.ColDVT.DataPropertyName = "DVT";
            this.ColDVT.HeaderText = "Đơn vị tính";
            this.ColDVT.MinimumWidth = 8;
            this.ColDVT.Name = "ColDVT";
            this.ColDVT.Width = 150;
            // 
            // ColGia
            // 
            this.ColGia.DataPropertyName = "Gia";
            this.ColGia.HeaderText = "Giá";
            this.ColGia.MinimumWidth = 8;
            this.ColGia.Name = "ColGia";
            this.ColGia.Width = 160;
            // 
            // ColMoTa
            // 
            this.ColMoTa.DataPropertyName = "MoTa";
            this.ColMoTa.HeaderText = "Mô tả";
            this.ColMoTa.MinimumWidth = 8;
            this.ColMoTa.Name = "ColMoTa";
            this.ColMoTa.Width = 250;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(30, 831);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 51);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(330, 831);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 51);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(653, 831);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 51);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnIn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.Location = new System.Drawing.Point(1257, 831);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(168, 51);
            this.btnIn.TabIndex = 22;
            this.btnIn.Text = "In danh sách";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(1600, 831);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(168, 51);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1794, 911);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng hoá";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoTa;
        private System.Windows.Forms.DateTimePicker dateNgayHH;
        private System.Windows.Forms.DateTimePicker dateNgaySX;
    }
}