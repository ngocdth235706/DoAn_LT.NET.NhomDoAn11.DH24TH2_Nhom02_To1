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
        private const string ConnectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

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

            // Thực hiện kiểm tra đăng nhập
            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thành công",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn form Đăng nhập hiện tại
                this.Hide();

                // Mở Form Menu chính
                form_Menu menuForm = new form_Menu();
                menuForm.Show();
            }
            else
            {
                // Đăng nhập thất bại
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
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            // =========================================================
            // CHỈ SỬ DỤNG LOGIC MÔ PHỎNG:
            // =========================================================

            if ((taiKhoan == "admin" && matKhau == "0909") ||
                (taiKhoan == "nhanvien" && matKhau == "0000"))
            {
                return true;
            }

            // Nếu mô phỏng thất bại, TRẢ VỀ FALSE và THOÁT HÀM ngay lập tức
            return false;


            // =========================================================
            // PHẦN KẾT NỐI CSDL THỰC TẾ (ĐÃ COMMENT)
            // BẠN CÓ THỂ BỎ COMMENT KHI ĐÃ SỬA LỖI TÊN CỘT TRONG CSDL.
            // =========================================================
            /*
            string query = "SELECT COUNT(MaNV) FROM NhanVien WHERE Username = @user AND Password = @pass"; // Đã sửa tên cột tiềm năng
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", taiKhoan);
                        cmd.Parameters.AddWithValue("@pass", matKhau); 

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ thống",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */
        }
    }
}