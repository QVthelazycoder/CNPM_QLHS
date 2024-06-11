namespace My_Application
{
    partial class Them_mon_hoc
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lb_Mamon = new System.Windows.Forms.Label();
            this.lb_Tenmon = new System.Windows.Forms.Label();
            this.txt_Mamon = new System.Windows.Forms.TextBox();
            this.txt_Tenmon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(501, 191);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(99, 37);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lb_Mamon
            // 
            this.lb_Mamon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Mamon.AutoSize = true;
            this.lb_Mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mamon.Location = new System.Drawing.Point(41, 63);
            this.lb_Mamon.Name = "lb_Mamon";
            this.lb_Mamon.Size = new System.Drawing.Size(73, 22);
            this.lb_Mamon.TabIndex = 9;
            this.lb_Mamon.Text = "Mã môn";
            // 
            // lb_Tenmon
            // 
            this.lb_Tenmon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Tenmon.AutoSize = true;
            this.lb_Tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tenmon.Location = new System.Drawing.Point(41, 131);
            this.lb_Tenmon.Name = "lb_Tenmon";
            this.lb_Tenmon.Size = new System.Drawing.Size(81, 22);
            this.lb_Tenmon.TabIndex = 12;
            this.lb_Tenmon.Text = "Tên môn";
            // 
            // txt_Mamon
            // 
            this.txt_Mamon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mamon.Location = new System.Drawing.Point(215, 63);
            this.txt_Mamon.MaxLength = 3;
            this.txt_Mamon.Name = "txt_Mamon";
            this.txt_Mamon.Size = new System.Drawing.Size(116, 27);
            this.txt_Mamon.TabIndex = 8;
            // 
            // txt_Tenmon
            // 
            this.txt_Tenmon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tenmon.Location = new System.Drawing.Point(215, 131);
            this.txt_Tenmon.MaxLength = 50;
            this.txt_Tenmon.Name = "txt_Tenmon";
            this.txt_Tenmon.Size = new System.Drawing.Size(251, 27);
            this.txt_Tenmon.TabIndex = 10;
            // 
            // Them_mon_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 240);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Mamon);
            this.Controls.Add(this.lb_Tenmon);
            this.Controls.Add(this.txt_Mamon);
            this.Controls.Add(this.txt_Tenmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Them_mon_hoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Them_mon_hoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lb_Mamon;
        private System.Windows.Forms.Label lb_Tenmon;
        private System.Windows.Forms.TextBox txt_Mamon;
        private System.Windows.Forms.TextBox txt_Tenmon;
    }
}