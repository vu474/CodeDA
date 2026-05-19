namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmHoaDonNhap
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
            panelLeft = new Panel();
            panelTongTien = new Panel();
            lblTongTien = new Label();
            label9 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label7 = new Label();
            cboNhaCungCap = new ComboBox();
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
            btnXoaNL = new Button();
            btnThemNL = new Button();
            cboDonVi = new ComboBox();
            cboNguyenLieu = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dgvChiTiet = new DataGridView();
            btnThemHD = new Button();
            btnInHoaDon = new Button();
            btnSuaHD = new Button();
            btnLamMoi = new Button();
            btnHoanThanh = new Button();
            btnXuatDS = new Button();
            txtTimKiem = new TextBox();
            btnXoaHD = new Button();
            panelTop = new Panel();
            btnTimKiem = new Button();
            panelLeft.SuspendLayout();
            panelTongTien.SuspendLayout();
            grpDSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(panelTongTien);
            panelLeft.Controls.Add(dtpNgayNhap);
            panelLeft.Controls.Add(label7);
            panelLeft.Controls.Add(cboNhaCungCap);
            panelLeft.Controls.Add(cboNhanVien);
            panelLeft.Controls.Add(txtMaHoaDon);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(grpDSHD);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 113);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(671, 700);
            panelLeft.TabIndex = 1;
            // 
            // panelTongTien
            // 
            panelTongTien.BorderStyle = BorderStyle.FixedSingle;
            panelTongTien.Controls.Add(lblTongTien);
            panelTongTien.Controls.Add(label9);
            panelTongTien.Location = new Point(12, 190);
            panelTongTien.Name = "panelTongTien";
            panelTongTien.Size = new Size(641, 58);
            panelTongTien.TabIndex = 8;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Dock = DockStyle.Right;
            lblTongTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Black;
            lblTongTien.Location = new Point(607, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(32, 31);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "--";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(158, 23);
            label9.TabIndex = 7;
            label9.Text = "Tổng tiền hoá đơn";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(466, 41);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(187, 30);
            dtpNgayNhap.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(197, 23);
            label7.TabIndex = 1;
            label7.Text = "Thông tin hoá đơn nhập";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(366, 144);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(287, 31);
            cboNhaCungCap.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(13, 144);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(321, 31);
            cboNhanVien.TabIndex = 3;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(121, 40);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(140, 30);
            txtMaHoaDon.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 46);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "Ngày nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 106);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 1;
            label4.Text = "Nhà cung cấp ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 106);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 1;
            label3.Text = "Nhân viên lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã hoá đơn";
            // 
            // grpDSHD
            // 
            grpDSHD.Controls.Add(dgvDanhSach);
            grpDSHD.Dock = DockStyle.Bottom;
            grpDSHD.Location = new Point(0, 254);
            grpDSHD.Name = "grpDSHD";
            grpDSHD.Size = new Size(669, 444);
            grpDSHD.TabIndex = 0;
            grpDSHD.TabStop = false;
            grpDSHD.Text = "Danh sách hoá đơn nhập";
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
            dgvDanhSach.Size = new Size(663, 415);
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
            panelFill.Controls.Add(btnXoaNL);
            panelFill.Controls.Add(btnThemNL);
            panelFill.Controls.Add(cboDonVi);
            panelFill.Controls.Add(cboNguyenLieu);
            panelFill.Controls.Add(label8);
            panelFill.Controls.Add(label6);
            panelFill.Controls.Add(label5);
            panelFill.Controls.Add(groupBox2);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(671, 113);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(579, 700);
            panelFill.TabIndex = 2;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(141, 132);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(106, 30);
            nudSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(330, 86);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(147, 30);
            txtDonGia.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(57, 134);
            label11.Name = "label11";
            label11.Size = new Size(78, 23);
            label11.TabIndex = 4;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 89);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 4;
            label10.Text = "Đơn giá";
            // 
            // btnXoaNL
            // 
            btnXoaNL.BackColor = Color.Cyan;
            btnXoaNL.FlatAppearance.BorderSize = 0;
            btnXoaNL.FlatStyle = FlatStyle.Flat;
            btnXoaNL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoaNL.ForeColor = Color.White;
            btnXoaNL.Location = new Point(460, 168);
            btnXoaNL.Name = "btnXoaNL";
            btnXoaNL.Size = new Size(106, 46);
            btnXoaNL.TabIndex = 3;
            btnXoaNL.Text = "Xoá";
            btnXoaNL.UseVisualStyleBackColor = false;
            btnXoaNL.Click += btnXoaNL_Click;
            // 
            // btnThemNL
            // 
            btnThemNL.BackColor = Color.Cyan;
            btnThemNL.FlatAppearance.BorderSize = 0;
            btnThemNL.FlatStyle = FlatStyle.Flat;
            btnThemNL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThemNL.ForeColor = Color.White;
            btnThemNL.Location = new Point(330, 168);
            btnThemNL.Name = "btnThemNL";
            btnThemNL.Size = new Size(106, 50);
            btnThemNL.TabIndex = 3;
            btnThemNL.Text = "Thêm NL";
            btnThemNL.UseVisualStyleBackColor = false;
            btnThemNL.Click += btnThemNL_Click;
            // 
            // cboDonVi
            // 
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(138, 88);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(109, 31);
            cboDonVi.TabIndex = 2;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(138, 38);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(428, 31);
            cboNguyenLieu.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 91);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 1;
            label8.Text = "Đơn vị ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 47);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 1;
            label6.Text = "Tên nguyên liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 23);
            label5.TabIndex = 1;
            label5.Text = "Chi tiết hoá đơn nhập";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTiet);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 474);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chi tiết hoá đơn nhập";
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
            dgvChiTiet.Size = new Size(571, 445);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
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
            btnThemHD.TabIndex = 0;
            btnThemHD.Text = "Thêm HĐ";
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.Cyan;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(674, 11);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(147, 41);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Text = "In hoá đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnSuaHD
            // 
            btnSuaHD.BackColor = Color.Cyan;
            btnSuaHD.FlatAppearance.BorderSize = 0;
            btnSuaHD.FlatStyle = FlatStyle.Flat;
            btnSuaHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSuaHD.ForeColor = Color.White;
            btnSuaHD.Location = new Point(173, 11);
            btnSuaHD.Name = "btnSuaHD";
            btnSuaHD.Size = new Size(147, 41);
            btnSuaHD.TabIndex = 0;
            btnSuaHD.Text = "Sửa HĐ";
            btnSuaHD.UseVisualStyleBackColor = false;
            btnSuaHD.Click += btnSuaHD_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(506, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(147, 41);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.BackColor = Color.Cyan;
            btnHoanThanh.FlatAppearance.BorderSize = 0;
            btnHoanThanh.FlatStyle = FlatStyle.Flat;
            btnHoanThanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHoanThanh.ForeColor = Color.White;
            btnHoanThanh.Location = new Point(341, 11);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(147, 41);
            btnHoanThanh.TabIndex = 1;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = false;
            btnHoanThanh.Click += btnHoanThanh_Click;
            // 
            // btnXuatDS
            // 
            btnXuatDS.BackColor = Color.Cyan;
            btnXuatDS.FlatAppearance.BorderSize = 0;
            btnXuatDS.FlatStyle = FlatStyle.Flat;
            btnXuatDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuatDS.ForeColor = Color.White;
            btnXuatDS.Location = new Point(1001, 11);
            btnXuatDS.Name = "btnXuatDS";
            btnXuatDS.Size = new Size(147, 41);
            btnXuatDS.TabIndex = 5;
            btnXuatDS.Text = "Xuất DS";
            btnXuatDS.UseVisualStyleBackColor = false;
            btnXuatDS.Click += btnXuatDS_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(13, 68);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(971, 30);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnXoaHD
            // 
            btnXoaHD.BackColor = Color.Cyan;
            btnXoaHD.FlatAppearance.BorderSize = 0;
            btnXoaHD.FlatStyle = FlatStyle.Flat;
            btnXoaHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoaHD.ForeColor = Color.White;
            btnXoaHD.Location = new Point(837, 11);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(147, 41);
            btnXoaHD.TabIndex = 6;
            btnXoaHD.Text = "Xoá HD";
            btnXoaHD.UseVisualStyleBackColor = false;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(btnTimKiem);
            panelTop.Controls.Add(btnXoaHD);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(btnXuatDS);
            panelTop.Controls.Add(btnHoanThanh);
            panelTop.Controls.Add(btnLamMoi);
            panelTop.Controls.Add(btnSuaHD);
            panelTop.Controls.Add(btnInHoaDon);
            panelTop.Controls.Add(btnThemHD);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1250, 113);
            panelTop.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1001, 65);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(147, 33);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // FrmHoaDonNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 242, 242);
            ClientSize = new Size(1250, 813);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(30, 50, 80);
            Name = "FrmHoaDonNhap";
            Text = "FrmHoaDonNhap";
            Load += FrmHoaDonNhap_Load;
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
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLeft;
        private Panel panelFill;
        private GroupBox groupBox2;
        private TextBox txtMaHoaDon;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cboNhaCungCap;
        private ComboBox cboNhanVien;
        private GroupBox grpDSHD;
        private DateTimePicker dtpNgayNhap;
        private Label label7;
        private DataGridView dgvDanhSach;
        private Button btnXoaNL;
        private Button btnThemNL;
        private ComboBox cboNguyenLieu;
        private Label label6;
        private Label label5;
        private DataGridView dgvChiTiet;
        private Panel panelTongTien;
        private Label label9;
        private Label lblTongTien;
        private TextBox txtDonGia;
        private Label label11;
        private Label label10;
        private TextBox textBox1;
        private ComboBox cboKhuyenMai;
        private ComboBox cboDonVi;
        private Label label8;
        private NumericUpDown nudSoLuong;
        private Button btnThemHD;
        private Button btnInHoaDon;
        private Button btnSuaHD;
        private Button btnLamMoi;
        private Button btnHoanThanh;
        private Button btnXuatDS;
        private TextBox txtTimKiem;
        private Button btnXoaHD;
        private Panel panelTop;
        private Button btnTimKiem;
    }
}