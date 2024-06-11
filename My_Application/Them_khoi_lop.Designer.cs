namespace My_Application
{
    partial class Them_khoi_lop
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
            this.lb_Makhoi = new System.Windows.Forms.Label();
            this.lb_Tenlop = new System.Windows.Forms.Label();
            this.txt_Tenlop = new System.Windows.Forms.TextBox();
            this.cbb_Khoi = new System.Windows.Forms.ComboBox();
            this.Khoi_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Khoi_DataSet = new My_Application.Khoi_DataSet();
            this.Khoi_TableAdapter = new My_Application.Khoi_DataSetTableAdapters.KHOILOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Khoi_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khoi_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(501, 192);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 37);
            this.btn_Luu.TabIndex = 16;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lb_Makhoi
            // 
            this.lb_Makhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Makhoi.AutoSize = true;
            this.lb_Makhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Makhoi.Location = new System.Drawing.Point(41, 64);
            this.lb_Makhoi.Name = "lb_Makhoi";
            this.lb_Makhoi.Size = new System.Drawing.Size(46, 22);
            this.lb_Makhoi.TabIndex = 14;
            this.lb_Makhoi.Text = "Khối";
            // 
            // lb_Tenlop
            // 
            this.lb_Tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Tenlop.AutoSize = true;
            this.lb_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenlop.Location = new System.Drawing.Point(41, 132);
            this.lb_Tenlop.Name = "lb_Tenlop";
            this.lb_Tenlop.Size = new System.Drawing.Size(71, 22);
            this.lb_Tenlop.TabIndex = 17;
            this.lb_Tenlop.Text = "Tên lớp";
            // 
            // txt_Tenlop
            // 
            this.txt_Tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tenlop.Location = new System.Drawing.Point(215, 132);
            this.txt_Tenlop.MaxLength = 5;
            this.txt_Tenlop.Name = "txt_Tenlop";
            this.txt_Tenlop.Size = new System.Drawing.Size(87, 27);
            this.txt_Tenlop.TabIndex = 15;
            // 
            // cbb_Khoi
            // 
            this.cbb_Khoi.DataSource = this.Khoi_BindingSource;
            this.cbb_Khoi.DisplayMember = "MAKHOI";
            this.cbb_Khoi.FormattingEnabled = true;
            this.cbb_Khoi.Location = new System.Drawing.Point(215, 66);
            this.cbb_Khoi.Name = "cbb_Khoi";
            this.cbb_Khoi.Size = new System.Drawing.Size(87, 24);
            this.cbb_Khoi.TabIndex = 18;
            this.cbb_Khoi.ValueMember = "MAKHOI";
            // 
            // Khoi_BindingSource
            // 
            this.Khoi_BindingSource.DataMember = "KHOILOP";
            this.Khoi_BindingSource.DataSource = this.Khoi_DataSet;
            // 
            // Khoi_DataSet
            // 
            this.Khoi_DataSet.DataSetName = "Khoi_DataSet";
            this.Khoi_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Khoi_TableAdapter
            // 
            this.Khoi_TableAdapter.ClearBeforeFill = true;
            // 
            // Them_khoi_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 240);
            this.Controls.Add(this.cbb_Khoi);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Makhoi);
            this.Controls.Add(this.lb_Tenlop);
            this.Controls.Add(this.txt_Tenlop);
            this.Name = "Them_khoi_lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khối lớp";
            this.Load += new System.EventHandler(this.Them_khoi_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Khoi_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Khoi_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lb_Makhoi;
        private System.Windows.Forms.Label lb_Tenlop;
        private System.Windows.Forms.TextBox txt_Tenlop;
        private System.Windows.Forms.ComboBox cbb_Khoi;
        private Khoi_DataSet Khoi_DataSet;
        private System.Windows.Forms.BindingSource Khoi_BindingSource;
        private Khoi_DataSetTableAdapters.KHOILOPTableAdapter Khoi_TableAdapter;
    }
}