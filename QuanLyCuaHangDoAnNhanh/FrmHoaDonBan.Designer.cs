namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmHoaDonBan
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
            btnXoaHD = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnHoanThanh = new Button();
            btnLamMoi = new Button();
            btnSuaHD = new Button();
            btnXuatDS = new Button();
            btnInHoaDon = new Button();
            btnThemHD = new Button();
            panelLeft = new Panel();
            cboKhachHang = new ComboBox();
            txtGiaTriKM = new TextBox();
            label13 = new Label();
            label12 = new Label();
            panelTongTien = new Panel();
            lblTongTien = new Label();
            label9 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label7 = new Label();
            cboKhuyenMai = new ComboBox();
            cboNhanVien = new ComboBox();
            txtMaHoaDon = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            grpDSHD = new GroupBox();
            dgvDanhSach = new DataGridView();
            panelFill = new Panel();
            nudSoLuong = new NumericUpDown();
            txtDonGia = new TextBox();
            label11 = new Label();
            label10 = new Label();
            btnXoaMon = new Button();
            btnThemMon = new Button();
            cboMonAn = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dgvChiTiet = new DataGridView();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelTongTien.SuspendLayout();
            grpDSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(btnXoaHD);
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnHoanThanh);
            panelTop.Controls.Add(btnLamMoi);
            panelTop.Controls.Add(btnSuaHD);
            panelTop.Controls.Add(btnXuatDS);
            panelTop.Controls.Add(btnInHoaDon);
            panelTop.Controls.Add(btnThemHD);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1379, 107);
            panelTop.TabIndex = 0;
            // 
            // btnXoaHD
            // 
            btnXoaHD.BackColor = Color.Cyan;
            btnXoaHD.FlatAppearance.BorderSize = 0;
            btnXoaHD.FlatStyle = FlatStyle.Flat;
            btnXoaHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoaHD.ForeColor = Color.White;
            btnXoaHD.Location = new Point(821, 11);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(147, 41);
            btnXoaHD.TabIndex = 10;
            btnXoaHD.Text = "Xoá HD";
            btnXoaHD.UseVisualStyleBackColor = false;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(987, 65);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(147, 30);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(9, 65);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(959, 30);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.BackColor = Color.Cyan;
            btnHoanThanh.FlatAppearance.BorderSize = 0;
            btnHoanThanh.FlatStyle = FlatStyle.Flat;
            btnHoanThanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHoanThanh.ForeColor = Color.White;
            btnHoanThanh.Location = new Point(333, 11);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(147, 41);
            btnHoanThanh.TabIndex = 7;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = false;
            btnHoanThanh.Click += btnHoanThanh_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(498, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(147, 41);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSuaHD
            // 
            btnSuaHD.BackColor = Color.Cyan;
            btnSuaHD.FlatAppearance.BorderSize = 0;
            btnSuaHD.FlatStyle = FlatStyle.Flat;
            btnSuaHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSuaHD.ForeColor = Color.White;
            btnSuaHD.Location = new Point(171, 11);
            btnSuaHD.Name = "btnSuaHD";
            btnSuaHD.Size = new Size(147, 41);
            btnSuaHD.TabIndex = 3;
            btnSuaHD.Text = "Sửa HĐ";
            btnSuaHD.UseVisualStyleBackColor = false;
            btnSuaHD.Click += btnSuaHD_Click;
            // 
            // btnXuatDS
            // 
            btnXuatDS.BackColor = Color.Cyan;
            btnXuatDS.FlatAppearance.BorderSize = 0;
            btnXuatDS.FlatStyle = FlatStyle.Flat;
            btnXuatDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuatDS.ForeColor = Color.White;
            btnXuatDS.Location = new Point(987, 11);
            btnXuatDS.Name = "btnXuatDS";
            btnXuatDS.Size = new Size(147, 41);
            btnXuatDS.TabIndex = 21;
            btnXuatDS.Text = "Xuất DS";
            btnXuatDS.UseVisualStyleBackColor = false;
            btnXuatDS.Click += btnXuatDS_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.Cyan;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(660, 11);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(147, 41);
            btnInHoaDon.TabIndex = 4;
            btnInHoaDon.Text = "In hoá đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThemHD
            // 
            btnThemHD.BackColor = Color.Cyan;
            btnThemHD.FlatAppearance.BorderSize = 0;
            btnThemHD.FlatStyle = FlatStyle.Flat;
            btnThemHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThemHD.ForeColor = Color.White;
            btnThemHD.Location = new Point(9, 11);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new Size(147, 41);
            btnThemHD.TabIndex = 5;
            btnThemHD.Text = "Thêm HĐ";
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // panelLeft
            // 
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(cboKhachHang);
            panelLeft.Controls.Add(txtGiaTriKM);
            panelLeft.Controls.Add(label13);
            panelLeft.Controls.Add(label12);
            panelLeft.Controls.Add(panelTongTien);
            panelLeft.Controls.Add(dtpNgayNhap);
            panelLeft.Controls.Add(label7);
            panelLeft.Controls.Add(cboKhuyenMai);
            panelLeft.Controls.Add(cboNhanVien);
            panelLeft.Controls.Add(txtMaHoaDon);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(grpDSHD);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 107);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(776, 706);
            panelLeft.TabIndex = 1;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(394, 162);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(364, 31);
            cboKhachHang.TabIndex = 26;
            // 
            // txtGiaTriKM
            // 
            txtGiaTriKM.Location = new Point(394, 72);
            txtGiaTriKM.Name = "txtGiaTriKM";
            txtGiaTriKM.Size = new Size(165, 30);
            txtGiaTriKM.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(394, 122);
            label13.Name = "label13";
            label13.Size = new Size(101, 23);
            label13.TabIndex = 24;
            label13.Text = "Khách hàng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(394, 45);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 24;
            label12.Text = "Giá trị KM";
            // 
            // panelTongTien
            // 
            panelTongTien.BorderStyle = BorderStyle.FixedSingle;
            panelTongTien.Controls.Add(lblTongTien);
            panelTongTien.Controls.Add(label9);
            panelTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTongTien.Location = new Point(11, 199);
            panelTongTien.Name = "panelTongTien";
            panelTongTien.Size = new Size(750, 85);
            panelTongTien.TabIndex = 23;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Dock = DockStyle.Bottom;
            lblTongTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.FromArgb(30, 50, 80);
            lblTongTien.Location = new Point(179, 52);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(41, 31);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "---";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(30, 50, 80);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(179, 23);
            label9.TabIndex = 7;
            label9.Text = "Tổng tiền thanh toán";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(593, 74);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(169, 30);
            dtpNgayNhap.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(187, 23);
            label7.TabIndex = 10;
            label7.Text = "Thông tin hoá đơn bán";
            // 
            // cboKhuyenMai
            // 
            cboKhuyenMai.FormattingEnabled = true;
            cboKhuyenMai.Location = new Point(146, 72);
            cboKhuyenMai.Name = "cboKhuyenMai";
            cboKhuyenMai.Size = new Size(228, 31);
            cboKhuyenMai.TabIndex = 18;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(9, 162);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(365, 31);
            cboNhanVien.TabIndex = 19;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(9, 72);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(110, 30);
            txtMaHoaDon.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 45);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 13;
            label2.Text = "Ngày lập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 45);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 14;
            label4.Text = "Khuyễn mãi ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 122);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 15;
            label3.Text = "Nhân viên lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 46);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã hoá đơn";
            // 
            // grpDSHD
            // 
            grpDSHD.Controls.Add(dgvDanhSach);
            grpDSHD.Dock = DockStyle.Bottom;
            grpDSHD.Location = new Point(0, 290);
            grpDSHD.Name = "grpDSHD";
            grpDSHD.Size = new Size(774, 414);
            grpDSHD.TabIndex = 9;
            grpDSHD.TabStop = false;
            grpDSHD.Text = "Danh sách hoá đơn bán";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 26);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(768, 385);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellContentClick += dgvDanhSach_CellContentClick;
            // 
            // panelFill
            // 
            panelFill.BorderStyle = BorderStyle.FixedSingle;
            panelFill.Controls.Add(nudSoLuong);
            panelFill.Controls.Add(txtDonGia);
            panelFill.Controls.Add(label11);
            panelFill.Controls.Add(label10);
            panelFill.Controls.Add(btnXoaMon);
            panelFill.Controls.Add(btnThemMon);
            panelFill.Controls.Add(cboMonAn);
            panelFill.Controls.Add(label6);
            panelFill.Controls.Add(label5);
            panelFill.Controls.Add(groupBox2);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(776, 107);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(603, 706);
            panelFill.TabIndex = 2;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(434, 72);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(112, 30);
            nudSoLuong.TabIndex = 18;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(297, 75);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(113, 30);
            txtDonGia.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(434, 45);
            label11.Name = "label11";
            label11.Size = new Size(78, 23);
            label11.TabIndex = 14;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 46);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 15;
            label10.Text = "Đơn giá";
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = Color.Cyan;
            btnXoaMon.FlatAppearance.BorderSize = 0;
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoaMon.ForeColor = Color.White;
            btnXoaMon.Location = new Point(436, 135);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(110, 41);
            btnXoaMon.TabIndex = 12;
            btnXoaMon.Text = "Xoá";
            btnXoaMon.UseVisualStyleBackColor = false;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.Cyan;
            btnThemMon.FlatAppearance.BorderSize = 0;
            btnThemMon.FlatStyle = FlatStyle.Flat;
            btnThemMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThemMon.ForeColor = Color.White;
            btnThemMon.Location = new Point(297, 135);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(113, 41);
            btnThemMon.TabIndex = 13;
            btnThemMon.Text = "Thêm Món";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // cboMonAn
            // 
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(9, 74);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(269, 31);
            cboMonAn.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 45);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 8;
            label6.Text = "Tên món ăn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 9;
            label5.Text = "Chi tiết hoá đơn bán";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTiet);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 522);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chi tiết hoá đơn bán";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 26);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(595, 493);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
            // 
            // FrmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 242, 242);
            ClientSize = new Size(1379, 813);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(30, 50, 80);
            Name = "FrmHoaDonBan";
            Text = "FrmHoaDonBan";
            Load += FrmHoaDonBan_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelTongTien.ResumeLayout(false);
            panelTongTien.PerformLayout();
            grpDSHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelFill;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnHoanThanh;
        private Button btnLamMoi;
        private Button btnSuaHD;
        private Button btnInHoaDon;
        private Button btnThemHD;
        private Panel panelTongTien;
        private Label lblTongTien;
        private Label label9;
        private DateTimePicker dtpNgayNhap;
        private Button btnXuatDS;
        private Label label7;
        private ComboBox cboKhuyenMai;
        private ComboBox cboNhanVien;
        private TextBox txtMaHoaDon;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private GroupBox grpDSHD;
        private DataGridView dgvDanhSach;
        private TextBox txtDonGia;
        private Label label11;
        private Label label10;
        private Button btnXoaMon;
        private Button btnThemMon;
        private ComboBox cboMonAn;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private DataGridView dgvChiTiet;
        private Button btnXoaHD;
        private ComboBox cboKhachHang;
        private TextBox txtGiaTriKM;
        private Label label13;
        private Label label12;
        private NumericUpDown nudSoLuong;
    }
}