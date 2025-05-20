namespace frmQuanLyLIAM
{
    partial class frmQuanLiNo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiNo));
            dgvQuanLiNo = new DataGridView();
            pnMenuKH = new Panel();
            btnKhachHang = new Button();
            btnUsers = new Button();
            lbMenu = new Label();
            pictureBox2 = new PictureBox();
            btnQuanLyNSvaNCC = new Button();
            btnBaoCao = new Button();
            btnQuanLiSP = new Button();
            btnNhapHang = new Button();
            btnTaoDonHang = new Button();
            btnTrangChu = new Button();
            tabControlQuanLyNo = new TabControl();
            tabPageTongNo = new TabPage();
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            tabPageNoChiTiet = new TabPage();
            dgvNoChiTiet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLiNo).BeginInit();
            pnMenuKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControlQuanLyNo.SuspendLayout();
            tabPageTongNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageNoChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNoChiTiet).BeginInit();
            SuspendLayout();
            // 
            // dgvQuanLiNo
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuanLiNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuanLiNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuanLiNo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuanLiNo.Location = new Point(367, 336);
            dgvQuanLiNo.Name = "dgvQuanLiNo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuanLiNo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuanLiNo.RowHeadersWidth = 62;
            dgvQuanLiNo.Size = new Size(811, 548);
            dgvQuanLiNo.TabIndex = 15;
            dgvQuanLiNo.CellContentClick += dvgQuanLiNo_CellContentClick;
            // 
            // pnMenuKH
            // 
            pnMenuKH.BackColor = SystemColors.ButtonFace;
            pnMenuKH.Controls.Add(btnKhachHang);
            pnMenuKH.Controls.Add(btnUsers);
            pnMenuKH.Controls.Add(lbMenu);
            pnMenuKH.Controls.Add(pictureBox2);
            pnMenuKH.Controls.Add(btnQuanLyNSvaNCC);
            pnMenuKH.Controls.Add(btnBaoCao);
            pnMenuKH.Controls.Add(btnQuanLiSP);
            pnMenuKH.Controls.Add(btnNhapHang);
            pnMenuKH.Controls.Add(btnTaoDonHang);
            pnMenuKH.Controls.Add(btnTrangChu);
            pnMenuKH.Dock = DockStyle.Left;
            pnMenuKH.Location = new Point(0, 0);
            pnMenuKH.Name = "pnMenuKH";
            pnMenuKH.Size = new Size(300, 1024);
            pnMenuKH.TabIndex = 16;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Font = new Font("Segoe UI", 10F);
            btnKhachHang.Location = new Point(58, 248);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(180, 50);
            btnKhachHang.TabIndex = 20;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 10F);
            btnUsers.Location = new Point(58, 883);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(180, 50);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Quản lý Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            lbMenu.AutoSize = true;
            lbMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbMenu.Location = new Point(123, 47);
            lbMenu.Margin = new Padding(4, 0, 4, 0);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(127, 48);
            lbMenu.TabIndex = 12;
            lbMenu.Text = "MENU";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnQuanLyNSvaNCC
            // 
            btnQuanLyNSvaNCC.Font = new Font("Segoe UI", 10F);
            btnQuanLyNSvaNCC.Location = new Point(58, 743);
            btnQuanLyNSvaNCC.Name = "btnQuanLyNSvaNCC";
            btnQuanLyNSvaNCC.Size = new Size(180, 91);
            btnQuanLyNSvaNCC.TabIndex = 18;
            btnQuanLyNSvaNCC.Text = "Nhân Sự \r\nNhà Cung Cấp";
            btnQuanLyNSvaNCC.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Font = new Font("Segoe UI", 10F);
            btnBaoCao.Location = new Point(58, 644);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(180, 50);
            btnBaoCao.TabIndex = 17;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnQuanLiSP
            // 
            btnQuanLiSP.Font = new Font("Segoe UI", 10F);
            btnQuanLiSP.Location = new Point(58, 539);
            btnQuanLiSP.Name = "btnQuanLiSP";
            btnQuanLiSP.Size = new Size(180, 50);
            btnQuanLiSP.TabIndex = 16;
            btnQuanLiSP.Text = "Sản Phẩm";
            btnQuanLiSP.UseVisualStyleBackColor = true;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Font = new Font("Segoe UI", 10F);
            btnNhapHang.Location = new Point(58, 446);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(180, 50);
            btnNhapHang.TabIndex = 15;
            btnNhapHang.Text = "Nhập Hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // btnTaoDonHang
            // 
            btnTaoDonHang.Font = new Font("Segoe UI", 10F);
            btnTaoDonHang.Location = new Point(58, 351);
            btnTaoDonHang.Name = "btnTaoDonHang";
            btnTaoDonHang.Size = new Size(180, 50);
            btnTaoDonHang.TabIndex = 14;
            btnTaoDonHang.Text = "Tạo Đơn Hàng";
            btnTaoDonHang.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Font = new Font("Segoe UI", 10F);
            btnTrangChu.Location = new Point(58, 155);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(180, 50);
            btnTrangChu.TabIndex = 12;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // tabControlQuanLyNo
            // 
            tabControlQuanLyNo.Controls.Add(tabPageTongNo);
            tabControlQuanLyNo.Controls.Add(tabPageNoChiTiet);
            tabControlQuanLyNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlQuanLyNo.Location = new Point(306, 12);
            tabControlQuanLyNo.Name = "tabControlQuanLyNo";
            tabControlQuanLyNo.SelectedIndex = 0;
            tabControlQuanLyNo.Size = new Size(1585, 1012);
            tabControlQuanLyNo.TabIndex = 19;
            // 
            // tabPageTongNo
            // 
            tabPageTongNo.BackColor = SystemColors.GradientInactiveCaption;
            tabPageTongNo.Controls.Add(pictureBox1);
            tabPageTongNo.Controls.Add(txtTimKiem);
            tabPageTongNo.Controls.Add(dgvQuanLiNo);
            tabPageTongNo.Location = new Point(4, 37);
            tabPageTongNo.Name = "tabPageTongNo";
            tabPageTongNo.Padding = new Padding(3);
            tabPageTongNo.Size = new Size(1577, 971);
            tabPageTongNo.TabIndex = 0;
            tabPageTongNo.Text = "Danh Sách Tổng Nợ";
            tabPageTongNo.Click += tabPageTongNo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(466, 76);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(528, 88);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(564, 34);
            txtTimKiem.TabIndex = 16;
            // 
            // tabPageNoChiTiet
            // 
            tabPageNoChiTiet.BackColor = SystemColors.GradientInactiveCaption;
            tabPageNoChiTiet.Controls.Add(dgvNoChiTiet);
            tabPageNoChiTiet.Location = new Point(4, 37);
            tabPageNoChiTiet.Name = "tabPageNoChiTiet";
            tabPageNoChiTiet.Padding = new Padding(3);
            tabPageNoChiTiet.Size = new Size(1577, 971);
            tabPageNoChiTiet.TabIndex = 1;
            tabPageNoChiTiet.Text = "Danh Sách Nợ Chi Tiết";
            // 
            // dgvNoChiTiet
            // 
            dgvNoChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoChiTiet.Location = new Point(367, 336);
            dgvNoChiTiet.Name = "dgvNoChiTiet";
            dgvNoChiTiet.RowHeadersWidth = 62;
            dgvNoChiTiet.Size = new Size(811, 548);
            dgvNoChiTiet.TabIndex = 20;
            // 
            // frmQuanLiNo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(tabControlQuanLyNo);
            Controls.Add(pnMenuKH);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmQuanLiNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyNo";
            Load += frmQuanLiNo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuanLiNo).EndInit();
            pnMenuKH.ResumeLayout(false);
            pnMenuKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControlQuanLyNo.ResumeLayout(false);
            tabPageTongNo.ResumeLayout(false);
            tabPageTongNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageNoChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNoChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvQuanLiNo;
        private Panel pnMenuKH;
        private Button btnUsers;
        private Label lbMenu;
        private PictureBox pictureBox2;
        private Button btnQuanLyNSvaNCC;
        private Button btnBaoCao;
        private Button btnQuanLiSP;
        private Button btnNhapHang;
        private Button btnTaoDonHang;
        private Button btnTrangChu;
        private TabControl tabControlQuanLyNo;
        private TabPage tabPageTongNo;
        private TabPage tabPageNoChiTiet;
        private Button btnKhachHang;
        private DataGridView dgvNoChiTiet;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
    }
}