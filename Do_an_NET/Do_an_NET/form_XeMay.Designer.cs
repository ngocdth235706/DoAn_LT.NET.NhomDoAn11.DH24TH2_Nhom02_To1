namespace Do_an_NET
{
    partial class form_XeMay
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
            txtTimKiem = new TextBox();
            btnTim = new Button();
            btnTaiLai = new Button();
            txtMaXe = new TextBox();
            txtTenXe = new TextBox();
            txtHangXe = new TextBox();
            cmbMauXe = new ComboBox();
            txtGiaXe = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            lblQUANLYXEMAY = new Label();
            lblMaXe = new Label();
            lblMauXe = new Label();
            lblTenXe = new Label();
            lblGiaXe = new Label();
            lblHangXe = new Label();
            lblSoLuong = new Label();
            lblTimKiem = new Label();
            dgvDanhSachXe = new DataGridView();
            groupBoxDanhSachXeMay = new GroupBox();
            groupBoxThongTinXeMay = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).BeginInit();
            groupBoxDanhSachXeMay.SuspendLayout();
            groupBoxThongTinXeMay.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(166, 61);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(846, 31);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.PaleTurquoise;
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(1027, 48);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(1174, 48);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 3;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(139, 29);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(213, 31);
            txtMaXe.TabIndex = 4;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(528, 22);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(213, 31);
            txtTenXe.TabIndex = 5;
            // 
            // txtHangXe
            // 
            txtHangXe.Location = new Point(966, 22);
            txtHangXe.Name = "txtHangXe";
            txtHangXe.Size = new Size(213, 31);
            txtHangXe.TabIndex = 6;
            // 
            // cmbMauXe
            // 
            cmbMauXe.FormattingEnabled = true;
            cmbMauXe.Location = new Point(139, 90);
            cmbMauXe.Name = "cmbMauXe";
            cmbMauXe.Size = new Size(213, 33);
            cmbMauXe.TabIndex = 7;
            // 
            // txtGiaXe
            // 
            txtGiaXe.Location = new Point(528, 90);
            txtGiaXe.Name = "txtGiaXe";
            txtGiaXe.Size = new Size(213, 31);
            txtGiaXe.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(966, 84);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(213, 31);
            txtSoLuong.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(49, 632);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(222, 58);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(312, 632);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(222, 58);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.LightGreen;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(571, 632);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(222, 58);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.HotPink;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(823, 632);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(222, 58);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkKhaki;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(1071, 632);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(222, 58);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblQUANLYXEMAY
            // 
            lblQUANLYXEMAY.AutoSize = true;
            lblQUANLYXEMAY.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYXEMAY.ForeColor = Color.RoyalBlue;
            lblQUANLYXEMAY.Location = new Point(540, 9);
            lblQUANLYXEMAY.Name = "lblQUANLYXEMAY";
            lblQUANLYXEMAY.Size = new Size(284, 45);
            lblQUANLYXEMAY.TabIndex = 15;
            lblQUANLYXEMAY.Text = "QUẢN LÝ XE MÁY";
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.ForeColor = Color.Black;
            lblMaXe.Location = new Point(43, 35);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(69, 25);
            lblMaXe.TabIndex = 16;
            lblMaXe.Text = "Mã xe:";
            // 
            // lblMauXe
            // 
            lblMauXe.AutoSize = true;
            lblMauXe.ForeColor = Color.Black;
            lblMauXe.Location = new Point(43, 93);
            lblMauXe.Name = "lblMauXe";
            lblMauXe.Size = new Size(85, 25);
            lblMauXe.TabIndex = 17;
            lblMauXe.Text = "Màu xe: ";
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.ForeColor = Color.Black;
            lblTenXe.Location = new Point(449, 22);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(72, 25);
            lblTenXe.TabIndex = 18;
            lblTenXe.Text = "Tên xe:";
            // 
            // lblGiaXe
            // 
            lblGiaXe.AutoSize = true;
            lblGiaXe.ForeColor = Color.Black;
            lblGiaXe.Location = new Point(449, 90);
            lblGiaXe.Name = "lblGiaXe";
            lblGiaXe.Size = new Size(70, 25);
            lblGiaXe.TabIndex = 19;
            lblGiaXe.Text = "Giá xe:";
            // 
            // lblHangXe
            // 
            lblHangXe.AutoSize = true;
            lblHangXe.ForeColor = Color.Black;
            lblHangXe.Location = new Point(852, 22);
            lblHangXe.Name = "lblHangXe";
            lblHangXe.Size = new Size(88, 25);
            lblHangXe.TabIndex = 20;
            lblHangXe.Text = "Hãng xe:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.ForeColor = Color.Black;
            lblSoLuong.Location = new Point(852, 87);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(93, 25);
            lblSoLuong.TabIndex = 21;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(72, 70);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(95, 25);
            lblTimKiem.TabIndex = 22;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // dgvDanhSachXe
            // 
            dgvDanhSachXe.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachXe.Location = new Point(7, 28);
            dgvDanhSachXe.Name = "dgvDanhSachXe";
            dgvDanhSachXe.RowHeadersWidth = 62;
            dgvDanhSachXe.Size = new Size(1296, 318);
            dgvDanhSachXe.TabIndex = 0;
            dgvDanhSachXe.CellClick += dgvDanhSachXe_CellClick;
            dgvDanhSachXe.CellContentClick += dgvDanhSachXe_CellContentClick;
            // 
            // groupBoxDanhSachXeMay
            // 
            groupBoxDanhSachXeMay.BackColor = Color.LemonChiffon;
            groupBoxDanhSachXeMay.Controls.Add(dgvDanhSachXe);
            groupBoxDanhSachXeMay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhSachXeMay.ForeColor = Color.MediumBlue;
            groupBoxDanhSachXeMay.Location = new Point(12, 101);
            groupBoxDanhSachXeMay.Name = "groupBoxDanhSachXeMay";
            groupBoxDanhSachXeMay.Size = new Size(1309, 352);
            groupBoxDanhSachXeMay.TabIndex = 23;
            groupBoxDanhSachXeMay.TabStop = false;
            groupBoxDanhSachXeMay.Text = "Danh sách xe máy";
            // 
            // groupBoxThongTinXeMay
            // 
            groupBoxThongTinXeMay.Controls.Add(lblSoLuong);
            groupBoxThongTinXeMay.Controls.Add(lblHangXe);
            groupBoxThongTinXeMay.Controls.Add(lblGiaXe);
            groupBoxThongTinXeMay.Controls.Add(lblTenXe);
            groupBoxThongTinXeMay.Controls.Add(lblMauXe);
            groupBoxThongTinXeMay.Controls.Add(lblMaXe);
            groupBoxThongTinXeMay.Controls.Add(txtSoLuong);
            groupBoxThongTinXeMay.Controls.Add(txtGiaXe);
            groupBoxThongTinXeMay.Controls.Add(cmbMauXe);
            groupBoxThongTinXeMay.Controls.Add(txtHangXe);
            groupBoxThongTinXeMay.Controls.Add(txtTenXe);
            groupBoxThongTinXeMay.Controls.Add(txtMaXe);
            groupBoxThongTinXeMay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongTinXeMay.ForeColor = Color.MediumBlue;
            groupBoxThongTinXeMay.Location = new Point(12, 475);
            groupBoxThongTinXeMay.Name = "groupBoxThongTinXeMay";
            groupBoxThongTinXeMay.Size = new Size(1309, 137);
            groupBoxThongTinXeMay.TabIndex = 24;
            groupBoxThongTinXeMay.TabStop = false;
            groupBoxThongTinXeMay.Text = "Thông tin xe máy";
            groupBoxThongTinXeMay.Enter += groupBox1_Enter;
            // 
            // form_XeMay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1333, 732);
            Controls.Add(groupBoxThongTinXeMay);
            Controls.Add(groupBoxDanhSachXeMay);
            Controls.Add(lblTimKiem);
            Controls.Add(lblQUANLYXEMAY);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Name = "form_XeMay";
            Text = "Quản Lý Xe Máy";
            Load += form_XeMay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).EndInit();
            groupBoxDanhSachXeMay.ResumeLayout(false);
            groupBoxThongTinXeMay.ResumeLayout(false);
            groupBoxThongTinXeMay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private TextBox txtMaXe;
        private TextBox txtTenXe;
        private TextBox txtHangXe;
        private ComboBox cmbMauXe;
        private TextBox txtGiaXe;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnHuy;
        private Label lblQUANLYXEMAY;
        private Label lblMaXe;
        private Label lblMauXe;
        private Label lblTenXe;
        private Label lblGiaXe;
        private Label lblHangXe;
        private Label lblSoLuong;
        private Label lblTimKiem;
        private DataGridView dgvDanhSachXe;
        private GroupBox groupBoxDanhSachXeMay;
        private GroupBox groupBoxThongTinXeMay;
    }
}