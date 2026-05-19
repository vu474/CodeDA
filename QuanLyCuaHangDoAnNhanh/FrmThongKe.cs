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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangDoAnNhanh
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            cboLocTheo.Items.Add("Ngày");
            cboLocTheo.Items.Add("Tháng");
            cboLocTheo.Items.Add("Năm");

            cboLocTheo.SelectedIndex = 0;

            ThongKe();
        }

        private void ThongKe()
        {

            // =========================
            // TỔNG DOANH THU
            // =========================

            string sqlDoanhThu = @"
    SELECT ISNULL(SUM(tongTien),0)
    FROM HoaDonBan
    WHERE ngayLap BETWEEN @tu AND @den
    AND trangThai = N'Hoàn thành'";

            object doanhThu = KetNoiCSDL.ExecuteScalar(
     sqlDoanhThu,
     new SqlParameter("@tu", dtpTuNgay.Value), // Thêm .Value vào đây
     new SqlParameter("@den", dtpDenNgay.Value)); // Thêm .Value vào đây

            lblTongDoanhThu.Text =
                Convert.ToDecimal(doanhThu).ToString("N0") + " VNĐ";

            // =========================
            // SỐ HÓA ĐƠN
            // =========================

            string sqlHD = @"
    SELECT COUNT(*)
    FROM HoaDonBan
    WHERE ngayLap BETWEEN @tu AND @den";

            object soHD = KetNoiCSDL.ExecuteScalar(
                sqlHD,
                new SqlParameter("@tu", dtpTuNgay.Value),
                new SqlParameter("@den", dtpDenNgay.Value));

            lblSoHoaDon.Text = soHD.ToString();

            // =========================
            // TỔNG MÓN BÁN
            // =========================

            string sqlMon = @"
    SELECT ISNULL(SUM(soLuong),0)
    FROM ChiTietHDB ct
    JOIN HoaDonBan hd
    ON ct.maHD = hd.maHD
    WHERE hd.ngayLap BETWEEN @tu AND @den";

            object tongMon = KetNoiCSDL.ExecuteScalar(
                sqlMon,
                new SqlParameter("@tu", dtpTuNgay.Value),
                new SqlParameter("@den", dtpDenNgay.Value));

            lblMonDaBan.Text = tongMon.ToString();

            // =========================
            // KHÁCH HÀNG
            // =========================

            string sqlKH = @"
    SELECT COUNT(DISTINCT maKH)
    FROM HoaDonBan
    WHERE ngayLap BETWEEN @tu AND @den";

            object kh = KetNoiCSDL.ExecuteScalar(
                sqlKH,
                new SqlParameter("@tu", dtpTuNgay.Value),
                new SqlParameter("@den", dtpDenNgay.Value));

            lblKhachHang.Text = kh.ToString();

            LoadDanhSachHoaDon();
            LoadTopMon();
            LoadNhanVien();
            LoadChartDoanhThu();
            LoadChartMon();
        }

        private void LoadDanhSachHoaDon()
        {
            string sql = @"
    SELECT
        maHD,
        ngayLap,
        tongTien,
        trangThai
    FROM HoaDonBan
    ORDER BY ngayLap DESC";

            dgvHoaDon.DataSource =
                KetNoiCSDL.GetDataTable(sql);

            dgvHoaDon.ClearSelection();
        }

        private void LoadTopMon()
        {
            string sql = @"
    SELECT TOP 5
        m.tenMonAn,
        SUM(ct.soLuong) AS SoLuongBan
    FROM ChiTietHDB ct
    JOIN MonAn m
        ON ct.maMonAn = m.maMonAn
    GROUP BY m.tenMonAn
    ORDER BY SoLuongBan DESC";

            dgvTopMon.DataSource =
                KetNoiCSDL.GetDataTable(sql);

            dgvTopMon.ClearSelection();
        }

        private void LoadNhanVien()
        {
            string sql = @"
    SELECT
        nv.tenNV,
        COUNT(hd.maHD) AS SoHoaDon,
        SUM(hd.tongTien) AS DoanhThu
    FROM HoaDonBan hd
    JOIN NhanVien nv
        ON hd.maNV = nv.maNV
    GROUP BY nv.tenNV";

            dgvNhanVien.DataSource =
                KetNoiCSDL.GetDataTable(sql);

            dgvNhanVien.ClearSelection();
        }

        private void LoadChartDoanhThu()
        {
            chartDoanhThu.Series.Clear();

            Series s = new Series("Doanh thu");

            s.ChartType = SeriesChartType.Column;

            string sql = @"
    SELECT
        DAY(ngayLap) AS Ngay,
        SUM(tongTien) AS DoanhThu
    FROM HoaDonBan
    GROUP BY DAY(ngayLap)
    ORDER BY Ngay";

            DataTable dt =
                KetNoiCSDL.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    row["Ngay"],
                    row["DoanhThu"]);
            }

            chartDoanhThu.Series.Add(s);
        }

        private void LoadChartMon()
        {
            chartMonAn.Series.Clear();

            Series s = new Series("Món ăn");

            s.ChartType = SeriesChartType.Pie;

            string sql = @"
    SELECT
        m.tenMonAn,
        SUM(ct.soLuong) AS SoLuong
    FROM ChiTietHDB ct
    JOIN MonAn m
        ON ct.maMonAn = m.maMonAn
    GROUP BY m.tenMonAn";

            DataTable dt =
                KetNoiCSDL.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    row["tenMonAn"],
                    row["SoLuong"]);
            }

            chartMonAn.Series.Add(s);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;

            cboLocTheo.SelectedIndex = 0;

            ThongKe();
        }
    }
}
