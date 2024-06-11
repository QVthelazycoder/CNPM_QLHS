namespace My_Application
{
    partial class Bao_cao_Hocky
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
            this.components = new System.ComponentModel.Container();
            this.btn_Xembangdiem = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Tile = new System.Windows.Forms.TextBox();
            this.lb_Tile = new System.Windows.Forms.Label();
            this.StatusLabel_Siso = new System.Windows.Forms.Label();
            this.txt_Siso = new System.Windows.Forms.TextBox();
            this.lb_Siso = new System.Windows.Forms.Label();
            this.dtg_Bangdiem = new System.Windows.Forms.DataGridView();
            this.StatusLabel_Soluongdat = new System.Windows.Forms.Label();
            this.txt_Soluongdat = new System.Windows.Forms.TextBox();
            this.lb_Soluongdat = new System.Windows.Forms.Label();
            this.cbb_Hocky = new System.Windows.Forms.ComboBox();
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.lb_Tenlop = new System.Windows.Forms.Label();
            this.cbb_Chonlop = new System.Windows.Forms.ComboBox();
            this.LOP_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOP_DataSet = new My_Application.My_ApplicationDataSet();
            this.LOP_TableAdapter = new My_Application.My_ApplicationDataSetTableAdapters.LOPTableAdapter();
            this.btn_Xembaocao = new System.Windows.Forms.Button();
            this.StatusLabel_Tile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Bangdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xembangdiem
            // 
            this.btn_Xembangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xembangdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xembangdiem.Location = new System.Drawing.Point(881, 611);
            this.btn_Xembangdiem.Name = "btn_Xembangdiem";
            this.btn_Xembangdiem.Size = new System.Drawing.Size(153, 37);
            this.btn_Xembangdiem.TabIndex = 77;
            this.btn_Xembangdiem.Text = "Xem bảng điểm";
            this.btn_Xembangdiem.UseVisualStyleBackColor = true;
            this.btn_Xembangdiem.Click += new System.EventHandler(this.btn_Xembangdiem_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1231, 611);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 37);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_Tile
            // 
            this.txt_Tile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Tile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tile.Location = new System.Drawing.Point(211, 510);
            this.txt_Tile.Name = "txt_Tile";
            this.txt_Tile.Size = new System.Drawing.Size(49, 24);
            this.txt_Tile.TabIndex = 4;
            this.txt_Tile.Leave += new System.EventHandler(this.txt_Tile_Leave);
            // 
            // lb_Tile
            // 
            this.lb_Tile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.Location = new System.Drawing.Point(68, 510);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(45, 22);
            this.lb_Tile.TabIndex = 75;
            this.lb_Tile.Text = "Tỉ lệ";
            // 
            // StatusLabel_Siso
            // 
            this.StatusLabel_Siso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Siso.AutoSize = true;
            this.StatusLabel_Siso.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Siso.Location = new System.Drawing.Point(208, 351);
            this.StatusLabel_Siso.Name = "StatusLabel_Siso";
            this.StatusLabel_Siso.Size = new System.Drawing.Size(127, 16);
            this.StatusLabel_Siso.TabIndex = 73;
            this.StatusLabel_Siso.Text = "Vui lòng nhập sĩ số !";
            this.StatusLabel_Siso.Visible = false;
            // 
            // txt_Siso
            // 
            this.txt_Siso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Siso.Location = new System.Drawing.Point(211, 313);
            this.txt_Siso.Name = "txt_Siso";
            this.txt_Siso.Size = new System.Drawing.Size(49, 24);
            this.txt_Siso.TabIndex = 2;
            this.txt_Siso.TextChanged += new System.EventHandler(this.txt_Siso_TextChanged);
            this.txt_Siso.Leave += new System.EventHandler(this.txt_Siso_Leave);
            // 
            // lb_Siso
            // 
            this.lb_Siso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Siso.AutoSize = true;
            this.lb_Siso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Siso.Location = new System.Drawing.Point(68, 313);
            this.lb_Siso.Name = "lb_Siso";
            this.lb_Siso.Size = new System.Drawing.Size(50, 22);
            this.lb_Siso.TabIndex = 72;
            this.lb_Siso.Text = "Sĩ số";
            // 
            // dtg_Bangdiem
            // 
            this.dtg_Bangdiem.AllowUserToAddRows = false;
            this.dtg_Bangdiem.AllowUserToDeleteRows = false;
            this.dtg_Bangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Bangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Bangdiem.Location = new System.Drawing.Point(515, 41);
            this.dtg_Bangdiem.Name = "dtg_Bangdiem";
            this.dtg_Bangdiem.ReadOnly = true;
            this.dtg_Bangdiem.RowHeadersWidth = 51;
            this.dtg_Bangdiem.RowTemplate.Height = 24;
            this.dtg_Bangdiem.Size = new System.Drawing.Size(827, 555);
            this.dtg_Bangdiem.TabIndex = 7;
            // 
            // StatusLabel_Soluongdat
            // 
            this.StatusLabel_Soluongdat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Soluongdat.AutoSize = true;
            this.StatusLabel_Soluongdat.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Soluongdat.Location = new System.Drawing.Point(208, 445);
            this.StatusLabel_Soluongdat.Name = "StatusLabel_Soluongdat";
            this.StatusLabel_Soluongdat.Size = new System.Drawing.Size(222, 16);
            this.StatusLabel_Soluongdat.TabIndex = 69;
            this.StatusLabel_Soluongdat.Text = "Vui lòng nhập số luọng học sinh đạt !";
            this.StatusLabel_Soluongdat.Visible = false;
            // 
            // txt_Soluongdat
            // 
            this.txt_Soluongdat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Soluongdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Soluongdat.Location = new System.Drawing.Point(211, 407);
            this.txt_Soluongdat.Name = "txt_Soluongdat";
            this.txt_Soluongdat.Size = new System.Drawing.Size(49, 24);
            this.txt_Soluongdat.TabIndex = 3;
            this.txt_Soluongdat.TextChanged += new System.EventHandler(this.txt_Soluongdat_TextChanged);
            this.txt_Soluongdat.Leave += new System.EventHandler(this.txt_Soluongdat_Leave);
            // 
            // lb_Soluongdat
            // 
            this.lb_Soluongdat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Soluongdat.AutoSize = true;
            this.lb_Soluongdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Soluongdat.Location = new System.Drawing.Point(68, 407);
            this.lb_Soluongdat.Name = "lb_Soluongdat";
            this.lb_Soluongdat.Size = new System.Drawing.Size(111, 22);
            this.lb_Soluongdat.TabIndex = 68;
            this.lb_Soluongdat.Text = "Số lượng đạt";
            // 
            // cbb_Hocky
            // 
            this.cbb_Hocky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_Hocky.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "II"});
            this.cbb_Hocky.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cbb_Hocky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Hocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Hocky.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Hocky.FormattingEnabled = true;
            this.cbb_Hocky.Items.AddRange(new object[] {
            "I",
            "II"});
            this.cbb_Hocky.Location = new System.Drawing.Point(211, 221);
            this.cbb_Hocky.Name = "cbb_Hocky";
            this.cbb_Hocky.Size = new System.Drawing.Size(219, 28);
            this.cbb_Hocky.TabIndex = 1;
            this.cbb_Hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_Hocky_SelectedIndexChanged);
            // 
            // lb_Hocky
            // 
            this.lb_Hocky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hocky.Location = new System.Drawing.Point(68, 221);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(65, 22);
            this.lb_Hocky.TabIndex = 67;
            this.lb_Hocky.Text = "Học kỳ";
            // 
            // lb_Tenlop
            // 
            this.lb_Tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Tenlop.AutoSize = true;
            this.lb_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenlop.Location = new System.Drawing.Point(68, 130);
            this.lb_Tenlop.Name = "lb_Tenlop";
            this.lb_Tenlop.Size = new System.Drawing.Size(40, 22);
            this.lb_Tenlop.TabIndex = 62;
            this.lb_Tenlop.Text = "Lớp";
            // 
            // cbb_Chonlop
            // 
            this.cbb_Chonlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_Chonlop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cbb_Chonlop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Chonlop.DataSource = this.LOP_BindingSource;
            this.cbb_Chonlop.DisplayMember = "TENLOP";
            this.cbb_Chonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Chonlop.FormattingEnabled = true;
            this.cbb_Chonlop.Location = new System.Drawing.Point(211, 130);
            this.cbb_Chonlop.Name = "cbb_Chonlop";
            this.cbb_Chonlop.Size = new System.Drawing.Size(80, 28);
            this.cbb_Chonlop.TabIndex = 0;
            this.cbb_Chonlop.ValueMember = "TENLOP";
            this.cbb_Chonlop.SelectedIndexChanged += new System.EventHandler(this.cbb_Chonlop_SelectedIndexChanged);
            // 
            // LOP_BindingSource
            // 
            this.LOP_BindingSource.DataMember = "LOP";
            this.LOP_BindingSource.DataSource = this.LOP_DataSet;
            // 
            // LOP_DataSet
            // 
            this.LOP_DataSet.DataSetName = "LOP_DataSet";
            this.LOP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LOP_TableAdapter
            // 
            this.LOP_TableAdapter.ClearBeforeFill = true;
            // 
            // btn_Xembaocao
            // 
            this.btn_Xembaocao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xembaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xembaocao.Location = new System.Drawing.Point(1060, 611);
            this.btn_Xembaocao.Name = "btn_Xembaocao";
            this.btn_Xembaocao.Size = new System.Drawing.Size(147, 37);
            this.btn_Xembaocao.TabIndex = 78;
            this.btn_Xembaocao.Text = "Xem báo cáo";
            this.btn_Xembaocao.UseVisualStyleBackColor = true;
            this.btn_Xembaocao.Click += new System.EventHandler(this.btn_Xembaocao_Click);
            // 
            // StatusLabel_Tile
            // 
            this.StatusLabel_Tile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Tile.AutoSize = true;
            this.StatusLabel_Tile.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Tile.Location = new System.Drawing.Point(208, 554);
            this.StatusLabel_Tile.Name = "StatusLabel_Tile";
            this.StatusLabel_Tile.Size = new System.Drawing.Size(117, 16);
            this.StatusLabel_Tile.TabIndex = 79;
            this.StatusLabel_Tile.Text = "Vui lòng nhập tỉ lệ !";
            this.StatusLabel_Tile.Visible = false;
            // 
            // Bao_cao_Hocky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1342, 703);
            this.Controls.Add(this.StatusLabel_Tile);
            this.Controls.Add(this.btn_Xembaocao);
            this.Controls.Add(this.btn_Xembangdiem);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_Tile);
            this.Controls.Add(this.lb_Tile);
            this.Controls.Add(this.StatusLabel_Siso);
            this.Controls.Add(this.txt_Siso);
            this.Controls.Add(this.lb_Siso);
            this.Controls.Add(this.dtg_Bangdiem);
            this.Controls.Add(this.StatusLabel_Soluongdat);
            this.Controls.Add(this.txt_Soluongdat);
            this.Controls.Add(this.lb_Soluongdat);
            this.Controls.Add(this.cbb_Hocky);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.lb_Tenlop);
            this.Controls.Add(this.cbb_Chonlop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bao_cao_Hocky";
            this.Text = "Báo Cáo Tổng Kết Học Kỳ";
            this.Load += new System.EventHandler(this.Bao_cao_Hocky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Bangdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xembangdiem;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_Tile;
        private System.Windows.Forms.Label lb_Tile;
        private System.Windows.Forms.Label StatusLabel_Siso;
        private System.Windows.Forms.TextBox txt_Siso;
        private System.Windows.Forms.Label lb_Siso;
        private System.Windows.Forms.DataGridView dtg_Bangdiem;
        private System.Windows.Forms.Label StatusLabel_Soluongdat;
        private System.Windows.Forms.TextBox txt_Soluongdat;
        private System.Windows.Forms.Label lb_Soluongdat;
        private System.Windows.Forms.ComboBox cbb_Hocky;
        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.Label lb_Tenlop;
        private System.Windows.Forms.ComboBox cbb_Chonlop;
        private System.Windows.Forms.BindingSource LOP_BindingSource;
        private My_ApplicationDataSet LOP_DataSet;
        private My_ApplicationDataSetTableAdapters.LOPTableAdapter LOP_TableAdapter;
        private System.Windows.Forms.Button btn_Xembaocao;
        private System.Windows.Forms.Label StatusLabel_Tile;
    }
}