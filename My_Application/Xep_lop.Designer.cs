namespace My_Application
{
    partial class Xep_lop
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
            this.lb_Timlop = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.dtg_DsLop = new System.Windows.Forms.DataGridView();
            this.btn_Xeplop = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tailai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Timlop
            // 
            this.lb_Timlop.AutoSize = true;
            this.lb_Timlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Timlop.Location = new System.Drawing.Point(173, 41);
            this.lb_Timlop.Name = "lb_Timlop";
            this.lb_Timlop.Size = new System.Drawing.Size(64, 20);
            this.lb_Timlop.TabIndex = 11;
            this.lb_Timlop.Text = "Tìm lớp";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(274, 38);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(465, 27);
            this.txt_Tim.TabIndex = 9;
            this.txt_Tim.TextChanged += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(769, 38);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(43, 28);
            this.btn_Tim.TabIndex = 10;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // dtg_DsLop
            // 
            this.dtg_DsLop.AllowUserToAddRows = false;
            this.dtg_DsLop.AllowUserToDeleteRows = false;
            this.dtg_DsLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_DsLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DsLop.Location = new System.Drawing.Point(-3, 101);
            this.dtg_DsLop.Name = "dtg_DsLop";
            this.dtg_DsLop.ReadOnly = true;
            this.dtg_DsLop.RowHeadersWidth = 51;
            this.dtg_DsLop.RowTemplate.Height = 24;
            this.dtg_DsLop.Size = new System.Drawing.Size(1007, 422);
            this.dtg_DsLop.TabIndex = 12;
            // 
            // btn_Xeplop
            // 
            this.btn_Xeplop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Xeplop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xeplop.Location = new System.Drawing.Point(59, 544);
            this.btn_Xeplop.Name = "btn_Xeplop";
            this.btn_Xeplop.Size = new System.Drawing.Size(212, 68);
            this.btn_Xeplop.TabIndex = 13;
            this.btn_Xeplop.Text = "Xếp Lớp";
            this.btn_Xeplop.UseVisualStyleBackColor = true;
            this.btn_Xeplop.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(737, 544);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(212, 68);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tailai
            // 
            this.btn_Tailai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Tailai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tailai.Location = new System.Drawing.Point(400, 544);
            this.btn_Tailai.Name = "btn_Tailai";
            this.btn_Tailai.Size = new System.Drawing.Size(212, 68);
            this.btn_Tailai.TabIndex = 15;
            this.btn_Tailai.Text = "Tải Lại";
            this.btn_Tailai.UseVisualStyleBackColor = true;
            this.btn_Tailai.Click += new System.EventHandler(this.btn_Tailai_Click);
            // 
            // Xep_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 624);
            this.Controls.Add(this.btn_Xeplop);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Tailai);
            this.Controls.Add(this.dtg_DsLop);
            this.Controls.Add(this.lb_Timlop);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Tim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Xep_lop";
            this.Text = "Danh Sách Xếp Lớp";
            this.Load += new System.EventHandler(this.Xep_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Timlop;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.DataGridView dtg_DsLop;
        private System.Windows.Forms.Button btn_Xeplop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tailai;
    }
}