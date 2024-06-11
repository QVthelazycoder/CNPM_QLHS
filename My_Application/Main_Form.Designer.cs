namespace My_Application
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Taikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BGH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Gvu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Gvi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Chucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tiepnhanhocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Xeplop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Bangdiemmon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BaocaoMon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BaocaoHocky = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ThaydoiQuydinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Danhsachmonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tuoiquydinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Danhsachkhoilop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Diemdat = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Trangthaidangnhap = new System.Windows.Forms.Label();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Taikhoan,
            this.tsmi_Chucnang});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1375, 28);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // tsmi_Taikhoan
            // 
            this.tsmi_Taikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Admin,
            this.tsmi_BGH,
            this.tsmi_Gvu,
            this.tsmi_Gvi,
            this.tsmi_Dangxuat});
            this.tsmi_Taikhoan.Name = "tsmi_Taikhoan";
            this.tsmi_Taikhoan.Size = new System.Drawing.Size(85, 24);
            this.tsmi_Taikhoan.Text = "Tài khoản";
            // 
            // tsmi_Admin
            // 
            this.tsmi_Admin.Name = "tsmi_Admin";
            this.tsmi_Admin.Size = new System.Drawing.Size(224, 26);
            this.tsmi_Admin.Text = "Admin";
            this.tsmi_Admin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tsmi_BGH
            // 
            this.tsmi_BGH.Name = "tsmi_BGH";
            this.tsmi_BGH.Size = new System.Drawing.Size(224, 26);
            this.tsmi_BGH.Text = "Ban Giám Hiệu";
            this.tsmi_BGH.Click += new System.EventHandler(this.banGiámGiệuToolStripMenuItem_Click);
            // 
            // tsmi_Gvu
            // 
            this.tsmi_Gvu.Name = "tsmi_Gvu";
            this.tsmi_Gvu.Size = new System.Drawing.Size(224, 26);
            this.tsmi_Gvu.Text = "Giáo vụ";
            this.tsmi_Gvu.Click += new System.EventHandler(this.giáoVụToolStripMenuItem_Click);
            // 
            // tsmi_Gvi
            // 
            this.tsmi_Gvi.Name = "tsmi_Gvi";
            this.tsmi_Gvi.Size = new System.Drawing.Size(224, 26);
            this.tsmi_Gvi.Text = "Giáo viên";
            this.tsmi_Gvi.Click += new System.EventHandler(this.giáoViênToolStripMenuItem_Click);
            // 
            // tsmi_Dangxuat
            // 
            this.tsmi_Dangxuat.Name = "tsmi_Dangxuat";
            this.tsmi_Dangxuat.Size = new System.Drawing.Size(224, 26);
            this.tsmi_Dangxuat.Text = "Đăng xuất";
            this.tsmi_Dangxuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tsmi_Chucnang
            // 
            this.tsmi_Chucnang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Tiepnhanhocsinh,
            this.tsmi_Xeplop,
            this.tsmi_Tracuu,
            this.tsmi_Bangdiemmon,
            this.tsmi_Baocao,
            this.tsmi_ThaydoiQuydinh});
            this.tsmi_Chucnang.Name = "tsmi_Chucnang";
            this.tsmi_Chucnang.Size = new System.Drawing.Size(93, 24);
            this.tsmi_Chucnang.Text = "Chức năng";
            // 
            // tsmi_Tiepnhanhocsinh
            // 
            this.tsmi_Tiepnhanhocsinh.Name = "tsmi_Tiepnhanhocsinh";
            this.tsmi_Tiepnhanhocsinh.Size = new System.Drawing.Size(237, 26);
            this.tsmi_Tiepnhanhocsinh.Text = "Tiếp nhận học sinh";
            this.tsmi_Tiepnhanhocsinh.Click += new System.EventHandler(this.tsmi_Hosohocsinh_Click);
            // 
            // tsmi_Xeplop
            // 
            this.tsmi_Xeplop.Name = "tsmi_Xeplop";
            this.tsmi_Xeplop.Size = new System.Drawing.Size(237, 26);
            this.tsmi_Xeplop.Text = "Xếp lớp";
            this.tsmi_Xeplop.Click += new System.EventHandler(this.tsmi_Xeplop_Click);
            // 
            // tsmi_Tracuu
            // 
            this.tsmi_Tracuu.Name = "tsmi_Tracuu";
            this.tsmi_Tracuu.Size = new System.Drawing.Size(237, 26);
            this.tsmi_Tracuu.Text = "Tra cứu học sinh";
            this.tsmi_Tracuu.Click += new System.EventHandler(this.tsmi_Tracuu_Click);
            // 
            // tsmi_Bangdiemmon
            // 
            this.tsmi_Bangdiemmon.Name = "tsmi_Bangdiemmon";
            this.tsmi_Bangdiemmon.Size = new System.Drawing.Size(237, 26);
            this.tsmi_Bangdiemmon.Text = "Nhận bảng điểm môn";
            this.tsmi_Bangdiemmon.Click += new System.EventHandler(this.tsmi_Bangdiemmon_Click);
            // 
            // tsmi_Baocao
            // 
            this.tsmi_Baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_BaocaoMon,
            this.tsmi_BaocaoHocky});
            this.tsmi_Baocao.Name = "tsmi_Baocao";
            this.tsmi_Baocao.Size = new System.Drawing.Size(237, 26);
            this.tsmi_Baocao.Text = "Báo cáo tổng kết";
            // 
            // tsmi_BaocaoMon
            // 
            this.tsmi_BaocaoMon.Name = "tsmi_BaocaoMon";
            this.tsmi_BaocaoMon.Size = new System.Drawing.Size(137, 26);
            this.tsmi_BaocaoMon.Text = "Môn";
            this.tsmi_BaocaoMon.Click += new System.EventHandler(this.tsmi_BaocaoMon_Click);
            // 
            // tsmi_BaocaoHocky
            // 
            this.tsmi_BaocaoHocky.Name = "tsmi_BaocaoHocky";
            this.tsmi_BaocaoHocky.Size = new System.Drawing.Size(137, 26);
            this.tsmi_BaocaoHocky.Text = "Học kỳ";
            this.tsmi_BaocaoHocky.Click += new System.EventHandler(this.tsmi_BaocaoHocky_Click);
            // 
            // tsmi_ThaydoiQuydinh
            // 
            this.tsmi_ThaydoiQuydinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Danhsachmonhoc,
            this.tsmi_Tuoiquydinh,
            this.tsmi_Danhsachkhoilop,
            this.tsmi_Diemdat});
            this.tsmi_ThaydoiQuydinh.Name = "tsmi_ThaydoiQuydinh";
            this.tsmi_ThaydoiQuydinh.Size = new System.Drawing.Size(237, 26);
            this.tsmi_ThaydoiQuydinh.Text = "Thay đổi quy định";
            // 
            // tsmi_Danhsachmonhoc
            // 
            this.tsmi_Danhsachmonhoc.Name = "tsmi_Danhsachmonhoc";
            this.tsmi_Danhsachmonhoc.Size = new System.Drawing.Size(247, 26);
            this.tsmi_Danhsachmonhoc.Text = "Danh sách môn học";
            this.tsmi_Danhsachmonhoc.Click += new System.EventHandler(this.tsmi_Danhsachmonhoc_Click);
            // 
            // tsmi_Tuoiquydinh
            // 
            this.tsmi_Tuoiquydinh.Name = "tsmi_Tuoiquydinh";
            this.tsmi_Tuoiquydinh.Size = new System.Drawing.Size(247, 26);
            this.tsmi_Tuoiquydinh.Text = "Tuổi quy định";
            this.tsmi_Tuoiquydinh.Click += new System.EventHandler(this.tsmi_Tuoiquydinh_Click);
            // 
            // tsmi_Danhsachkhoilop
            // 
            this.tsmi_Danhsachkhoilop.Name = "tsmi_Danhsachkhoilop";
            this.tsmi_Danhsachkhoilop.Size = new System.Drawing.Size(247, 26);
            this.tsmi_Danhsachkhoilop.Text = "Danh sách khối lớp ";
            this.tsmi_Danhsachkhoilop.Click += new System.EventHandler(this.tsmi_Danhsachcaclop_Click);
            // 
            // tsmi_Diemdat
            // 
            this.tsmi_Diemdat.Name = "tsmi_Diemdat";
            this.tsmi_Diemdat.Size = new System.Drawing.Size(247, 26);
            this.tsmi_Diemdat.Text = "Điểm đạt (môn, học kỳ)";
            this.tsmi_Diemdat.Click += new System.EventHandler(this.tsmi_Diemdat_Click);
            // 
            // lb_Trangthaidangnhap
            // 
            this.lb_Trangthaidangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Trangthaidangnhap.AutoSize = true;
            this.lb_Trangthaidangnhap.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Trangthaidangnhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Trangthaidangnhap.Location = new System.Drawing.Point(12, 689);
            this.lb_Trangthaidangnhap.Name = "lb_Trangthaidangnhap";
            this.lb_Trangthaidangnhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Trangthaidangnhap.Size = new System.Drawing.Size(118, 20);
            this.lb_Trangthaidangnhap.TabIndex = 8;
            this.lb_Trangthaidangnhap.Text = "Chưa đăng nhập";
            // 
            // panel_Content
            // 
            this.panel_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Content.AutoSize = true;
            this.panel_Content.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Content.BackgroundImage")));
            this.panel_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Content.Location = new System.Drawing.Point(0, 29);
            this.panel_Content.MinimumSize = new System.Drawing.Size(1375, 500);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1375, 657);
            this.panel_Content.TabIndex = 7;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1375, 715);
            this.Controls.Add(this.lb_Trangthaidangnhap);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Chucnang;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Taikhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BGH;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Gvu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Gvi;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tiepnhanhocsinh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Xeplop;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tracuu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Baocao;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BaocaoMon;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BaocaoHocky;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Bangdiemmon;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ThaydoiQuydinh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Danhsachmonhoc;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tuoiquydinh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Danhsachkhoilop;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Diemdat;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Dangxuat;
        private System.Windows.Forms.Label lb_Trangthaidangnhap;
        private System.Windows.Forms.Panel panel_Content;
    }
}

