using System;
using System.Windows.Forms;
using System.Data;
// Thư viện CSDL (chỉ dùng khi bật lại phần CSDL)
using MySql.Data.MySqlClient;

namespace Do_an_NET
{
    public partial class form_DangNhap : Form
    {
        // Chuỗi kết nối CSDL thực tế của bạn
        private const string ConnectionString = "Server=localhost;Database=QLCuaHangXeMay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        public form_DangNhap()
        {
            InitializeComponent();

            // ĐÃ XÓA: btnDangNhap.Click += btnDangNhap_Click;
            // Dòng này đã bị xóa vì nó đã được gán trong form_DangNhap.Designer.cs (InitializeComponent)
            // Việc gán 2 lần là nguyên nhân gây ra lỗi chồng 2 Form Menu.

            txtMatKhau.PasswordChar = '*';
            this.AcceptButton = btnDangNhap;
        }

        // Xử lý sự kiện khi click nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Lỗi Đăng nhập",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy phân quyền từ hàm kiểm tra
            string role = KiemTraDangNhap(taiKhoan, matKhau);

            if (role != "")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                // Truyền role sang form Menu
                form_Menu menuForm = new form_Menu(role);
                menuForm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng!", "Lỗi Đăng nhập",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
        }


        /// <summary>
        /// Phương thức kiểm tra thông tin đăng nhập. 
        /// Hiện đang sử dụng MÔ PHỎNG để tránh lỗi CSDL hiện tại.
        /// </summary>
        private string KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            // MÔ PHỎNG PHÂN QUYỀN
            if (taiKhoan == "admin" && matKhau == "0909")
                return "admin";

            if (taiKhoan == "nhanvien" && matKhau == "0000")
                return "nhanvien";

            return "";
        }

    }
}