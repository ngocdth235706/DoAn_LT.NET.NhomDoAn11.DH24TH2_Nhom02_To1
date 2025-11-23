namespace Do_an_NET
{
    partial class form_HoaDon
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
            lblQUANLYHOADON = new Label();
            dgvDanhSachHoaDon = new DataGridView();
            txtTimKiem = new TextBox();
            labelTimKiem = new Label();
            btnTim = new Button();
            btnTaiLai = new Button();
            txtMaHD = new TextBox();
            txtNgayban = new TextBox();
            txtMaNV = new TextBox();
            txtGhichu = new TextBox();
            cmbKhachhang = new ComboBox(); // ĐÃ ĐỔI TỪ TEXTBOX SANG COMBOBOX
            btnThem = new Button();
            btnLuu = new Button();
            btnQuayLai = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            button1 = new Button(); // Mở chi tiết HĐ
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
            lblQUANLYHOADON.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYHOADON.ForeColor = Color.RoyalBlue;
            lblQUANLYHOADON.Location = new Point(484, 41);
            lblQUANLYHOADON.Name = "lblQUANLYHOADON";
            lblQUANLYHOADON.Size = new Size(321, 45);
            lblQUANLYHOADON.TabIndex = 25;
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
            dgvDanhSachHoaDon.TabIndex = 26;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 120);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(722, 31);
            txtTimKiem.TabIndex = 27;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.Location = new Point(49, 120);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(95, 25);
            labelTimKiem.TabIndex = 28;
            labelTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.PaleTurquoise;
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(888, 112);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 29;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(1035, 112);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 30;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(170, 25);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(213, 31);
            txtMaHD.TabIndex = 31;
            // 
            // txtNgayban
            // 
            txtNgayban.Location = new Point(170, 76);
            txtNgayban.Name = "txtNgayban";
            txtNgayban.Size = new Size(213, 31);
            txtNgayban.TabIndex = 32;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(542, 28);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(213, 31);
            txtMaNV.TabIndex = 33;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(924, 25);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(213, 31);
            txtGhichu.TabIndex = 34;
            // 
            // cmbKhachhang
            // 
            cmbKhachhang.FormattingEnabled = true;
            cmbKhachhang.Location = new Point(542, 76);
            cmbKhachhang.Name = "cmbKhachhang";
            cmbKhachhang.Size = new Size(301, 33);
            cmbKhachhang.TabIndex = 35;
            // ĐÃ SỬA LỖI: Dùng DropDown để cho phép vừa chọn, vừa gõ Khách hàng mới
            cmbKhachhang.DropDownStyle = ComboBoxStyle.DropDown;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(38, 682);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(242, 682);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 37;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.LightGreen;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1023, 682);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 47;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkKhaki;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(819, 682);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 48;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.HotPink;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(633, 682);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(436, 682);
            button1.Name = "button1";
            button1.Size = new Size(153, 58);
            button1.TabIndex = 50;
            button1.Text = "Mở chi tiết HĐ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTimkhach
            // 
            btnTimkhach.BackColor = Color.DeepSkyBlue;
            btnTimkhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimkhach.ForeColor = Color.Black;
            btnTimkhach.Location = new Point(849, 72);
            btnTimkhach.Name = "btnTimkhach";
            btnTimkhach.Size = new Size(141, 39);
            btnTimkhach.TabIndex = 51;
            btnTimkhach.Text = "Tìm khách";
            btnTimkhach.UseVisualStyleBackColor = false;
            // 
            // btnThemkhach
            // 
            btnThemkhach.BackColor = Color.SpringGreen;
            btnThemkhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemkhach.ForeColor = Color.Black;
            btnThemkhach.Location = new Point(996, 72);
            btnThemkhach.Name = "btnThemkhach";
            btnThemkhach.Size = new Size(141, 39);
            btnThemkhach.TabIndex = 52;
            btnThemkhach.Text = "Thêm khách";
            btnThemkhach.UseVisualStyleBackColor = false;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaHD.ForeColor = Color.Black;
            lblMaHD.Location = new Point(60, 31);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(81, 25);
            lblMaHD.TabIndex = 53;
            lblMaHD.Text = "Mã HĐ :";
            // 
            // lblNgayban
            // 
            lblNgayban.AutoSize = true;
            lblNgayban.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayban.ForeColor = Color.Black;
            lblNgayban.Location = new Point(60, 82);
            lblNgayban.Name = "lblNgayban";
            lblNgayban.Size = new Size(104, 25);
            lblNgayban.TabIndex = 54;
            lblNgayban.Text = "Ngày bán :";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.ForeColor = Color.Black;
            lblMaNV.Location = new Point(412, 31);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(80, 25);
            lblMaNV.TabIndex = 55;
            lblMaNV.Text = "Mã NV :";
            // 
            // lblKhachhang
            // 
            lblKhachhang.AutoSize = true;
            lblKhachhang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhachhang.ForeColor = Color.Black;
            lblKhachhang.Location = new Point(412, 82);
            lblKhachhang.Name = "lblKhachhang";
            lblKhachhang.Size = new Size(123, 25);
            lblKhachhang.TabIndex = 56;
            lblKhachhang.Text = "Khách hàng :";
            // 
            // lblGhichu
            // 
            lblGhichu.AutoSize = true;
            lblGhichu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGhichu.ForeColor = Color.Black;
            lblGhichu.Location = new Point(831, 28);
            lblGhichu.Name = "lblGhichu";
            lblGhichu.Size = new Size(87, 25);
            lblGhichu.TabIndex = 57;
            lblGhichu.Text = "Ghi chú :";
            // 
            // groupBoxDanhsachhoadon
            // 
            groupBoxDanhsachhoadon.Controls.Add(dgvDanhSachHoaDon);
            groupBoxDanhsachhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhsachhoadon.ForeColor = Color.MediumBlue;
            groupBoxDanhsachhoadon.Location = new Point(8, 173);
            groupBoxDanhsachhoadon.Name = "groupBoxDanhsachhoadon";
            groupBoxDanhsachhoadon.Size = new Size(1210, 348);
            groupBoxDanhsachhoadon.TabIndex = 58;
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
            groupBoxThongtinhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongtinhoadon.ForeColor = Color.MediumBlue;
            groupBoxThongtinhoadon.Location = new Point(8, 534);
            groupBoxThongtinhoadon.Name = "groupBoxThongtinhoadon";
            groupBoxThongtinhoadon.Size = new Size(1210, 130);
            groupBoxThongtinhoadon.TabIndex = 59;
            groupBoxThongtinhoadon.TabStop = false;
            groupBoxThongtinhoadon.Text = "Thông tin hóa đơn";
            // 
            // form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1228, 770);
            Controls.Add(groupBoxThongtinhoadon);
            Controls.Add(groupBoxDanhsachhoadon);
            Controls.Add(button1);
            Controls.Add(btnXoa);
            Controls.Add(btnHuy);
            Controls.Add(btnQuayLai);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(labelTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblQUANLYHOADON);
            Name = "form_HoaDon";
            Text = "Quản lý Hóa Đơn";

            // Liên kết các sự kiện 
            Load += form_HoaDon_Load;
            dgvDanhSachHoaDon.CellClick += dgvDanhSachHoaDon_CellClick;
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnHuy.Click += btnHuy_Click;
            btnQuayLai.Click += btnQuayLai_Click;
            btnTim.Click += btnTim_Click;
            btnTaiLai.Click += btnTaiLai_Click;
            button1.Click += button1_Click;
            btnTimkhach.Click += btnTimkhach_Click;
            btnThemkhach.Click += btnThemkhach_Click;

            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).EndInit();
            groupBoxDanhsachhoadon.ResumeLayout(false);
            groupBoxThongtinhoadon.ResumeLayout(false);
            groupBoxThongtinhoadon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Khai báo các control
        private Label lblQUANLYHOADON;
        public DataGridView dgvDanhSachHoaDon;
        private TextBox txtTimKiem;
        private Label labelTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private TextBox txtMaHD;
        private TextBox txtNgayban;
        private TextBox txtMaNV;
        private TextBox txtGhichu;
        public ComboBox cmbKhachhang; // <-- COMBOBOX
        private Button btnThem;
        private Button btnLuu;
        private Button btnQuayLai;
        private Button btnHuy;
        private Button btnXoa;
        private Button button1; // Mở chi tiết HĐ
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