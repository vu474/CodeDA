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
    public partial class FrmHoaDonNhap : Form
    {
        private int _maHDN = -1;
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadCboNhanVien();
            LoadCboNhaCungCap();
            LoadCboNguyenLieu();
            LoadDanhSachHD();
            Reset();
        }

        private void LoadCboNhanVien()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(
                "SELECT maNV, tenNV FROM NhanVien WHERE trangThai=1 ORDER BY tenNV");
            cboNhanVien.DisplayMember = "tenNV";
            cboNhanVien.ValueMember = "maNV";
            cboNhanVien.DataSource = dt;
        }

        // Nhà cung cấp
        private void LoadCboNhaCungCap()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(
                "SELECT maNhaCC, tenNhaCC FROM NhaCungCap WHERE trangThai=1 ORDER BY tenNhaCC");
            cboNhaCungCap.DisplayMember = "tenNhaCC";
            cboNhaCungCap.ValueMember = "maNhaCC";
            cboNhaCungCap.DataSource = dt;
        }

        // Nguyên liệu (có thêm donVi và giaNhap để tự điền)
        private void LoadCboNguyenLieu()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(
                "SELECT maNL, tenNL, donVi, giaNhap FROM NguyenLieu WHERE trangThaiKho=1 ORDER BY tenNL");
            cboNguyenLieu.DisplayMember = "tenNL";
            cboNguyenLieu.ValueMember = "maNL";
            cboNguyenLieu.DataSource = dt;
        }

        // ════════════════════════════════════════════════════════════
        // LOAD BẢNG DANH SÁCH HÓA ĐƠN NHẬP (bên trái dưới)
        // ════════════════════════════════════════════════════════════
        private void LoadDanhSachHD()
        {
            string sql = @"
                SELECT
                    h.maHDN                         AS [Mã HDN],
                    nv.tenNV                         AS [Nhân viên],
                    ncc.tenNhaCC                     AS [Nhà cung cấp],
                    CONVERT(varchar,h.ngayNhap,103)  AS [Ngày nhập],
                    h.tongTien                       AS [Tổng tiền],
                    h.trangThai                      AS [Trạng thái]
                FROM HoaDonNhap h
                JOIN NhanVien   nv  ON h.maNV    = nv.maNV
                JOIN NhaCungCap ncc ON h.maNhaCC = ncc.maNhaCC
                ORDER BY h.maHDN DESC";

            dgvDanhSach.AutoGenerateColumns = true;
            dgvDanhSach.DataSource = KetNoiCSDL.GetDataTable(sql);
            dgvDanhSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvDanhSach.ClearSelection();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDanhSach.Rows[e.RowIndex];
            _maHDN = Convert.ToInt32(row.Cells["Mã HDN"].Value);
            txtMaHoaDon.Text = "HDN-" + _maHDN.ToString("D3");

            decimal tt = Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
            lblTongTien.Text = tt.ToString("N0") + " ₫";

            // Chọn đúng Nhân viên
            string tenNV = row.Cells["Nhân viên"].Value?.ToString() ?? "";
            foreach (DataRowView item in cboNhanVien.Items)
                if (item["tenNV"].ToString() == tenNV)
                { cboNhanVien.SelectedItem = item; break; }

            // Chọn đúng Nhà cung cấp
            string tenNCC = row.Cells["Nhà cung cấp"].Value?.ToString() ?? "";
            foreach (DataRowView item in cboNhaCungCap.Items)
                if (item["tenNhaCC"].ToString() == tenNCC)
                { cboNhaCungCap.SelectedItem = item; break; }

            LoadChiTiet(_maHDN);
        }

        private void LoadChiTiet(int maHDN)
        {
            string sql = @"
                SELECT
                    nl.maNL                     AS [Mã NL],
                    nl.tenNL                    AS [Tên nguyên liệu],
                    nl.donVi                    AS [Đơn vị],
                    ct.soLuong                  AS [Số lượng],
                    ct.donGia                   AS [Đơn giá],
                    ct.soLuong * ct.donGia      AS [Thành tiền]
                FROM ChiTietHDN ct
                JOIN NguyenLieu nl ON ct.maNL = nl.maNL
                WHERE ct.maHDN = @id";

            dgvChiTiet.AutoGenerateColumns = true;
            dgvChiTiet.DataSource = KetNoiCSDL.GetDataTable(sql,
                new SqlParameter("@id", maHDN));
            dgvChiTiet.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            TinhTongTien();
        }

        // ════════════════════════════════════════════════════════════
        // CHỌN NGUYÊN LIỆU → TỰ ĐIỀN ĐƠN VỊ + ĐƠN GIÁ
        // ════════════════════════════════════════════════════════════
        private void cboNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNguyenLieu.SelectedItem is DataRowView drv)
            {
                cboDonVi.Text = drv["donVi"].ToString();
                txtDonGia.Text = drv["giaNhap"].ToString();
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên và Nhà cung cấp!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // FIX: Dùng OUTPUT INSERTED.maHDN để lấy ID vừa tạo
                object ketQua = KetNoiCSDL.ExecuteScalar(@"
                    INSERT INTO HoaDonNhap (maNhaCC, maNV, ngayNhap, tongTien, trangThai)
                    OUTPUT INSERTED.maHDN
                    VALUES (@ncc, @nv, @ngay, 0, N'Chờ xử lý')",
                    new SqlParameter("@ncc", cboNhaCungCap.SelectedValue),
                    new SqlParameter("@nv", cboNhanVien.SelectedValue),
                    new SqlParameter("@ngay", dtpNgayNhap.Value.Date));

                if (ketQua == null || ketQua == DBNull.Value)
                {
                    MessageBox.Show("Không lấy được mã hoá đơn!", "Lỗi");
                    return;
                }

                _maHDN = Convert.ToInt32(ketQua);
                txtMaHoaDon.Text = "HDN-" + _maHDN.ToString("D3");
                lblTongTien.Text = "0 ₫";

                MessageBox.Show(
                    $"Tạo hoá đơn HDN-{_maHDN:D3} thành công!\nHãy thêm nguyên liệu vào bên phải.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachHD();
                LoadChiTiet(_maHDN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo hoá đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (_maHDN < 0)
            {
                MessageBox.Show("Vui lòng chọn hoá đơn cần sửa!", "Thông báo");
                return;
            }

            try
            {
                KetNoiCSDL.ExecuteNonQuery(@"
                    UPDATE HoaDonNhap
                    SET maNhaCC  = @ncc,
                        maNV     = @nv,
                        ngayNhap = @ngay
                    WHERE maHDN  = @id",
                    new SqlParameter("@ncc", cboNhaCungCap.SelectedValue),
                    new SqlParameter("@nv", cboNhanVien.SelectedValue),
                    new SqlParameter("@ngay", dtpNgayNhap.Value.Date),
                    new SqlParameter("@id", _maHDN));

                MessageBox.Show("Cập nhật hoá đơn thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa hoá đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (_maHDN < 0)
            {
                MessageBox.Show("Vui lòng chọn hoá đơn!", "Thông báo");
                return;
            }

            // Kiểm tra có chi tiết chưa
            int soNL = Convert.ToInt32(KetNoiCSDL.ExecuteScalar(
                "SELECT COUNT(*) FROM ChiTietHDN WHERE maHDN=@id",
                new SqlParameter("@id", _maHDN)));

            if (soNL == 0)
            {
                MessageBox.Show("Hoá đơn chưa có nguyên liệu nào!\nVui lòng thêm nguyên liệu trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                $"Xác nhận HOÀN THÀNH hoá đơn HDN-{_maHDN:D3}?\nSau đó không thể chỉnh sửa thêm.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetNoiCSDL.ExecuteNonQuery(
                    "UPDATE HoaDonNhap SET trangThai=N'Hoàn thành' WHERE maHDN=@id",
                    new SqlParameter("@id", _maHDN));

                MessageBox.Show("Hoá đơn đã hoàn thành!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachHD();
                Reset();
            }
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if (_maHDN < 0)
            {
                MessageBox.Show("Vui lòng tạo hoặc chọn hoá đơn trước!", "Thông báo");
                return;
            }

            if (!int.TryParse(nudSoLuong.Text.Trim(), out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo");
                nudSoLuong.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal dg) || dg <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương!", "Thông báo");
                txtDonGia.Focus();
                return;
            }

            string maNL = cboNguyenLieu.SelectedValue?.ToString() ?? "";
            if (string.IsNullOrEmpty(maNL))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!", "Thông báo");
                return;
            }

            try
            {
                int daTon = Convert.ToInt32(KetNoiCSDL.ExecuteScalar(
                    "SELECT COUNT(*) FROM ChiTietHDN WHERE maHDN=@hdn AND maNL=@nl",
                    new SqlParameter("@hdn", _maHDN),
                    new SqlParameter("@nl", maNL)));

                if (daTon > 0)
                {
                    if (MessageBox.Show(
                        "Nguyên liệu đã có trong hoá đơn.\nBạn có muốn cập nhật số lượng và đơn giá không?",
                        "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        KetNoiCSDL.ExecuteNonQuery(@"
                            UPDATE ChiTietHDN
                            SET soLuong=@sl, donGia=@dg
                            WHERE maHDN=@hdn AND maNL=@nl",
                            new SqlParameter("@sl", sl),
                            new SqlParameter("@dg", dg),
                            new SqlParameter("@hdn", _maHDN),
                            new SqlParameter("@nl", maNL));
                    }
                    else return;
                }
                else
                {
                    KetNoiCSDL.ExecuteNonQuery(@"
                        INSERT INTO ChiTietHDN (maHDN, maNL, soLuong, donGia)
                        VALUES (@hdn, @nl, @sl, @dg)",
                        new SqlParameter("@hdn", _maHDN),
                        new SqlParameter("@nl", maNL),
                        new SqlParameter("@sl", sl),
                        new SqlParameter("@dg", dg));
                }

                CapNhatTongTienDB();
                LoadChiTiet(_maHDN);
                LoadDanhSachHD();

                nudSoLuong.Value = 0;
                txtDonGia.Clear();
                cboNguyenLieu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nguyên liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            if (_maHDN < 0 || dgvChiTiet.CurrentRow == null) return;

            string maNL = dgvChiTiet.CurrentRow.Cells["Mã NL"].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(maNL)) return;

            if (MessageBox.Show("Xoá dòng nguyên liệu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetNoiCSDL.ExecuteNonQuery(
                    "DELETE FROM ChiTietHDN WHERE maHDN=@hdn AND maNL=@nl",
                    new SqlParameter("@hdn", _maHDN),
                    new SqlParameter("@nl", maNL));

                CapNhatTongTienDB();
                LoadChiTiet(_maHDN);
                LoadDanhSachHD();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

            if (_maHDN < 0)
            {
                MessageBox.Show("Vui lòng chọn hoá đơn cần in!", "Thông báo");
                return;
            }

            try
            {
                // Lấy thông tin HĐ
                DataTable dtHD = KetNoiCSDL.GetDataTable(@"
                    SELECT h.maHDN, nv.tenNV, ncc.tenNhaCC,
                           CONVERT(varchar,h.ngayNhap,103) AS ngayNhap,
                           h.tongTien, h.trangThai
                    FROM HoaDonNhap h
                    JOIN NhanVien nv ON h.maNV = nv.maNV
                    JOIN NhaCungCap ncc ON h.maNhaCC = ncc.maNhaCC
                    WHERE h.maHDN = @id",
                    new SqlParameter("@id", _maHDN));

                // Lấy chi tiết
                DataTable dtCT = KetNoiCSDL.GetDataTable(@"
                    SELECT nl.tenNL, nl.donVi, ct.soLuong, ct.donGia,
                           ct.soLuong * ct.donGia AS thanhTien
                    FROM ChiTietHDN ct
                    JOIN NguyenLieu nl ON ct.maNL = nl.maNL
                    WHERE ct.maHDN = @id",
                    new SqlParameter("@id", _maHDN));

                if (dtHD.Rows.Count == 0) return;

                var row = dtHD.Rows[0];
                var sb = new StringBuilder();

                sb.AppendLine("======================================");
                sb.AppendLine("       CỬA HÀNG ĐỒ ĂN NHANH GS25");
                sb.AppendLine("======================================");
                sb.AppendLine($"Mã hoá đơn  : HDN-{_maHDN:D3}");
                sb.AppendLine($"Nhân viên   : {row["tenNV"]}");
                sb.AppendLine($"Nhà cung cấp: {row["tenNhaCC"]}");
                sb.AppendLine($"Ngày nhập   : {row["ngayNhap"]}");
                sb.AppendLine($"Trạng thái  : {row["trangThai"]}");
                sb.AppendLine("--------------------------------------");
                sb.AppendLine($"{"Tên NL",-22} {"SL",5} {"Đơn giá",10} {"Thành tiền",12}");
                sb.AppendLine("--------------------------------------");

                foreach (DataRow r in dtCT.Rows)
                {
                    string ten = r["tenNL"].ToString();
                    int sl = Convert.ToInt32(r["soLuong"]);
                    decimal dg = Convert.ToDecimal(r["donGia"]);
                    decimal tt = Convert.ToDecimal(r["thanhTien"]);
                    sb.AppendLine($"{ten,-22} {sl,5} {dg,10:N0} {tt,12:N0}");
                }

                sb.AppendLine("======================================");
                sb.AppendLine($"TỔNG TIỀN: {Convert.ToDecimal(row["tongTien"]):N0} ₫");
                sb.AppendLine("======================================");

                // Lưu file
                string fileName = $"HoaDonNhap_HDN{_maHDN:D3}_{DateTime.Now:yyyyMMdd_HHmm}.txt";
                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

                MessageBox.Show($"Xuất hoá đơn thành công!\nFile lưu tại: {path}",
                    "In hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in hoá đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = KetNoiCSDL.GetDataTable(@"
                    SELECT h.maHDN, nv.tenNV, ncc.tenNhaCC,
                           CONVERT(varchar,h.ngayNhap,103) AS ngayNhap,
                           h.tongTien, h.trangThai
                    FROM HoaDonNhap h
                    JOIN NhanVien nv ON h.maNV = nv.maNV
                    JOIN NhaCungCap ncc ON h.maNhaCC = ncc.maNhaCC
                    ORDER BY h.maHDN DESC");

                var sb = new StringBuilder();
                sb.AppendLine("======================================");
                sb.AppendLine("   DANH SÁCH HOÁ ĐƠN NHẬP - GS25");
                sb.AppendLine($"   Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}");
                sb.AppendLine("======================================");
                sb.AppendLine($"{"Mã HDN",-8} {"Nhân viên",-20} {"Nhà cung cấp",-25} {"Ngày nhập",-12} {"Tổng tiền",12} {"Trạng thái"}");
                sb.AppendLine(new string('-', 90));

                foreach (DataRow r in dt.Rows)
                {
                    sb.AppendLine(
                        $"HDN-{Convert.ToInt32(r["maHDN"]):D3}  " +
                        $"{r["tenNV"],-20} " +
                        $"{r["tenNhaCC"],-25} " +
                        $"{r["ngayNhap"],-12} " +
                        $"{Convert.ToDecimal(r["tongTien"]),12:N0} " +
                        $"{r["trangThai"]}");
                }

                string fileName = $"DanhSachHDNhap_{DateTime.Now:yyyyMMdd_HHmm}.txt";
                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

                MessageBox.Show($"Xuất danh sách thành công!\nFile: {path}",
                    "Xuất DS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất DS: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            LoadDanhSachHD();
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvChiTiet.Rows[e.RowIndex];
            string maNL = row.Cells["Mã NL"].Value?.ToString() ?? "";

            foreach (DataRowView item in cboNguyenLieu.Items)
                if (item["maNL"].ToString() == maNL)
                { cboNguyenLieu.SelectedItem = item; break; }

            nudSoLuong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtDonGia.Text = row.Cells["Đơn giá"].Value?.ToString() ?? "";
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
                if (decimal.TryParse(row.Cells["Thành tiền"].Value?.ToString(), out decimal v))
                    tong += v;
            lblTongTien.Text = tong.ToString("N0") + " ₫";
        }

        // ════════════════════════════════════════════════════════════
        // HELPER: Tính lại tongTien trong DB từ ChiTietHDN
        // ════════════════════════════════════════════════════════════
        private void CapNhatTongTienDB()
        {
            KetNoiCSDL.ExecuteNonQuery(@"
                UPDATE HoaDonNhap
                SET tongTien = (
                    SELECT ISNULL(SUM(soLuong * donGia), 0)
                    FROM ChiTietHDN WHERE maHDN = @id)
                WHERE maHDN = @id",
                new SqlParameter("@id", _maHDN));
        }

        // ════════════════════════════════════════════════════════════
        // HELPER: Reset toàn bộ form về trạng thái ban đầu
        // ════════════════════════════════════════════════════════════
        private void Reset()
        {
            _maHDN = -1;
            txtMaHoaDon.Text = "";
            nudSoLuong.Text = "";
            txtDonGia.Text = "";
            txtTimKiem.Text = "";
            lblTongTien.Text = "---";        // Chưa chọn HĐ nào
            dtpNgayNhap.Value = DateTime.Today;
            dgvChiTiet.DataSource = null;     // Xóa bảng chi tiết

            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            if (cboNhaCungCap.Items.Count > 0) cboNhaCungCap.SelectedIndex = 0;
            if (cboNguyenLieu.Items.Count > 0) cboNguyenLieu.SelectedIndex = 0;

            dgvDanhSach.ClearSelection();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (_maHDN < 0) { MessageBox.Show("Chọn hoá đơn cần xoá!"); return; }

            if (MessageBox.Show($"Xoá hoá đơn HĐ-{_maHDN:D3}?\nToàn bộ chi tiết cũng bị xoá!",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    KetNoiCSDL.ExecuteNonQuery("DELETE FROM ChiTietHDN WHERE maHD=@id",
                        new SqlParameter("@id", _maHDN));
                    KetNoiCSDL.ExecuteNonQuery("DELETE FROM HoaDonNhap WHERE maHD=@id",
                        new SqlParameter("@id", _maHDN));

                    MessageBox.Show("Xoá thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHD();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text.Trim();

            dgvDanhSach.DataSource = KetNoiCSDL.GetDataTable(@"
                SELECT
                    h.maHDN                         AS [Mã HDN],
                    nv.tenNV                         AS [Nhân viên],
                    ncc.tenNhaCC                     AS [Nhà cung cấp],
                    CONVERT(varchar,h.ngayNhap,103)  AS [Ngày nhập],
                    h.tongTien                       AS [Tổng tiền],
                    h.trangThai                      AS [Trạng thái]
                FROM HoaDonNhap h
                JOIN NhanVien   nv  ON h.maNV    = nv.maNV
                JOIN NhaCungCap ncc ON h.maNhaCC = ncc.maNhaCC
                WHERE nv.tenNV              LIKE @tk
                   OR ncc.tenNhaCC          LIKE @tk
                   OR CAST(h.maHDN AS NVARCHAR) LIKE @tk
                ORDER BY h.maHDN DESC",
                new SqlParameter("@tk", "%" + tk + "%"));
        }
    }
}
