namespace My_Application
{
    partial class Danh_sach_mon_hoc
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
            this.dtg_Monhoc = new System.Windows.Forms.DataGridView();
            this.lb_Timmon = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tailai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Monhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Monhoc
            // 
            this.dtg_Monhoc.AllowUserToAddRows = false;
            this.dtg_Monhoc.AllowUserToDeleteRows = false;
            this.dtg_Monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Monhoc.Location = new System.Drawing.Point(-2, 92);
            this.dtg_Monhoc.Name = "dtg_Monhoc";
            this.dtg_Monhoc.ReadOnly = true;
            this.dtg_Monhoc.RowHeadersWidth = 51;
            this.dtg_Monhoc.RowTemplate.Height = 24;
            this.dtg_Monhoc.Size = new System.Drawing.Size(1007, 433);
            this.dtg_Monhoc.TabIndex = 13;
            this.dtg_Monhoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Monhoc_CellDoubleClick);
            // 
            // lb_Timmon
            // 
            this.lb_Timmon.AutoSize = true;
            this.lb_Timmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Timmon.Location = new System.Drawing.Point(176, 33);
            this.lb_Timmon.Name = "lb_Timmon";
            this.lb_Timmon.Size = new System.Drawing.Size(74, 20);
            this.lb_Timmon.TabIndex = 15;
            this.lb_Timmon.Text = "Tìm môn";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(278, 30);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(462, 27);
            this.txt_Tim.TabIndex = 9;
            this.txt_Tim.TextChanged += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(770, 30);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(43, 28);
            this.btn_Tim.TabIndex = 10;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(44, 543);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(212, 68);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(744, 543);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(212, 68);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Tailai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tailai.Location = new System.Drawing.Point(396, 543);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(212, 68);
            this.btn_Tailai.TabIndex = 14;
            this.btn_Tailai.Text = "Tải Lại";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            this.btn_Tailai.Click += new System.EventHandler(this.btn_Tailai_Click);
            // 
            // Danh_sach_mon_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 624);
            this.Controls.Add(this.dtg_Monhoc);
            this.Controls.Add(this.lb_Timmon);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Tailai);
            this.Name = "Danh_sach_mon_hoc";
            this.Text = "Danh Sách Môn Học";
            this.Load += new System.EventHandler(this.Danh_sach_mon_hoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Monhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Monhoc;
        private System.Windows.Forms.Label lb_Timmon;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tailai;
    }
}