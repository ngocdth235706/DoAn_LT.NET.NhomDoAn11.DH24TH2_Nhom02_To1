namespace Do_an_NET
{
    partial class form_HoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblQUANLYHOADON = new Label();
            dgvDanhSachHoaDon = new DataGridView();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTim = new Button();
            btnTaiLai = new Button();
            txtMaHD = new TextBox();
            txtNgayban = new TextBox();
            txtMaNV = new TextBox();
            txtGhichu = new TextBox();
            cmbKhachhang = new ComboBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnQuayLai = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnMoCTHoaDon = new Button();
            btnTimkhach = new Button();
            btnThemkhach = new Button();
            lblMaHD = new Label();
            lblNgayban = new Label();
            lblMaNV = new Label();
            lblKhachhang = new Label();
            lblGhichu = new Label();
            groupBoxDanhsachhoadon = new GroupBox();
            groupBoxThongtinhoadon = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).BeginInit();
            groupBoxDanhsachhoadon.SuspendLayout();
            groupBoxThongtinhoadon.SuspendLayout();
            SuspendLayout();
            // 
            // lblQUANLYHOADON
            // 
            lblQUANLYHOADON.AutoSize = true;
            lblQUANLYHOADON.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            lblQUANLYHOADON.ForeColor = Color.MidnightBlue;
            lblQUANLYHOADON.Location = new Point(420, 36);
            lblQUANLYHOADON.Name = "lblQUANLYHOADON";
            lblQUANLYHOADON.Size = new Size(402, 45);
            lblQUANLYHOADON.TabIndex = 12;
            lblQUANLYHOADON.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // dgvDanhSachHoaDon
            // 
            dgvDanhSachHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHoaDon.Location = new Point(21, 30);
            dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            dgvDanhSachHoaDon.RowHeadersWidth = 62;
            dgvDanhSachHoaDon.Size = new Size(1173, 304);
            dgvDanhSachHoaDon.TabIndex = 0;
            dgvDanhSachHoaDon.CellClick += dgvDanhSachHoaDon_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 120);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(722, 31);
            txtTimKiem.TabIndex = 11;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTimKiem.Location = new Point(27, 125);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(117, 26);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.MediumSeaGreen;
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnTim.Location = new Point(878, 120);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.RoyalBlue;
            btnTaiLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnTaiLai.Location = new Point(1025, 120);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 8;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(162, 34);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(213, 35);
            txtMaHD.TabIndex = 11;
            // 
            // txtNgayban
            // 
            txtNgayban.Location = new Point(162, 78);
            txtNgayban.Name = "txtNgayban";
            txtNgayban.Size = new Size(213, 35);
            txtNgayban.TabIndex = 10;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(542, 34);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(213, 35);
            txtMaNV.TabIndex = 9;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(924, 31);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(213, 35);
            txtGhichu.TabIndex = 8;
            // 
            // cmbKhachhang
            // 
            cmbKhachhang.Location = new Point(542, 79);
            cmbKhachhang.Name = "cmbKhachhang";
            cmbKhachhang.Size = new Size(301, 34);
            cmbKhachhang.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(38, 682);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SpringGreen;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(230, 682);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.RoyalBlue;
            btnQuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1023, 682);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 5;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.MediumSeaGreen;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(819, 682);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(633, 682);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoCTHoaDon
            // 
            btnMoCTHoaDon.BackColor = Color.RoyalBlue;
            btnMoCTHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoCTHoaDon.Location = new Point(411, 682);
            btnMoCTHoaDon.Name = "btnMoCTHoaDon";
            btnMoCTHoaDon.Size = new Size(191, 58);
            btnMoCTHoaDon.TabIndex = 2;
            btnMoCTHoaDon.Text = "Mở chi tiết HĐ";
            btnMoCTHoaDon.UseVisualStyleBackColor = false;
            btnMoCTHoaDon.Click += btnMoCTHoaDon_Click;
            // 
            // btnTimkhach
            // 
            btnTimkhach.BackColor = Color.RoyalBlue;
            btnTimkhach.Location = new Point(849, 76);
            btnTimkhach.Name = "btnTimkhach";
            btnTimkhach.Size = new Size(141, 49);
            btnTimkhach.TabIndex = 6;
            btnTimkhach.Text = "Tìm khách";
            btnTimkhach.UseVisualStyleBackColor = false;
            btnTimkhach.Click += btnTimkhach_Click;
            // 
            // btnThemkhach
            // 
            btnThemkhach.BackColor = Color.MediumSeaGreen;
            btnThemkhach.Location = new Point(996, 78);
            btnThemkhach.Name = "btnThemkhach";
            btnThemkhach.Size = new Size(148, 47);
            btnThemkhach.TabIndex = 5;
            btnThemkhach.Text = "Thêm khách";
            btnThemkhach.UseVisualStyleBackColor = false;
            btnThemkhach.Click += btnThemkhach_Click;
            // 
            // lblMaHD
            // 
            lblMaHD.Location = new Point(33, 37);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(100, 23);
            lblMaHD.TabIndex = 4;
            lblMaHD.Text = "Mã HĐ :";
            // 
            // lblNgayban
            // 
            lblNgayban.Location = new Point(33, 85);
            lblNgayban.Name = "lblNgayban";
            lblNgayban.Size = new Size(100, 23);
            lblNgayban.TabIndex = 3;
            lblNgayban.Text = "Ngày bán :";
            // 
            // lblMaNV
            // 
            lblMaNV.Location = new Point(386, 43);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(100, 23);
            lblMaNV.TabIndex = 2;
            lblMaNV.Text = "Mã NV :";
            // 
            // lblKhachhang
            // 
            lblKhachhang.Location = new Point(386, 87);
            lblKhachhang.Name = "lblKhachhang";
            lblKhachhang.Size = new Size(100, 23);
            lblKhachhang.TabIndex = 1;
            lblKhachhang.Text = "Khách hàng :";
            // 
            // lblGhichu
            // 
            lblGhichu.Location = new Point(811, 43);
            lblGhichu.Name = "lblGhichu";
            lblGhichu.Size = new Size(100, 23);
            lblGhichu.TabIndex = 0;
            lblGhichu.Text = "Ghi chú :";
            // 
            // groupBoxDanhsachhoadon
            // 
            groupBoxDanhsachhoadon.Controls.Add(dgvDanhSachHoaDon);
            groupBoxDanhsachhoadon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhsachhoadon.Location = new Point(8, 173);
            groupBoxDanhsachhoadon.Name = "groupBoxDanhsachhoadon";
            groupBoxDanhsachhoadon.Size = new Size(1210, 348);
            groupBoxDanhsachhoadon.TabIndex = 1;
            groupBoxDanhsachhoadon.TabStop = false;
            groupBoxDanhsachhoadon.Text = "Danh sách hóa đơn";
            // 
            // groupBoxThongtinhoadon
            // 
            groupBoxThongtinhoadon.Controls.Add(lblGhichu);
            groupBoxThongtinhoadon.Controls.Add(lblKhachhang);
            groupBoxThongtinhoadon.Controls.Add(lblMaNV);
            groupBoxThongtinhoadon.Controls.Add(lblNgayban);
            groupBoxThongtinhoadon.Controls.Add(lblMaHD);
            groupBoxThongtinhoadon.Controls.Add(btnThemkhach);
            groupBoxThongtinhoadon.Controls.Add(btnTimkhach);
            groupBoxThongtinhoadon.Controls.Add(cmbKhachhang);
            groupBoxThongtinhoadon.Controls.Add(txtGhichu);
            groupBoxThongtinhoadon.Controls.Add(txtMaNV);
            groupBoxThongtinhoadon.Controls.Add(txtNgayban);
            groupBoxThongtinhoadon.Controls.Add(txtMaHD);
            groupBoxThongtinhoadon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongtinhoadon.Location = new Point(8, 534);
            groupBoxThongtinhoadon.Name = "groupBoxThongtinhoadon";
            groupBoxThongtinhoadon.Size = new Size(1210, 131);
            groupBoxThongtinhoadon.TabIndex = 0;
            groupBoxThongtinhoadon.TabStop = false;
            groupBoxThongtinhoadon.Text = "Thông tin hóa đơn";
            // 
            // form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1228, 770);
            Controls.Add(groupBoxThongtinhoadon);
            Controls.Add(groupBoxDanhsachhoadon);
            Controls.Add(btnMoCTHoaDon);
            Controls.Add(btnXoa);
            Controls.Add(btnHuy);
            Controls.Add(btnQuayLai);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblQUANLYHOADON);
            Name = "form_HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Hóa Đơn";
            Load += form_HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).EndInit();
            groupBoxDanhsachhoadon.ResumeLayout(false);
            groupBoxThongtinhoadon.ResumeLayout(false);
            groupBoxThongtinhoadon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQUANLYHOADON;
        public DataGridView dgvDanhSachHoaDon;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private TextBox txtMaHD;
        private TextBox txtMaKH;
        private TextBox txtNgayban;
        private TextBox txtMaNV;
        private TextBox txtGhichu;
        public ComboBox cmbKhachhang;
        private Button btnThem;
        private Button btnLuu;
        private Button btnQuayLai;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnMoCTHoaDon;
        private Button btnTimkhach;
        private Button btnThemkhach;
        private Label lblMaHD;
        private Label lblNgayban;
        private Label lblMaNV;
        private Label lblKhachhang;
        private Label lblGhichu;
        private GroupBox groupBoxDanhsachhoadon;
        private GroupBox groupBoxThongtinhoadon;
    }
}
