namespace QuanLyCuaHangDoAnNhanh
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_DangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label2 = new Label();
            label4 = new Label();
            l = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.White;
            btn_DangNhap.FlatAppearance.BorderSize = 0;
            btn_DangNhap.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btn_DangNhap.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btn_DangNhap.FlatStyle = FlatStyle.Flat;
            btn_DangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangNhap.ForeColor = Color.FromArgb(30, 50, 80);
            btn_DangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DangNhap.Location = new Point(636, 305);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(135, 51);
            btn_DangNhap.TabIndex = 10;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click_1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(634, 242);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(240, 30);
            txtMatKhau.TabIndex = 9;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(636, 167);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(240, 30);
            txtTaiKhoan.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 50, 80);
            label2.Location = new Point(542, 51);
            label2.Name = "label2";
            label2.Size = new Size(323, 60);
            label2.TabIndex = 11;
            label2.Text = "Tuan Vu Frood";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(220, 242, 242);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(30, 50, 80);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(515, 241);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 12;
            label4.Text = "Mật khẩu :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // l
            // 
            l.AutoSize = true;
            l.FlatStyle = FlatStyle.Flat;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l.ForeColor = Color.FromArgb(30, 50, 80);
            l.ImageAlign = ContentAlignment.MiddleLeft;
            l.Location = new Point(516, 166);
            l.Name = "l";
            l.Size = new Size(114, 28);
            l.TabIndex = 13;
            l.Text = "Tài khoản :";
            l.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.tuanvu;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 242, 242);
            ClientSize = new Size(887, 420);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(l);
            Controls.Add(btn_DangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_DangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label2;
        private Label label4;
        private Label l;
        private PictureBox pictureBox1;
    }
}
