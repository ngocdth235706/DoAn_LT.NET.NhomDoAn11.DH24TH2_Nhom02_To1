namespace Do_an_NET
{
    partial class form_CTHoaDon
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
            lblQUANLYCHITIETHOADON = new Label();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTim = new Button();
            btnTaiLai = new Button();
            dgvDanhSachCTHoaDon = new DataGridView();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            txtMaXe = new TextBox();
            txtDonGia = new TextBox();
            txtMaHD = new TextBox();
            btnInHD = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            lblSoLuong = new Label();
            lblThanhTien = new Label();
            lblDonGia = new Label();
            lblMaXe = new Label();
            lblMaHD = new Label();
            groupBoxDanhsachCTHoaDon = new GroupBox();
            groupBoxThongTinCTHoaDon = new GroupBox();
            btnXoa = new Button();
            btnQuayLai = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCTHoaDon).BeginInit();
            groupBoxDanhsachCTHoaDon.SuspendLayout();
            groupBoxThongTinCTHoaDon.SuspendLayout();
            SuspendLayout();
            // 
            // lblQUANLYCHITIETHOADON
            // 
            lblQUANLYCHITIETHOADON.AutoSize = true;
            lblQUANLYCHITIETHOADON.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYCHITIETHOADON.ForeColor = Color.RoyalBlue;
            lblQUANLYCHITIETHOADON.Location = new Point(496, 34);
            lblQUANLYCHITIETHOADON.Name = "lblQUANLYCHITIETHOADON";
            lblQUANLYCHITIETHOADON.Size = new Size(459, 45);
            lblQUANLYCHITIETHOADON.TabIndex = 25;
            lblQUANLYCHITIETHOADON.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(180, 107);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(846, 31);
            txtTimKiem.TabIndex = 26;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(79, 113);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(95, 25);
            lblTimKiem.TabIndex = 27;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.PaleTurquoise;
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(1032, 96);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 28;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(1179, 91);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 29;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // dgvDanhSachCTHoaDon
            // 
            dgvDanhSachCTHoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachCTHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachCTHoaDon.Location = new Point(23, 27);
            dgvDanhSachCTHoaDon.Name = "dgvDanhSachCTHoaDon";
            dgvDanhSachCTHoaDon.RowHeadersWidth = 62;
            dgvDanhSachCTHoaDon.Size = new Size(1296, 318);
            dgvDanhSachCTHoaDon.TabIndex = 30;
            dgvDanhSachCTHoaDon.CellClick += dgvDanhSachCTHoaDon_CellClick;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(897, 37);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(213, 31);
            txtSoLuong.TabIndex = 31;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(509, 80);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(213, 31);
            txtThanhTien.TabIndex = 32;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(509, 34);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(213, 31);
            txtMaXe.TabIndex = 33;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(109, 77);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(213, 31);
            txtDonGia.TabIndex = 34;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(109, 31);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.ReadOnly = true;
            txtMaHD.Size = new Size(213, 31);
            txtMaHD.TabIndex = 35;
            // 
            // btnInHD
            // 
            btnInHD.BackColor = Color.LightGreen;
            btnInHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInHD.Location = new Point(753, 684);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(153, 58);
            btnInHD.TabIndex = 38;
            btnInHD.Text = "In hóa đơn";
            btnInHD.UseVisualStyleBackColor = false;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(294, 684);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 40;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(52, 684);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 41;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoLuong.ForeColor = Color.Black;
            lblSoLuong.Location = new Point(793, 40);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(98, 25);
            lblSoLuong.TabIndex = 42;
            lblSoLuong.Text = "Số lượng :";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThanhTien.ForeColor = Color.Black;
            lblThanhTien.Location = new Point(389, 86);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(114, 25);
            lblThanhTien.TabIndex = 43;
            lblThanhTien.Text = "Thành tiền :";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonGia.ForeColor = Color.Black;
            lblDonGia.Location = new Point(15, 83);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(88, 25);
            lblDonGia.TabIndex = 44;
            lblDonGia.Text = "Đơn giá :";
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaXe.ForeColor = Color.Black;
            lblMaXe.Location = new Point(389, 40);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(74, 25);
            lblMaXe.TabIndex = 45;
            lblMaXe.Text = "Mã xe :";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaHD.ForeColor = Color.Black;
            lblMaHD.Location = new Point(15, 37);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(81, 25);
            lblMaHD.TabIndex = 46;
            lblMaHD.Text = "Mã HĐ :";
            // 
            // groupBoxDanhsachCTHoaDon
            // 
            groupBoxDanhsachCTHoaDon.Controls.Add(dgvDanhSachCTHoaDon);
            groupBoxDanhsachCTHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhsachCTHoaDon.ForeColor = Color.MediumBlue;
            groupBoxDanhsachCTHoaDon.Location = new Point(15, 149);
            groupBoxDanhsachCTHoaDon.Name = "groupBoxDanhsachCTHoaDon";
            groupBoxDanhsachCTHoaDon.Size = new Size(1347, 362);
            groupBoxDanhsachCTHoaDon.TabIndex = 47;
            groupBoxDanhsachCTHoaDon.TabStop = false;
            groupBoxDanhsachCTHoaDon.Text = "Danh sách chi tiết hóa đơn";
            // 
            // groupBoxThongTinCTHoaDon
            // 
            groupBoxThongTinCTHoaDon.Controls.Add(lblMaHD);
            groupBoxThongTinCTHoaDon.Controls.Add(lblMaXe);
            groupBoxThongTinCTHoaDon.Controls.Add(lblDonGia);
            groupBoxThongTinCTHoaDon.Controls.Add(lblThanhTien);
            groupBoxThongTinCTHoaDon.Controls.Add(lblSoLuong);
            groupBoxThongTinCTHoaDon.Controls.Add(txtMaHD);
            groupBoxThongTinCTHoaDon.Controls.Add(txtDonGia);
            groupBoxThongTinCTHoaDon.Controls.Add(txtMaXe);
            groupBoxThongTinCTHoaDon.Controls.Add(txtThanhTien);
            groupBoxThongTinCTHoaDon.Controls.Add(txtSoLuong);
            groupBoxThongTinCTHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongTinCTHoaDon.ForeColor = Color.MediumBlue;
            groupBoxThongTinCTHoaDon.Location = new Point(15, 534);
            groupBoxThongTinCTHoaDon.Name = "groupBoxThongTinCTHoaDon";
            groupBoxThongTinCTHoaDon.Size = new Size(1355, 127);
            groupBoxThongTinCTHoaDon.TabIndex = 48;
            groupBoxThongTinCTHoaDon.TabStop = false;
            groupBoxThongTinCTHoaDon.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.HotPink;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(537, 684);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 47;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.LightGreen;
            btnQuayLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(1167, 684);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 49;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkKhaki;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(955, 684);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 50;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // form_CTHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1383, 754);
            Controls.Add(btnHuy);
            Controls.Add(btnQuayLai);
            Controls.Add(btnXoa);
            Controls.Add(groupBoxThongTinCTHoaDon);
            Controls.Add(groupBoxDanhsachCTHoaDon);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnInHD);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblQUANLYCHITIETHOADON);
            Name = "form_CTHoaDon";
            Text = "form_CTHoaDon";
            Load += form_CTHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCTHoaDon).EndInit();
            groupBoxDanhsachCTHoaDon.ResumeLayout(false);
            groupBoxThongTinCTHoaDon.ResumeLayout(false);
            groupBoxThongTinCTHoaDon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQUANLYCHITIETHOADON;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private DataGridView dgvDanhSachCTHoaDon;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private TextBox txtMaXe;
        private TextBox txtDonGia;
        private TextBox txtMaHD;
        private Button btnInHD;
        private Button btnLuu;
        private Button btnThem;
        private Label lblSoLuong;
        private Label lblThanhTien;
        private Label lblDonGia;
        private Label lblMaXe;
        private Label lblMaHD;
        private GroupBox groupBoxDanhsachCTHoaDon;
        private GroupBox groupBoxThongTinCTHoaDon;
        private Button btnXoa;
        private Button btnQuayLai;
        private Button btnHuy;
    }
}