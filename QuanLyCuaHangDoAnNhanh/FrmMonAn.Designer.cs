namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmMonAn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMonAn = new Panel();
            cboLoaiMon = new ComboBox();
            btnLamMoi = new Button();
            grbGioiTinh = new GroupBox();
            radConBan = new RadioButton();
            radNgungBan = new RadioButton();
            label2 = new Label();
            picHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            label1 = new Label();
            txtMaMonAn = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGia = new TextBox();
            txtTenMonAn = new TextBox();
            dgvMonAN = new DataGridView();
            panelMonAn.SuspendLayout();
            grbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAN).BeginInit();
            SuspendLayout();
            // 
            // panelMonAn
            // 
            panelMonAn.BackColor = Color.FromArgb(220, 242, 242);
            panelMonAn.BorderStyle = BorderStyle.FixedSingle;
            panelMonAn.Controls.Add(cboLoaiMon);
            panelMonAn.Controls.Add(btnLamMoi);
            panelMonAn.Controls.Add(grbGioiTinh);
            panelMonAn.Controls.Add(label2);
            panelMonAn.Controls.Add(picHinhAnh);
            panelMonAn.Controls.Add(btnChonAnh);
            panelMonAn.Controls.Add(label1);
            panelMonAn.Controls.Add(txtMaMonAn);
            panelMonAn.Controls.Add(label5);
            panelMonAn.Controls.Add(label3);
            panelMonAn.Controls.Add(label7);
            panelMonAn.Controls.Add(txtTimkiem);
            panelMonAn.Controls.Add(btnTimKiem);
            panelMonAn.Controls.Add(btnXoa);
            panelMonAn.Controls.Add(btnSua);
            panelMonAn.Controls.Add(btnThem);
            panelMonAn.Controls.Add(txtGia);
            panelMonAn.Controls.Add(txtTenMonAn);
            panelMonAn.Dock = DockStyle.Top;
            panelMonAn.ForeColor = Color.FromArgb(30, 50, 80);
            panelMonAn.Location = new Point(0, 0);
            panelMonAn.Name = "panelMonAn";
            panelMonAn.Size = new Size(998, 307);
            panelMonAn.TabIndex = 0;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.Font = new Font("Segoe UI", 10.2F);
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(196, 155);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(288, 31);
            cboLoaiMon.TabIndex = 87;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(514, 253);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 42);
            btnLamMoi.TabIndex = 86;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grbGioiTinh
            // 
            grbGioiTinh.Controls.Add(radConBan);
            grbGioiTinh.Controls.Add(radNgungBan);
            grbGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbGioiTinh.Location = new Point(514, 31);
            grbGioiTinh.Name = "grbGioiTinh";
            grbGioiTinh.Size = new Size(262, 95);
            grbGioiTinh.TabIndex = 82;
            grbGioiTinh.TabStop = false;
            grbGioiTinh.Text = "Trạng thái";
            // 
            // radConBan
            // 
            radConBan.AutoSize = true;
            radConBan.Location = new Point(6, 36);
            radConBan.Name = "radConBan";
            radConBan.Size = new Size(106, 27);
            radConBan.TabIndex = 0;
            radConBan.TabStop = true;
            radConBan.Text = "Đang bán";
            radConBan.UseVisualStyleBackColor = true;
            // 
            // radNgungBan
            // 
            radNgungBan.AutoSize = true;
            radNgungBan.Location = new Point(144, 36);
            radNgungBan.Name = "radNgungBan";
            radNgungBan.Size = new Size(118, 27);
            radNgungBan.TabIndex = 0;
            radNgungBan.TabStop = true;
            radNgungBan.Text = "Ngừng bán";
            radNgungBan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(829, 8);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 85;
            label2.Text = "Ảnh minh hoạ";
            // 
            // picHinhAnh
            // 
            picHinhAnh.BackColor = Color.White;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(799, 43);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(178, 195);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 84;
            picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.Cyan;
            btnChonAnh.FlatAppearance.BorderSize = 0;
            btnChonAnh.FlatStyle = FlatStyle.Flat;
            btnChonAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnChonAnh.ForeColor = Color.White;
            btnChonAnh.Location = new Point(390, 253);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 42);
            btnChonAnh.TabIndex = 83;
            btnChonAnh.Text = "Chọn ảnh ";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 125);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 80;
            label1.Text = "Giá bán";
            // 
            // txtMaMonAn
            // 
            txtMaMonAn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaMonAn.Location = new Point(34, 62);
            txtMaMonAn.Name = "txtMaMonAn";
            txtMaMonAn.Size = new Size(135, 30);
            txtMaMonAn.TabIndex = 69;
            txtMaMonAn.KeyPress += txtMaMonAn_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(196, 31);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 65;
            label5.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(196, 125);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 67;
            label3.Text = "Loại món";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 31);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 68;
            label7.Text = "Mã món ăn";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimkiem.Location = new Point(649, 265);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(222, 30);
            txtTimkiem.TabIndex = 79;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(877, 266);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 29);
            btnTimKiem.TabIndex = 78;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Cyan;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(270, 253);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 42);
            btnXoa.TabIndex = 75;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Cyan;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(146, 253);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 42);
            btnSua.TabIndex = 76;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Cyan;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(31, 253);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 42);
            btnThem.TabIndex = 77;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGia.Location = new Point(31, 156);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(138, 30);
            txtGia.TabIndex = 73;
            txtGia.KeyPress += txtGia_KeyPress;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Font = new Font("Segoe UI", 10.2F);
            txtTenMonAn.Location = new Point(196, 62);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(288, 30);
            txtTenMonAn.TabIndex = 72;
            // 
            // dgvMonAN
            // 
            dgvMonAN.AllowUserToAddRows = false;
            dgvMonAN.AllowUserToDeleteRows = false;
            dgvMonAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAN.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMonAN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMonAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAN.Dock = DockStyle.Fill;
            dgvMonAN.EnableHeadersVisualStyles = false;
            dgvMonAN.Location = new Point(0, 307);
            dgvMonAN.MultiSelect = false;
            dgvMonAN.Name = "dgvMonAN";
            dgvMonAN.ReadOnly = true;
            dgvMonAN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMonAN.RowHeadersVisible = false;
            dgvMonAN.RowHeadersWidth = 51;
            dgvMonAN.RowTemplate.Height = 80;
            dgvMonAN.ScrollBars = ScrollBars.None;
            dgvMonAN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonAN.Size = new Size(998, 346);
            dgvMonAN.TabIndex = 1;
            dgvMonAN.CellContentClick += dgvMonAN_CellContentClick;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 653);
            Controls.Add(dgvMonAN);
            Controls.Add(panelMonAn);
            Name = "FrmMonAn";
            Text = "FrmMonAn";
            Load += FrmMonAn_Load;
            panelMonAn.ResumeLayout(false);
            panelMonAn.PerformLayout();
            grbGioiTinh.ResumeLayout(false);
            grbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMonAn;
        private DataGridView dgvMonAN;
        private TextBox txtMaMonAn;
        private Label label5;
        private Label label3;
        private Label label7;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenMonAn;
        private Label label1;
        private TextBox txtGia;
        private GroupBox grbGioiTinh;
        private RadioButton radConBan;
        private RadioButton radNgungBan;
        private PictureBox picHinhAnh;
        private Button btnChonAnh;
        private Label label2;
        private Button btnLamMoi;
        private ComboBox cboLoaiMon;
    }
}