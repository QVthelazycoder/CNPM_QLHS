namespace My_Application
{
    partial class Tra_cuu
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
            this.dtg_Tracuu = new System.Windows.Forms.DataGridView();
            this.my_ApplicationDataSet = new My_Application.My_ApplicationDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new My_Application.My_ApplicationDataSetTableAdapters.LOPTableAdapter();
            this.cbb_Chonlop = new System.Windows.Forms.ComboBox();
            this.lb_Tenlop = new System.Windows.Forms.Label();
            this.lb_Tenhs = new System.Windows.Forms.Label();
            this.txt_Tenhs = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tracuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_ApplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Tracuu
            // 
            this.dtg_Tracuu.AllowUserToAddRows = false;
            this.dtg_Tracuu.AllowUserToDeleteRows = false;
            this.dtg_Tracuu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Tracuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Tracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Tracuu.Location = new System.Drawing.Point(0, 245);
            this.dtg_Tracuu.Name = "dtg_Tracuu";
            this.dtg_Tracuu.ReadOnly = true;
            this.dtg_Tracuu.RowHeadersWidth = 51;
            this.dtg_Tracuu.RowTemplate.Height = 24;
            this.dtg_Tracuu.Size = new System.Drawing.Size(983, 308);
            this.dtg_Tracuu.TabIndex = 11;
            // 
            // my_ApplicationDataSet
            // 
            this.my_ApplicationDataSet.DataSetName = "My_ApplicationDataSet";
            this.my_ApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.my_ApplicationDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // cbb_Chonlop
            // 
            this.cbb_Chonlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Chonlop.DataSource = this.lOPBindingSource;
            this.cbb_Chonlop.DisplayMember = "TENLOP";
            this.cbb_Chonlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Chonlop.FormattingEnabled = true;
            this.cbb_Chonlop.Location = new System.Drawing.Point(442, 119);
            this.cbb_Chonlop.Name = "cbb_Chonlop";
            this.cbb_Chonlop.Size = new System.Drawing.Size(100, 33);
            this.cbb_Chonlop.TabIndex = 1;
            this.cbb_Chonlop.ValueMember = "TENLOP";
            // 
            // lb_Tenlop
            // 
            this.lb_Tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Tenlop.AutoSize = true;
            this.lb_Tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenlop.Location = new System.Drawing.Point(283, 122);
            this.lb_Tenlop.Name = "lb_Tenlop";
            this.lb_Tenlop.Size = new System.Drawing.Size(45, 25);
            this.lb_Tenlop.TabIndex = 19;
            this.lb_Tenlop.Text = "Lớp";
            // 
            // lb_Tenhs
            // 
            this.lb_Tenhs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Tenhs.AutoSize = true;
            this.lb_Tenhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenhs.Location = new System.Drawing.Point(283, 63);
            this.lb_Tenhs.Name = "lb_Tenhs";
            this.lb_Tenhs.Size = new System.Drawing.Size(125, 25);
            this.lb_Tenhs.TabIndex = 18;
            this.lb_Tenhs.Text = "Tên học sinh";
            // 
            // txt_Tenhs
            // 
            this.txt_Tenhs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tenhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tenhs.Location = new System.Drawing.Point(442, 60);
            this.txt_Tenhs.Name = "txt_Tenhs";
            this.txt_Tenhs.Size = new System.Drawing.Size(215, 30);
            this.txt_Tenhs.TabIndex = 0;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(641, 188);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(55, 35);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // Tra_cuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.cbb_Chonlop);
            this.Controls.Add(this.lb_Tenlop);
            this.Controls.Add(this.lb_Tenhs);
            this.Controls.Add(this.txt_Tenhs);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.dtg_Tracuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tra_cuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Học SInh";
            this.Load += new System.EventHandler(this.Tra_cuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tracuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_ApplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Tracuu;
        private My_ApplicationDataSet my_ApplicationDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private My_ApplicationDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cbb_Chonlop;
        private System.Windows.Forms.Label lb_Tenlop;
        private System.Windows.Forms.Label lb_Tenhs;
        private System.Windows.Forms.TextBox txt_Tenhs;
        private System.Windows.Forms.Button btn_Tim;
    }
}