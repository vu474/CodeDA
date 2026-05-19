namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmDatMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            cboNhanVien = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            txtMaHD = new TextBox();
            cboKhachHang = new ComboBox();
            btnLamMoi = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnHuyDon = new Button();
            panel1 = new Panel();
            btnGioHang = new Button();
            nudSoLuong = new NumericUpDown();
            label6 = new Label();
            dgvMonAn = new DataGridView();
            panel3 = new Panel();
            btnTimKiem = new Button();
            cboLoaiMon = new ComboBox();
            txtTimKiem = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            txtTienKhachDua = new TextBox();
            lblTienThua = new Label();
            btnThanhToan = new Button();
            label13 = new Label();
            label12 = new Label();
            lblTongTienThanhToan = new Label();
            label11 = new Label();
            panel4 = new Panel();
            lblTienGiam = new Label();
            lblTamTinh = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnApDung = new Button();
            cboKhuyenMai = new ComboBox();
            label7 = new Label();
            dgvGioHang = new DataGridView();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(cboNhanVien);
            panelTop.Controls.Add(dtpNgayLap);
            panelTop.Controls.Add(txtMaHD);
            panelTop.Controls.Add(cboKhachHang);
            panelTop.Controls.Add(btnLamMoi);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1254, 106);
            panelTop.TabIndex = 0;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(40, 50);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(253, 31);
            cboNhanVien.TabIndex = 6;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(665, 51);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(144, 30);
            dtpNgayLap.TabIndex = 5;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(882, 50);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(140, 30);
            txtMaHD.TabIndex = 4;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(339, 50);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(253, 31);
            cboKhachHang.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(1080, 48);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 33);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(872, 24);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 0;
            label4.Text = "Mã HĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 25);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 0;
            label3.Text = "Ngày lập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 24);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 0;
            label2.Text = "Khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // btnHuyDon
            // 
            btnHuyDon.Location = new Point(432, 668);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(106, 33);
            btnHuyDon.TabIndex = 1;
            btnHuyDon.Text = "Huỷ đơn";
            btnHuyDon.UseVisualStyleBackColor = true;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGioHang);
            panel1.Controls.Add(nudSoLuong);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvMonAn);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 716);
            panel1.TabIndex = 1;
            // 
            // btnGioHang
            // 
            btnGioHang.Location = new Point(457, 382);
            btnGioHang.Name = "btnGioHang";
            btnGioHang.Size = new Size(173, 46);
            btnGioHang.TabIndex = 4;
            btnGioHang.Text = "+ Thêm giỏ hàng";
            btnGioHang.UseVisualStyleBackColor = true;
            btnGioHang.Click += button1_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(299, 395);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(126, 31);
            nudSoLuong.TabIndex = 3;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 401);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 2;
            label6.Text = "Số lượng :";
            // 
            // dgvMonAn
            // 
            dgvMonAn.AllowUserToAddRows = false;
            dgvMonAn.AllowUserToDeleteRows = false;
            dgvMonAn.BackgroundColor = Color.White;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Dock = DockStyle.Top;
            dgvMonAn.Location = new Point(0, 77);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.RowHeadersVisible = false;
            dgvMonAn.RowHeadersWidth = 51;
            dgvMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonAn.Size = new Size(657, 289);
            dgvMonAn.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(cboLoaiMon);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(657, 77);
            panel3.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(537, 28);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 33);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(278, 26);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(253, 33);
            cboLoaiMon.TabIndex = 2;
            cboLoaiMon.SelectedIndexChanged += cboLoaiMon_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(39, 28);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(160, 31);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 0;
            label5.Text = "Chọn món ăn ";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtTienKhachDua);
            panel2.Controls.Add(lblTienThua);
            panel2.Controls.Add(btnThanhToan);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnHuyDon);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lblTongTienThanhToan);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(659, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 716);
            panel2.TabIndex = 2;
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Location = new Point(207, 537);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(205, 31);
            txtTienKhachDua.TabIndex = 6;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Location = new Point(432, 597);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(26, 25);
            lblTienThua.TabIndex = 5;
            lblTienThua.Text = "--";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(282, 668);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(130, 33);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(99, 597);
            label13.Name = "label13";
            label13.Size = new Size(94, 25);
            label13.TabIndex = 3;
            label13.Text = "Tiền thừa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 537);
            label12.Name = "label12";
            label12.Size = new Size(143, 25);
            label12.TabIndex = 3;
            label12.Text = "Tiên khách đưa";
            // 
            // lblTongTienThanhToan
            // 
            lblTongTienThanhToan.AutoSize = true;
            lblTongTienThanhToan.Location = new Point(432, 483);
            lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            lblTongTienThanhToan.Size = new Size(26, 25);
            lblTongTienThanhToan.TabIndex = 2;
            lblTongTienThanhToan.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 480);
            label11.Name = "label11";
            label11.Size = new Size(193, 25);
            label11.TabIndex = 2;
            label11.Text = "Tổng tiền thanh toán";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTienGiam);
            panel4.Controls.Add(lblTamTinh);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 317);
            panel4.Name = "panel4";
            panel4.Size = new Size(593, 163);
            panel4.TabIndex = 1;
            // 
            // lblTienGiam
            // 
            lblTienGiam.AutoSize = true;
            lblTienGiam.Location = new Point(431, 111);
            lblTienGiam.Name = "lblTienGiam";
            lblTienGiam.Size = new Size(26, 25);
            lblTienGiam.TabIndex = 1;
            lblTienGiam.Text = "--";
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Location = new Point(433, 64);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(26, 25);
            lblTamTinh.TabIndex = 0;
            lblTamTinh.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 111);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 0;
            label10.Text = "Tiền giảm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 64);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 0;
            label9.Text = "Tạm tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 0;
            label8.Text = "Thanh Toán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnApDung);
            groupBox1.Controls.Add(cboKhuyenMai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dgvGioHang);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "GIỎ HÀNG";
            // 
            // btnApDung
            // 
            btnApDung.Location = new Point(470, 271);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(106, 33);
            btnApDung.TabIndex = 3;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            btnApDung.Click += btnApDung_Click;
            // 
            // cboKhuyenMai
            // 
            cboKhuyenMai.FormattingEnabled = true;
            cboKhuyenMai.Location = new Point(136, 270);
            cboKhuyenMai.Name = "cboKhuyenMai";
            cboKhuyenMai.Size = new Size(322, 33);
            cboKhuyenMai.TabIndex = 2;
            cboKhuyenMai.SelectedIndexChanged += cboKhuyenMai_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 270);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 1;
            label7.Text = "Khuyến mãi";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.BackgroundColor = Color.White;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Top;
            dgvGioHang.Location = new Point(3, 27);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(587, 221);
            dgvGioHang.TabIndex = 0;
            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            dgvGioHang.CellValueChanged += dgvGioHang_CellValueChanged;
            dgvGioHang.CurrentCellDirtyStateChanged += dgvGioHang_CurrentCellDirtyStateChanged;
            // 
            // FrmDatMon
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 242, 242);
            ClientSize = new Size(1254, 822);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(30, 50, 80);
            Name = "FrmDatMon";
            Text = "FrmDatMon";
            Load += FrmDatMon_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblNgayLap;
        private ComboBox cboNhanVien;
        private Panel panelTop;
        private DateTimePicker dtpNgayLap;
        private TextBox txtMaHD;
        private ComboBox cboKhachHang;
        private Button btnHuyDon;
        private Button btnLamMoi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dgvMonAn;
        private Button btnTimKiem;
        private ComboBox cboLoaiMon;
        private TextBox txtTimKiem;
        private Label label5;
        private Button btnGioHang;
        private NumericUpDown nudSoLuong;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private DataGridView dgvGioHang;
        private Label lblTongTienThanhToan;
        private Label label11;
        private Panel panel4;
        private Label lblTienGiam;
        private Label lblTamTinh;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnApDung;
        private ComboBox cboKhuyenMai;
        private Label lblTienThua;
        private Button btnThanhToan;
        private Label label13;
        private Label label12;
        private TextBox txtTienKhachDua;
    }
}