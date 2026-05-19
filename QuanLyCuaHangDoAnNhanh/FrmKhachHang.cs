using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangDoAnNhanh
{
    public partial class FrmKhachHang : Form
    {

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT 
                maKH AS [Mã KH],
                tenKH AS [Tên khách hàng],
                gioiTinh AS [Giới tính],
                soDienThoai AS [Số điện thoại],
                diaChi AS [Địa chỉ],
                ngaySinh AS [Ngày sinh]
            FROM KhachHang 
            WHERE trangThai = 1 
            ORDER BY maKH DESC";

                DataTable dt = KetNoiCSDL.GetDataTable(query);

                dgvKhachHang.AutoGenerateColumns = true;
                dgvKhachHang.DataSource = KetNoiCSDL.GetDataTable(query);

                // Force hiển thị
                dgvKhachHang.Refresh();
                dgvKhachHang.ClearSelection();
                dgvKhachHang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text)|| string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo");
                return;
            }


            // Kiểm tra số điện thoại chỉ được nhập số
            if (!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                txtSDT.Focus();
                return;
            }

            // Kiểm tra độ dài số điện thoại
            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDT.Focus();
                return;
            }

            // KIỂM TRA TRÙNG SĐT
            string checkQuery = @"SELECT COUNT(*) 
                          FROM KhachHang
                          WHERE soDienThoai = @sdt
                          AND trangThai = 1";

            object result = KetNoiCSDL.ExecuteScalar(
                checkQuery,
                new SqlParameter("@sdt", txtSDT.Text.Trim())
            );

            int count = Convert.ToInt32(result);

            if (count > 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
                txtSDT.Focus();
                return;
            }

            try
            {
                string gt = roNam.Checked ? "Nam" : "Nữ";

                string query = @"INSERT INTO KhachHang 
                        (tenKH, gioiTinh, soDienThoai, diaChi, ngaySinh, trangThai) 
                        VALUES (@ten, @gt, @sdt, @dc, @ns, 1)";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenKH.Text.Trim()),
                    new SqlParameter("@gt", gt),
                    new SqlParameter("@sdt", txtSDT.Text.Trim()),
                    new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                    new SqlParameter("@ns", dateNamsinh.Value.Date)
                );

                MessageBox.Show("Thêm khách hàng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chọn khách hàng cần sửa!");
                return;
            }

            if (!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                txtSDT.Focus();
                return;
            }

            string gt = roNam.Checked ? "Nam" : "Nữ";

            string query = @"UPDATE KhachHang
                    SET tenKH=@ten,
                        gioiTinh=@gt,
                        soDienThoai=@sdt,
                        diaChi=@dc,
                        ngaySinh=@ns
                    WHERE maKH=@id";

            KetNoiCSDL.ExecuteNonQuery(query,
                new SqlParameter("@ten", txtTenKH.Text),
                new SqlParameter("@gt", gt),
                new SqlParameter("@sdt", txtSDT.Text),
                new SqlParameter("@dc", txtDiaChi.Text),
                new SqlParameter("@ns", dateNamsinh.Value),
                new SqlParameter("@id", txtMaKH.Text)
            );

            MessageBox.Show("Sửa thành công!");

            LoadData();
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chọn khách hàng cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                string query = @"UPDATE KhachHang
                        SET trangThai = 0
                        WHERE maKH=@id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@id", txtMaKH.Text));

                MessageBox.Show("Xóa thành công!");

                LoadData();
                LamMoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
            maKH AS [Mã KH],
            tenKH AS [Tên khách hàng],
            gioiTinh AS [Giới tính],
            soDienThoai AS [Số điện thoại],
            diaChi AS [Địa chỉ],
            ngaySinh AS [Ngày sinh]
        FROM KhachHang
        WHERE (
                tenKH LIKE @tk
                OR gioiTinh LIKE @tk
                OR soDienThoai LIKE @tk
                OR diaChi LIKE @tk
                OR CONVERT(NVARCHAR, ngaySinh, 103) LIKE @tk
              )
        AND trangThai = 1";

            dgvKhachHang.DataSource =
                KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }


        private void LamMoi()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTimkiem.Clear();

            roNam.Checked = true;
            dateNamsinh.Value = DateTime.Now;

            txtTenKH.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = row.Cells["Mã KH"].Value?.ToString() ?? "";
            txtTenKH.Text = row.Cells["Tên khách hàng"].Value?.ToString() ?? "";

            string gt = row.Cells["Giới tính"].Value?.ToString() ?? "";
            roNam.Checked = (gt == "Nam");
            roNu.Checked = (gt != "Nam");

            txtSDT.Text = row.Cells["Số điện thoại"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString() ?? "";

            var ngaySinhCell = row.Cells["Ngày sinh"].Value;
            if (ngaySinhCell != DBNull.Value && ngaySinhCell != null)
            {
                dateNamsinh.Value = Convert.ToDateTime(ngaySinhCell);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép chữ cái, khoảng trắng và phím Backspace
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }


}