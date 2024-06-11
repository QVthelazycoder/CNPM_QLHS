namespace My_Application
{
    partial class Danh_sach_khoi_lop
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tailai = new System.Windows.Forms.Button();
            this.dtg_Khoilop = new System.Windows.Forms.DataGridView();
            this.lb_Tim = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.lb_Sisotoida = new System.Windows.Forms.Label();
            this.btn_Thaydoi = new System.Windows.Forms.Button();
            this.nud_Sisotoida = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Khoilop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sisotoida)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(60, 544);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(212, 68);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(738, 544);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(212, 68);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Tailai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tailai.Location = new System.Drawing.Point(401, 544);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(212, 68);
            this.btn_Tailai.TabIndex = 22;
            this.btn_Tailai.Text = "Tải Lại";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            this.btn_Tailai.Click += new System.EventHandler(this.btn_Tailai_Click);
            // 
            // dtg_Khoilop
            // 
            this.dtg_Khoilop.AllowUserToAddRows = false;
            this.dtg_Khoilop.AllowUserToDeleteRows = false;
            this.dtg_Khoilop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Khoilop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Khoilop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Khoilop.Location = new System.Drawing.Point(-2, 101);
            this.dtg_Khoilop.Name = "dtg_Khoilop";
            this.dtg_Khoilop.ReadOnly = true;
            this.dtg_Khoilop.RowHeadersWidth = 51;
            this.dtg_Khoilop.RowTemplate.Height = 24;
            this.dtg_Khoilop.Size = new System.Drawing.Size(1007, 422);
            this.dtg_Khoilop.TabIndex = 19;
            this.dtg_Khoilop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Ds_Lop_CellDoubleClick);
            // 
            // lb_Tim
            // 
            this.lb_Tim.AutoSize = true;
            this.lb_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tim.Location = new System.Drawing.Point(99, 41);
            this.lb_Tim.Name = "lb_Tim";
            this.lb_Tim.Size = new System.Drawing.Size(103, 20);
            this.lb_Tim.TabIndex = 18;
            this.lb_Tim.Text = "Tìm khối, lớp";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(216, 38);
            this.txt_Tim.MaxLength = 5;
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(115, 27);
            this.txt_Tim.TabIndex = 16;
            this.txt_Tim.TextChanged += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(353, 38);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(43, 28);
            this.btn_Tim.TabIndex = 17;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // lb_Sisotoida
            // 
            this.lb_Sisotoida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sisotoida.AutoSize = true;
            this.lb_Sisotoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sisotoida.Location = new System.Drawing.Point(603, 42);
            this.lb_Sisotoida.Name = "lb_Sisotoida";
            this.lb_Sisotoida.Size = new System.Drawing.Size(93, 20);
            this.lb_Sisotoida.TabIndex = 25;
            this.lb_Sisotoida.Text = "Sĩ số tối đa";
            // 
            // btn_Thaydoi
            // 
            this.btn_Thaydoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thaydoi.AutoSize = true;
            this.btn_Thaydoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Thaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thaydoi.Location = new System.Drawing.Point(818, 38);
            this.btn_Thaydoi.Name = "btn_Thaydoi";
            this.btn_Thaydoi.Size = new System.Drawing.Size(74, 28);
            this.btn_Thaydoi.TabIndex = 24;
            this.btn_Thaydoi.Text = "Thay đổi";
            this.btn_Thaydoi.UseVisualStyleBackColor = true;
            this.btn_Thaydoi.Click += new System.EventHandler(this.btn_Thaydoi_Click);
            // 
            // nud_Sisotoida
            // 
            this.nud_Sisotoida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Sisotoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Sisotoida.Location = new System.Drawing.Point(717, 40);
            this.nud_Sisotoida.Name = "nud_Sisotoida";
            this.nud_Sisotoida.Size = new System.Drawing.Size(83, 24);
            this.nud_Sisotoida.TabIndex = 26;
            // 
            // Danh_sach_khoi_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 624);
            this.Controls.Add(this.nud_Sisotoida);
            this.Controls.Add(this.lb_Sisotoida);
            this.Controls.Add(this.btn_Thaydoi);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Tailai);
            this.Controls.Add(this.dtg_Khoilop);
            this.Controls.Add(this.lb_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Tim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Danh_sach_khoi_lop";
            this.Text = "Danh Sách Khối Lớp";
            this.Load += new System.EventHandler(this.Danh_sach_khoi_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Khoilop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Sisotoida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tailai;
        private System.Windows.Forms.DataGridView dtg_Khoilop;
        private System.Windows.Forms.Label lb_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label lb_Sisotoida;
        private System.Windows.Forms.Button btn_Thaydoi;
        private System.Windows.Forms.NumericUpDown nud_Sisotoida;
    }
}