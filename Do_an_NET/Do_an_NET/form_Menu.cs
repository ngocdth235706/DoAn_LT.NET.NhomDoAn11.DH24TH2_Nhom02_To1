using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class form_Menu : Form
    {
        public form_Menu()
        {
            InitializeComponent();
            // Đính kèm các sự kiện Click vào các Button đã được khai báo
            btnQLXeMay.Click += btnQLXeMay_Click;
            btnQLNV.Click += btnQLNV_Click;
            btnQLKhachHang.Click += btnQLKhachHnag_Click;
            btnQLHoaDon.Click += btnQLHoaDon_Click;
            btnQLCTHoaDon.Click += btnQLCTHoaDon_Click;
            btnThoat.Click += btnThoat_Click;
        }

        // Phương thức để mở Form con và ẩn Form Menu hiện tại
        private void OpenNewForm(Form newForm)
        {
            // Ẩn Form Menu hiện tại
            this.Hide();

            // Đăng ký sự kiện FormClosed để khi Form con đóng, Form Menu sẽ hiện lại
            newForm.FormClosed += (s, args) => this.Show();

            // Hiển thị Form mới
            newForm.Show();
        }

        // Xử lý sự kiện khi click nút Quản Lý Xe Máy
        private void btnQLXeMay_Click(object sender, EventArgs e)
        {
            // Lưu ý: Đảm bảo class form_XeMay đã tồn tại trong project
            OpenNewForm(new form_XeMay());
        }

        // Xử lý sự kiện khi click nút Quản Lý Nhân Viên
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            // Lưu ý: Đảm bảo class form_NhanVien đã tồn tại trong project
            OpenNewForm(new form_NhanVien());
        }

        // Xử lý sự kiện khi click nút Quản Lý Khách Hàng
        private void btnQLKhachHnag_Click(object sender, EventArgs e)
        {
            // Lưu ý: Đảm bảo class form_KhachHang đã tồn tại trong project
            OpenNewForm(new form_KhachHang());
        }

        // Xử lý sự kiện khi click nút Quản Lý Hóa Đơn
        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            // Lưu ý: Đảm bảo class form_HoaDon đã tồn tại trong project
            OpenNewForm(new form_HoaDon());
        }

        // Xử lý sự kiện khi click nút Quản Lý Chi Tiết Hóa Đơn
        private void btnQLCTHoaDon_Click(object sender, EventArgs e)
        {
            // Lưu ý: Đảm bảo class form_CTHoaDon đã tồn tại trong project
            OpenNewForm(new form_CTHoaDon());
        }

        // Xử lý sự kiện khi click nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi ứng dụng không?",
                "Xác nhận Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn Yes, đóng Form và kết thúc ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Bạn có thể thêm phương thức Load Form nếu cần thiết
        private void form_Menu_Load(object sender, EventArgs e)
        {
            // Code thực hiện khi Form Menu được tải (ví dụ: hiển thị Welcome)
        }

        private void form_Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}