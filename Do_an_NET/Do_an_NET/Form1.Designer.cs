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
            dgvDanhSachXe = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhSachXe
            // 
            dgvDanhSachXe.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachXe.Location = new Point(12, 103);
            dgvDanhSachXe.Name = "dgvDanhSachXe";
            dgvDanhSachXe.RowHeadersWidth = 62;
            dgvDanhSachXe.Size = new Size(1044, 232);
            dgvDanhSachXe.TabIndex = 0;
            dgvDanhSachXe.CellClick += dgvDanhSachXe_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(106, 64);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(674, 31);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(786, 65);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(85, 32);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(877, 65);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(85, 32);
            btnTaiLai.TabIndex = 3;
            btnTaiLai.Text = "Tải Lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // txtMaXe
            // 
            txtMaXe.Location = new Point(106, 341);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(213, 31);
            txtMaXe.TabIndex = 4;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(441, 341);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(213, 31);
            txtTenXe.TabIndex = 5;
            // 
            // txtHangXe
            // 
            txtHangXe.Location = new Point(758, 341);
            txtHangXe.Name = "txtHangXe";
            txtHangXe.Size = new Size(213, 31);
            txtHangXe.TabIndex = 6;
            // 
            // txtMauXe
            // 
            txtMauXe.Location = new Point(106, 390);
            txtMauXe.Name = "txtMauXe";
            txtMauXe.Size = new Size(213, 31);
            txtMauXe.TabIndex = 7;
            // 
            // txtGiaXe
            // 
            txtGiaXe.Location = new Point(441, 390);
            txtGiaXe.Name = "txtGiaXe";
            txtGiaXe.Size = new Size(213, 31);
            txtGiaXe.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(758, 390);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(213, 31);
            txtSoLuong.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(62, 480);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(171, 43);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(252, 480);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(171, 43);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(441, 480);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(171, 43);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(630, 480);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(171, 43);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(820, 480);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(171, 43);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(394, 16);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 15;
            label1.Text = "QUẢN LÝ XE MÁY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 347);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 16;
            label2.Text = "Mã xe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 396);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 17;
            label3.Text = "Màu xe: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 344);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 18;
            label4.Text = "Tên xe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 390);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 19;
            label5.Text = "Giá xe:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(660, 347);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 20;
            label6.Text = "Hãng xe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(660, 396);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 21;
            label7.Text = "Số lượng:";
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Location = new Point(12, 67); // Vị trí gần txtTimKiem
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(88, 25);
            labelTimKiem.TabIndex = 22; // Thay đổi số index nếu cần
            labelTimKiem.Text = "Tìm kiếm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1068, 547);
            Controls.Add(labelTimKiem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGiaXe);
            Controls.Add(txtMauXe);
            Controls.Add(txtHangXe);
            Controls.Add(txtTenXe);
            Controls.Add(txtMaXe);
            Controls.Add(btnTaiLai);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvDanhSachXe);
            Name = "Form1";
            Text = "Quản Lý Xe Máy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSachXe;
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
    }
}
