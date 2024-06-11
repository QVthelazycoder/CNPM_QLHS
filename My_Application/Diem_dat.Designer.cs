namespace My_Application
{
    partial class Diem_dat
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
            this.nud_Diemdathocky = new System.Windows.Forms.NumericUpDown();
            this.nud_Diemdatmon = new System.Windows.Forms.NumericUpDown();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lb_Diemdathocky = new System.Windows.Forms.Label();
            this.lb_Diemdatmon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Diemdathocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Diemdatmon)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Diemdathocky
            // 
            this.nud_Diemdathocky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Diemdathocky.DecimalPlaces = 1;
            this.nud_Diemdathocky.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_Diemdathocky.Location = new System.Drawing.Point(254, 203);
            this.nud_Diemdathocky.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Diemdathocky.Name = "nud_Diemdathocky";
            this.nud_Diemdathocky.Size = new System.Drawing.Size(120, 22);
            this.nud_Diemdathocky.TabIndex = 11;
            // 
            // nud_Diemdatmon
            // 
            this.nud_Diemdatmon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Diemdatmon.DecimalPlaces = 1;
            this.nud_Diemdatmon.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_Diemdatmon.Location = new System.Drawing.Point(254, 86);
            this.nud_Diemdatmon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Diemdatmon.Name = "nud_Diemdatmon";
            this.nud_Diemdatmon.Size = new System.Drawing.Size(120, 22);
            this.nud_Diemdatmon.TabIndex = 10;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(393, 278);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(90, 45);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lb_Diemdathocky
            // 
            this.lb_Diemdathocky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Diemdathocky.AutoSize = true;
            this.lb_Diemdathocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diemdathocky.Location = new System.Drawing.Point(73, 202);
            this.lb_Diemdathocky.Name = "lb_Diemdathocky";
            this.lb_Diemdathocky.Size = new System.Drawing.Size(129, 20);
            this.lb_Diemdathocky.TabIndex = 8;
            this.lb_Diemdathocky.Text = "Điểm đạt học kỳ";
            // 
            // lb_Diemdatmon
            // 
            this.lb_Diemdatmon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Diemdatmon.AutoSize = true;
            this.lb_Diemdatmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diemdatmon.Location = new System.Drawing.Point(73, 85);
            this.lb_Diemdatmon.Name = "lb_Diemdatmon";
            this.lb_Diemdatmon.Size = new System.Drawing.Size(113, 20);
            this.lb_Diemdatmon.TabIndex = 7;
            this.lb_Diemdatmon.Text = "Điểm đạt môn";
            // 
            // Diem_dat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.nud_Diemdathocky);
            this.Controls.Add(this.nud_Diemdatmon);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Diemdathocky);
            this.Controls.Add(this.lb_Diemdatmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Diem_dat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm đạt (môn, học kỳ)";
            this.Load += new System.EventHandler(this.Diem_dat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Diemdathocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Diemdatmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Diemdathocky;
        private System.Windows.Forms.NumericUpDown nud_Diemdatmon;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lb_Diemdathocky;
        private System.Windows.Forms.Label lb_Diemdatmon;
    }
}