namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmKho
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
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panelKho = new Panel();
            groupBox2 = new GroupBox();
            CbTrangThai = new CheckBox();
            txtDiaChiKho = new TextBox();
            cbTenKho = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cbDonvitinh = new ComboBox();
            txtTenNL = new TextBox();
            txtMaNL = new TextBox();
            nudSoLuongTon = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvKho = new DataGridView();
            panelKho.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(610, 283);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(246, 27);
            txtTimkiem.TabIndex = 79;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Cyan;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(863, 283);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 78;
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
            btnLamMoi.Location = new Point(492, 275);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 75;
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
            btnXoa.Location = new Point(182, 275);
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
            btnSua.Location = new Point(336, 275);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 76;
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
            btnThem.Location = new Point(24, 275);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 77;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panelKho
            // 
            panelKho.BackColor = Color.White;
            panelKho.BorderStyle = BorderStyle.FixedSingle;
            panelKho.Controls.Add(groupBox2);
            panelKho.Controls.Add(groupBox1);
            panelKho.Controls.Add(txtTimkiem);
            panelKho.Controls.Add(btnTimKiem);
            panelKho.Controls.Add(btnLamMoi);
            panelKho.Controls.Add(btnXoa);
            panelKho.Controls.Add(btnSua);
            panelKho.Controls.Add(btnThem);
            panelKho.Dock = DockStyle.Top;
            panelKho.Location = new Point(0, 0);
            panelKho.Name = "panelKho";
            panelKho.Size = new Size(970, 332);
            panelKho.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(220, 242, 242);
            groupBox2.Controls.Add(CbTrangThai);
            groupBox2.Controls.Add(txtDiaChiKho);
            groupBox2.Controls.Add(cbTenKho);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(10, 50, 80);
            groupBox2.Location = new Point(538, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 231);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin kho ";
            // 
            // CbTrangThai
            // 
            CbTrangThai.AutoSize = true;
            CbTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbTrangThai.Location = new Point(160, 148);
            CbTrangThai.Name = "CbTrangThai";
            CbTrangThai.Size = new Size(158, 27);
            CbTrangThai.TabIndex = 3;
            CbTrangThai.Text = "Đang hoạt động";
            CbTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiKho
            // 
            txtDiaChiKho.ForeColor = Color.FromArgb(10, 50, 80);
            txtDiaChiKho.Location = new Point(143, 86);
            txtDiaChiKho.Name = "txtDiaChiKho";
            txtDiaChiKho.Size = new Size(175, 30);
            txtDiaChiKho.TabIndex = 2;
            // 
            // cbTenKho
            // 
            cbTenKho.ForeColor = Color.FromArgb(10, 50, 80);
            cbTenKho.FormattingEnabled = true;
            cbTenKho.Location = new Point(143, 37);
            cbTenKho.Name = "cbTenKho";
            cbTenKho.Size = new Size(175, 31);
            cbTenKho.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.FromArgb(10, 50, 80);
            label7.Location = new Point(15, 148);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 0;
            label7.Text = "Trạng thái kho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.ForeColor = Color.FromArgb(10, 50, 80);
            label6.Location = new Point(40, 92);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(40, 43);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 0;
            label5.Text = "Tên kho";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(220, 242, 242);
            groupBox1.Controls.Add(cbDonvitinh);
            groupBox1.Controls.Add(txtTenNL);
            groupBox1.Controls.Add(txtMaNL);
            groupBox1.Controls.Add(nudSoLuongTon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(10, 50, 80);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 231);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nguyên liệu ";
            // 
            // cbDonvitinh
            // 
            cbDonvitinh.ForeColor = Color.FromArgb(10, 50, 80);
            cbDonvitinh.FormattingEnabled = true;
            cbDonvitinh.Location = new Point(170, 141);
            cbDonvitinh.Name = "cbDonvitinh";
            cbDonvitinh.Size = new Size(125, 33);
            cbDonvitinh.TabIndex = 3;
            // 
            // txtTenNL
            // 
            txtTenNL.ForeColor = Color.FromArgb(10, 50, 80);
            txtTenNL.Location = new Point(170, 86);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.Size = new Size(232, 31);
            txtTenNL.TabIndex = 2;
            // 
            // txtMaNL
            // 
            txtMaNL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNL.ForeColor = Color.FromArgb(10, 50, 80);
            txtMaNL.Location = new Point(170, 40);
            txtMaNL.Name = "txtMaNL";
            txtMaNL.Size = new Size(232, 30);
            txtMaNL.TabIndex = 2;
            // 
            // nudSoLuongTon
            // 
            nudSoLuongTon.ForeColor = Color.FromArgb(10, 50, 80);
            nudSoLuongTon.Location = new Point(170, 182);
            nudSoLuongTon.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuongTon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuongTon.Name = "nudSoLuongTon";
            nudSoLuongTon.Size = new Size(125, 31);
            nudSoLuongTon.TabIndex = 1;
            nudSoLuongTon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(39, 184);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 0;
            label4.Text = "Số lượng tồn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(39, 141);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 0;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên nguyên liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã nguyên liệu";
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AllowUserToDeleteRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = Color.White;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Dock = DockStyle.Fill;
            dgvKho.Location = new Point(0, 332);
            dgvKho.MultiSelect = false;
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKho.RowHeadersVisible = false;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(970, 261);
            dgvKho.TabIndex = 3;
            dgvKho.CellContentClick += dgvKho_CellContentClick;
            // 
            // FrmKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 593);
            Controls.Add(dgvKho);
            Controls.Add(panelKho);
            Name = "FrmKho";
            Text = "FrmKho";
            Load += FrmKho_Load;
            panelKho.ResumeLayout(false);
            panelKho.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panelKho;
        private DataGridView dgvKho;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private NumericUpDown nudSoLuongTon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox CbTrangThai;
        private TextBox txtDiaChiKho;
        private ComboBox cbTenKho;
        private ComboBox cbDonvitinh;
        private TextBox txtTenNL;
        private TextBox txtMaNL;
    }
}