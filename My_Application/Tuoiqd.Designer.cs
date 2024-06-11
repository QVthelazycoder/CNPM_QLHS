namespace My_Application
{
    partial class Tuoiqd
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
            this.lb_Tuoitoithieu = new System.Windows.Forms.Label();
            this.lb_Tuoitoida = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.nud_Tuoitoithieu = new System.Windows.Forms.NumericUpDown();
            this.nud_Tuoitoida = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tuoitoithieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tuoitoida)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Tuoitoithieu
            // 
            this.lb_Tuoitoithieu.AutoSize = true;
            this.lb_Tuoitoithieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tuoitoithieu.Location = new System.Drawing.Point(73, 85);
            this.lb_Tuoitoithieu.Name = "lb_Tuoitoithieu";
            this.lb_Tuoitoithieu.Size = new System.Drawing.Size(105, 20);
            this.lb_Tuoitoithieu.TabIndex = 2;
            this.lb_Tuoitoithieu.Text = "Tuổi tối thiểu";
            // 
            // lb_Tuoitoida
            // 
            this.lb_Tuoitoida.AutoSize = true;
            this.lb_Tuoitoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tuoitoida.Location = new System.Drawing.Point(73, 202);
            this.lb_Tuoitoida.Name = "lb_Tuoitoida";
            this.lb_Tuoitoida.Size = new System.Drawing.Size(87, 20);
            this.lb_Tuoitoida.TabIndex = 3;
            this.lb_Tuoitoida.Text = "Tuổi tối đa";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(393, 278);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(90, 45);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // nud_Tuoitoithieu
            // 
            this.nud_Tuoitoithieu.Location = new System.Drawing.Point(254, 86);
            this.nud_Tuoitoithieu.Name = "nud_Tuoitoithieu";
            this.nud_Tuoitoithieu.Size = new System.Drawing.Size(120, 22);
            this.nud_Tuoitoithieu.TabIndex = 5;
            // 
            // nud_Tuoitoida
            // 
            this.nud_Tuoitoida.Location = new System.Drawing.Point(254, 203);
            this.nud_Tuoitoida.Name = "nud_Tuoitoida";
            this.nud_Tuoitoida.Size = new System.Drawing.Size(120, 22);
            this.nud_Tuoitoida.TabIndex = 6;
            // 
            // Tuoiqd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.nud_Tuoitoida);
            this.Controls.Add(this.nud_Tuoitoithieu);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lb_Tuoitoida);
            this.Controls.Add(this.lb_Tuoitoithieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tuoiqd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuổi quy định";
            this.Load += new System.EventHandler(this.Tuoiqd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tuoitoithieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tuoitoida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Tuoitoithieu;
        private System.Windows.Forms.Label lb_Tuoitoida;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.NumericUpDown nud_Tuoitoithieu;
        private System.Windows.Forms.NumericUpDown nud_Tuoitoida;
    }
}