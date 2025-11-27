namespace Do_an_NET
{
    partial class form_XeMay
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

        private void InitializeComponent()
        {
            groupBoxThongtinxemay = new GroupBox();
            cmbMauXe = new ComboBox();
            lblHangXe = new Label();
            lblSoLuong = new Label();
            lblTenXe = new Label();
            lblGiaXe = new Label();
            lblMaXe = new Label();
            lblMauXe = new Label();
            txtSoLuong = new TextBox();
            txtGiaXe = new TextBox();
            txtTenXe = new TextBox();
            txtHangXe = new TextBox();
            txtMaXe = new TextBox();
            btnQuayLai = new Button();
            groupBoxDanhSachXeMay = new GroupBox();
            dgvDanhSachXe = new DataGridView();
            btnHuy = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            lblQUANLYXEMAY = new Label();
            lblTimKiem = new Label();
            btnTaiLai = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            groupBoxThongtinxemay.SuspendLayout();
            groupBoxDanhSachXeMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).BeginInit();
            SuspendLayout();
            // 
            // groupBoxThongtinxemay
            // 
            groupBoxThongtinxemay.Controls.Add(cmbMauXe);
            groupBoxThongtinxemay.Controls.Add(lblHangXe);
            groupBoxThongtinxemay.Controls.Add(lblSoLuong);
            groupBoxThongtinxemay.Controls.Add(lblTenXe);
            groupBoxThongtinxemay.Controls.Add(lblGiaXe);
            groupBoxThongtinxemay.Controls.Add(lblMaXe);
            groupBoxThongtinxemay.Controls.Add(lblMauXe);
            groupBoxThongtinxemay.Controls.Add(txtSoLuong);
            groupBoxThongtinxemay.Controls.Add(txtGiaXe);
            groupBoxThongtinxemay.Controls.Add(txtTenXe);
            groupBoxThongtinxemay.Controls.Add(txtHangXe);
            groupBoxThongtinxemay.Controls.Add(txtMaXe);
            groupBoxThongtinxemay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongtinxemay.ForeColor = Color.Black;
            groupBoxThongtinxemay.Location = new Point(18, 367);
            groupBoxThongtinxemay.Name = "groupBoxThongtinxemay";
            groupBoxThongtinxemay.Size = new Size(1019, 134);
            groupBoxThongtinxemay.TabIndex = 61;
            groupBoxThongtinxemay.TabStop = false;
            groupBoxThongtinxemay.Text = "Thông tin xe máy";
            // 
            // cmbMauXe
            // 
            cmbMauXe.FormattingEnabled = true;
            cmbMauXe.Location = new Point(100, 92);
            cmbMauXe.Name = "cmbMauXe";
            cmbMauXe.Size = new Size(191, 34);
            cmbMauXe.TabIndex = 46;
            // 
            // lblHangXe
            // 
            lblHangXe.AutoSize = true;
            lblHangXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHangXe.ForeColor = Color.Black;
            lblHangXe.Location = new Point(651, 37);
            lblHangXe.Name = "lblHangXe";
            lblHangXe.Size = new Size(111, 26);
            lblHangXe.TabIndex = 45;
            lblHangXe.Text = "Hãng xe :";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoLuong.ForeColor = Color.Black;
            lblSoLuong.Location = new Point(651, 95);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(116, 26);
            lblSoLuong.TabIndex = 44;
            lblSoLuong.Text = "Số lượng :";
            // 
            // lblTenXe
            // 
            lblTenXe.AutoSize = true;
            lblTenXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenXe.ForeColor = Color.Black;
            lblTenXe.Location = new Point(317, 37);
            lblTenXe.Name = "lblTenXe";
            lblTenXe.Size = new Size(94, 26);
            lblTenXe.TabIndex = 41;
            lblTenXe.Text = "Tên xe :";
            // 
            // lblGiaXe
            // 
            lblGiaXe.AutoSize = true;
            lblGiaXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaXe.ForeColor = Color.Black;
            lblGiaXe.Location = new Point(317, 95);
            lblGiaXe.Name = "lblGiaXe";
            lblGiaXe.Size = new Size(92, 26);
            lblGiaXe.TabIndex = 40;
            lblGiaXe.Text = "Giá xe :";
            // 
            // lblMaXe
            // 
            lblMaXe.AutoSize = true;
            lblMaXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaXe.ForeColor = Color.Black;
            lblMaXe.Location = new Point(6, 37);
            lblMaXe.Name = "lblMaXe";
            lblMaXe.Size = new Size(90, 26);
            lblMaXe.TabIndex = 39;
            lblMaXe.Text = "Mã xe :";
            // 
            // lblMauXe
            // 
            lblMauXe.AutoSize = true;
            lblMauXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMauXe.ForeColor = Color.Black;
            lblMauXe.Location = new Point(6, 95);
            lblMauXe.Name = "lblMauXe";
            lblMauXe.Size = new Size(103, 26);
            lblMauXe.TabIndex = 38;
            lblMauXe.Text = "Màu xe :";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(749, 86);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(213, 35);
            txtSoLuong.TabIndex = 30;
            // 
            // txtGiaXe
            // 
            txtGiaXe.Location = new Point(398, 86);
            txtGiaXe.Name = "txtGiaXe";
            txtGiaXe.Size = new Size(213, 35);
            txtGiaXe.TabIndex = 29;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(398, 28);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(213, 35);
            txtTenXe.TabIndex = 28;
            // 
            // txtHangXe
            // 
            txtHangXe.Location = new Point(749, 28);
            txtHangXe.Name = "txtHangXe";
            txtHangXe.Size = new Size(213, 35);
            txtHangXe.TabIndex = 27;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(91, 34);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(172, 35);
            txtMaXe.TabIndex = 25;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.RoyalBlue;
            btnQuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(871, 535);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(153, 58);
            btnQuayLai.TabIndex = 59;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // groupBoxDanhSachXeMay
            // 
            groupBoxDanhSachXeMay.Controls.Add(dgvDanhSachXe);
            groupBoxDanhSachXeMay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhSachXeMay.ForeColor = Color.Black;
            groupBoxDanhSachXeMay.Location = new Point(18, 110);
            groupBoxDanhSachXeMay.Name = "groupBoxDanhSachXeMay";
            groupBoxDanhSachXeMay.Size = new Size(1006, 237);
            groupBoxDanhSachXeMay.TabIndex = 60;
            groupBoxDanhSachXeMay.TabStop = false;
            groupBoxDanhSachXeMay.Text = "Danh sách xe máy";
            // 
            // dgvDanhSachXe
            // 
            dgvDanhSachXe.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachXe.Location = new Point(6, 34);
            dgvDanhSachXe.Name = "dgvDanhSachXe";
            dgvDanhSachXe.RowHeadersWidth = 62;
            dgvDanhSachXe.Size = new Size(994, 197);
            dgvDanhSachXe.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.MediumSeaGreen;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(702, 535);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 58);
            btnHuy.TabIndex = 58;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(532, 535);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 58);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.MediumSeaGreen;
            btnCapNhat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(358, 535);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(153, 58);
            btnCapNhat.TabIndex = 56;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SpringGreen;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(184, 535);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 58);
            btnLuu.TabIndex = 55;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSeaGreen;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(12, 535);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 58);
            btnThem.TabIndex = 54;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // lblQUANLYXEMAY
            // 
            lblQUANLYXEMAY.AutoSize = true;
            lblQUANLYXEMAY.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQUANLYXEMAY.ForeColor = Color.MidnightBlue;
            lblQUANLYXEMAY.Location = new Point(309, 9);
            lblQUANLYXEMAY.Name = "lblQUANLYXEMAY";
            lblQUANLYXEMAY.Size = new Size(376, 45);
            lblQUANLYXEMAY.TabIndex = 53;
            lblQUANLYXEMAY.Text = "QUẢN LÝ XE MÁY";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(25, 78);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(117, 26);
            lblTimKiem.TabIndex = 52;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.MediumSeaGreen;
            btnTaiLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(871, 57);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(141, 47);
            btnTaiLai.TabIndex = 51;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.RoyalBlue;
            btnTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.Location = new Point(724, 57);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(141, 47);
            btnTim.TabIndex = 50;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(154, 73);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(564, 31);
            txtTimKiem.TabIndex = 49;
            // 
            // form_XeMay
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGray;
            ClientSize = new Size(1050, 608);
            Controls.Add(groupBoxThongtinxemay);
            Controls.Add(btnQuayLai);
            Controls.Add(groupBoxDanhSachXeMay);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lblQUANLYXEMAY);
            Controls.Add(lblTimKiem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Name = "form_XeMay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Xe Máy";
            Load += form_XeMay_Load;
            groupBoxThongtinxemay.ResumeLayout(false);
            groupBoxThongtinxemay.PerformLayout();
            groupBoxDanhSachXeMay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private GroupBox groupBoxThongtinxemay;
        private Label lblHangXe;
        private Label lblSoLuong;
        private Label lblTenXe;
        private Label lblGiaXe;
        private Label lblMaXe;
        private Label lblMauXe;
        private TextBox txtSoLuong;
        private TextBox txtGiaXe;
        private TextBox txtTenXe;
        private TextBox txtHangXe;
        private TextBox txtMaXe;
        private Button btnQuayLai;
        private GroupBox groupBoxDanhSachXeMay;
        private DataGridView dgvDanhSachXe;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnLuu;
        private Button btnThem;
        private Label lblQUANLYXEMAY;
        private Label lblTimKiem;
        private Button btnTaiLai;
        private Button btnTim;
        private TextBox txtTimKiem;
        private ComboBox cmbMauXe;

    }
}
