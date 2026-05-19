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
    public partial class FrmKhuyenMai : Form
    {
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }

        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadLoaiKM();
            LoadTrangThai();
            LoadMonAn();
            LoadData();
        }

        private void LoadData()
        {
            string query = @"
            SELECT 
                km.maKM AS [Mã KM],
                km.tenKM AS [Tên khuyến mãi],
                km.loaiKM AS [Loại KM],
                km.giaTriKM AS [Giá trị],
                km.ngayBatDau AS [Ngày bắt đầu],
                km.ngayKetThuc AS [Ngày kết thúc],
                ISNULL(ma.tenMonAn, N'Tất cả món') AS [Món áp dụng],
                CASE 
                    WHEN km.trangThai = 1 THEN N'Hoạt động'
                    ELSE N'Ngừng'
                END AS [Trạng thái]
            FROM KhuyenMai km
            LEFT JOIN MonAn ma
                ON km.maMonAn = ma.maMonAn
            WHERE km.trangThai = 1
            ORDER BY km.maKM DESC";

            dgvKhuyenMai.AutoGenerateColumns = true;
            dgvKhuyenMai.DataSource = KetNoiCSDL.GetDataTable(query);

            dgvKhuyenMai.Refresh();
            dgvKhuyenMai.ClearSelection();
            dgvKhuyenMai.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadLoaiKM()
        {
            cboLoaiKM.Items.Clear();

            cboLoaiKM.Items.Add("PhanTram");
            cboLoaiKM.Items.Add("SoTienCoDinh");

            cboLoaiKM.SelectedIndex = 0;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Ngừng");

            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadMonAn()
        {
            string query = @"
    SELECT maMonAn, tenMonAn
    FROM MonAn
    WHERE trangThai = 1";

            DataTable dt = KetNoiCSDL.GetDataTable(query);

            // THÊM DÒNG TẤT CẢ MÓN
            DataRow row = dt.NewRow();

            row["maMonAn"] = DBNull.Value;
            row["tenMonAn"] = "Tất cả món";

            dt.Rows.InsertAt(row, 0);

            cbMonAn.DataSource = dt;
            cbMonAn.DisplayMember = "tenMonAn";
            cbMonAn.ValueMember = "maMonAn";

            cbMonAn.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKM.Text) || string.IsNullOrWhiteSpace(txtGiaTri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !", "Thông báo");
                return;
            }

            if (txtGiaTri.Text.Trim() == "")
            {
                MessageBox.Show("Nhập giá trị khuyến mãi!");
                txtGiaTri.Focus();
                return;
            }

            if (dtpKetThuc.Value < dtpBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                return;
            }

            string query = @"
            INSERT INTO KhuyenMai
            (
                tenKM,
                loaiKM,
                giaTriKM,
                ngayBatDau,
                ngayKetThuc,
                trangThai,
                maMonAn
            )
            VALUES
            (
                @ten,
                @loai,
                @giaTri,
                @bd,
                @kt,
                @tt,
                @maMon
            )";

            int tt = cboTrangThai.Text == "Hoạt động" ? 1 : 0;

            KetNoiCSDL.ExecuteNonQuery(query,
                new SqlParameter("@ten", txtTenKM.Text),
                new SqlParameter("@loai", cboLoaiKM.Text),
                new SqlParameter("@giaTri", txtGiaTri.Text),
                new SqlParameter("@bd", dtpBatDau.Value),
                new SqlParameter("@kt", dtpKetThuc.Value),
                new SqlParameter("@tt", tt),
               new SqlParameter(
                 "@maMon",
                  cbMonAn.SelectedValue == DBNull.Value
                ? DBNull.Value
        : cbMonAn.SelectedValue));

            MessageBox.Show("Thêm thành công!");

            LoadData();
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Chọn khuyến mãi cần sửa!");
                return;
            }

            string query = @"
            UPDATE KhuyenMai
            SET
                tenKM = @ten,
                loaiKM = @loai,
                giaTriKM = @giaTri,
                ngayBatDau = @bd,
                ngayKetThuc = @kt,
                trangThai = @tt,
                maMonAn = @maMon
            WHERE maKM = @id";

            int tt = cboTrangThai.Text == "Hoạt động" ? 1 : 0;

            KetNoiCSDL.ExecuteNonQuery(query,
                new SqlParameter("@ten", txtTenKM.Text),
                new SqlParameter("@loai", cboLoaiKM.Text),
                new SqlParameter("@giaTri", txtGiaTri.Text),
                new SqlParameter("@bd", dtpBatDau.Value),
                new SqlParameter("@kt", dtpKetThuc.Value),
                new SqlParameter("@tt", tt),
                new SqlParameter(
                "@maMon",
                cbMonAn.SelectedValue == DBNull.Value
              ? DBNull.Value
        :       cbMonAn.SelectedValue),
                new SqlParameter("@id", txtMaKM.Text)
            );

            MessageBox.Show("Sửa thành công!");

            LoadData();
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                string query = @"
                UPDATE KhuyenMai
                SET trangThai = 0
                WHERE maKM = @id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@id", txtMaKM.Text));

                MessageBox.Show("Xoá thành công!");

                LoadData();
                LamMoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT 
        km.maKM             AS [Mã KM],
        km.tenKM            AS [Tên khuyến mãi],
        km.loaiKM           AS [Loại KM],
        km.giaTriKM         AS [Giá trị],
        km.ngayBatDau       AS [Ngày bắt đầu],
        km.ngayKetThuc      AS [Ngày kết thúc],
        ISNULL(ma.tenMonAn, N'Tất cả món') AS [Món áp dụng],
        CASE 
            WHEN km.trangThai = 1 THEN N'Hoạt động'
            ELSE N'Ngừng'
        END AS [Trạng thái]

    FROM KhuyenMai km

    LEFT JOIN MonAn ma 
        ON km.maMonAn = ma.maMonAn

    WHERE
        (
            CAST(km.maKM AS NVARCHAR) LIKE @tk
            OR km.tenKM LIKE @tk
            OR km.loaiKM LIKE @tk
            OR CAST(km.giaTriKM AS NVARCHAR) LIKE @tk
            OR CONVERT(NVARCHAR, km.ngayBatDau, 103) LIKE @tk
            OR CONVERT(NVARCHAR, km.ngayKetThuc, 103) LIKE @tk
            OR ISNULL(ma.tenMonAn, N'Tất cả món') LIKE @tk
            OR (
                CASE 
                    WHEN km.trangThai = 1 THEN N'Hoạt động'
                    ELSE N'Ngừng'
                END
               ) LIKE @tk
        )";

            dgvKhuyenMai.DataSource =
                KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }

        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row =
                dgvKhuyenMai.Rows[e.RowIndex];

            txtMaKM.Text =
                row.Cells["Mã KM"].Value.ToString();

            txtTenKM.Text =
                row.Cells["Tên khuyến mãi"].Value.ToString();

            cboLoaiKM.Text =
                row.Cells["Loại KM"].Value.ToString();

            txtGiaTri.Text =
                row.Cells["Giá trị"].Value.ToString();

            dtpBatDau.Value =
                Convert.ToDateTime(
                    row.Cells["Ngày bắt đầu"].Value);

            dtpKetThuc.Value =
                Convert.ToDateTime(
                    row.Cells["Ngày kết thúc"].Value);

            cboTrangThai.Text =
                row.Cells["Trạng thái"].Value.ToString();
            string tenMon =
    row.Cells["Món áp dụng"].Value.ToString();

            cbMonAn.Text = tenMon;
        }

        private void LamMoi()
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtGiaTri.Clear();
            txtTimkiem.Clear();

            cboLoaiKM.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;

            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
