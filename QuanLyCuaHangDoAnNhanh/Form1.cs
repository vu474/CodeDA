using Microsoft.VisualBasic.ApplicationServices;

namespace QuanLyCuaHangDoAnNhanh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            NguoiDungBUS bus = new NguoiDungBUS();
            var nd = bus.DangNhap(user, pass);

            if (nd != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                FrmMain f = new FrmMain(nd);
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
