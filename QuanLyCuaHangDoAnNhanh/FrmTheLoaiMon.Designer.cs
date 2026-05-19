namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmTheLoaiMon
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
            radNgungBan = new RadioButton();
            grbTrangThai = new GroupBox();
            radConBan = new RadioButton();
            label1 = new Label();
            txtMaLoaiMon = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtMoTa = new TextBox();
            txtTenLoaiMon = new TextBox();
            dgvTheLoaiMon = new DataGridView();
            btnThem = new Button();
            panelMonAn = new Panel();
            btnLamMoi = new Button();
            grbTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiMon).BeginInit();
            panelMonAn.SuspendLayout();
            SuspendLayout();
            // 
            // radNgungBan
            // 
            radNgungBan.AutoSize = true;
            radNgungBan.Location = new Point(144, 36);
            radNgungBan.Name = "radNgungBan";
            radNgungBan.Size = new Size(84, 27);
            radNgungBan.TabIndex = 0;
            radNgungBan.TabStop = true;
            radNgungBan.Text = "Ngừng";
            radNgungBan.UseVisualStyleBackColor = true;
            // 
            // grbTrangThai
            // 
            grbTrangThai.Controls.Add(radConBan);
            grbTrangThai.Controls.Add(radNgungBan);
            grbTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbTrangThai.Location = new Point(34, 105);
            grbTrangThai.Name = "grbTrangThai";
            grbTrangThai.Size = new Size(262, 78);
            grbTrangThai.TabIndex = 82;
            grbTrangThai.TabStop = false;
            grbTrangThai.Text = "Trạng thái";
            // 
            // radConBan
            // 
            radConBan.AutoSize = true;
            radConBan.Location = new Point(6, 36);
            radConBan.Name = "radConBan";
            radConBan.Size = new Size(113, 27);
            radConBan.TabIndex = 0;
            radConBan.TabStop = true;
            radConBan.Text = "Hoạt động";
            radConBan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(610, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 80;
            label1.Text = "Mô tả";
            // 
            // txtMaLoaiMon
            // 
            txtMaLoaiMon.BorderStyle = BorderStyle.FixedSingle;
            txtMaLoaiMon.Location = new Point(40, 53);
            txtMaLoaiMon.Name = "txtMaLoaiMon";
            txtMaLoaiMon.Size = new Size(146, 30);
            txtMaLoaiMon.TabIndex = 69;
            txtMaLoaiMon.KeyPress += txtMaLoaiMon_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(330, 18);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 65;
            label5.Text = "Tên loại món";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 18);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 68;
            label7.Text = "Mã loại món";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(610, 224);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(199, 30);
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
            btnTimKiem.Location = new Point(815, 221);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 31);
            btnTimKiem.TabIndex = 78;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Cyan;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(330, 215);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 75;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Cyan;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(191, 216);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 76;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.BorderStyle = BorderStyle.FixedSingle;
            txtMoTa.Font = new Font("Segoe UI", 10.2F);
            txtMoTa.Location = new Point(610, 53);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(319, 30);
            txtMoTa.TabIndex = 73;
            txtMoTa.KeyPress += txtMoTa_KeyPress;
            // 
            // txtTenLoaiMon
            // 
            txtTenLoaiMon.BorderStyle = BorderStyle.FixedSingle;
            txtTenLoaiMon.Font = new Font("Segoe UI", 10.2F);
            txtTenLoaiMon.Location = new Point(330, 53);
            txtTenLoaiMon.Name = "txtTenLoaiMon";
            txtTenLoaiMon.Size = new Size(233, 30);
            txtTenLoaiMon.TabIndex = 72;
            txtTenLoaiMon.KeyPress += txtTenLoaiMon_KeyPress;
            // 
            // dgvTheLoaiMon
            // 
            dgvTheLoaiMon.AllowUserToAddRows = false;
            dgvTheLoaiMon.AllowUserToDeleteRows = false;
            dgvTheLoaiMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoaiMon.BackgroundColor = Color.White;
            dgvTheLoaiMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoaiMon.Dock = DockStyle.Fill;
            dgvTheLoaiMon.Location = new Point(0, 276);
            dgvTheLoaiMon.Name = "dgvTheLoaiMon";
            dgvTheLoaiMon.ReadOnly = true;
            dgvTheLoaiMon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTheLoaiMon.RowHeadersVisible = false;
            dgvTheLoaiMon.RowHeadersWidth = 51;
            dgvTheLoaiMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoaiMon.Size = new Size(934, 277);
            dgvTheLoaiMon.TabIndex = 3;
            dgvTheLoaiMon.CellContentClick += dgvTheLoaiMon_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Cyan;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(34, 216);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 77;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panelMonAn
            // 
            panelMonAn.BackColor = Color.FromArgb(220, 242, 242);
            panelMonAn.BorderStyle = BorderStyle.FixedSingle;
            panelMonAn.Controls.Add(grbTrangThai);
            panelMonAn.Controls.Add(label1);
            panelMonAn.Controls.Add(txtMaLoaiMon);
            panelMonAn.Controls.Add(label5);
            panelMonAn.Controls.Add(label7);
            panelMonAn.Controls.Add(txtTimkiem);
            panelMonAn.Controls.Add(btnTimKiem);
            panelMonAn.Controls.Add(btnXoa);
            panelMonAn.Controls.Add(btnLamMoi);
            panelMonAn.Controls.Add(btnSua);
            panelMonAn.Controls.Add(btnThem);
            panelMonAn.Controls.Add(txtMoTa);
            panelMonAn.Controls.Add(txtTenLoaiMon);
            panelMonAn.Dock = DockStyle.Top;
            panelMonAn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMonAn.ForeColor = Color.FromArgb(10, 50, 80);
            panelMonAn.Location = new Point(0, 0);
            panelMonAn.Name = "panelMonAn";
            panelMonAn.Size = new Size(934, 276);
            panelMonAn.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(469, 215);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 76;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FrmTheLoaiMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 553);
            Controls.Add(dgvTheLoaiMon);
            Controls.Add(panelMonAn);
            Name = "FrmTheLoaiMon";
            Text = "FrmTheLoaiMon";
            Load += FrmTheLoaiMon_Load;
            grbTrangThai.ResumeLayout(false);
            grbTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiMon).EndInit();
            panelMonAn.ResumeLayout(false);
            panelMonAn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radNgungBan;
        private GroupBox grbTrangThai;
        private RadioButton radConBan;
        private Label label1;
        private TextBox txtMaLoaiMon;
        private Label label5;
        private Label label7;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtMoTa;
        private TextBox txtTenLoaiMon;
        private DataGridView dgvTheLoaiMon;
        private Button btnThem;
        private Panel panelMonAn;
        private Button btnLamMoi;
    }
}