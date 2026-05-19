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
    public partial class FrmHoaDonBan : Form
    {
        private int _maHD = -1; // Mã HĐ đang chọn, -1 = chưa chọn
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }

        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {

            LoadCboNhanVien();
            LoadCboKhachHang();
            LoadCboKhuyenMai();
            LoadCboMonAn();
            LoadDanhSachHD();
            Reset();
        }


        // 1. Nhân viên lập hóa đơn
        private void LoadCboNhanVien()
        {
            var dt = KetNoiCSDL.GetDataTable(
                "SELECT maNV, tenNV FROM NhanVien WHERE trangThai=1 ORDER BY tenNV");
            cboNhanVien.DisplayMember = "tenNV";
            cboNhanVien.ValueMember = "maNV";
            cboNhanVien.DataSource = dt;
        }

        // 2. Khách hàng (có thêm dòng "Khách vãng lai" ở đầu)
        private void LoadCboKhachHang()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(@"
                SELECT 0 AS maKH, N'-- Khách lẻ --' AS tenKH
                UNION ALL
                SELECT maKH, tenKH + N' - ' + ISNULL(soDienThoai,'')
                FROM KhachHang WHERE trangThai=1 ORDER BY maKH");
            cboKhachHang.DisplayMember = "tenKH";
            cboKhachHang.ValueMember = "maKH";
            cboKhachHang.DataSource = dt;
        }

        // 3. Khuyến mãi (chỉ lấy KM còn hiệu lực)
        private void LoadCboKhuyenMai()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(@"
                SELECT 0 AS maKM, N'-- Không có --' AS tenKM,
                       CAST(0 AS DECIMAL(18,0)) AS giaTriKM, N'' AS loaiKM
                UNION ALL
                SELECT maKM, tenKM, giaTriKM, loaiKM FROM KhuyenMai
                WHERE trangThai=1 AND GETDATE() BETWEEN ngayBatDau AND ngayKetThuc
                ORDER BY maKM");
            cboKhuyenMai.DisplayMember = "tenKM";
            cboKhuyenMai.ValueMember = "maKM";
            cboKhuyenMai.DataSource = dt;
        }

        // 4. Món ăn (lấy giaBan để tự điền đơn giá)
        private void LoadCboMonAn()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(
                "SELECT maMonAn, tenMonAn, giaBan FROM MonAn WHERE trangThai=1 ORDER BY tenMonAn");
            cboMonAn.DisplayMember = "tenMonAn";
            cboMonAn.ValueMember = "maMonAn";
            cboMonAn.DataSource = dt;
        }

        private void cboMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedItem is DataRowView drv)
                txtDonGia.Text = drv["giaBan"].ToString();
        }

        // ── CHỌN KM → HIỆN GIÁ TRỊ + TÍNH LẠI ─────────────────────────────
        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhuyenMai.SelectedItem is DataRowView drv)
            {
                string loai = drv["loaiKM"].ToString();
                decimal gt = Convert.ToDecimal(drv["giaTriKM"]);
                txtGiaTriKM.Text = loai == "PhanTram" ? gt + "%" :
                                   loai == "SoTienCoDinh" ? gt.ToString("N0") + " ₫" : "";
            }
            TinhTongTien();
        }

        private void LoadDanhSachHD()
        {
            string sql = @"
                SELECT h.maHD                              AS [Mã HĐ],
                       ISNULL(kh.tenKH, N'Khách lẻ')      AS [Khách hàng],
                       nv.tenNV                            AS [Nhân viên],
                       ISNULL(km.tenKM, N'Không có')       AS [Khuyến mãi],
                       CONVERT(varchar,h.ngayLap,103)      AS [Ngày lập],
                       h.tongTien                          AS [Tổng tiền],
                       h.trangThai                         AS [Trạng thái]
                FROM HoaDonBan h
                JOIN NhanVien nv        ON h.maNV = nv.maNV
                LEFT JOIN KhachHang kh  ON h.maKH = kh.maKH
                LEFT JOIN KhuyenMai km  ON h.maKM = km.maKM
                ORDER BY h.maHD DESC";

            dgvDanhSach.AutoGenerateColumns = true;
            dgvDanhSach.DataSource = KetNoiCSDL.GetDataTable(sql);
            dgvDanhSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvDanhSach.ClearSelection();
        }

        // LOAD BẢNG CHI TIẾT MÓN ĂN THEO HĐ ĐANG CHỌN

        private void LoadChiTiet(int maHD)
        {
            dgvChiTiet.AutoGenerateColumns = true;
            dgvChiTiet.DataSource = KetNoiCSDL.GetDataTable(@"
                SELECT ct.maMonAn                   AS [Mã Món],
                       m.tenMonAn                   AS [Tên món ăn],
                       ct.soLuong                   AS [Số lượng],
                       ct.donGia                    AS [Đơn giá],
                       ct.soLuong * ct.donGia       AS [Thành tiền]
                FROM ChiTietHDB ct
                JOIN MonAn m ON ct.maMonAn = m.maMonAn
                WHERE ct.maHD = @id",
                new SqlParameter("@id", maHD));
            dgvChiTiet.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            TinhTongTien();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDanhSach.Rows[e.RowIndex];
            _maHD = Convert.ToInt32(row.Cells["Mã HĐ"].Value);
            txtMaHoaDon.Text = "HĐ-" + _maHD.ToString("D3");

            string tenNV = row.Cells["Nhân viên"].Value?.ToString() ?? "";
            string tenKH = row.Cells["Khách hàng"].Value?.ToString() ?? "";
            string tenKM = row.Cells["Khuyến mãi"].Value?.ToString() ?? "";

            foreach (DataRowView item in cboNhanVien.Items)
                if (item["tenNV"].ToString() == tenNV) { cboNhanVien.SelectedItem = item; break; }

            foreach (DataRowView item in cboKhachHang.Items)
                if (item["tenKH"].ToString().Contains(tenKH)) { cboKhachHang.SelectedItem = item; break; }

            foreach (DataRowView item in cboKhuyenMai.Items)
                if (item["tenKM"].ToString() == tenKM) { cboKhuyenMai.SelectedItem = item; break; }

            LoadChiTiet(_maHD);
        }

        private void cboTenMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedItem is DataRowView drv)
                txtDonGia.Text = drv["giaBan"].ToString();
        }

        // ════════════════════════════════════════════════════════════
        // CHỌN KHUYẾN MÃI → Tính lại tổng tiền + hiện giá trị KM
        // ════════════════════════════════════════════════════════════

        private void btnThemHD_Click(object sender, EventArgs e)
        {

            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                int maKH = Convert.ToInt32(cboKhachHang.SelectedValue ?? 0);
                int maKM = Convert.ToInt32(cboKhuyenMai.SelectedValue ?? 0);

                object ketQua = KetNoiCSDL.ExecuteScalar(@"
                    INSERT INTO HoaDonBan (maKH, maKM, maNV, ngayLap, tongTien, trangThai)
                    OUTPUT INSERTED.maHD
                    VALUES (@maKH, @maKM, @maNV, GETDATE(), 0, N'Chờ xử lý')",
                    new SqlParameter("@maKH", maKH > 0 ? (object)maKH : DBNull.Value),
                    new SqlParameter("@maKM", maKM > 0 ? (object)maKM : DBNull.Value),
                    new SqlParameter("@maNV", maNV));

                _maHD = Convert.ToInt32(ketQua);
                txtMaHoaDon.Text = "HĐ-" + _maHD.ToString("D3");
                lblTongTien.Text = "0 ₫";

                MessageBox.Show($"Tạo hoá đơn HĐ-{_maHD:D3} thành công!\nHãy thêm món ăn vào bên phải.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachHD();
                LoadChiTiet(_maHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo hoá đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (_maHD < 0) { MessageBox.Show("Chọn hoá đơn cần sửa!"); return; }

            try
            {
                int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                int maKH = Convert.ToInt32(cboKhachHang.SelectedValue ?? 0);
                int maKM = Convert.ToInt32(cboKhuyenMai.SelectedValue ?? 0);

                KetNoiCSDL.ExecuteNonQuery(@"
                    UPDATE HoaDonBan SET maNV=@maNV, maKH=@maKH, maKM=@maKM WHERE maHD=@id",
                    new SqlParameter("@maNV", maNV),
                    new SqlParameter("@maKH", maKH > 0 ? (object)maKH : DBNull.Value),
                    new SqlParameter("@maKM", maKM > 0 ? (object)maKM : DBNull.Value),
                    new SqlParameter("@id", _maHD));

                CapNhatTongTienDB();
                MessageBox.Show("Cập nhật thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (_maHD < 0) { MessageBox.Show("Tạo hoặc chọn hoá đơn trước!"); return; }

            if (!int.TryParse(nudSoLuong.Text.Trim(), out int sl) || sl <= 0)
            { MessageBox.Show("Số lượng phải là số nguyên dương!"); nudSoLuong.Focus(); return; }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal dg) || dg <= 0)
            { MessageBox.Show("Đơn giá phải là số dương!"); txtDonGia.Focus(); return; }

            if (cboMonAn.SelectedValue == null) { MessageBox.Show("Chọn món ăn!"); return; }

            int maMonAn = Convert.ToInt32(cboMonAn.SelectedValue);

            try
            {
                int daTon = Convert.ToInt32(KetNoiCSDL.ExecuteScalar(
                    "SELECT COUNT(*) FROM ChiTietHDB WHERE maHD=@hd AND maMonAn=@mon",
                    new SqlParameter("@hd", _maHD),
                    new SqlParameter("@mon", maMonAn)));

                if (daTon > 0)
                {
                    if (MessageBox.Show("Món đã có. Cập nhật số lượng và đơn giá?",
                        "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        KetNoiCSDL.ExecuteNonQuery(@"
                            UPDATE ChiTietHDB SET soLuong=@sl, donGia=@dg
                            WHERE maHD=@hd AND maMonAn=@mon",
                            new SqlParameter("@sl", sl),
                            new SqlParameter("@dg", dg),
                            new SqlParameter("@hd", _maHD),
                            new SqlParameter("@mon", maMonAn));
                    }
                    else return;
                }
                else
                {
                    KetNoiCSDL.ExecuteNonQuery(@"
                        INSERT INTO ChiTietHDB (maHD, maMonAn, soLuong, donGia)
                        VALUES (@hd, @mon, @sl, @dg)",
                        new SqlParameter("@hd", _maHD),
                        new SqlParameter("@mon", maMonAn),
                        new SqlParameter("@sl", sl),
                        new SqlParameter("@dg", dg));
                }

                CapNhatTongTienDB();
                LoadChiTiet(_maHD);
                LoadDanhSachHD();

                nudSoLuong.Value = 0; 
                cboMonAn.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (_maHD < 0 || dgvChiTiet.CurrentRow == null) return;

            int maMonAn = Convert.ToInt32(dgvChiTiet.CurrentRow.Cells["Mã Món"].Value);

            if (MessageBox.Show("Xoá món này khỏi hoá đơn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetNoiCSDL.ExecuteNonQuery(
                    "DELETE FROM ChiTietHDB WHERE maHD=@hd AND maMonAn=@mon",
                    new SqlParameter("@hd", _maHD),
                    new SqlParameter("@mon", maMonAn));

                CapNhatTongTienDB();
                LoadChiTiet(_maHD);
                LoadDanhSachHD();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (_maHD < 0) { MessageBox.Show("Chọn hoá đơn cần xoá!"); return; }

            if (MessageBox.Show($"Xoá hoá đơn HĐ-{_maHD:D3}?\nToàn bộ chi tiết cũng bị xoá!",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    KetNoiCSDL.ExecuteNonQuery("DELETE FROM ChiTietHDB WHERE maHD=@id",
                        new SqlParameter("@id", _maHD));
                    KetNoiCSDL.ExecuteNonQuery("DELETE FROM HoaDonBan WHERE maHD=@id",
                        new SqlParameter("@id", _maHD));

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

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (_maHD < 0) { MessageBox.Show("Chọn hoá đơn!"); return; }

            int soMon = Convert.ToInt32(KetNoiCSDL.ExecuteScalar(
                "SELECT COUNT(*) FROM ChiTietHDB WHERE maHD=@id",
                new SqlParameter("@id", _maHD)));

            if (soMon == 0)
            {
                MessageBox.Show("Chưa có món ăn nào! Vui lòng thêm món trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận HOÀN THÀNH hoá đơn HĐ-{_maHD:D3}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CapNhatTongTienDB();
                KetNoiCSDL.ExecuteNonQuery(
                    "UPDATE HoaDonBan SET trangThai=N'Hoàn thành' WHERE maHD=@id",
                    new SqlParameter("@id", _maHD));

                MessageBox.Show("Hoá đơn đã hoàn thành!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHD();
                Reset();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            dgvDanhSach.DataSource = KetNoiCSDL.GetDataTable(@"
                SELECT h.maHD                              AS [Mã HĐ],
                       ISNULL(kh.tenKH, N'Khách lẻ')      AS [Khách hàng],
                       nv.tenNV                            AS [Nhân viên],
                       ISNULL(km.tenKM, N'Không có')       AS [Khuyến mãi],
                       CONVERT(varchar,h.ngayLap,103)      AS [Ngày lập],
                       h.tongTien                          AS [Tổng tiền],
                       h.trangThai                         AS [Trạng thái]
                FROM HoaDonBan h
                JOIN NhanVien nv       ON h.maNV = nv.maNV
                LEFT JOIN KhachHang kh ON h.maKH = kh.maKH
                LEFT JOIN KhuyenMai km ON h.maKM = km.maKM
                WHERE nv.tenNV              LIKE @tk
                   OR ISNULL(kh.tenKH,'')  LIKE @tk
                   OR CAST(h.maHD AS NVARCHAR) LIKE @tk
                ORDER BY h.maHD DESC",
                new SqlParameter("@tk", "%" + txtTimKiem.Text.Trim() + "%"));
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            LoadDanhSachHD();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (_maHD < 0) { MessageBox.Show("Chọn hoá đơn cần in!"); return; }

            try
            {
                DataTable dtHD = KetNoiCSDL.GetDataTable(@"
                    SELECT h.maHD, nv.tenNV,
                           ISNULL(kh.tenKH,N'Khách lẻ')  AS tenKH,
                           ISNULL(km.tenKM,N'Không có')   AS tenKM,
                           ISNULL(km.giaTriKM,0)          AS giaTriKM,
                           ISNULL(km.loaiKM,'')           AS loaiKM,
                           CONVERT(varchar,h.ngayLap,103) AS ngayLap,
                           h.tongTien, h.trangThai
                    FROM HoaDonBan h
                    JOIN NhanVien nv       ON h.maNV = nv.maNV
                    LEFT JOIN KhachHang kh ON h.maKH = kh.maKH
                    LEFT JOIN KhuyenMai km ON h.maKM = km.maKM
                    WHERE h.maHD = @id",
                    new SqlParameter("@id", _maHD));

                DataTable dtCT = KetNoiCSDL.GetDataTable(@"
                    SELECT m.tenMonAn, ct.soLuong, ct.donGia,
                           ct.soLuong*ct.donGia AS thanhTien
                    FROM ChiTietHDB ct
                    JOIN MonAn m ON ct.maMonAn = m.maMonAn
                    WHERE ct.maHD = @id",
                    new SqlParameter("@id", _maHD));

                if (dtHD.Rows.Count == 0) return;
                var r = dtHD.Rows[0];
                var sb = new StringBuilder();

                sb.AppendLine("======================================");
                sb.AppendLine("      CỬA HÀNG ĐỒ ĂN NHANH GS25");
                sb.AppendLine("======================================");
                sb.AppendLine($"Mã hoá đơn : HĐ-{_maHD:D3}");
                sb.AppendLine($"Nhân viên  : {r["tenNV"]}");
                sb.AppendLine($"Khách hàng : {r["tenKH"]}");
                sb.AppendLine($"Khuyến mãi : {r["tenKM"]}");
                sb.AppendLine($"Ngày lập   : {r["ngayLap"]}");
                sb.AppendLine($"Trạng thái : {r["trangThai"]}");
                sb.AppendLine("--------------------------------------");
                sb.AppendLine($"{"Tên món",-22} {"SL",4} {"Đơn giá",10} {"Thành tiền",12}");
                sb.AppendLine("--------------------------------------");

                decimal tongCong = 0;
                foreach (DataRow ct in dtCT.Rows)
                {
                    decimal tt = Convert.ToDecimal(ct["thanhTien"]);
                    tongCong += tt;
                    sb.AppendLine(
                        $"{ct["tenMonAn"],-22} " +
                        $"{Convert.ToInt32(ct["soLuong"]),4} " +
                        $"{Convert.ToDecimal(ct["donGia"]),10:N0} " +
                        $"{tt,12:N0}");
                }

                decimal giamGia = 0;
                string loaiKM = r["loaiKM"].ToString();
                decimal gtKM = Convert.ToDecimal(r["giaTriKM"]);
                if (loaiKM == "PhanTram") giamGia = tongCong * gtKM / 100;
                else if (loaiKM == "SoTienCoDinh") giamGia = gtKM;

                sb.AppendLine("--------------------------------------");
                sb.AppendLine($"{"Tổng cộng:",-30} {tongCong,12:N0} ₫");
                if (giamGia > 0)
                    sb.AppendLine($"{"Giảm giá:",-30} -{giamGia,11:N0} ₫");
                sb.AppendLine($"{"THANH TOÁN:",-30} {(tongCong - giamGia),12:N0} ₫");
                sb.AppendLine("======================================");
                sb.AppendLine("       Cảm ơn quý khách! GS25");
                sb.AppendLine("======================================");

                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"HoaDonBan_HD{_maHD:D3}_{DateTime.Now:yyyyMMdd_HHmm}.txt");

                File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
                MessageBox.Show($"In hoá đơn thành công!\nFile lưu tại Desktop.",
                    "In hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = KetNoiCSDL.GetDataTable(@"
                    SELECT h.maHD,
                           ISNULL(kh.tenKH,N'Khách lẻ')  AS tenKH,
                           nv.tenNV,
                           CONVERT(varchar,h.ngayLap,103) AS ngayLap,
                           h.tongTien, h.trangThai
                    FROM HoaDonBan h
                    JOIN NhanVien nv       ON h.maNV = nv.maNV
                    LEFT JOIN KhachHang kh ON h.maKH = kh.maKH
                    ORDER BY h.maHD DESC");

                var sb = new StringBuilder();
                sb.AppendLine("==========================================");
                sb.AppendLine("    DANH SÁCH HOÁ ĐƠN BÁN - GS25");
                sb.AppendLine($"    Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}");
                sb.AppendLine("==========================================");
                sb.AppendLine($"{"Mã HĐ",-8} {"Khách hàng",-22} {"Nhân viên",-20} {"Ngày lập",-12} {"Tổng tiền",12} Trạng thái");
                sb.AppendLine(new string('-', 90));

                foreach (DataRow r in dt.Rows)
                    sb.AppendLine(
                        $"HĐ-{Convert.ToInt32(r["maHD"]):D3}  " +
                        $"{r["tenKH"],-22} {r["tenNV"],-20} " +
                        $"{r["ngayLap"],-12} " +
                        $"{Convert.ToDecimal(r["tongTien"]),12:N0} {r["trangThai"]}");

                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"DanhSachHDBan_{DateTime.Now:yyyyMMdd_HHmm}.txt");

                File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất danh sách thành công!\nFile lưu tại Desktop.",
                    "Xuất DS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            var row = dgvChiTiet.Rows[e.RowIndex];
            int maMonAn = Convert.ToInt32(row.Cells["Mã Món"].Value);

            foreach (DataRowView item in cboMonAn.Items)
                if (Convert.ToInt32(item["maMonAn"]) == maMonAn) { cboMonAn.SelectedItem = item; break; }

            txtDonGia.Text = row.Cells["Đơn giá"].Value?.ToString() ?? "";
            nudSoLuong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
        }

        private void TinhTongTien()
        {
            decimal tongCong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
                if (decimal.TryParse(row.Cells["Thành tiền"].Value?.ToString(), out decimal v))
                    tongCong += v;

            decimal giamGia = 0;
            if (cboKhuyenMai.SelectedItem is DataRowView drv)
            {
                string loai = drv["loaiKM"].ToString();
                decimal gt = Convert.ToDecimal(drv["giaTriKM"]);
                if (loai == "PhanTram") giamGia = tongCong * gt / 100;
                else if (loai == "SoTienCoDinh") giamGia = gt;
            }

            lblTongTien.Text =
                $"Tổng: {tongCong:N0} ₫   Giảm: {giamGia:N0} ₫   Thanh toán: {(tongCong - giamGia):N0} ₫";
        }

        // ════════════════════════════════════════════════════════════
        // HELPER: Lưu tongTien vào DB (tính lại từ ChiTietHDB + KM)
        // ════════════════════════════════════════════════════════════
        private void CapNhatTongTienDB()
        {

            if (_maHD < 0) return;

            object tongObj = KetNoiCSDL.ExecuteScalar(
                "SELECT ISNULL(SUM(soLuong*donGia),0) FROM ChiTietHDB WHERE maHD=@id",
                new SqlParameter("@id", _maHD));
            decimal tong = Convert.ToDecimal(tongObj);

            decimal giamGia = 0;
            if (cboKhuyenMai.SelectedItem is DataRowView drv)
            {
                string loai = drv["loaiKM"].ToString();
                decimal gt = Convert.ToDecimal(drv["giaTriKM"]);
                if (loai == "PhanTram") giamGia = tong * gt / 100;
                else if (loai == "SoTienCoDinh") giamGia = gt;
            }

            KetNoiCSDL.ExecuteNonQuery(
                "UPDATE HoaDonBan SET tongTien=@tt WHERE maHD=@id",
                new SqlParameter("@tt", tong - giamGia),
                new SqlParameter("@id", _maHD));
        }

        // ════════════════════════════════════════════════════════════
        // HELPER: Reset toàn bộ form về trạng thái ban đầu
        // ════════════════════════════════════════════════════════════
        private void Reset()
        {
            _maHD = -1;
            txtMaHoaDon.Text = "";
            nudSoLuong.Text = "";
            txtDonGia.Text = "";
            txtGiaTriKM.Text = "";
            txtTimKiem.Text = "";
            lblTongTien.Text = "---";
            dgvChiTiet.DataSource = null;

            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
            if (cboKhuyenMai.Items.Count > 0) cboKhuyenMai.SelectedIndex = 0;
            if (cboMonAn.Items.Count > 0) cboMonAn.SelectedIndex = 0;

            dgvDanhSach.ClearSelection();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }
    }
}


