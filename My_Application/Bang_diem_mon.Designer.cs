namespace My_Application
{
    partial class Bang_diem_mon
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lb_Mon = new System.Windows.Forms.Label();
            this.lb_Tenlop = new System.Windows.Forms.Label();
            this.cbb_Chonlop = new System.Windows.Forms.ComboBox();
            this.LOP_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOP_DataSet = new My_Application.My_ApplicationDataSet();
            this.lb_Hocky = new System.Windows.Forms.Label();
            this.cbb_Hocky = new System.Windows.Forms.ComboBox();
            this.cbb_Monhoc = new System.Windows.Forms.ComboBox();
            this.MONHOC_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOC_DataSet = new My_Application.MONHOC_DataSet();
            this.lb_Hoten = new System.Windows.Forms.Label();
            this.lb_Diem15 = new System.Windows.Forms.Label();
            this.lb_Diem1T = new System.Windows.Forms.Label();
            this.lb_DiemTB = new System.Windows.Forms.Label();
            this.dtg_Bangdiem = new System.Windows.Forms.DataGridView();
            this.LOP_TableAdapter = new My_Application.My_ApplicationDataSetTableAdapters.LOPTableAdapter();
            this.MONHOC_TableAdapter = new My_Application.MONHOC_DataSetTableAdapters.MONHOCTableAdapter();
            this.StatusLabel_Hoten = new System.Windows.Forms.Label();
            this.StatusLabel_Diem15 = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_Diem15 = new System.Windows.Forms.TextBox();
            this.txt_Diem1T = new System.Windows.Forms.TextBox();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.StatusLabel_Diem1T = new System.Windows.Forms.Label();
            this.StatusLabel_DiemTB = new System.Windows.Forms.Label();
            this.btn_Timbangdiem = new System.Windows.Forms.Button();
            this.lb_STT = new System.Windows.Forms.Label();
            this.txt_STT = new System.Windows.Forms.TextBox();
            this.StatusLabel_STT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOC_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Bangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(1231, 610);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 37);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lb_Mon
            // 
            this.lb_Mon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Mon.AutoSize = true;
            this.lb_Mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mon.Location = new System.Drawing.Point(57, 109);
            this.lb_Mon.Name = "lb_Mon";
            this.lb_Mon.Size = new System.Drawing.Size(44, 22);
            this.lb_Mon.TabIndex = 1;
            this.lb_Mon.Text = "Môn";
            // 
            // lb_Tenlop
            // 
            this.lb_Tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Tenlop.AutoSize = true;
            this.lb_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenlop.Location = new System.Drawing.Point(57, 43);
            this.lb_Tenlop.Name = "lb_Tenlop";
            this.lb_Tenlop.Size = new System.Drawing.Size(40, 22);
            this.lb_Tenlop.TabIndex = 0;
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
            this.cbb_Chonlop.Location = new System.Drawing.Point(168, 43);
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
            // lb_Hocky
            // 
            this.lb_Hocky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Hocky.AutoSize = true;
            this.lb_Hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hocky.Location = new System.Drawing.Point(57, 182);
            this.lb_Hocky.Name = "lb_Hocky";
            this.lb_Hocky.Size = new System.Drawing.Size(65, 22);
            this.lb_Hocky.TabIndex = 8;
            this.lb_Hocky.Text = "Học kỳ";
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
            this.cbb_Hocky.Location = new System.Drawing.Point(168, 182);
            this.cbb_Hocky.Name = "cbb_Hocky";
            this.cbb_Hocky.Size = new System.Drawing.Size(219, 28);
            this.cbb_Hocky.TabIndex = 2;
            this.cbb_Hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_Hocky_SelectedIndexChanged);
            // 
            // cbb_Monhoc
            // 
            this.cbb_Monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_Monhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cbb_Monhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Monhoc.DataSource = this.MONHOC_BindingSource;
            this.cbb_Monhoc.DisplayMember = "TENMON";
            this.cbb_Monhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Monhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Monhoc.FormattingEnabled = true;
            this.cbb_Monhoc.Location = new System.Drawing.Point(168, 109);
            this.cbb_Monhoc.Name = "cbb_Monhoc";
            this.cbb_Monhoc.Size = new System.Drawing.Size(219, 28);
            this.cbb_Monhoc.TabIndex = 1;
            this.cbb_Monhoc.ValueMember = "TENMON";
            this.cbb_Monhoc.SelectedIndexChanged += new System.EventHandler(this.cbb_Monhoc_SelectedIndexChanged);
            // 
            // MONHOC_BindingSource
            // 
            this.MONHOC_BindingSource.DataMember = "MONHOC";
            this.MONHOC_BindingSource.DataSource = this.MONHOC_DataSet;
            // 
            // MONHOC_DataSet
            // 
            this.MONHOC_DataSet.DataSetName = "MONHOC_DataSet";
            this.MONHOC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Hoten.AutoSize = true;
            this.lb_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(57, 255);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(63, 22);
            this.lb_Hoten.TabIndex = 11;
            this.lb_Hoten.Text = "Họ tên";
            // 
            // lb_Diem15
            // 
            this.lb_Diem15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Diem15.AutoSize = true;
            this.lb_Diem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diem15.Location = new System.Drawing.Point(57, 409);
            this.lb_Diem15.Name = "lb_Diem15";
            this.lb_Diem15.Size = new System.Drawing.Size(80, 22);
            this.lb_Diem15.TabIndex = 12;
            this.lb_Diem15.Text = "Điểm 15\'";
            // 
            // lb_Diem1T
            // 
            this.lb_Diem1T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Diem1T.AutoSize = true;
            this.lb_Diem1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diem1T.Location = new System.Drawing.Point(57, 490);
            this.lb_Diem1T.Name = "lb_Diem1T";
            this.lb_Diem1T.Size = new System.Drawing.Size(95, 22);
            this.lb_Diem1T.TabIndex = 13;
            this.lb_Diem1T.Text = "Điểm 1 tiết";
            // 
            // lb_DiemTB
            // 
            this.lb_DiemTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_DiemTB.AutoSize = true;
            this.lb_DiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiemTB.Location = new System.Drawing.Point(57, 574);
            this.lb_DiemTB.Name = "lb_DiemTB";
            this.lb_DiemTB.Size = new System.Drawing.Size(80, 22);
            this.lb_DiemTB.TabIndex = 14;
            this.lb_DiemTB.Text = "Điểm TB";
            // 
            // dtg_Bangdiem
            // 
            this.dtg_Bangdiem.AllowUserToAddRows = false;
            this.dtg_Bangdiem.AllowUserToDeleteRows = false;
            this.dtg_Bangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Bangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Bangdiem.Location = new System.Drawing.Point(461, 43);
            this.dtg_Bangdiem.Name = "dtg_Bangdiem";
            this.dtg_Bangdiem.ReadOnly = true;
            this.dtg_Bangdiem.RowHeadersWidth = 51;
            this.dtg_Bangdiem.RowTemplate.Height = 24;
            this.dtg_Bangdiem.Size = new System.Drawing.Size(869, 555);
            this.dtg_Bangdiem.TabIndex = 18;
            this.dtg_Bangdiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Bangdiem_CellClick);
            // 
            // LOP_TableAdapter
            // 
            this.LOP_TableAdapter.ClearBeforeFill = true;
            // 
            // MONHOC_TableAdapter
            // 
            this.MONHOC_TableAdapter.ClearBeforeFill = true;
            // 
            // StatusLabel_Hoten
            // 
            this.StatusLabel_Hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Hoten.AutoSize = true;
            this.StatusLabel_Hoten.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Hoten.Location = new System.Drawing.Point(165, 292);
            this.StatusLabel_Hoten.Name = "StatusLabel_Hoten";
            this.StatusLabel_Hoten.Size = new System.Drawing.Size(133, 16);
            this.StatusLabel_Hoten.TabIndex = 19;
            this.StatusLabel_Hoten.Text = "Vui lòng nhập họ tên !";
            this.StatusLabel_Hoten.Visible = false;
            // 
            // StatusLabel_Diem15
            // 
            this.StatusLabel_Diem15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Diem15.AutoSize = true;
            this.StatusLabel_Diem15.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Diem15.Location = new System.Drawing.Point(165, 444);
            this.StatusLabel_Diem15.Name = "StatusLabel_Diem15";
            this.StatusLabel_Diem15.Size = new System.Drawing.Size(147, 16);
            this.StatusLabel_Diem15.TabIndex = 20;
            this.StatusLabel_Diem15.Text = "Vui lòng nhập điểm 15\' !";
            this.StatusLabel_Diem15.Visible = false;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hoten.Location = new System.Drawing.Point(168, 255);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(150, 24);
            this.txt_Hoten.TabIndex = 3;
            this.txt_Hoten.TextChanged += new System.EventHandler(this.txt_Hoten_TextChanged);
            this.txt_Hoten.Leave += new System.EventHandler(this.txt_Hoten_Leave);
            // 
            // txt_Diem15
            // 
            this.txt_Diem15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Diem15.Location = new System.Drawing.Point(168, 409);
            this.txt_Diem15.Name = "txt_Diem15";
            this.txt_Diem15.Size = new System.Drawing.Size(219, 22);
            this.txt_Diem15.TabIndex = 5;
            this.txt_Diem15.Leave += new System.EventHandler(this.txt_Diem15_Leave);
            // 
            // txt_Diem1T
            // 
            this.txt_Diem1T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Diem1T.Location = new System.Drawing.Point(168, 492);
            this.txt_Diem1T.Name = "txt_Diem1T";
            this.txt_Diem1T.Size = new System.Drawing.Size(219, 22);
            this.txt_Diem1T.TabIndex = 6;
            this.txt_Diem1T.Leave += new System.EventHandler(this.txt_Diem1T_Leave);
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_DiemTB.Location = new System.Drawing.Point(168, 576);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(219, 22);
            this.txt_DiemTB.TabIndex = 7;
            this.txt_DiemTB.Leave += new System.EventHandler(this.txt_DiemTB_Leave);
            // 
            // StatusLabel_Diem1T
            // 
            this.StatusLabel_Diem1T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_Diem1T.AutoSize = true;
            this.StatusLabel_Diem1T.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_Diem1T.Location = new System.Drawing.Point(165, 527);
            this.StatusLabel_Diem1T.Name = "StatusLabel_Diem1T";
            this.StatusLabel_Diem1T.Size = new System.Drawing.Size(157, 16);
            this.StatusLabel_Diem1T.TabIndex = 25;
            this.StatusLabel_Diem1T.Text = "Vui lòng nhập điểm 1 tiết !";
            this.StatusLabel_Diem1T.Visible = false;
            // 
            // StatusLabel_DiemTB
            // 
            this.StatusLabel_DiemTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_DiemTB.AutoSize = true;
            this.StatusLabel_DiemTB.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_DiemTB.Location = new System.Drawing.Point(165, 610);
            this.StatusLabel_DiemTB.Name = "StatusLabel_DiemTB";
            this.StatusLabel_DiemTB.Size = new System.Drawing.Size(148, 16);
            this.StatusLabel_DiemTB.TabIndex = 26;
            this.StatusLabel_DiemTB.Text = "Vui lòng nhập điểm TB !";
            this.StatusLabel_DiemTB.Visible = false;
            // 
            // btn_Timbangdiem
            // 
            this.btn_Timbangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Timbangdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timbangdiem.Location = new System.Drawing.Point(1048, 610);
            this.btn_Timbangdiem.Name = "btn_Timbangdiem";
            this.btn_Timbangdiem.Size = new System.Drawing.Size(147, 37);
            this.btn_Timbangdiem.TabIndex = 28;
            this.btn_Timbangdiem.Text = "Tìm bảng điểm";
            this.btn_Timbangdiem.UseVisualStyleBackColor = true;
            this.btn_Timbangdiem.Visible = false;
            this.btn_Timbangdiem.Click += new System.EventHandler(this.btn_Timbangdiem_Click);
            // 
            // lb_STT
            // 
            this.lb_STT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_STT.AutoSize = true;
            this.lb_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_STT.Location = new System.Drawing.Point(57, 327);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(46, 22);
            this.lb_STT.TabIndex = 29;
            this.lb_STT.Text = "STT";
            // 
            // txt_STT
            // 
            this.txt_STT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STT.Location = new System.Drawing.Point(168, 327);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(49, 24);
            this.txt_STT.TabIndex = 4;
            this.txt_STT.TextChanged += new System.EventHandler(this.txt_STT_TextChanged);
            this.txt_STT.Leave += new System.EventHandler(this.txt_STT_Leave);
            // 
            // StatusLabel_STT
            // 
            this.StatusLabel_STT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel_STT.AutoSize = true;
            this.StatusLabel_STT.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel_STT.Location = new System.Drawing.Point(165, 365);
            this.StatusLabel_STT.Name = "StatusLabel_STT";
            this.StatusLabel_STT.Size = new System.Drawing.Size(124, 16);
            this.StatusLabel_STT.TabIndex = 31;
            this.StatusLabel_STT.Text = "Vui lòng nhập STT !";
            this.StatusLabel_STT.Visible = false;
            // 
            // Bang_diem_mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1342, 703);
            this.Controls.Add(this.StatusLabel_STT);
            this.Controls.Add(this.txt_STT);
            this.Controls.Add(this.lb_STT);
            this.Controls.Add(this.btn_Timbangdiem);
            this.Controls.Add(this.StatusLabel_DiemTB);
            this.Controls.Add(this.StatusLabel_Diem1T);
            this.Controls.Add(this.txt_DiemTB);
            this.Controls.Add(this.txt_Diem1T);
            this.Controls.Add(this.txt_Diem15);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.StatusLabel_Diem15);
            this.Controls.Add(this.StatusLabel_Hoten);
            this.Controls.Add(this.dtg_Bangdiem);
            this.Controls.Add(this.lb_DiemTB);
            this.Controls.Add(this.lb_Diem1T);
            this.Controls.Add(this.lb_Diem15);
            this.Controls.Add(this.lb_Hoten);
            this.Controls.Add(this.cbb_Monhoc);
            this.Controls.Add(this.cbb_Hocky);
            this.Controls.Add(this.lb_Hocky);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Mon);
            this.Controls.Add(this.lb_Tenlop);
            this.Controls.Add(this.cbb_Chonlop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bang_diem_mon";
            this.Text = "Bảng Điểm Môn Học";
            this.Load += new System.EventHandler(this.Bang_diem_mon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOP_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOP_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOC_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONHOC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Bangdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lb_Mon;
        private System.Windows.Forms.Label lb_Tenlop;
        private System.Windows.Forms.ComboBox cbb_Chonlop;
        private System.Windows.Forms.Label lb_Hocky;
        private System.Windows.Forms.ComboBox cbb_Hocky;
        private System.Windows.Forms.ComboBox cbb_Monhoc;
        private System.Windows.Forms.Label lb_Hoten;
        private System.Windows.Forms.Label lb_Diem15;
        private System.Windows.Forms.Label lb_Diem1T;
        private System.Windows.Forms.Label lb_DiemTB;
        private System.Windows.Forms.DataGridView dtg_Bangdiem;
        private My_ApplicationDataSet LOP_DataSet;
        private System.Windows.Forms.BindingSource LOP_BindingSource;
        private My_ApplicationDataSetTableAdapters.LOPTableAdapter LOP_TableAdapter;
        private MONHOC_DataSet MONHOC_DataSet;
        private System.Windows.Forms.BindingSource MONHOC_BindingSource;
        private MONHOC_DataSetTableAdapters.MONHOCTableAdapter MONHOC_TableAdapter;
        private System.Windows.Forms.Label StatusLabel_Hoten;
        private System.Windows.Forms.Label StatusLabel_Diem15;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_Diem15;
        private System.Windows.Forms.TextBox txt_Diem1T;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Label StatusLabel_Diem1T;
        private System.Windows.Forms.Label StatusLabel_DiemTB;
        private System.Windows.Forms.Button btn_Timbangdiem;
        private System.Windows.Forms.Label lb_STT;
        private System.Windows.Forms.TextBox txt_STT;
        private System.Windows.Forms.Label StatusLabel_STT;
    }
}