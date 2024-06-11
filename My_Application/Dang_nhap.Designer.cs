namespace My_Application
{
    partial class Dang_nhap
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
            this.lb_Taikhoan = new System.Windows.Forms.Label();
            this.txt_Taikhoan = new System.Windows.Forms.TextBox();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.btn_Doimatkhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Taikhoan
            // 
            this.lb_Taikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Taikhoan.AutoSize = true;
            this.lb_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Taikhoan.Location = new System.Drawing.Point(85, 66);
            this.lb_Taikhoan.Name = "lb_Taikhoan";
            this.lb_Taikhoan.Size = new System.Drawing.Size(81, 20);
            this.lb_Taikhoan.TabIndex = 0;
            this.lb_Taikhoan.Text = "Tài khoản";
            // 
            // txt_Taikhoan
            // 
            this.txt_Taikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Taikhoan.Location = new System.Drawing.Point(202, 63);
            this.txt_Taikhoan.Name = "txt_Taikhoan";
            this.txt_Taikhoan.ReadOnly = true;
            this.txt_Taikhoan.Size = new System.Drawing.Size(223, 26);
            this.txt_Taikhoan.TabIndex = 0;
            this.txt_Taikhoan.TabStop = false;
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matkhau.Location = new System.Drawing.Point(202, 131);
            this.txt_Matkhau.MaxLength = 100;
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.PasswordChar = '*';
            this.txt_Matkhau.Size = new System.Drawing.Size(223, 26);
            this.txt_Matkhau.TabIndex = 1;
            this.txt_Matkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Matkhau_KeyPress);
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhau.Location = new System.Drawing.Point(85, 134);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(77, 20);
            this.lb_Matkhau.TabIndex = 2;
            this.lb_Matkhau.Text = "Mật khẩu";
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangnhap.Location = new System.Drawing.Point(398, 211);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(127, 31);
            this.btn_Dangnhap.TabIndex = 2;
            this.btn_Dangnhap.Text = "Đăng nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // btn_Doimatkhau
            // 
            this.btn_Doimatkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Doimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doimatkhau.Location = new System.Drawing.Point(226, 211);
            this.btn_Doimatkhau.Name = "btn_Doimatkhau";
            this.btn_Doimatkhau.Size = new System.Drawing.Size(151, 31);
            this.btn_Doimatkhau.TabIndex = 6;
            this.btn_Doimatkhau.Text = "Đổi mật khẩu";
            this.btn_Doimatkhau.UseVisualStyleBackColor = true;
            this.btn_Doimatkhau.Click += new System.EventHandler(this.btn_Doimatkhau_Click);
            // 
            // Dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 254);
            this.Controls.Add(this.btn_Doimatkhau);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.txt_Taikhoan);
            this.Controls.Add(this.lb_Taikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dang_nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Dang_nhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Taikhoan;
        private System.Windows.Forms.TextBox txt_Taikhoan;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.Button btn_Doimatkhau;
    }
}