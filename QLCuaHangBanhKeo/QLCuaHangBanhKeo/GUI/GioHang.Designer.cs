namespace QLCuaHangBanhKeo.GUI
{
    partial class GioHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnXoaDaChon = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(407, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIỎ HÀNG CỦA BẠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGioHang);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.groupBox1.Location = new System.Drawing.Point(48, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm hiện có";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaHang,
            this.ColMaTaiKhoan,
            this.ColTenHang,
            this.ColSoLuong,
            this.ColTongTien});
            this.dgvGioHang.Location = new System.Drawing.Point(16, 36);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 62;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.Size = new System.Drawing.Size(1057, 369);
            this.dgvGioHang.TabIndex = 0;
            this.dgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellClick);
            // 
            // btnXoaDaChon
            // 
            this.btnXoaDaChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnXoaDaChon.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDaChon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaDaChon.Location = new System.Drawing.Point(48, 537);
            this.btnXoaDaChon.Name = "btnXoaDaChon";
            this.btnXoaDaChon.Size = new System.Drawing.Size(216, 59);
            this.btnXoaDaChon.TabIndex = 6;
            this.btnXoaDaChon.Text = "Xoá sản phẩm đã chọn";
            this.btnXoaDaChon.UseVisualStyleBackColor = false;
            this.btnXoaDaChon.Click += new System.EventHandler(this.btnXoaDaChon_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnXoaTB.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaTB.Location = new System.Drawing.Point(270, 537);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(216, 59);
            this.btnXoaTB.TabIndex = 7;
            this.btnXoaTB.Text = "Xoá toàn bộ sản phẩm";
            this.btnXoaTB.UseVisualStyleBackColor = false;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(561, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng cộng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.txtTongTien.Location = new System.Drawing.Point(732, 547);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(407, 35);
            this.txtTongTien.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(1031, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 44);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ColSTT
            // 
            this.ColSTT.DataPropertyName = "STT";
            this.ColSTT.HeaderText = "ID";
            this.ColSTT.MinimumWidth = 8;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.Width = 80;
            // 
            // ColMaHang
            // 
            this.ColMaHang.DataPropertyName = "MaHang";
            this.ColMaHang.HeaderText = "Mã sản phẩm";
            this.ColMaHang.MinimumWidth = 8;
            this.ColMaHang.Name = "ColMaHang";
            this.ColMaHang.Width = 140;
            // 
            // ColMaTaiKhoan
            // 
            this.ColMaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.ColMaTaiKhoan.HeaderText = "Mã tài khoản";
            this.ColMaTaiKhoan.MinimumWidth = 8;
            this.ColMaTaiKhoan.Name = "ColMaTaiKhoan";
            this.ColMaTaiKhoan.Width = 150;
            // 
            // ColTenHang
            // 
            this.ColTenHang.DataPropertyName = "TenHang";
            this.ColTenHang.HeaderText = "Tên sản phẩm";
            this.ColTenHang.MinimumWidth = 8;
            this.ColTenHang.Name = "ColTenHang";
            this.ColTenHang.Width = 170;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.DataPropertyName = "SOLUONG";
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.MinimumWidth = 8;
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.Width = 110;
            // 
            // ColTongTien
            // 
            this.ColTongTien.DataPropertyName = "TongTien";
            this.ColTongTien.HeaderText = "Giá";
            this.ColTongTien.MinimumWidth = 8;
            this.ColTongTien.Name = "ColTongTien";
            this.ColTongTien.Width = 200;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.btnXoaDaChon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GioHang";
            this.Size = new System.Drawing.Size(1190, 640);
            this.Load += new System.EventHandler(this.GioHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaDaChon;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongTien;
    }
}
