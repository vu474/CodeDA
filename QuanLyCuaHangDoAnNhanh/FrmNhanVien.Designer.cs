namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmNhanVien
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
            panelNV = new Panel();
            grbGioiTinh = new GroupBox();
            roNam = new RadioButton();
            roNu = new RadioButton();
            txtMaNV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dateNamsinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtTenNV = new TextBox();
            txtSDT = new TextBox();
            dgvNhanVien = new DataGridView();
            panelNV.SuspendLayout();
            grbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panelNV
            // 
            panelNV.BackColor = Color.FromArgb(220, 242, 242);
            panelNV.BorderStyle = BorderStyle.FixedSingle;
            panelNV.Controls.Add(grbGioiTinh);
            panelNV.Controls.Add(txtMaNV);
            panelNV.Controls.Add(label6);
            panelNV.Controls.Add(label5);
            panelNV.Controls.Add(label4);
            panelNV.Controls.Add(label3);
            panelNV.Controls.Add(label7);
            panelNV.Controls.Add(txtTimkiem);
            panelNV.Controls.Add(btnTimKiem);
            panelNV.Controls.Add(btnLamMoi);
            panelNV.Controls.Add(btnXoa);
            panelNV.Controls.Add(btnSua);
            panelNV.Controls.Add(btnThem);
            panelNV.Controls.Add(dateNamsinh);
            panelNV.Controls.Add(txtDiaChi);
            panelNV.Controls.Add(txtTenNV);
            panelNV.Controls.Add(txtSDT);
            panelNV.Dock = DockStyle.Top;
            panelNV.ForeColor = Color.FromArgb(30, 50, 80);
            panelNV.Location = new Point(0, 0);
            panelNV.Name = "panelNV";
            panelNV.Size = new Size(1022, 294);
            panelNV.TabIndex = 2;
            // 
            // grbGioiTinh
            // 
            grbGioiTinh.Controls.Add(roNam);
            grbGioiTinh.Controls.Add(roNu);
            grbGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbGioiTinh.Location = new Point(12, 103);
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
            roNu.Location = new Point(162, 36);
            roNu.Name = "roNu";
            roNu.Size = new Size(54, 27);
            roNu.TabIndex = 0;
            roNu.TabStop = true;
            roNu.Text = "Nữ";
            roNu.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(140, 21);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(155, 30);
            txtMaNV.TabIndex = 53;
            txtMaNV.KeyPress += txtMaNV_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(718, 121);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 48;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(334, 23);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 49;
            label5.Text = "Tên nhân viên ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(694, 23);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 50;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(339, 124);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 51;
            label3.Text = "Số điện thoại ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 23);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 52;
            label7.Text = "Mã nhân viên";
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Location = new Point(576, 256);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(263, 27);
            txtTimkiem.TabIndex = 63;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(855, 252);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 31);
            btnTimKiem.TabIndex = 62;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(449, 242);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Cyan;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(298, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 59;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Cyan;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(156, 242);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 60;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Cyan;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(13, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dateNamsinh
            // 
            dateNamsinh.CustomFormat = "dd/MM/yyyy";
            dateNamsinh.Format = DateTimePickerFormat.Custom;
            dateNamsinh.Location = new Point(789, 19);
            dateNamsinh.Name = "dateNamsinh";
            dateNamsinh.Size = new Size(107, 27);
            dateNamsinh.TabIndex = 58;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(789, 114);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(196, 30);
            txtDiaChi.TabIndex = 57;
            // 
            // txtTenNV
            // 
            txtTenNV.BorderStyle = BorderStyle.FixedSingle;
            txtTenNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNV.Location = new Point(466, 21);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(191, 30);
            txtTenNV.TabIndex = 56;
            txtTenNV.KeyPress += txtTenNV_KeyPress;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(466, 119);
            txtSDT.MaxLength = 10;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(191, 30);
            txtSDT.TabIndex = 55;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 294);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1022, 259);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // FrmNhanVien
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1022, 553);
            Controls.Add(dgvNhanVien);
            Controls.Add(panelNV);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            Load += FrmNhanVien_Load;
            panelNV.ResumeLayout(false);
            panelNV.PerformLayout();
            grbGioiTinh.ResumeLayout(false);
            grbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNV;
        private GroupBox grbGioiTinh;
        private RadioButton roNam;
        private RadioButton roNu;
        private TextBox txtMaNV;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateNamsinh;
        private TextBox txtDiaChi;
        private TextBox txtTenNV;
        private TextBox txtSDT;
        private DataGridView dgvNhanVien;
        private Button btnLamMoi;
    }
}