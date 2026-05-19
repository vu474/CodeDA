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
using System.IO;

namespace QuanLyCuaHangDoAnNhanh
{
    public partial class FrmMonAn : Form
    {
        private string _anhDuongDan = "D:\\WDF\\image";
        private string _anhFileChon = "";
        public FrmMonAn()
        {
            InitializeComponent();
        }

        private void FrmMonAn_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
            LoadData();
        }

        private void LoadLoaiMon()
        {
            DataTable dt = KetNoiCSDL.GetDataTable(
                "SELECT maLoaiMon, tenLoaiMon FROM LoaiMon WHERE trangThai=1 ORDER BY tenLoaiMon");
            cboLoaiMon.DisplayMember = "tenLoaiMon";
            cboLoaiMon.ValueMember = "maLoaiMon";
            cboLoaiMon.DataSource = dt;
        }

        // ── LOAD DANH SÁCH MÓN ĂN ────────────────────────────────────────
        private void LoadData()
        {
            string query = @"
    SELECT 
        m.maMonAn       AS [Mã món],
        m.tenMonAn      AS [Tên món ăn],
        l.tenLoaiMon    AS [Loại món],
        m.giaBan        AS [Giá bán],
        m.donViTinh     AS [Đơn vị tính],
        m.hinhAnh       AS [Tên ảnh],
        CASE 
            WHEN m.trangThai = 1 
            THEN N'Đang bán'
            ELSE N'Ngừng bán'
        END AS [Trạng thái]
    FROM MonAn m
    JOIN LoaiMon l 
        ON m.maLoaiMon = l.maLoaiMon
    WHERE m.trangThai = 1
    ORDER BY m.maMonAn DESC";

            DataTable dt = KetNoiCSDL.GetDataTable(query);

            dgvMonAN.Columns.Clear();
            dgvMonAN.AutoGenerateColumns = true;
            dgvMonAN.DataSource = dt;

            // Ẩn cột tên file ảnh
            dgvMonAN.Columns["Tên ảnh"].Visible = false;

            // Tạo cột ảnh
            DataGridViewImageColumn imgCol =
                new DataGridViewImageColumn();

            imgCol.Name = "Hình ảnh";
            imgCol.HeaderText = "Hình ảnh";
            imgCol.ImageLayout =
                DataGridViewImageCellLayout.Zoom;

            dgvMonAN.Columns.Add(imgCol);

            // Load ảnh
            foreach (DataGridViewRow row in dgvMonAN.Rows)
            {
                if (row.Cells["Tên ảnh"].Value == null)
                    continue;

                string tenAnh =
                    row.Cells["Tên ảnh"].Value.ToString();

                string path =
                    Path.Combine(_anhDuongDan, tenAnh);

                if (File.Exists(path))
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(path);

                        using (MemoryStream ms =
                            new MemoryStream(bytes))
                        {
                            row.Cells["Hình ảnh"].Value =
                                Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        row.Cells["Hình ảnh"].Value = null;
                    }
                }
            }

            // Hiển thị đẹp
            dgvMonAN.RowTemplate.Height = 30;

            dgvMonAN.Columns["Hình ảnh"].Width = 50;

            dgvMonAN.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvMonAN.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonAn.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(txtGia.Text, out decimal gia))
            {
                MessageBox.Show("Giá bán phải là số!");
                txtGia.Focus();
                return;
            }

            if (gia <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!");
                txtGia.Focus();
                return;
            }

            if (string.IsNullOrEmpty(_anhFileChon))
            {
                MessageBox.Show("Vui lòng chọn ảnh món ăn!");
                return;
            }

            try
            {
                int tt = radConBan.Checked ? 1 : 0;
                int maLoai = Convert.ToInt32(cboLoaiMon.SelectedValue);

                // Lấy tên file ảnh từ đường dẫn (nếu có)
                string tenAnh = "";
                if (!string.IsNullOrEmpty(_anhFileChon) && File.Exists(_anhFileChon))
                {
                    tenAnh = Path.GetFileName(_anhFileChon);

                    // Copy ảnh vào thư mục image (nếu chưa có ở đó)
                    string dest = Path.Combine(_anhDuongDan, tenAnh);
                    if (!File.Exists(dest))
                        File.Copy(_anhFileChon, dest);
                }

                string query = @"INSERT INTO MonAn
                    (maLoaiMon, tenMonAn, giaBan, hinhAnh, trangThai)
                    VALUES (@loai, @ten, @gia, @anh, @tt)";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@loai", maLoai),
                    new SqlParameter("@ten", txtTenMonAn.Text.Trim()),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@anh", tenAnh),
                    new SqlParameter("@tt", tt)
                );

                MessageBox.Show("Thêm món ăn thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            txtMaMonAn.Clear();
            txtTenMonAn.Clear();
            txtGia.Clear();
            txtTimkiem.Clear();

            // Reset lại đường dẫn ảnh về thư mục mặc định
            _anhDuongDan = "D:\\WDF\\image";
            _anhFileChon = "";

            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }

            radConBan.Checked = true;
            if (cboLoaiMon.Items.Count > 0) cboLoaiMon.SelectedIndex = 0;
            txtTenMonAn.Focus();

            // Clear selection trên bảng để tránh lỗi
            dgvMonAN.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMonAn.Text))
            {
                MessageBox.Show("Chọn món ăn cần sửa!");
                return;
            }

            if (!decimal.TryParse(txtGia.Text, out decimal gia))
            {
                MessageBox.Show("Giá bán phải là số!", "Thông báo");
                return;
            }

            try
            {
                int tt = radConBan.Checked ? 1 : 0;
                int maLoai = Convert.ToInt32(cboLoaiMon.SelectedValue);

                string tenAnh = "";
                if (!string.IsNullOrEmpty(_anhFileChon) && File.Exists(_anhFileChon))
                {
                    // ✅ Người dùng vừa chọn ảnh mới
                    tenAnh = Path.GetFileName(_anhFileChon);
                    string dest = Path.Combine(_anhDuongDan, tenAnh);
                    if (!File.Exists(dest))
                        File.Copy(_anhFileChon, dest);
                }
                else
                {
                    // ✅ Giữ ảnh cũ từ DB
                    string queryGetAnh = "SELECT hinhAnh FROM MonAn WHERE maMonAn = @id";
                    DataTable dt = KetNoiCSDL.GetDataTable(queryGetAnh,
                        new SqlParameter("@id", txtMaMonAn.Text));
                    if (dt.Rows.Count > 0)
                        tenAnh = dt.Rows[0]["hinhAnh"].ToString();
                }

                string query = @"UPDATE MonAn
                    SET maLoaiMon = @loai,
                        tenMonAn  = @ten,
                        giaBan    = @gia,
                        hinhAnh   = @anh,
                        trangThai = @tt
                    WHERE maMonAn = @id";

                KetNoiCSDL.ExecuteNonQuery(query,
                    new SqlParameter("@loai", maLoai),
                    new SqlParameter("@ten", txtTenMonAn.Text.Trim()),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@anh", tenAnh),
                    new SqlParameter("@tt", tt),
                    new SqlParameter("@id", txtMaMonAn.Text)
                );

                MessageBox.Show("Sửa thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMonAn.Text))
            {
                MessageBox.Show("Chọn món ăn cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá món này?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetNoiCSDL.ExecuteNonQuery(
                    "UPDATE MonAn SET trangThai=0 WHERE maMonAn=@id",
                    new SqlParameter("@id", txtMaMonAn.Text));

                MessageBox.Show("Xoá thành công!");
                LoadData();
                LamMoi();
            }
        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Chọn ảnh minh hoạ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _anhFileChon = ofd.FileName; // ✅ Lưu đường dẫn file đầy đủ

                if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
                picHinhAnh.Image = Image.FromFile(_anhFileChon);
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string query = @"SELECT 
                m.maMonAn       AS [Mã món],
                m.tenMonAn      AS [Tên món ăn],
                l.tenLoaiMon    AS [Loại món],
                m.giaBan        AS [Giá bán],
                m.donViTinh     AS [Đơn vị tính],
                m.hinhAnh       AS [Hình ảnh],
                CASE m.trangThai WHEN 1 THEN N'Đang bán' ELSE N'Ngừng bán' END
                                AS [Trạng thái]
            FROM MonAn m
            JOIN LoaiMon l ON m.maLoaiMon = l.maLoaiMon
            WHERE (m.tenMonAn LIKE @tk OR l.tenLoaiMon LIKE @tk)
            AND m.trangThai = 1";

            dgvMonAN.DataSource = KetNoiCSDL.GetDataTable(query,
                new SqlParameter("@tk", "%" + txtTimkiem.Text.Trim() + "%"));
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }

        private void dgvMonAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMonAN.Rows[e.RowIndex];

            // Load Textbox
            txtMaMonAn.Text = row.Cells["Mã món"].Value?.ToString() ?? "";
            txtTenMonAn.Text = row.Cells["Tên món ăn"].Value?.ToString() ?? "";
            txtGia.Text = row.Cells["Giá bán"].Value?.ToString() ?? "";

            // Load Combobox Loại món
            string tenLoai = row.Cells["Loại món"].Value?.ToString() ?? "";
            foreach (DataRowView item in cboLoaiMon.Items)
            {
                if (item["tenLoaiMon"].ToString() == tenLoai)
                {
                    cboLoaiMon.SelectedItem = item;
                    break;
                }
            }

            // Load Radio Button Trạng thái
            string tt = row.Cells["Trạng thái"].Value?.ToString() ?? "";
            radConBan.Checked = (tt == "Đang bán");
            radNgungBan.Checked = (tt != "Đang bán");

            // ─── LOAD ẢNH ───
            string queryAnh =
    "SELECT hinhAnh FROM MonAn WHERE maMonAn=@id";

            object result = KetNoiCSDL.ExecuteScalar(
                queryAnh,
                new SqlParameter("@id", txtMaMonAn.Text));

            string tenFileAnh =
                result?.ToString() ?? "";
            // Nếu tên file rỗng, xóa ảnh hiện tại
            if (string.IsNullOrEmpty(tenFileAnh))
            {
                picHinhAnh.Image = null;
                return;
            }

            // Tạo đường dẫn đầy đủ: Thư mục + Tên file
            string duongDanDayDu = Path.Combine(_anhDuongDan, tenFileAnh);

            if (File.Exists(duongDanDayDu))
            {
                try
                {
                    // Load ảnh trực tiếp từ file (cách đơn giản nhất)
                    // Lưu ý: Cần dispose ảnh cũ để tránh lỗi file bị khóa
                    if (picHinhAnh.Image != null)
                    {
                        var oldImage = picHinhAnh.Image;
                        picHinhAnh.Image = null;
                        oldImage.Dispose();
                    }

                    picHinhAnh.Image = Image.FromFile(duongDanDayDu);
                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom; // Tự co dãn vừa khung
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                    picHinhAnh.Image = null;
                }
            }
            else
            {
                // Không tìm thấy file
                picHinhAnh.Image = null;
            }
        }

        private void txtMaMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
