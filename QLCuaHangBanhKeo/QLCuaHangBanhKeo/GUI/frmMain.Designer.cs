namespace QLCuaHangBanhKeo
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommodity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.mnuWeb});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut,
            this.mnuClose});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Image = global::QLCuaHangBanhKeo.Properties.Resources.LogOut;
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(219, 34);
            this.mnuLogOut.Text = "Đăng xuất";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Image = global::QLCuaHangBanhKeo.Properties.Resources.Close;
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(219, 34);
            this.mnuClose.Text = "Thoát";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCommodity,
            this.mnuEmployee,
            this.mnuGuest,
            this.mnuSupplier});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuCommodity
            // 
            this.mnuCommodity.Image = global::QLCuaHangBanhKeo.Properties.Resources.Food;
            this.mnuCommodity.Name = "mnuCommodity";
            this.mnuCommodity.Size = new System.Drawing.Size(253, 34);
            this.mnuCommodity.Text = "Hàng hoá";
            this.mnuCommodity.Click += new System.EventHandler(this.mnuCommodity_Click);
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Image = global::QLCuaHangBanhKeo.Properties.Resources.Employee;
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(253, 34);
            this.mnuEmployee.Text = "Nhân viên";
            this.mnuEmployee.Click += new System.EventHandler(this.mnuEmployee_Click);
            // 
            // mnuGuest
            // 
            this.mnuGuest.Image = global::QLCuaHangBanhKeo.Properties.Resources.Guest;
            this.mnuGuest.Name = "mnuGuest";
            this.mnuGuest.Size = new System.Drawing.Size(253, 34);
            this.mnuGuest.Text = "Khách hàng";
            this.mnuGuest.Click += new System.EventHandler(this.mnuGuest_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Image = global::QLCuaHangBanhKeo.Properties.Resources.Supplier;
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(253, 34);
            this.mnuSupplier.Text = "Nhà cung cấp";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // mnuImport
            // 
            this.mnuImport.Image = global::QLCuaHangBanhKeo.Properties.Resources.Import;
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(225, 34);
            this.mnuImport.Text = "Nhập hàng";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportIn,
            this.mnuInventory,
            this.mnuSales,
            this.mnuTopSales});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(109, 30);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuImportIn
            // 
            this.mnuImportIn.Image = global::QLCuaHangBanhKeo.Properties.Resources.ImportIn;
            this.mnuImportIn.Name = "mnuImportIn";
            this.mnuImportIn.Size = new System.Drawing.Size(268, 34);
            this.mnuImportIn.Text = "Hàng đã nhập";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Image = global::QLCuaHangBanhKeo.Properties.Resources.Inventory;
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(268, 34);
            this.mnuInventory.Text = "Hàng tồn kho";
            // 
            // mnuSales
            // 
            this.mnuSales.Image = global::QLCuaHangBanhKeo.Properties.Resources.Sales;
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Size = new System.Drawing.Size(268, 34);
            this.mnuSales.Text = "Doanh thu";
            // 
            // mnuTopSales
            // 
            this.mnuTopSales.Image = global::QLCuaHangBanhKeo.Properties.Resources.TopSales;
            this.mnuTopSales.Name = "mnuTopSales";
            this.mnuTopSales.Size = new System.Drawing.Size(268, 34);
            this.mnuTopSales.Text = "Hàng bán chạy";
            // 
            // mnuWeb
            // 
            this.mnuWeb.Name = "mnuWeb";
            this.mnuWeb.Size = new System.Drawing.Size(136, 30);
            this.mnuWeb.Text = "Trang web";
            this.mnuWeb.Click += new System.EventHandler(this.mnuWeb_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangBanhKeo.Properties.Resources.BG2;
            this.ClientSize = new System.Drawing.Size(1078, 769);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng bánh kẹo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCommodity;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuGuest;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImportIn;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem mnuTopSales;
        private System.Windows.Forms.ToolStripMenuItem mnuWeb;
    }
}

