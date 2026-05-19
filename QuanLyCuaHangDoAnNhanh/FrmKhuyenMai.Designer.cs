namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmKhuyenMai
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
            txtTimkiem = new TextBox();
            txtMaKM = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenKM = new TextBox();
            dgvKhuyenMai = new DataGridView();
            panelKM = new Panel();
            txtGiaTri = new TextBox();
            label8 = new Label();
            cboTrangThai = new ComboBox();
            cbMonAn = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            cboLoaiKM = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
            panelKM.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(580, 222);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(256, 27);
            txtTimkiem.TabIndex = 63;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // txtMaKM
            // 
            txtMaKM.Location = new Point(132, 38);
            txtMaKM.Name = "txtMaKM";
            txtMaKM.Size = new Size(87, 27);
            txtMaKM.TabIndex = 53;
            txtMaKM.KeyPress += txtMaKM_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 92);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 49;
            label5.Text = "Tên khuyến mãi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 37);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 50;
            label4.Text = "Loại khuyến mãi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 37);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 52;
            label7.Text = "Mã khuyến mãi";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(858, 222);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
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
            btnLamMoi.Location = new Point(450, 214);
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
            btnXoa.Location = new Point(303, 214);
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
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(157, 214);
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
            btnThem.Location = new Point(17, 214);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenKM
            // 
            txtTenKM.Location = new Point(132, 92);
            txtTenKM.Name = "txtTenKM";
            txtTenKM.Size = new Size(412, 27);
            txtTenKM.TabIndex = 56;
            // 
            // dgvKhuyenMai
            // 
            dgvKhuyenMai.AllowUserToAddRows = false;
            dgvKhuyenMai.AllowUserToDeleteRows = false;
            dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuyenMai.BackgroundColor = Color.White;
            dgvKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhuyenMai.Dock = DockStyle.Fill;
            dgvKhuyenMai.Location = new Point(0, 274);
            dgvKhuyenMai.MultiSelect = false;
            dgvKhuyenMai.Name = "dgvKhuyenMai";
            dgvKhuyenMai.ReadOnly = true;
            dgvKhuyenMai.RowHeadersVisible = false;
            dgvKhuyenMai.RowHeadersWidth = 51;
            dgvKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuyenMai.Size = new Size(970, 279);
            dgvKhuyenMai.TabIndex = 3;
            dgvKhuyenMai.CellContentClick += dgvKhuyenMai_CellContentClick;
            // 
            // panelKM
            // 
            panelKM.BackColor = Color.FromArgb(220, 242, 242);
            panelKM.BorderStyle = BorderStyle.FixedSingle;
            panelKM.Controls.Add(txtGiaTri);
            panelKM.Controls.Add(label8);
            panelKM.Controls.Add(cboTrangThai);
            panelKM.Controls.Add(cbMonAn);
            panelKM.Controls.Add(label6);
            panelKM.Controls.Add(label3);
            panelKM.Controls.Add(dtpKetThuc);
            panelKM.Controls.Add(dtpBatDau);
            panelKM.Controls.Add(label2);
            panelKM.Controls.Add(label1);
            panelKM.Controls.Add(cboLoaiKM);
            panelKM.Controls.Add(txtMaKM);
            panelKM.Controls.Add(label5);
            panelKM.Controls.Add(label4);
            panelKM.Controls.Add(label7);
            panelKM.Controls.Add(txtTimkiem);
            panelKM.Controls.Add(btnTimKiem);
            panelKM.Controls.Add(btnLamMoi);
            panelKM.Controls.Add(btnXoa);
            panelKM.Controls.Add(btnSua);
            panelKM.Controls.Add(btnThem);
            panelKM.Controls.Add(txtTenKM);
            panelKM.Dock = DockStyle.Top;
            panelKM.ForeColor = Color.FromArgb(10, 50, 80);
            panelKM.Location = new Point(0, 0);
            panelKM.Name = "panelKM";
            panelKM.Size = new Size(970, 274);
            panelKM.TabIndex = 2;
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(684, 34);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(125, 27);
            txtGiaTri.TabIndex = 72;
            txtGiaTri.KeyPress += txtGiaTri_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(625, 38);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 71;
            label8.Text = "Giá trị ";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(684, 154);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(133, 28);
            cboTrangThai.TabIndex = 70;
            // 
            // cbMonAn
            // 
            cbMonAn.FormattingEnabled = true;
            cbMonAn.Location = new Point(684, 92);
            cbMonAn.Name = "cbMonAn";
            cbMonAn.Size = new Size(268, 28);
            cbMonAn.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 157);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 68;
            label6.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 92);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 67;
            label3.Text = "Món áp dụng";
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.Location = new Point(419, 157);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(125, 27);
            dtpKetThuc.TabIndex = 66;
            // 
            // dtpBatDau
            // 
            dtpBatDau.CustomFormat = "dd/MM/yyyy";
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(132, 157);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(143, 27);
            dtpBatDau.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 157);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 65;
            label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 157);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 65;
            label1.Text = "Ngày bắt đầu ";
            // 
            // cboLoaiKM
            // 
            cboLoaiKM.FormattingEnabled = true;
            cboLoaiKM.Location = new Point(368, 37);
            cboLoaiKM.Name = "cboLoaiKM";
            cboLoaiKM.Size = new Size(176, 28);
            cboLoaiKM.TabIndex = 64;
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 553);
            Controls.Add(dgvKhuyenMai);
            Controls.Add(panelKM);
            Name = "FrmKhuyenMai";
            Text = "FrmKhuyenMai";
            Load += FrmKhuyenMai_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
            panelKM.ResumeLayout(false);
            panelKM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTimkiem;
        private TextBox txtMaKM;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenKM;
        private DataGridView dgvKhuyenMai;
        private Panel panelKM;
        private ComboBox cboTrangThai;
        private ComboBox cbMonAn;
        private Label label6;
        private Label label3;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Label label2;
        private Label label1;
        private ComboBox cboLoaiKM;
        private TextBox txtGiaTri;
        private Label label8;
    }
}