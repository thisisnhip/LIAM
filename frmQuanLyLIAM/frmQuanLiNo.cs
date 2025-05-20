using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace frmQuanLyLIAM
{
    public partial class frmQuanLiNo : Form
    {
        string sCon = "Data Source=DESKTOP-U15MUJ5\\PHUONGNHI;Initial Catalog=QuanLyLIAM;Integrated Security=True;Encrypt=False";
        public frmQuanLiNo()
        {
            InitializeComponent();
        }

        private void frmQuanLiNo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối DB không thành công");
            }
            //bước 2: Lấy dữ liệu từ DB
            string sQuery1 = "SELECT K.MaKH, TenKH, DiaChi, TongTienNo, HanMuc FROM QuanLiNo Q JOIN KhachHang K ON Q.MaKH = K.MaKH";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "QuanLiNo"); 
            //bước 3: Đổ dữ liệu vào DataGridView
            dgvQuanLiNo.DataSource = ds1.Tables["QuanLiNo"];
            //bước 4: Đóng kết nối
            con.Close();
            // ===== CHỈNH KÍCH THƯỚC CỘT Ở ĐÂY =====
            dgvQuanLiNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            //dgvQuanLiNo.Columns["MaKH"].Width = 160;
            //dgvQuanLiNo.Columns["TongTienNo"].Width = 300;
            //dgvQuanLiNo.Columns["HanMuc"].Width = 260;

            foreach (DataGridViewColumn col in dgvQuanLiNo.Columns)
            {
                col.Resizable = DataGridViewTriState.False; // Không cho resize
            }

            dgvQuanLiNo.AllowUserToResizeColumns = false; // Không cho người dùng resize bằng chuột
            //NOCHITIET
            string sQuery2 = "SELECT * FROM NoChiTiet";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "NoChiTiet");
            dgvNoChiTiet.DataSource = ds2.Tables["NoChiTiet"];
            con.Close();
            dgvNoChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvNoChiTiet.Columns["SoHDB"].Width = 160;
            dgvNoChiTiet.Columns["TienNo"].Width = 180;
            dgvNoChiTiet.Columns["TrangThai"].Width = 120;
            dgvNoChiTiet.Columns["NgayTra"].Width = 260;

            foreach (DataGridViewColumn col in dgvNoChiTiet.Columns)
            {
                col.Resizable = DataGridViewTriState.False; // Không cho resize
            }

            dgvNoChiTiet.AllowUserToResizeColumns = false;

        }
        private void dvgQuanLiNo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageTongNo_Click(object sender, EventArgs e)
        {

        }
    }
}
