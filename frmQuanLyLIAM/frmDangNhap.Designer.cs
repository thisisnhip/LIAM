namespace frmQuanLyLIAM
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            txtMK = new TextBox();
            txtTenDN = new TextBox();
            MatKhau = new Label();
            TenDN = new Label();
            btnDN = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMK);
            panel1.Controls.Add(txtTenDN);
            panel1.Controls.Add(MatKhau);
            panel1.Controls.Add(TenDN);
            panel1.Location = new Point(82, 43);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 181);
            panel1.TabIndex = 0;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(202, 108);
            txtMK.Margin = new Padding(4, 4, 4, 4);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(518, 31);
            txtMK.TabIndex = 2;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(202, 48);
            txtTenDN.Margin = new Padding(4, 4, 4, 4);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(518, 31);
            txtTenDN.TabIndex = 1;
            txtTenDN.TextChanged += frmDangNhap_Load;
            // 
            // MatKhau
            // 
            MatKhau.AutoSize = true;
            MatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MatKhau.Location = new Point(29, 108);
            MatKhau.Margin = new Padding(4, 0, 4, 0);
            MatKhau.Name = "MatKhau";
            MatKhau.Size = new Size(113, 30);
            MatKhau.TabIndex = 1;
            MatKhau.Text = "Mật khẩu:";
            MatKhau.Click += label1_Click_1;
            // 
            // TenDN
            // 
            TenDN.AutoSize = true;
            TenDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenDN.Location = new Point(29, 49);
            TenDN.Margin = new Padding(4, 0, 4, 0);
            TenDN.Name = "TenDN";
            TenDN.Size = new Size(165, 30);
            TenDN.TabIndex = 0;
            TenDN.Text = "Tên đăng nhập:";
            TenDN.Click += label1_Click;
            // 
            // btnDN
            // 
            btnDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDN.Location = new Point(490, 232);
            btnDN.Margin = new Padding(4, 4, 4, 4);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(154, 36);
            btnDN.TabIndex = 3;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = true;
            btnDN.Click += btnDN_click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(664, 232);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 36);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(956, 332);
            Controls.Add(btnThoat);
            Controls.Add(btnDN);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += frmDangNhap_FormClosing;
            Load += frmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TenDN;
        private Label MatKhau;
        private TextBox txtMK;
        private TextBox txtTenDN;
        private Button btnThoat;
        private Button btnDN;
      
    }
}