using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDoAnNhanh
{
    public partial class FrmNhaCC : Form
    {
        public FrmNhaCC()
        {
            InitializeComponent();
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT
                    maNhaCC         AS [Mã NCC],
                    tenNhaCC        AS [Tên NCC],
                    email           AS [Email],
                    soDienThoai     AS [Số điện thoại],
                    diaChi          AS [Địa chỉ]
                FROM NhaCungCap
                WHERE trangThai = 1
                ORDER BY maNhaCC DESC";

                dgvNhaCC.AutoGenerateColumns = true;
                dgvNhaCC.DataSource = KetNoiCSDL.GetDataTable(query);
                dgvNhaCC.Refresh();
                dgvNhaCC.ClearSelection();
                dgvNhaCC.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) 
                || string.IsNullOrWhiteSpace(txtDiaChi.Text) 
                || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !", "Thông báo");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!KiemTraEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không đúng định dạng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }
            }


            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên khách hàng và Số điện thoại!", "Thông báo");
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

            string check = "SELECT COUNT(*) FROM NhaCungCap WHERE soDienThoai = @sdt";

            int dem = Convert.ToInt32(
                KetNoiCSDL.ExecuteScalar(check,
                new SqlParameter("@sdt", txtSDT.Text.Trim()))
            );

            if (dem > 0)
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
                return;
            }

            try
            {
                string query = @"INSERT INTO NhaCungCap
                        (tenNhaCC, email, soDienThoai, diaChi, trangThai)
                        VALUES (@ten, @email, @sdt, @dc, 1)";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenNCC.Text.Trim()),
                    new SqlParameter("@email", txtEmail.Text.Trim()),
                    new SqlParameter("@sdt", txtSDT.Text.Trim()),
                    new SqlParameter("@dc", txtDiaChi.Text.Trim())
                );

                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thành công",
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
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Chọn nhà cung cấp cần sửa!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!KiemTraEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không đúng định dạng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }
            }

            try
            {
                string query = @"UPDATE NhaCungCap
                        SET tenNhaCC    = @ten,
                            email       = @email,
                            soDienThoai = @sdt,
                            diaChi      = @dc
                        WHERE maNhaCC = @id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenNCC.Text.Trim()),
                    new SqlParameter("@email", txtEmail.Text.Trim()),
                    new SqlParameter("@sdt", txtSDT.Text.Trim()),
                    new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                    new SqlParameter("@id", txtMaNCC.Text)
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
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Chọn nhà cung cấp cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá nhà cung cấp này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    string query = @"UPDATE NhaCungCap
                            SET trangThai = 0
                            WHERE maNhaCC = @id";

                    KetNoiCSDL.ExecuteNonQuery(query,
                        new SqlParameter("@id", txtMaNCC.Text));

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
        maNhaCC         AS [Mã NCC],
        tenNhaCC        AS [Tên NCC],
        email           AS [Email],
        soDienThoai     AS [Số điện thoại],
        diaChi          AS [Địa chỉ]
    FROM NhaCungCap
    WHERE (
            CAST(maNhaCC AS NVARCHAR) LIKE @tk
            OR tenNhaCC    LIKE @tk
            OR soDienThoai LIKE @tk
            OR email       LIKE @tk
            OR diaChi      LIKE @tk
          )
    AND trangThai = 1";

            dgvNhaCC.DataSource = KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void LamMoi()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTimkiem.Clear();

            txtTenNCC.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private bool KiemTraEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void dgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhaCC.Rows[e.RowIndex];

            txtMaNCC.Text = row.Cells["Mã NCC"].Value?.ToString() ?? "";
            txtTenNCC.Text = row.Cells["Tên NCC"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["Số điện thoại"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString() ?? "";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép chữ cái, khoảng trắng và phím Backspace
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
