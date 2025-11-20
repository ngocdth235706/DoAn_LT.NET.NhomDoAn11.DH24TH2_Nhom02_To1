namespace Do_an_NET
{
    partial class Form1
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
            txtMauXe = new TextBox();
            txtGiaXe = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelTimKiem = new Label();
            dgvDanhSachXe = new DataGridView();
            groupBoxDanhSach = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).BeginInit();
            groupBoxDanhSach.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // txtMauXe
            // 
            txtMauXe.Location = new Point(139, 90);
            txtMauXe.Name = "txtMauXe";
            txtMauXe.Size = new Size(213, 31);
            txtMauXe.TabIndex = 7;
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
            btnHuy.Location = new Point(1071, 632);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(222, 58);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(540, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 15;
            label1.Text = "QUẢN LÝ XE MÁY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 35);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 16;
            label2.Text = "Mã xe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 93);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 17;
            label3.Text = "Màu xe: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 22);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 18;
            label4.Text = "Tên xe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 90);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 19;
            label5.Text = "Giá xe:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(852, 22);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 20;
            label6.Text = "Hãng xe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(852, 87);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 21;
            label7.Text = "Số lượng:";
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTimKiem.Location = new Point(72, 70);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(95, 25);
            labelTimKiem.TabIndex = 22;
            labelTimKiem.Text = "Tìm kiếm:";
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
            // groupBoxDanhSach
            // 
            groupBoxDanhSach.BackColor = Color.LemonChiffon;
            groupBoxDanhSach.Controls.Add(dgvDanhSachXe);
            groupBoxDanhSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDanhSach.ForeColor = Color.MediumBlue;
            groupBoxDanhSach.Location = new Point(12, 101);
            groupBoxDanhSach.Name = "groupBoxDanhSach";
            groupBoxDanhSach.Size = new Size(1309, 352);
            groupBoxDanhSach.TabIndex = 23;
            groupBoxDanhSach.TabStop = false;
            groupBoxDanhSach.Text = "Danh sách xe máy";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGiaXe);
            groupBox1.Controls.Add(txtMauXe);
            groupBox1.Controls.Add(txtHangXe);
            groupBox1.Controls.Add(txtTenXe);
            groupBox1.Controls.Add(txtMaXe);
            groupBox1.Location = new Point(12, 475);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1309, 137);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe máy";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1333, 732);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDanhSach);
            Controls.Add(labelTimKiem);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Name = "Form1";
            Text = "Quản Lý Xe Máy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).EndInit();
            groupBoxDanhSach.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtMauXe;
        private TextBox txtGiaXe;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnLuu;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnHuy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelTimKiem;
        private DataGridView dgvDanhSachXe;
        private GroupBox groupBoxDanhSach;
        private GroupBox groupBox1;
    }
}
