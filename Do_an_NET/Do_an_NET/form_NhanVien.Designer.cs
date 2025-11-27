namespace Do_an_NET
{
    partial class form_NhanVien
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
        /// Required method for Designer support - do modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDanhSachNhanVien = new DataGridView();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            btnTaiLai = new Button();
            labelTimKiem = new Label();
            lblQUANLYNHANVIEN = new Label();
            txtMaNV = new TextBox();
            txtNgaySinh = new TextBox();
            txtChucVu = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtLuong = new TextBox();
            txtGioiTinh = new TextBox();
            txtDiaChi = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            lblNgaysinh = new Label();
            lblMaNV = new Label();
            lblSDT = new Label();
            lblHoten = new Label();
            lblDiachi = new Label();
            lblGioitinh = new Label();
            lblLuong = new Label();
            lblChucvu = new Label();
            btnQuayLai = new Button();
            groupBoxDanhSachNhanVien = new GroupBox();
            groupBoxThongtinnhanvien = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            groupBoxDanhSachNhanVien.SuspendLayout();
            groupBoxThongtinnhanvien.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(24, 29);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 62;
            dgvDanhSachNhanVien.Size = new Size(1296, 318);
            dgvDanhSachNhanVien.TabIndex = 1;
            dgvDanhSachNhanVien.CellClick += dgvDanhSachNhanVien_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(197, 102);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(846, 31);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.RoyalBlue;
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(1049, 97);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.MediumSeaGreen;
            btnTaiLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(1196, 97);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.Location = new Point(74, 107);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(117, 26);
            labelTimKiem.TabIndex = 23;
            labelTimKiem.Text = "Tìm kiếm:";
            // 
            // lblQUANLYNHANVIEN
            // 
            lblQUANLYNHANVIEN.AutoSize = true;
            lblQUANLYNHANVIEN.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYNHANVIEN.ForeColor = Color.MidnightBlue;
            lblQUANLYNHANVIEN.Location = new Point(458, 28);
            lblQUANLYNHANVIEN.Name = "lblQUANLYNHANVIEN";
            lblQUANLYNHANVIEN.Size = new Size(442, 45);
            lblQUANLYNHANVIEN.TabIndex = 24;
            lblQUANLYNHANVIEN.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(139, 28);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(172, 35);
            txtMaNV.TabIndex = 25;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(139, 86);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(172, 35);
            txtNgaySinh.TabIndex = 26;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(1097, 28);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(213, 35);
            txtChucVu.TabIndex = 27;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(418, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(213, 35);
            txtHoTen.TabIndex = 28;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(418, 86);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(213, 35);
            txtSDT.TabIndex = 29;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(1097, 86);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(213, 35);
            txtLuong.TabIndex = 30;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(761, 27);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(213, 35);
            txtGioiTinh.TabIndex = 31;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(761, 86);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(213, 35);
            txtDiaChi.TabIndex = 32;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(41, 659);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SpringGreen;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(278, 659);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.MediumSeaGreen;
            btnCapNhat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(515, 659);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(153, 58);
            btnCapNhat.TabIndex = 35;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(735, 659);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 36;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.MediumSeaGreen;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(961, 659);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 37;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgaysinh.ForeColor = Color.Black;
            lblNgaysinh.Location = new Point(6, 95);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new Size(127, 26);
            lblNgaysinh.TabIndex = 38;
            lblNgaysinh.Text = "Ngày sinh :";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.ForeColor = Color.Black;
            lblMaNV.Location = new Point(6, 37);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(101, 26);
            lblMaNV.TabIndex = 39;
            lblMaNV.Text = "Mã NV :";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.ForeColor = Color.Black;
            lblSDT.Location = new Point(317, 95);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(71, 26);
            lblSDT.TabIndex = 40;
            lblSDT.Text = "SĐT :";
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoten.ForeColor = Color.Black;
            lblHoten.Location = new Point(317, 37);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(95, 26);
            lblHoten.TabIndex = 41;
            lblHoten.Text = "Họ tên :";
            // 
            // lblDiachi
            // 
            lblDiachi.AutoSize = true;
            lblDiachi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiachi.ForeColor = Color.Black;
            lblDiachi.Location = new Point(637, 95);
            lblDiachi.Name = "lblDiachi";
            lblDiachi.Size = new Size(99, 26);
            lblDiachi.TabIndex = 42;
            lblDiachi.Text = "Địa chỉ :";
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioitinh.ForeColor = Color.Black;
            lblGioitinh.Location = new Point(637, 36);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new Size(118, 26);
            lblGioitinh.TabIndex = 43;
            lblGioitinh.Text = "Giới tính :";
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuong.ForeColor = Color.Black;
            lblLuong.Location = new Point(980, 95);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(94, 26);
            lblLuong.TabIndex = 44;
            lblLuong.Text = "Lương :";
            // 
            // lblChucvu
            // 
            lblChucvu.AutoSize = true;
            lblChucvu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucvu.ForeColor = Color.Black;
            lblChucvu.Location = new Point(980, 37);
            lblChucvu.Name = "lblChucvu";
            lblChucvu.Size = new Size(111, 26);
            lblChucvu.TabIndex = 45;
            lblChucvu.Text = "Chức vụ :";
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.RoyalBlue;
            btnQuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1184, 659);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 46;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // groupBoxDanhSachNhanVien
            // 
            groupBoxDanhSachNhanVien.Controls.Add(dgvDanhSachNhanVien);
            groupBoxDanhSachNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhSachNhanVien.ForeColor = Color.Black;
            groupBoxDanhSachNhanVien.Location = new Point(12, 139);
            groupBoxDanhSachNhanVien.Name = "groupBoxDanhSachNhanVien";
            groupBoxDanhSachNhanVien.Size = new Size(1341, 362);
            groupBoxDanhSachNhanVien.TabIndex = 47;
            groupBoxDanhSachNhanVien.TabStop = false;
            groupBoxDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // groupBoxThongtinnhanvien
            // 
            groupBoxThongtinnhanvien.Controls.Add(lblChucvu);
            groupBoxThongtinnhanvien.Controls.Add(lblLuong);
            groupBoxThongtinnhanvien.Controls.Add(lblGioitinh);
            groupBoxThongtinnhanvien.Controls.Add(lblDiachi);
            groupBoxThongtinnhanvien.Controls.Add(lblHoten);
            groupBoxThongtinnhanvien.Controls.Add(lblSDT);
            groupBoxThongtinnhanvien.Controls.Add(lblMaNV);
            groupBoxThongtinnhanvien.Controls.Add(lblNgaysinh);
            groupBoxThongtinnhanvien.Controls.Add(txtDiaChi);
            groupBoxThongtinnhanvien.Controls.Add(txtGioiTinh);
            groupBoxThongtinnhanvien.Controls.Add(txtLuong);
            groupBoxThongtinnhanvien.Controls.Add(txtSDT);
            groupBoxThongtinnhanvien.Controls.Add(txtHoTen);
            groupBoxThongtinnhanvien.Controls.Add(txtChucVu);
            groupBoxThongtinnhanvien.Controls.Add(txtNgaySinh);
            groupBoxThongtinnhanvien.Controls.Add(txtMaNV);
            groupBoxThongtinnhanvien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongtinnhanvien.ForeColor = Color.Black;
            groupBoxThongtinnhanvien.Location = new Point(12, 519);
            groupBoxThongtinnhanvien.Name = "groupBoxThongtinnhanvien";
            groupBoxThongtinnhanvien.Size = new Size(1341, 134);
            groupBoxThongtinnhanvien.TabIndex = 48;
            groupBoxThongtinnhanvien.TabStop = false;
            groupBoxThongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1365, 745);
            Controls.Add(groupBoxThongtinnhanvien);
            Controls.Add(groupBoxDanhSachNhanVien);
            Controls.Add(btnQuayLai);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lblQUANLYNHANVIEN);
            Controls.Add(labelTimKiem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Name = "form_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhân Viên";
            Load += form_NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            groupBoxDanhSachNhanVien.ResumeLayout(false);
            groupBoxThongtinnhanvien.ResumeLayout(false);
            groupBoxThongtinnhanvien.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSachNhanVien;
        private TextBox txtTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private Label labelTimKiem;
        private Label lblQUANLYNHANVIEN;
        private TextBox txtMaNV;
        private TextBox txtNgaySinh;
        private TextBox txtChucVu;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtLuong;
        private TextBox txtGioiTinh;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnHuy;
        private Label lblNgaysinh;
        private Label lblMaNV;
        private Label lblSDT;
        private Label lblHoten;
        private Label lblDiachi;
        private Label lblGioitinh;
        private Label lblLuong;
        private Label lblChucvu;
        private Button btnQuayLai;
        private GroupBox groupBoxDanhSachNhanVien;
        private GroupBox groupBoxThongtinnhanvien;
    }
}