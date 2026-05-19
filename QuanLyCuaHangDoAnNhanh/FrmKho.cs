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
    public partial class FrmKho : Form
    {
        public FrmKho()
        {
            InitializeComponent();
        }

        private void FrmKho_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            LoadTenKho();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"
                SELECT
                    maNL AS [Mã nguyên liệu],
                    tenNL AS [Tên nguyên liệu],
                    donVi AS [Đơn vị],
                    soLuongTon AS [Số lượng tồn],
                    tenKho AS [Tên kho],
                    diaChiKho AS [Địa chỉ kho],
                    CASE
                        WHEN trangThaiKho = 1
                        THEN N'Đang hoạt động'
                        ELSE N'Ngừng'
                    END AS [Trạng thái]
                FROM NguyenLieu
                ORDER BY maNL DESC";

                dgvKho.DataSource =
                    KetNoiCSDL.GetDataTable(query);

                dgvKho.Refresh();
                dgvKho.ClearSelection();

                dgvKho.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void LoadDonVi()
        {
            cbDonvitinh.Items.Clear();

            cbDonvitinh.Items.Add("Kg");
            cbDonvitinh.Items.Add("Gói");
            cbDonvitinh.Items.Add("Chai");
            cbDonvitinh.Items.Add("Lon");
            cbDonvitinh.Items.Add("Cây");
            cbDonvitinh.Items.Add("Hộp");

            cbDonvitinh.SelectedIndex = 0;
        }

        private void LoadTenKho()
        {
            cbTenKho.Items.Clear();

            cbTenKho.Items.Add("Kho A");
            cbTenKho.Items.Add("Kho B");
            cbTenKho.Items.Add("Kho C");

            cbTenKho.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() == "" ||
                txtTenNL.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                string query = @"
                INSERT INTO NguyenLieu
                (
                    maNL,tenNL,donVi,soLuongTon,tenKho,diaChiKho,trangThaiKho
                  
                )
                VALUES
                (
                    @ma,
                    @ten,
                    @dv,
                    @sl,
                    @kho,
                    @dc,
                    @tt
                )";

                KetNoiCSDL.ExecuteNonQuery(query,

                    new SqlParameter("@ma",
                        txtMaNL.Text.Trim()),

                    new SqlParameter("@ten",
                        txtTenNL.Text.Trim()),

                    new SqlParameter("@dv",
                        cbDonvitinh.Text),

                    new SqlParameter("@sl",
                        nudSoLuongTon.Value),

                    new SqlParameter("@kho",
                        cbTenKho.Text),

                    new SqlParameter("@dc",
                        txtDiaChiKho.Text.Trim()),

                    new SqlParameter("@tt",
                        CbTrangThai.Checked)
                );

                MessageBox.Show(
                    "Thêm thành công!");

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Chọn dữ liệu cần sửa!");
                return;
            }

            try
            {
                string query = @"
                UPDATE NguyenLieu
                SET
                    tenNL = @ten,
                    donVi = @dv,
                    soLuongTon = @sl,
                    tenKho = @kho,
                    diaChiKho = @dc,
                    trangThaiKho = @tt
                WHERE maNL = @ma";

                KetNoiCSDL.ExecuteNonQuery(query,

                    new SqlParameter("@ma",
                        txtMaNL.Text.Trim()),

                    new SqlParameter("@ten",
                        txtTenNL.Text.Trim()),

                    new SqlParameter("@dv",
                        cbDonvitinh.Text),

                    new SqlParameter("@sl",
                        nudSoLuongTon.Value),

                    new SqlParameter("@kho",
                        cbTenKho.Text),

                    new SqlParameter("@dc",
                        txtDiaChiKho.Text.Trim()),

                    new SqlParameter("@tt",
                        CbTrangThai.Checked)
                );

                MessageBox.Show(
                    "Sửa thành công!");

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNL.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Chọn dữ liệu cần xoá!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xoá?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    string query = @"
                    DELETE FROM NguyenLieu
                    WHERE maNL = @ma";

                    KetNoiCSDL.ExecuteNonQuery(query,

                        new SqlParameter("@ma",
                            txtMaNL.Text.Trim()));

                    MessageBox.Show(
                        "Xoá thành công!");

                    LoadData();
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi xoá: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT
        maNL AS [Mã nguyên liệu],
        tenNL AS [Tên nguyên liệu],
        donVi AS [Đơn vị],
        soLuongTon AS [Số lượng tồn],
        tenKho AS [Tên kho],
        diaChiKho AS [Địa chỉ kho]
    FROM NguyenLieu
    WHERE 
        CAST(maNL AS NVARCHAR) LIKE @tk
        OR tenNL LIKE @tk
        OR donVi LIKE @tk
        OR CAST(soLuongTon AS NVARCHAR) LIKE @tk
        OR tenKho LIKE @tk
        OR diaChiKho LIKE @tk";

            dgvKho.DataSource =
                KetNoiCSDL.GetDataTable(
                    query,
                    new SqlParameter("@tk",
                    "%" + txtTimkiem.Text.Trim() + "%")
                );
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row =
                dgvKho.Rows[e.RowIndex];

            txtMaNL.Text =
                row.Cells["Mã nguyên liệu"]
                .Value.ToString();

            txtTenNL.Text =
                row.Cells["Tên nguyên liệu"]
                .Value.ToString();

            cbDonvitinh.Text =
                row.Cells["Đơn vị"]
                .Value.ToString();

            nudSoLuongTon.Value =
                Convert.ToDecimal(
                    row.Cells["Số lượng tồn"]
                    .Value);

            cbTenKho.Text =
                row.Cells["Tên kho"]
                .Value.ToString();

            txtDiaChiKho.Text =
                row.Cells["Địa chỉ kho"]
                .Value.ToString();

            string tt =
                row.Cells["Trạng thái"]
                .Value.ToString();

            CbTrangThai.Checked =
                (tt == "Đang hoạt động");
        }

        private void LamMoi()
        {
            txtMaNL.Clear();
            txtTenNL.Clear();
            txtDiaChiKho.Clear();
            txtTimkiem.Clear();

            cbDonvitinh.SelectedIndex = 0;
            cbTenKho.SelectedIndex = 0;

            nudSoLuongTon.Value = 0;

            CbTrangThai.Checked = true;

            txtMaNL.Focus();
        }

       
    }
}
