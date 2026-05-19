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
    public partial class FrmDatMon : Form
    {
        public FrmDatMon()
        {
            InitializeComponent();
        }

        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNhanVien();
                LoadKhachHang();
                LoadKhuyenMai();
                LoadLoaiMon();
                LoadMonAn(0, "");
                KhoiTaoGioHang();

                lblTamTinh.Text = "0 đ";
                lblTongTienThanhToan.Text = "0 đ";
                lblTienThua.Text = "0 đ";
                lblTienGiam.Text = "0 đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiTaoGioHang()
        {
            dgvGioHang.Columns.Clear();
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "maMonAn", Visible = false });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "tenMonAn", HeaderText = "Tên món", ReadOnly = true, FillWeight = 35 });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "soLuong", HeaderText = "SL", FillWeight = 10 });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "donGia",
                HeaderText = "Đơn giá",
                ReadOnly = true,
                FillWeight = 20,
                DefaultCellStyle = { Format = "N0" }
            });

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "thanhTien",
                HeaderText = "Thành tiền",
                ReadOnly = true,
                FillWeight = 22,
                DefaultCellStyle = { Format = "N0" }
            });

            dgvGioHang.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Xoa",
                HeaderText = "",
                Text = "Xoá",
                UseColumnTextForButtonValue = true,
                FillWeight = 10
            });

            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            dgvGioHang.CellValueChanged += dgvGioHang_CellValueChanged;
            dgvGioHang.CurrentCellDirtyStateChanged += dgvGioHang_CurrentCellDirtyStateChanged;
        }

        // ════════════════════════════════════════════════════════════
        // LOAD COMBOBOX
        // ════════════════════════════════════════════════════════════
        private void LoadNhanVien()
        {
            var dt = KetNoiCSDL.GetDataTable(
                "SELECT maNV, tenNV FROM NhanVien WHERE trangThai=1 ORDER BY tenNV");
            cboNhanVien.DisplayMember = "tenNV";
            cboNhanVien.ValueMember = "maNV";
            cboNhanVien.DataSource = dt;
        }

        private void LoadKhachHang()
        {
            var dt = KetNoiCSDL.GetDataTable(
                "SELECT maKH, tenKH + N' - ' + ISNULL(soDienThoai,'')" +
                " AS tenKH FROM KhachHang WHERE trangThai=1 ORDER BY tenKH");

            DataRow r = dt.NewRow();
            r["maKH"] = 0;
            r["tenKH"] = "-- Khách lẻ --";
            dt.Rows.InsertAt(r, 0);

            cboKhachHang.DisplayMember = "tenKH";
            cboKhachHang.ValueMember = "maKH";
            cboKhachHang.DataSource = dt;
        }

        private void LoadKhuyenMai()
        {
            // Chỉ lấy KM còn hiệu lực theo ngày hôm nay
            var dt = KetNoiCSDL.GetDataTable(@"
                SELECT maKM, tenKM, loaiKM, giaTriKM
                FROM KhuyenMai
                WHERE trangThai = 1
                  AND CAST(GETDATE() AS DATE) BETWEEN ngayBatDau AND ngayKetThuc
                ORDER BY tenKM");

            DataRow r = dt.NewRow();
            r["maKM"] = 0;
            r["tenKM"] = "-- Không áp dụng --";
            r["loaiKM"] = "";
            r["giaTriKM"] = 0;
            dt.Rows.InsertAt(r, 0);

            cboKhuyenMai.DisplayMember = "tenKM";
            cboKhuyenMai.ValueMember = "maKM";
            cboKhuyenMai.DataSource = dt;
        }

        private void LoadLoaiMon()
        {
            var dt = KetNoiCSDL.GetDataTable(
                "SELECT maLoaiMon, tenLoaiMon FROM LoaiMon WHERE trangThai=1 ORDER BY tenLoaiMon");

            DataRow r = dt.NewRow();
            r["maLoaiMon"] = 0;
            r["tenLoaiMon"] = "-- Tất cả --";
            dt.Rows.InsertAt(r, 0);

            cboLoaiMon.DisplayMember = "tenLoaiMon";
            cboLoaiMon.ValueMember = "maLoaiMon";
            cboLoaiMon.DataSource = dt;
        }

        // ════════════════════════════════════════════════════════════
        // LOAD DANH SÁCH MÓN ĂN
        // ════════════════════════════════════════════════════════════
        private void LoadMonAn(int maLoai, string tenMon)
        {
            string sql = @"
                SELECT m.maMonAn    AS [Mã],
                       m.tenMonAn   AS [Tên món],
                       l.tenLoaiMon AS [Loại],
                       m.giaBan     AS [Giá bán],
                       m.donViTinh  AS [ĐVT]
                FROM MonAn m
                JOIN LoaiMon l ON m.maLoaiMon = l.maLoaiMon
                WHERE m.trangThai = 1
                  AND (m.tenMonAn LIKE @ten
                       OR CAST(m.maMonAn AS NVARCHAR) LIKE @ten)";


            if (maLoai != 0) sql += " AND m.maLoaiMon = @loai";
            sql += " ORDER BY m.tenMonAn";

            var dt = maLoai != 0
                ? KetNoiCSDL.GetDataTable(sql,
                    new SqlParameter("@ten", "%" + tenMon + "%"),
                    new SqlParameter("@loai", maLoai))
                : KetNoiCSDL.GetDataTable(sql,
                    new SqlParameter("@ten", "%" + tenMon + "%"));

            dgvMonAn.AutoGenerateColumns = true;
            dgvMonAn.DataSource = dt;
            dgvMonAn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMonAn.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int maLoai = cboLoaiMon.SelectedValue is int v ? v : 0;
            LoadMonAn(maLoai, txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void cboLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemMonVaoGio();
        }

        private void ThemMonVaoGio()
        {
            if (dgvMonAn.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn món ăn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int maMon = Convert.ToInt32(
                    dgvMonAn.CurrentRow.Cells["Mã"].Value);

                string tenMon =
                    dgvMonAn.CurrentRow.Cells["Tên món"].Value.ToString();

                decimal giaBan = Convert.ToDecimal(
                    dgvMonAn.CurrentRow.Cells["Giá bán"].Value);

                
                nudSoLuong.Refresh();
                int soLuongThem = Convert.ToInt32(nudSoLuong.Value);

                // nếu món đã có
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    if (row.Cells["maMonAn"].Value == null)
                        continue;

                    int maMonTrongGio =
                        Convert.ToInt32(row.Cells["maMonAn"].Value);

                    if (maMonTrongGio == maMon)
                    {
                        int slCu = Convert.ToInt32(row.Cells["soLuong"].Value);
                        int slMoi = slCu + soLuongThem;

                        // Cập nhật giá trị
                        row.Cells["soLuong"].Value = slMoi;
                        row.Cells["thanhTien"].Value = slMoi * giaBan;

                        // Buộc DataGridView vẽ lại ô đó
                        dgvGioHang.InvalidateCell(row.Cells["soLuong"]);
                        dgvGioHang.InvalidateCell(row.Cells["thanhTien"]);

                        TinhTongTien();

                        // Đặt lại số lượng mặc định cho lần thêm tiếp theo
                        nudSoLuong.Value = 1;
                        nudSoLuong.Refresh();
                        return;
                    }
                }

         
                dgvGioHang.Rows.Add(
                    maMon,
                    tenMon,
                    soLuongThem,
                    giaBan,
                    soLuongThem * giaBan
                );

                TinhTongTien();
                nudSoLuong.Value = 1;
                nudSoLuong.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm món:\n" + ex.Message);
            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // kiểm tra index hợp lệ
                if (e.RowIndex < 0 || e.RowIndex >= dgvGioHang.Rows.Count)
                    return;

                // kiểm tra đúng cột Xóa
                if (dgvGioHang.Columns[e.ColumnIndex].Name == "Xoa")
                {
                    dgvGioHang.Rows.RemoveAt(e.RowIndex);

                    TinhTongTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xoá món:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvGioHang.Columns[e.ColumnIndex].Name != "soLuong") return;

            var row = dgvGioHang.Rows[e.RowIndex];
            if (row.Cells["soLuong"].Value == null) return;

            if (!int.TryParse(row.Cells["soLuong"].Value.ToString(), out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Thông báo");
                row.Cells["soLuong"].Value = 1;
                sl = 1;
            }

            decimal donGia = Convert.ToDecimal(row.Cells["donGia"].Value);
            row.Cells["thanhTien"].Value = sl * donGia;
            TinhTongTien();
        }

        private void dgvGioHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (dgvGioHang.IsCurrentCellDirty)
                dgvGioHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void TinhTongTien()
        {
            decimal tamTinh = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
                if (row.Cells["thanhTien"].Value != null)
                    tamTinh += Convert.ToDecimal(row.Cells["thanhTien"].Value);

            decimal giam = TinhGiamGia(tamTinh);
            decimal tong = Math.Max(tamTinh - giam, 0);

            lblTamTinh.Text = tamTinh.ToString("N0") + " đ";
            lblTienGiam.Text = giam.ToString("N0") + " đ";
            lblTongTienThanhToan.Text = tong.ToString("N0") + " đ";

            TinhTienThua();
        }

        private decimal TinhGiamGia(decimal tamTinh)
        {
            if (cboKhuyenMai.SelectedItem is not DataRowView drv) return 0;
            int maKM = Convert.ToInt32(drv["maKM"]);
            if (maKM == 0) return 0;

            string loai = drv["loaiKM"].ToString();
            decimal gt = Convert.ToDecimal(drv["giaTriKM"]);

            // loaiKM trong CSDL: "Phần trăm" hoặc "Số tiền"
            if (loai.Contains("Phần") || loai.Contains("phan") || loai == "PhanTram")
                return tamTinh * gt / 100;
            else
                return gt;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            TinhTienThua();
        }

        private void TinhTienThua()
        {
            string tongStr = lblTongTienThanhToan.Text.Replace("đ", "").Replace(",", "").Trim();
            decimal.TryParse(tongStr, out decimal tong);
            decimal.TryParse(txtTienKhachDua.Text.Replace(",", "").Trim(), out decimal khach);

            decimal thua = khach - tong;
            lblTienThua.Text = (thua >= 0 ? thua : 0).ToString("N0") + " đ";
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {

            TinhTongTien();
            MessageBox.Show("Đã áp dụng khuyến mãi!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc muốn huỷ và xoá toàn bộ giỏ hàng?",
                "Xác nhận huỷ đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XoaGioHang();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            txtTienKhachDua.Clear();
            nudSoLuong.Value = 1;

            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
            if (cboKhuyenMai.Items.Count > 0) cboKhuyenMai.SelectedIndex = 0;
            if (cboLoaiMon.Items.Count > 0) cboLoaiMon.SelectedIndex = 0;

            dgvGioHang.Rows.Clear();
            LoadMonAn(0, "");
            dgvMonAn.ClearSelection();

            lblTamTinh.Text = "0 đ";
            lblTienGiam.Text = "0 đ";
            lblTongTienThanhToan.Text = "0 đ";
            lblTienThua.Text = "0 đ";
        }

        private void XoaGioHang()
        {
            dgvGioHang.Rows.Clear();
            txtTienKhachDua.Clear();
            nudSoLuong.Value = 1;
            if (cboKhuyenMai.Items.Count > 0) cboKhuyenMai.SelectedIndex = 0;

            lblTamTinh.Text = "0 đ";
            lblTienGiam.Text = "0 đ";
            lblTongTienThanhToan.Text = "0 đ";
            lblTienThua.Text = "0 đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống! Vui lòng chọn món.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tiền khách đưa
            string tongStr = lblTongTienThanhToan.Text.Replace("đ", "").Replace(",", "").Trim();
            decimal.TryParse(tongStr, out decimal tongTien);
            decimal.TryParse(txtTienKhachDua.Text.Replace(",", "").Trim(), out decimal tienKhach);

            if (txtTienKhachDua.Text.Trim() != "" && tienKhach < tongTien)
            {
                MessageBox.Show("Tiền khách đưa chưa đủ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
            int maKH = Convert.ToInt32(cboKhachHang.SelectedValue ?? 0);
            int maKM = Convert.ToInt32(cboKhuyenMai.SelectedValue ?? 0);

            try
            {
                // FIX: dùng OUTPUT INSERTED.maHD để lấy ID chính xác
                object ketQua = KetNoiCSDL.ExecuteScalar(@"
                    INSERT INTO HoaDonBan
                        (maKH, maKM, maNV, ngayLap, tongTien, trangThai)
                    OUTPUT INSERTED.maHD
                    VALUES
                        (@maKH, @maKM, @maNV, GETDATE(), @tong, N'Hoàn thành')",
                    new SqlParameter("@maKH", maKH > 0 ? (object)maKH : DBNull.Value),
                    new SqlParameter("@maKM", maKM > 0 ? (object)maKM : DBNull.Value),
                    new SqlParameter("@maNV", maNV),
                    new SqlParameter("@tong", tongTien));

                int maHD = Convert.ToInt32(ketQua);

                // FIX: tên bảng đúng = ChiTietHDB, không có cột thanhTien
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    if (row.Cells["maMonAn"].Value == null) continue;

                    KetNoiCSDL.ExecuteNonQuery(@"
                        INSERT INTO ChiTietHDB (maHD, maMonAn, soLuong, donGia)
                        VALUES (@maHD, @maMon, @sl, @dg)",
                        new SqlParameter("@maHD", maHD),
                        new SqlParameter("@maMon", Convert.ToInt32(row.Cells["maMonAn"].Value)),
                        new SqlParameter("@sl", Convert.ToInt32(row.Cells["soLuong"].Value)),
                        new SqlParameter("@dg", Convert.ToDecimal(row.Cells["donGia"].Value)));
                }

                decimal tienThua = tienKhach - tongTien;

                MessageBox.Show(
                    $"✅ Thanh toán thành công!\n\n" +
                    $"Mã hoá đơn : HĐ-{maHD:D3}\n" +
                    $"Tổng tiền  : {tongTien:N0} đ\n" +
                    $"Tiền khách : {tienKhach:N0} đ\n" +
                    $"Tiền thừa  : {tienThua:N0} đ",
                    "Thanh toán thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                XoaGioHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
