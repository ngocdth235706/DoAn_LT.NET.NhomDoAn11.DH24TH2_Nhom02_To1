namespace Do_an_NET
{
    partial class form_Menu
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
            lblQLCuaHang = new Label();
            btnQLXeMay = new Button();
            btnQLKhachHang = new Button();
            btnQLHoaDon = new Button();
            btnQLCTHoaDon = new Button();
            btnThoat = new Button();
            btnQLNV = new Button();
            SuspendLayout();
            // 
            // lblQLCuaHang
            // 
            lblQLCuaHang.AutoSize = true;
            lblQLCuaHang.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQLCuaHang.ForeColor = Color.MidnightBlue;
            lblQLCuaHang.Location = new Point(238, 9);
            lblQLCuaHang.Name = "lblQLCuaHang";
            lblQLCuaHang.Size = new Size(519, 55);
            lblQLCuaHang.TabIndex = 0;
            lblQLCuaHang.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // btnQLXeMay
            // 
            btnQLXeMay.BackColor = Color.RoyalBlue;
            btnQLXeMay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLXeMay.ForeColor = Color.White;
            btnQLXeMay.Location = new Point(100, 100);
            btnQLXeMay.Name = "btnQLXeMay";
            btnQLXeMay.Size = new Size(600, 60);
            btnQLXeMay.TabIndex = 1;
            btnQLXeMay.Text = "QUẢN LÝ XE MÁY";
            btnQLXeMay.UseVisualStyleBackColor = false;
            btnQLXeMay.Click += btnQLXeMay_Click;
            // 
            // btnQLKhachHang
            // 
            btnQLKhachHang.BackColor = Color.RoyalBlue;
            btnQLKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLKhachHang.ForeColor = Color.White;
            btnQLKhachHang.Location = new Point(100, 260);
            btnQLKhachHang.Name = "btnQLKhachHang";
            btnQLKhachHang.Size = new Size(600, 60);
            btnQLKhachHang.TabIndex = 2;
            btnQLKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            btnQLKhachHang.UseVisualStyleBackColor = false;
            btnQLKhachHang.Click += btnQLKhachHnag_Click;
            // 
            // btnQLHoaDon
            // 
            btnQLHoaDon.BackColor = Color.RoyalBlue;
            btnQLHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLHoaDon.ForeColor = Color.White;
            btnQLHoaDon.Location = new Point(100, 340);
            btnQLHoaDon.Name = "btnQLHoaDon";
            btnQLHoaDon.Size = new Size(600, 60);
            btnQLHoaDon.TabIndex = 3;
            btnQLHoaDon.Text = "QUẢN LÝ HÓA ĐƠN";
            btnQLHoaDon.UseVisualStyleBackColor = false;
            btnQLHoaDon.Click += btnQLHoaDon_Click;
            // 
            // btnQLCTHoaDon
            // 
            btnQLCTHoaDon.BackColor = Color.RoyalBlue;
            btnQLCTHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLCTHoaDon.ForeColor = Color.White;
            btnQLCTHoaDon.Location = new Point(100, 420);
            btnQLCTHoaDon.Name = "btnQLCTHoaDon";
            btnQLCTHoaDon.Size = new Size(600, 60);
            btnQLCTHoaDon.TabIndex = 4;
            btnQLCTHoaDon.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            btnQLCTHoaDon.UseVisualStyleBackColor = false;
            btnQLCTHoaDon.Click += btnQLCTHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Crimson;
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(100, 500);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(600, 60);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.BackColor = Color.RoyalBlue;
            btnQLNV.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLNV.ForeColor = Color.White;
            btnQLNV.Location = new Point(100, 180);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(600, 60);
            btnQLNV.TabIndex = 6;
            btnQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            btnQLNV.UseVisualStyleBackColor = false;
            btnQLNV.Click += btnQLNV_Click;
            // 
            // form_Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 600);
            Controls.Add(btnQLNV);
            Controls.Add(btnThoat);
            Controls.Add(btnQLCTHoaDon);
            Controls.Add(btnQLHoaDon);
            Controls.Add(btnQLKhachHang);
            Controls.Add(btnQLXeMay);
            Controls.Add(lblQLCuaHang);
            MinimumSize = new Size(800, 600);
            Name = "form_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Cửa Hàng Xe Máy";
            Load += form_Menu_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQLCuaHang;
        private System.Windows.Forms.Button btnQLXeMay;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Button btnQLCTHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQLNV;
    }
}