namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmKhachHang
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
            dgvKhachHang = new DataGridView();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            dateNamsinh = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaKH = new TextBox();
            grbGioiTinh = new GroupBox();
            roNam = new RadioButton();
            roNu = new RadioButton();
            panelKH = new Panel();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grbGioiTinh.SuspendLayout();
            panelKH.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 294);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.ScrollBars = ScrollBars.None;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(996, 259);
            dgvKhachHang.TabIndex = 1;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(446, 130);
            txtSDT.MaxLength = 10;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 30);
            txtSDT.TabIndex = 55;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKH.Location = new Point(448, 20);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(192, 30);
            txtTenKH.TabIndex = 56;
            txtTenKH.KeyPress += txtTenKH_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(782, 130);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(201, 30);
            txtDiaChi.TabIndex = 57;
            // 
            // dateNamsinh
            // 
            dateNamsinh.CustomFormat = "dd/MM/yyyy";
            dateNamsinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNamsinh.Format = DateTimePickerFormat.Custom;
            dateNamsinh.Location = new Point(781, 19);
            dateNamsinh.Name = "dateNamsinh";
            dateNamsinh.Size = new Size(141, 30);
            dateNamsinh.TabIndex = 58;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Cyan;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(17, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Cyan;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(153, 242);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 60;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Cyan;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(289, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 59;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(877, 253);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 31);
            btnTimKiem.TabIndex = 62;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(641, 256);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(222, 27);
            txtTimkiem.TabIndex = 63;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 26);
            label7.Name = "label7";
            label7.Size = new Size(133, 23);
            label7.TabIndex = 52;
            label7.Text = "Mã khách hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(326, 130);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 51;
            label3.Text = "Số điện thoại ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(680, 22);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 50;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(307, 26);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 49;
            label5.Text = "Tên khách hàng ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(704, 132);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 48;
            label6.Text = "Địa chỉ";
            // 
            // txtMaKH
            // 
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(161, 19);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(103, 30);
            txtMaKH.TabIndex = 53;
            txtMaKH.KeyPress += txtMaKH_KeyPress;
            // 
            // grbGioiTinh
            // 
            grbGioiTinh.BackColor = Color.FromArgb(220, 242, 242);
            grbGioiTinh.Controls.Add(roNam);
            grbGioiTinh.Controls.Add(roNu);
            grbGioiTinh.FlatStyle = FlatStyle.Flat;
            grbGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbGioiTinh.ForeColor = Color.FromArgb(10, 50, 80);
            grbGioiTinh.Location = new Point(9, 102);
            grbGioiTinh.Name = "grbGioiTinh";
            grbGioiTinh.Size = new Size(283, 95);
            grbGioiTinh.TabIndex = 54;
            grbGioiTinh.TabStop = false;
            grbGioiTinh.Text = "Giới tính";
            // 
            // roNam
            // 
            roNam.AutoSize = true;
            roNam.Location = new Point(54, 36);
            roNam.Name = "roNam";
            roNam.Size = new Size(68, 27);
            roNam.TabIndex = 0;
            roNam.TabStop = true;
            roNam.Text = "Nam";
            roNam.UseVisualStyleBackColor = true;
            // 
            // roNu
            // 
            roNu.AutoSize = true;
            roNu.Location = new Point(144, 36);
            roNu.Name = "roNu";
            roNu.Size = new Size(54, 27);
            roNu.TabIndex = 0;
            roNu.TabStop = true;
            roNu.Text = "Nữ";
            roNu.UseVisualStyleBackColor = true;
            // 
            // panelKH
            // 
            panelKH.BackColor = Color.FromArgb(220, 242, 242);
            panelKH.BorderStyle = BorderStyle.FixedSingle;
            panelKH.Controls.Add(btnLamMoi);
            panelKH.Controls.Add(grbGioiTinh);
            panelKH.Controls.Add(txtMaKH);
            panelKH.Controls.Add(label6);
            panelKH.Controls.Add(label5);
            panelKH.Controls.Add(label4);
            panelKH.Controls.Add(label3);
            panelKH.Controls.Add(label7);
            panelKH.Controls.Add(txtTimkiem);
            panelKH.Controls.Add(btnTimKiem);
            panelKH.Controls.Add(btnXoa);
            panelKH.Controls.Add(btnSua);
            panelKH.Controls.Add(btnThem);
            panelKH.Controls.Add(dateNamsinh);
            panelKH.Controls.Add(txtDiaChi);
            panelKH.Controls.Add(txtTenKH);
            panelKH.Controls.Add(txtSDT);
            panelKH.Dock = DockStyle.Top;
            panelKH.ForeColor = Color.FromArgb(10, 50, 80);
            panelKH.Location = new Point(0, 0);
            panelKH.Name = "panelKH";
            panelKH.Size = new Size(996, 294);
            panelKH.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(421, 242);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 64;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FrmKhachHang
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(996, 553);
            Controls.Add(dgvKhachHang);
            Controls.Add(panelKH);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmKhachHang";
            Text = "Quản lý khách hàng";
            Load += FrmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grbGioiTinh.ResumeLayout(false);
            grbGioiTinh.PerformLayout();
            panelKH.ResumeLayout(false);
            panelKH.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKhachHang;
        private Panel panelKH;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private DateTimePicker dateNamsinh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaKH;
        private GroupBox grbGioiTinh;
        private RadioButton roNam;
        private RadioButton roNu;
        private Button btnLamMoi;
    }
}