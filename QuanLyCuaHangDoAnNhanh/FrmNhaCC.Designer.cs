namespace QuanLyCuaHangDoAnNhanh
{
    partial class FrmNhaCC
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
            txtMaNCC = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtEmail = new TextBox();
            txtTenNCC = new TextBox();
            txtSDT = new TextBox();
            dgvNhaCC = new DataGridView();
            panelNCC = new Panel();
            label1 = new Label();
            txtDiaChi = new TextBox();
            btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).BeginInit();
            panelNCC.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaNCC
            // 
            txtMaNCC.BorderStyle = BorderStyle.FixedSingle;
            txtMaNCC.Font = new Font("Segoe UI", 10.2F);
            txtMaNCC.Location = new Point(114, 26);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(90, 30);
            txtMaNCC.TabIndex = 53;
            txtMaNCC.KeyPress += txtMaNCC_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(597, 31);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 48;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(34, 72);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 49;
            label5.Text = "Tên NCC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(261, 31);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 51;
            label3.Text = "Số điện thoại ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(34, 31);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 52;
            label7.Text = "Mã NCC";
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Location = new Point(597, 184);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(216, 27);
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
            btnTimKiem.Location = new Point(831, 180);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(117, 31);
            btnTimKiem.TabIndex = 62;
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
            btnXoa.Location = new Point(292, 170);
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
            btnSua.Location = new Point(165, 170);
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
            btnThem.Location = new Point(34, 170);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(665, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 30);
            txtEmail.TabIndex = 57;
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderStyle = BorderStyle.FixedSingle;
            txtTenNCC.Font = new Font("Segoe UI", 10.2F);
            txtTenNCC.Location = new Point(34, 107);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(352, 30);
            txtTenNCC.TabIndex = 56;
            txtTenNCC.KeyPress += txtTenNCC_KeyPress;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 10.2F);
            txtSDT.Location = new Point(383, 31);
            txtSDT.MaxLength = 10;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(181, 30);
            txtSDT.TabIndex = 55;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // dgvNhaCC
            // 
            dgvNhaCC.AllowUserToAddRows = false;
            dgvNhaCC.AllowUserToDeleteRows = false;
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCC.BackgroundColor = Color.White;
            dgvNhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCC.Dock = DockStyle.Fill;
            dgvNhaCC.Location = new Point(0, 225);
            dgvNhaCC.MultiSelect = false;
            dgvNhaCC.Name = "dgvNhaCC";
            dgvNhaCC.ReadOnly = true;
            dgvNhaCC.RowHeadersVisible = false;
            dgvNhaCC.RowHeadersWidth = 51;
            dgvNhaCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaCC.Size = new Size(962, 328);
            dgvNhaCC.TabIndex = 3;
            dgvNhaCC.CellContentClick += dgvNhaCC_CellContentClick;
            // 
            // panelNCC
            // 
            panelNCC.BackColor = Color.FromArgb(220, 242, 242);
            panelNCC.BorderStyle = BorderStyle.FixedSingle;
            panelNCC.Controls.Add(label1);
            panelNCC.Controls.Add(txtDiaChi);
            panelNCC.Controls.Add(txtMaNCC);
            panelNCC.Controls.Add(label6);
            panelNCC.Controls.Add(label5);
            panelNCC.Controls.Add(label3);
            panelNCC.Controls.Add(label7);
            panelNCC.Controls.Add(txtTimkiem);
            panelNCC.Controls.Add(btnTimKiem);
            panelNCC.Controls.Add(btnLamMoi);
            panelNCC.Controls.Add(btnXoa);
            panelNCC.Controls.Add(btnSua);
            panelNCC.Controls.Add(btnThem);
            panelNCC.Controls.Add(txtEmail);
            panelNCC.Controls.Add(txtTenNCC);
            panelNCC.Controls.Add(txtSDT);
            panelNCC.Dock = DockStyle.Top;
            panelNCC.ForeColor = Color.FromArgb(10, 50, 80);
            panelNCC.Location = new Point(0, 0);
            panelNCC.Name = "panelNCC";
            panelNCC.Size = new Size(962, 225);
            panelNCC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(597, 94);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 66;
            label1.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10.2F);
            txtDiaChi.Location = new Point(665, 87);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(283, 30);
            txtDiaChi.TabIndex = 65;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Cyan;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(428, 170);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FrmNhaCC
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(962, 553);
            Controls.Add(dgvNhaCC);
            Controls.Add(panelNCC);
            Name = "FrmNhaCC";
            Text = "FrmNhaCC";
            Load += FrmNhaCC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).EndInit();
            panelNCC.ResumeLayout(false);
            panelNCC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMaNCC;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label7;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtEmail;
        private TextBox txtTenNCC;
        private TextBox txtSDT;
        private DataGridView dgvNhaCC;
        private Panel panelNCC;
        private TextBox txtDiaChi;
        private Label label1;
        private Button btnLamMoi;
    }
}