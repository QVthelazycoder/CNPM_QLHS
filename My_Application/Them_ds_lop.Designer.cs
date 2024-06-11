namespace My_Application
{
    partial class Them_ds_lop
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
            this.cbb_Chonlop = new System.Windows.Forms.ComboBox();
            this.LOP_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOP_DataSet = new My_Application.My_ApplicationDataSet();
            this.lb_Chonlop = new System.Windows.Forms.Label();
            this.lb_Mahs = new System.Windows.Forms.Label();
            this.txt_Mahs = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.dtg_Hosohs = new System.Windows.Forms.DataGridView();
            this.lb_Timkiem = new System.Windows.Forms.Label();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.LOP_TableAdapter = new My_Application.My_ApplicationDataSetTableAdapters.LOPTableAdapter();
            this.lb_STT = new System.Windows.Forms.Label();
            this.nud_STT = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Hosohs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_STT)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_Chonlop
            // 
            this.cbb_Chonlop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_Chonlop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cbb_Chonlop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Chonlop.DataSource = this.LOP_BindingSource;
            this.cbb_Chonlop.DisplayMember = "TENLOP";
            this.cbb_Chonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Chonlop.FormattingEnabled = true;
            this.cbb_Chonlop.Location = new System.Drawing.Point(529, 45);
            this.cbb_Chonlop.Name = "cbb_Chonlop";
            this.cbb_Chonlop.Size = new System.Drawing.Size(219, 28);
            this.cbb_Chonlop.TabIndex = 0;
            this.cbb_Chonlop.ValueMember = "TENLOP";
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
            // lb_Chonlop
            // 
            this.lb_Chonlop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Chonlop.AutoSize = true;
            this.lb_Chonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Chonlop.Location = new System.Drawing.Point(293, 45);
            this.lb_Chonlop.Name = "lb_Chonlop";
            this.lb_Chonlop.Size = new System.Drawing.Size(82, 22);
            this.lb_Chonlop.TabIndex = 1;
            this.lb_Chonlop.Text = "Chọn lớp";
            // 
            // lb_Mahs
            // 
            this.lb_Mahs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Mahs.AutoSize = true;
            this.lb_Mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mahs.Location = new System.Drawing.Point(293, 106);
            this.lb_Mahs.Name = "lb_Mahs";
            this.lb_Mahs.Size = new System.Drawing.Size(199, 22);
            this.lb_Mahs.TabIndex = 2;
            this.lb_Mahs.Text = "Mã học sinh muốn thêm";
            // 
            // txt_Mahs
            // 
            this.txt_Mahs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mahs.Location = new System.Drawing.Point(529, 106);
            this.txt_Mahs.Name = "txt_Mahs";
            this.txt_Mahs.ReadOnly = true;
            this.txt_Mahs.Size = new System.Drawing.Size(219, 26);
            this.txt_Mahs.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(941, 214);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 37);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dtg_Hosohs
            // 
            this.dtg_Hosohs.AllowUserToAddRows = false;
            this.dtg_Hosohs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Hosohs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Hosohs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Hosohs.Location = new System.Drawing.Point(0, 258);
            this.dtg_Hosohs.Name = "dtg_Hosohs";
            this.dtg_Hosohs.ReadOnly = true;
            this.dtg_Hosohs.RowHeadersWidth = 51;
            this.dtg_Hosohs.RowTemplate.Height = 24;
            this.dtg_Hosohs.Size = new System.Drawing.Size(1083, 398);
            this.dtg_Hosohs.TabIndex = 4;
            this.dtg_Hosohs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Hosohs_CellClick);
            // 
            // lb_Timkiem
            // 
            this.lb_Timkiem.AutoSize = true;
            this.lb_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Timkiem.Location = new System.Drawing.Point(11, 227);
            this.lb_Timkiem.Name = "lb_Timkiem";
            this.lb_Timkiem.Size = new System.Drawing.Size(105, 20);
            this.lb_Timkiem.TabIndex = 10;
            this.lb_Timkiem.Text = "Tìm học sinh";
            // 
            // txt_Tim
            // 
            this.txt_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(137, 224);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(355, 27);
            this.txt_Tim.TabIndex = 4;
            this.txt_Tim.TextChanged += new System.EventHandler(this.txt_Tim_TextChanged);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(519, 224);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(43, 28);
            this.btn_Tim.TabIndex = 11;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Visible = false;
            // 
            // LOP_TableAdapter
            // 
            this.LOP_TableAdapter.ClearBeforeFill = true;
            // 
            // lb_STT
            // 
            this.lb_STT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_STT.AutoSize = true;
            this.lb_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_STT.Location = new System.Drawing.Point(293, 164);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(79, 22);
            this.lb_STT.TabIndex = 12;
            this.lb_STT.Text = "STT mới";
            // 
            // nud_STT
            // 
            this.nud_STT.Location = new System.Drawing.Point(529, 163);
            this.nud_STT.Name = "nud_STT";
            this.nud_STT.Size = new System.Drawing.Size(120, 22);
            this.nud_STT.TabIndex = 13;
            // 
            // Them_ds_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1083, 656);
            this.Controls.Add(this.nud_STT);
            this.Controls.Add(this.lb_STT);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.lb_Timkiem);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.dtg_Hosohs);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_Mahs);
            this.Controls.Add(this.lb_Mahs);
            this.Controls.Add(this.lb_Chonlop);
            this.Controls.Add(this.cbb_Chonlop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Them_ds_lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp Lớp";
            this.Load += new System.EventHandler(this.Them_ds_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Hosohs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_STT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Chonlop;
        private System.Windows.Forms.Label lb_Mahs;
        private System.Windows.Forms.TextBox txt_Mahs;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridView dtg_Hosohs;
        private System.Windows.Forms.Label lb_Timkiem;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private My_ApplicationDataSet LOP_DataSet;
        private System.Windows.Forms.BindingSource LOP_BindingSource;
        private My_ApplicationDataSetTableAdapters.LOPTableAdapter LOP_TableAdapter;
        private System.Windows.Forms.ComboBox cbb_Chonlop;
        private System.Windows.Forms.Label lb_STT;
        private System.Windows.Forms.NumericUpDown nud_STT;
    }
}