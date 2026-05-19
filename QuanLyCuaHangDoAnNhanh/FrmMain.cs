using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDoAnNhanh
{

    public partial class FrmMain : Form
    {

        private NguoiDung nguoiDung;
        private Form currentForm = null;

        public FrmMain(NguoiDung nd)
        {
            InitializeComponent();
            nguoiDung = nd;
        }

        private void OpenChildForm(Form f)
        {
            try
            {
                // Không mở lại nếu đã đang mở đúng form đó
                if (currentForm != null && currentForm.GetType() == f.GetType())
                    return;

                // Đóng và giải phóng form cũ
                if (currentForm != null)
                {
                    currentForm.Close();
                    currentForm.Dispose();
                    currentForm = null;
                }

                currentForm = f;

                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;

                panelContent.Controls.Clear();
                panelContent.Controls.Add(f);
                panelContent.Tag = f;

                f.BringToFront();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở form:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            if (nguoiDung == null)
            {
                MessageBox.Show(
                    "Không có thông tin người dùng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
                return;
            }

            // Hiển thị tiêu đề
            this.Text =
                "Cửa hàng đồ ăn nhanh TuanVuFood - Xin chào : "
                + nguoiDung.TenDangNhap
                + " (" + nguoiDung.VaiTro + ")";

            PhanQuyenHeThong();
            OpenChildForm(new FrmTrangChu());

        }

        private void PhanQuyenHeThong()
        {
            string role =
                nguoiDung.VaiTro.Trim().ToLower();
            bool isNhanVien = role.Contains("nhân viên") || role.Contains("nhanvien");

            // Nhân viên
            if (isNhanVien)
            {
                btnNhanVien.Visible = false;
                btnThongKe.Visible = false;
                btnNhaCC.Visible = false;
                btnKhuyenMai.Visible = false;
                btnHoaDonNhap.Visible = false;
                btnKho.Visible = false;
                btnMonAn.Visible = false;
                btnTheLoaiMon.Visible = false;

            }

            // Quản lý
            else
            {
                btnNhanVien.Visible = true;
                btnThongKe.Visible = true;
                btnNhaCC.Visible = true;
                btnKhuyenMai.Visible = true;
                btnHoaDonNhap.Visible = true;
                btnKho.Visible = true;
                btnMonAn.Visible = true;
                btnTheLoaiMon.Visible = true;
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTrangChu());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhachHang());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien());
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMonAn());
        }

        private void btnTheLoaiMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTheLoaiMon());
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhaCC());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKho());
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhuyenMai());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonNhap());
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonBan());
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatMon());
        }
    }
}
