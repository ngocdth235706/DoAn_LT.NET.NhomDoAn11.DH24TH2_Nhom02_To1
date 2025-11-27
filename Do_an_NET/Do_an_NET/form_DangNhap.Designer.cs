namespace Do_an_NET
{
    partial class form_DangNhap
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
            lblDangNhap = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangNhap.ForeColor = Color.MidnightBlue;
            lblDangNhap.Location = new Point(154, 28);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(314, 55);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(140, 160);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(350, 31);
            txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(140, 240);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(350, 31);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaiKhoan.Location = new Point(140, 131);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(129, 26);
            lblTaiKhoan.TabIndex = 3;
            lblTaiKhoan.Text = "Tài khoản :";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(140, 211);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(126, 26);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu :";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.RoyalBlue;
            btnDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(170, 320);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(280, 60);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(620, 420);
            Controls.Add(btnDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(lblDangNhap);
            MinimumSize = new Size(620, 420);
            Name = "form_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private Button btnDangNhap;
    }
}