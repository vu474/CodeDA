using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT 
                    maNV            AS [Mã NV],
                    tenNV           AS [Tên nhân viên],
                    gioiTinh        AS [Giới tính],
                    soDienThoai     AS [Số điện thoại],
                    diaChi          AS [Địa chỉ],
                    ngaySinh        AS [Ngày sinh]
                FROM NhanVien
                WHERE trangThai = 1
                ORDER BY maNV DESC";

                DataTable dt = KetNoiCSDL.GetDataTable(query);

                dgvNhanVien.AutoGenerateColumns = true;
                dgvNhanVien.DataSource = KetNoiCSDL.GetDataTable(query);

                dgvNhanVien.Refresh();
                dgvNhanVien.ClearSelection();
                dgvNhanVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))

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
                          FROM NhanVien
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

                string query = @"INSERT INTO NhanVien
                        (tenNV, gioiTinh, soDienThoai, diaChi, ngaySinh, trangThai)
                        VALUES (@ten, @gt, @sdt, @dc,  @ns, 1)";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenNV.Text.Trim()),
                    new SqlParameter("@gt", gt),
                    new SqlParameter("@sdt", txtSDT.Text.Trim()),
                    new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                    new SqlParameter("@ns", dateNamsinh.Value.Date)
                );

                MessageBox.Show("Thêm nhân viên thành công!", "Thành công",
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
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chọn nhân viên cần sửa!");
                return;
            }

            if (!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                txtSDT.Focus();
                return;
            }

            string checkQuery = @"SELECT COUNT(*)
                      FROM NhanVien
                      WHERE soDienThoai = @sdt
                      AND maNV <> @id
                      AND trangThai = 1";

            object result = KetNoiCSDL.ExecuteScalar(
                checkQuery,
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@id", txtMaNV.Text)
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

                string query = @"UPDATE NhanVien
                        SET tenNV        = @ten,
                            gioiTinh    = @gt,
                            soDienThoai = @sdt,
                            diaChi      = @dc,
                            ngaySinh    = @ns
                        WHERE maNV = @id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenNV.Text.Trim()),
                    new SqlParameter("@gt", gt),
                    new SqlParameter("@sdt", txtSDT.Text.Trim()),
                    new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                    new SqlParameter("@ns", dateNamsinh.Value.Date),
                    new SqlParameter("@id", txtMaNV.Text)
                );

                MessageBox.Show("Sửa thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chọn nhân viên cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá nhân viên này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    string query = @"UPDATE NhanVien
                            SET trangThai = 0
                            WHERE maNV = @id";

                    KetNoiCSDL.ExecuteNonQuery(query,
                        new SqlParameter("@id", txtMaNV.Text));

                    MessageBox.Show("Xoá thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
            maNV        AS [Mã NV],
            tenNV       AS [Tên nhân viên],
            gioiTinh    AS [Giới tính],
            soDienThoai AS [Số điện thoại],
            diaChi      AS [Địa chỉ],
            ngaySinh    AS [Ngày sinh]
        FROM NhanVien
        WHERE (
                tenNV LIKE @tk
                OR gioiTinh LIKE @tk
                OR soDienThoai LIKE @tk
                OR diaChi LIKE @tk
                OR CONVERT(NVARCHAR, ngaySinh, 103) LIKE @tk
              )
        AND trangThai = 1";

            dgvNhanVien.DataSource =
                KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void LamMoi()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTimkiem.Clear();

            roNam.Checked = true;
            dateNamsinh.Value = DateTime.Now;

            txtTenNV.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["Mã NV"].Value?.ToString() ?? "";
            txtTenNV.Text = row.Cells["Tên nhân viên"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["Số điện thoại"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString() ?? "";

            string gt = row.Cells["Giới tính"].Value?.ToString() ?? "";
            roNam.Checked = (gt == "Nam");
            roNu.Checked = (gt != "Nam");

            var ns = row.Cells["Ngày sinh"].Value;
            if (ns != DBNull.Value && ns != null)
                dateNamsinh.Value = Convert.ToDateTime(ns);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép chữ cái, khoảng trắng và phím Backspace
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
