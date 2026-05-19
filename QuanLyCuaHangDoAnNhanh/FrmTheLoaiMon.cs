using Microsoft.Data.SqlClient;
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
    public partial class FrmTheLoaiMon : Form
    {
        public FrmTheLoaiMon()
        {
            InitializeComponent();
        }

        private void FrmTheLoaiMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"SELECT
                    maLoaiMon   AS [Mã loại món],
                    tenLoaiMon  AS [Tên loại món],
                    moTa        AS [Mô tả],
                    CASE trangThai WHEN 1 THEN N'Hoạt động' ELSE N'Ngừng' END
                                AS [Trạng thái]
                FROM LoaiMon
                WHERE trangThai = 1
                ORDER BY maLoaiMon DESC";

                dgvTheLoaiMon.AutoGenerateColumns = true;
                dgvTheLoaiMon.DataSource = KetNoiCSDL.GetDataTable(query);
                dgvTheLoaiMon.Refresh();
                dgvTheLoaiMon.ClearSelection();
                dgvTheLoaiMon.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiMon.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text))
               
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo");
                return;
            }

            try
            {
                int tt = radConBan.Checked ? 1 : 0;

                string query = @"INSERT INTO LoaiMon (tenLoaiMon, moTa, trangThai)
                                 VALUES (@ten, @mota, @tt)";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenLoaiMon.Text.Trim()),
                    new SqlParameter("@mota", txtMoTa.Text.Trim()),
                    new SqlParameter("@tt", tt)
                );

                MessageBox.Show("Thêm loại món thành công!", "Thành công",
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
            if (string.IsNullOrWhiteSpace(txtMaLoaiMon.Text))
            {
                MessageBox.Show("Chọn loại món cần sửa!");
                return;
            }

            try
            {
                int tt = radConBan.Checked ? 1 : 0;

                string query = @"UPDATE LoaiMon
                                 SET tenLoaiMon = @ten,
                                     moTa       = @mota,
                                     trangThai  = @tt
                                 WHERE maLoaiMon = @id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@ten", txtTenLoaiMon.Text.Trim()),
                    new SqlParameter("@mota", txtMoTa.Text.Trim()),
                    new SqlParameter("@tt", tt),
                    new SqlParameter("@id", txtMaLoaiMon.Text)
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
            if (string.IsNullOrWhiteSpace(txtMaLoaiMon.Text))
            {
                MessageBox.Show("Chọn loại món cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá loại món này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    string query = @"UPDATE LoaiMon SET trangThai = 0
                                     WHERE maLoaiMon = @id";

                    KetNoiCSDL.ExecuteNonQuery(query,
                        new SqlParameter("@id", txtMaLoaiMon.Text));

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
            maLoaiMon   AS [Mã loại món],
            tenLoaiMon  AS [Tên loại món],
            moTa        AS [Mô tả],
            CASE 
                WHEN trangThai = 1 THEN N'Hoạt động'
                ELSE N'Ngừng'
            END AS [Trạng thái]
        FROM LoaiMon
        WHERE (
                CAST(maLoaiMon AS NVARCHAR) LIKE @tk
                OR tenLoaiMon LIKE @tk
                OR moTa LIKE @tk
                OR (
                    CASE 
                        WHEN trangThai = 1 THEN N'Hoạt động'
                        ELSE N'Ngừng'
                    END
                   ) LIKE @tk
              )
        AND trangThai = 1";

            dgvTheLoaiMon.DataSource = KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void LamMoi()
        {
            txtMaLoaiMon.Clear();
            txtTenLoaiMon.Clear();
            txtMoTa.Clear();
            txtTimkiem.Clear();

            radConBan.Checked = true;

            txtTenLoaiMon.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvTheLoaiMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTheLoaiMon.Rows[e.RowIndex];

            txtMaLoaiMon.Text = row.Cells["Mã loại món"].Value?.ToString() ?? "";
            txtTenLoaiMon.Text = row.Cells["Tên loại món"].Value?.ToString() ?? "";
            txtMoTa.Text = row.Cells["Mô tả"].Value?.ToString() ?? "";

            string tt = row.Cells["Trạng thái"].Value?.ToString() ?? "";
            radConBan.Checked = (tt == "Hoạt động");
            radNgungBan.Checked = (tt != "Hoạt động");
        }

        private void txtMaLoaiMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenLoaiMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép chữ cái, khoảng trắng và phím Backspace
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
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