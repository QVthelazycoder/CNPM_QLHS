namespace My_Application
{
    partial class Doi_mat_khau
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
            this.btn_Xacnhan = new System.Windows.Forms.Button();
            this.txt_Matkhaumoi = new System.Windows.Forms.TextBox();
            this.lb_Matkhaumoi = new System.Windows.Forms.Label();
            this.txt_Matkhaucu = new System.Windows.Forms.TextBox();
            this.lb_Matkhaucu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xacnhan.Location = new System.Drawing.Point(398, 211);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(127, 31);
            this.btn_Xacnhan.TabIndex = 10;
            this.btn_Xacnhan.Text = "Xác nhận";
            this.btn_Xacnhan.UseVisualStyleBackColor = true;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
            // 
            // txt_Matkhaumoi
            // 
            this.txt_Matkhaumoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Matkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matkhaumoi.Location = new System.Drawing.Point(202, 131);
            this.txt_Matkhaumoi.MaxLength = 100;
            this.txt_Matkhaumoi.Name = "txt_Matkhaumoi";
            this.txt_Matkhaumoi.PasswordChar = '*';
            this.txt_Matkhaumoi.Size = new System.Drawing.Size(223, 26);
            this.txt_Matkhaumoi.TabIndex = 9;
            // 
            // lb_Matkhaumoi
            // 
            this.lb_Matkhaumoi.AutoSize = true;
            this.lb_Matkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhaumoi.Location = new System.Drawing.Point(28, 134);
            this.lb_Matkhaumoi.Name = "lb_Matkhaumoi";
            this.lb_Matkhaumoi.Size = new System.Drawing.Size(153, 20);
            this.lb_Matkhaumoi.TabIndex = 11;
            this.lb_Matkhaumoi.Text = "Nhập mật khẩu mới";
            // 
            // txt_Matkhaucu
            // 
            this.txt_Matkhaucu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Matkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matkhaucu.Location = new System.Drawing.Point(202, 63);
            this.txt_Matkhaucu.MaxLength = 100;
            this.txt_Matkhaucu.Name = "txt_Matkhaucu";
            this.txt_Matkhaucu.PasswordChar = '*';
            this.txt_Matkhaucu.Size = new System.Drawing.Size(223, 26);
            this.txt_Matkhaucu.TabIndex = 7;
            // 
            // lb_Matkhaucu
            // 
            this.lb_Matkhaucu.AutoSize = true;
            this.lb_Matkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhaucu.Location = new System.Drawing.Point(28, 66);
            this.lb_Matkhaucu.Name = "lb_Matkhaucu";
            this.lb_Matkhaucu.Size = new System.Drawing.Size(144, 20);
            this.lb_Matkhaucu.TabIndex = 8;
            this.lb_Matkhaucu.Text = "Nhập mật khẩu cũ";
            // 
            // Doi_mat_khau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 254);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.txt_Matkhaumoi);
            this.Controls.Add(this.lb_Matkhaumoi);
            this.Controls.Add(this.txt_Matkhaucu);
            this.Controls.Add(this.lb_Matkhaucu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Doi_mat_khau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Xacnhan;
        private System.Windows.Forms.TextBox txt_Matkhaumoi;
        private System.Windows.Forms.Label lb_Matkhaumoi;
        private System.Windows.Forms.TextBox txt_Matkhaucu;
        private System.Windows.Forms.Label lb_Matkhaucu;
    }
}