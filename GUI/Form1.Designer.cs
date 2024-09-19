namespace GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Các thành phần giao diện
        private System.Windows.Forms.TextBox txtSoLuongBo;
        private System.Windows.Forms.TextBox txtSoLuongCuu;
        private System.Windows.Forms.TextBox txtSoLuongDe;
        private System.Windows.Forms.Label lblSoLuongBo;
        private System.Windows.Forms.Label lblSoLuongCuu;
        private System.Windows.Forms.Label lblSoLuongDe;
        private System.Windows.Forms.Button btnThemGiaSuc;
        private System.Windows.Forms.Button btnKeuTieng;
        private System.Windows.Forms.Button btnSinhCon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Label lblThongTin;

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
            this.txtSoLuongBo = new System.Windows.Forms.TextBox();
            this.txtSoLuongCuu = new System.Windows.Forms.TextBox();
            this.txtSoLuongDe = new System.Windows.Forms.TextBox();
            this.lblSoLuongBo = new System.Windows.Forms.Label();
            this.lblSoLuongCuu = new System.Windows.Forms.Label();
            this.lblSoLuongDe = new System.Windows.Forms.Label();
            this.btnThemGiaSuc = new System.Windows.Forms.Button();
            this.btnKeuTieng = new System.Windows.Forms.Button();
            this.btnSinhCon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoLuongBo
            // 
            this.txtSoLuongBo.Location = new System.Drawing.Point(100, 30);
            this.txtSoLuongBo.Name = "txtSoLuongBo";
            this.txtSoLuongBo.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongBo.TabIndex = 0;
            // 
            // txtSoLuongCuu
            // 
            this.txtSoLuongCuu.Location = new System.Drawing.Point(100, 60);
            this.txtSoLuongCuu.Name = "txtSoLuongCuu";
            this.txtSoLuongCuu.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongCuu.TabIndex = 1;
            // 
            // txtSoLuongDe
            // 
            this.txtSoLuongDe.Location = new System.Drawing.Point(100, 90);
            this.txtSoLuongDe.Name = "txtSoLuongDe";
            this.txtSoLuongDe.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongDe.TabIndex = 2;
            // 
            // lblSoLuongBo
            // 
            this.lblSoLuongBo.AutoSize = true;
            this.lblSoLuongBo.Location = new System.Drawing.Point(30, 30);
            this.lblSoLuongBo.Name = "lblSoLuongBo";
            this.lblSoLuongBo.Size = new System.Drawing.Size(64, 13);
            this.lblSoLuongBo.TabIndex = 3;
            this.lblSoLuongBo.Text = "Số lượng bò";
            // 
            // lblSoLuongCuu
            // 
            this.lblSoLuongCuu.AutoSize = true;
            this.lblSoLuongCuu.Location = new System.Drawing.Point(30, 60);
            this.lblSoLuongCuu.Name = "lblSoLuongCuu";
            this.lblSoLuongCuu.Size = new System.Drawing.Size(70, 13);
            this.lblSoLuongCuu.TabIndex = 4;
            this.lblSoLuongCuu.Text = "Số lượng cừu";
            // 
            // lblSoLuongDe
            // 
            this.lblSoLuongDe.AutoSize = true;
            this.lblSoLuongDe.Location = new System.Drawing.Point(30, 90);
            this.lblSoLuongDe.Name = "lblSoLuongDe";
            this.lblSoLuongDe.Size = new System.Drawing.Size(64, 13);
            this.lblSoLuongDe.TabIndex = 5;
            this.lblSoLuongDe.Text = "Số lượng dê";
            // 
            // btnThemGiaSuc
            // 
            this.btnThemGiaSuc.Location = new System.Drawing.Point(30, 130);
            this.btnThemGiaSuc.Name = "btnThemGiaSuc";
            this.btnThemGiaSuc.Size = new System.Drawing.Size(84, 30);
            this.btnThemGiaSuc.TabIndex = 6;
            this.btnThemGiaSuc.Text = "Thêm Gia Súc";
            this.btnThemGiaSuc.UseVisualStyleBackColor = true;
            this.btnThemGiaSuc.Click += new System.EventHandler(this.btnThemGiaSuc_Click);
            // 
            // btnKeuTieng
            // 
            this.btnKeuTieng.Location = new System.Drawing.Point(120, 130);
            this.btnKeuTieng.Name = "btnKeuTieng";
            this.btnKeuTieng.Size = new System.Drawing.Size(84, 30);
            this.btnKeuTieng.TabIndex = 7;
            this.btnKeuTieng.Text = "Kêu Tiếng";
            this.btnKeuTieng.UseVisualStyleBackColor = true;
            this.btnKeuTieng.Click += new System.EventHandler(this.btnKeuTieng_Click);
            // 
            // btnSinhCon
            // 
            this.btnSinhCon.Location = new System.Drawing.Point(214, 130);
            this.btnSinhCon.Name = "btnSinhCon";
            this.btnSinhCon.Size = new System.Drawing.Size(80, 30);
            this.btnSinhCon.TabIndex = 10;
            this.btnSinhCon.Text = "Sinh Con";
            this.btnSinhCon.UseVisualStyleBackColor = true;
            this.btnSinhCon.Click += new System.EventHandler(this.btnSinhCon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(300, 130);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(80, 30);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(386, 130);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(80, 30);
            this.btnXoaTatCa.TabIndex = 9;
            this.btnXoaTatCa.Text = "Xóa Tất Cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Location = new System.Drawing.Point(30, 180);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(0, 13);
            this.lblThongTin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 250);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnKeuTieng);
            this.Controls.Add(this.btnSinhCon);
            this.Controls.Add(this.btnThemGiaSuc);
            this.Controls.Add(this.lblSoLuongDe);
            this.Controls.Add(this.lblSoLuongCuu);
            this.Controls.Add(this.lblSoLuongBo);
            this.Controls.Add(this.txtSoLuongDe);
            this.Controls.Add(this.txtSoLuongCuu);
            this.Controls.Add(this.txtSoLuongBo);
            this.Name = "Form1";
            this.Text = "Farm Management - To Vinh Tien - 22521474";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
