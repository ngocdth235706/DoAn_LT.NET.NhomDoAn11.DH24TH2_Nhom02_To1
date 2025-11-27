namespace Do_an_NET
{
    partial class form_KhachHang
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
            lblQUANLYKHACHHANG = new Label();
            txtTimKiem = new TextBox();
            labelTimKiem = new Label();
            btnTim = new Button();
            btnTaiLai = new Button();
            dgvDanhSachKhachHang = new DataGridView();
            txtMaKH = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            lblMaKH = new Label();
            lblSDT = new Label();
            lblTenKH = new Label();
            lblEmail = new Label();
            lblDchchi = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnQuayLai = new Button();
            groupBoxDanhsachkhachhang = new GroupBox();
            groupBoxThongtinnhanvien = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).BeginInit();
            groupBoxDanhsachkhachhang.SuspendLayout();
            groupBoxThongtinnhanvien.SuspendLayout();
            SuspendLayout();
            // 
            // lblQUANLYKHACHHANG
            // 
            lblQUANLYKHACHHANG.AutoSize = true;
            lblQUANLYKHACHHANG.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYKHACHHANG.ForeColor = Color.MidnightBlue;
            lblQUANLYKHACHHANG.Location = new Point(475, 46);
            lblQUANLYKHACHHANG.Name = "lblQUANLYKHACHHANG";
            lblQUANLYKHACHHANG.Size = new Size(495, 45);
            lblQUANLYKHACHHANG.TabIndex = 25;
            lblQUANLYKHACHHANG.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(167, 113);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(846, 31);
            txtTimKiem.TabIndex = 26;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.Location = new Point(44, 118);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(117, 26);
            labelTimKiem.TabIndex = 27;
            labelTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.RoyalBlue;
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(1019, 108);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 28;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.MediumSeaGreen;
            btnTaiLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(1166, 109);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 29;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // dgvDanhSachKhachHang
            // 
            dgvDanhSachKhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhachHang.Location = new Point(22, 30);
            dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            dgvDanhSachKhachHang.RowHeadersWidth = 62;
            dgvDanhSachKhachHang.Size = new Size(1296, 315);
            dgvDanhSachKhachHang.TabIndex = 30;
            dgvDanhSachKhachHang.CellClick += dgvDanhSachKhachHang_CellClick;
            this.dgvDanhSachKhachHang.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDanhSachKhachHang_CellDoubleClick);

            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(150, 39);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(213, 35);
            txtMaKH.TabIndex = 31;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(150, 98);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(213, 35);
            txtSDT.TabIndex = 32;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(550, 39);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(213, 35);
            txtTenKH.TabIndex = 33;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(550, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 35);
            txtEmail.TabIndex = 34;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(988, 39);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(213, 35);
            txtDiaChi.TabIndex = 35;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaKH.ForeColor = Color.Black;
            lblMaKH.Location = new Point(39, 48);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(105, 26);
            lblMaKH.TabIndex = 40;
            lblMaKH.Text = "Mã KH :";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.ForeColor = Color.Black;
            lblSDT.Location = new Point(36, 107);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(71, 26);
            lblSDT.TabIndex = 41;
            lblSDT.Text = "SĐT :";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenKH.ForeColor = Color.Black;
            lblTenKH.Location = new Point(435, 48);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(109, 26);
            lblTenKH.TabIndex = 42;
            lblTenKH.Text = "Tên KH :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(435, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(87, 26);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "Email :";
            // 
            // lblDchchi
            // 
            lblDchchi.AutoSize = true;
            lblDchchi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDchchi.ForeColor = Color.Black;
            lblDchchi.Location = new Point(883, 48);
            lblDchchi.Name = "lblDchchi";
            lblDchchi.Size = new Size(99, 26);
            lblDchchi.TabIndex = 44;
            lblDchchi.Text = "Địa chỉ :";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(42, 712);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SpringGreen;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(271, 712);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 46;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.MediumSeaGreen;
            btnCapNhat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(497, 712);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(153, 58);
            btnCapNhat.TabIndex = 47;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(720, 712);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 48;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.MediumSeaGreen;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(933, 712);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 49;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.RoyalBlue;
            btnQuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1135, 712);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 50;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // groupBoxDanhsachkhachhang
            // 
            groupBoxDanhsachkhachhang.Controls.Add(dgvDanhSachKhachHang);
            groupBoxDanhsachkhachhang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhsachkhachhang.ForeColor = Color.Black;
            groupBoxDanhsachkhachhang.Location = new Point(8, 162);
            groupBoxDanhsachkhachhang.Name = "groupBoxDanhsachkhachhang";
            groupBoxDanhsachkhachhang.Size = new Size(1338, 361);
            groupBoxDanhsachkhachhang.TabIndex = 51;
            groupBoxDanhsachkhachhang.TabStop = false;
            groupBoxDanhsachkhachhang.Text = "Danh sách khách hàng";
            // 
            // groupBoxThongtinnhanvien
            // 
            groupBoxThongtinnhanvien.Controls.Add(lblDchchi);
            groupBoxThongtinnhanvien.Controls.Add(lblEmail);
            groupBoxThongtinnhanvien.Controls.Add(lblTenKH);
            groupBoxThongtinnhanvien.Controls.Add(lblSDT);
            groupBoxThongtinnhanvien.Controls.Add(lblMaKH);
            groupBoxThongtinnhanvien.Controls.Add(txtDiaChi);
            groupBoxThongtinnhanvien.Controls.Add(txtEmail);
            groupBoxThongtinnhanvien.Controls.Add(txtTenKH);
            groupBoxThongtinnhanvien.Controls.Add(txtSDT);
            groupBoxThongtinnhanvien.Controls.Add(txtMaKH);
            groupBoxThongtinnhanvien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongtinnhanvien.ForeColor = Color.Black;
            groupBoxThongtinnhanvien.Location = new Point(8, 540);
            groupBoxThongtinnhanvien.Name = "groupBoxThongtinnhanvien";
            groupBoxThongtinnhanvien.Size = new Size(1338, 149);
            groupBoxThongtinnhanvien.TabIndex = 52;
            groupBoxThongtinnhanvien.TabStop = false;
            groupBoxThongtinnhanvien.Text = "Thông tin khách hàng";
            // 
            // form_KhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1360, 782);
            Controls.Add(groupBoxThongtinnhanvien);
            Controls.Add(groupBoxDanhsachkhachhang);
            Controls.Add(btnQuayLai);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(labelTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblQUANLYKHACHHANG);
            Name = "form_KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Khách Hàng";
            Load += form_KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).EndInit();
            groupBoxDanhsachkhachhang.ResumeLayout(false);
            groupBoxThongtinnhanvien.ResumeLayout(false);
            groupBoxThongtinnhanvien.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQUANLYKHACHHANG;
        private TextBox txtTimKiem;
        private Label labelTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private DataGridView dgvDanhSachKhachHang;
        private TextBox txtMaKH;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Label lblMaKH;
        private Label lblSDT;
        private Label lblTenKH;
        private Label lblEmail;
        private Label lblDchchi;
        private Button btnThem;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnQuayLai;
        private GroupBox groupBoxDanhsachkhachhang;
        private GroupBox groupBoxThongtinnhanvien;

    }

}
