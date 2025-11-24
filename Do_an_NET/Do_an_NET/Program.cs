using System;
using System.Windows.Forms;

namespace Do_an_NET // Thay thế bằng Namespace của bạn
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dòng quan trọng: Form nào được khởi động đầu tiên
            // Nếu bạn muốn chạy form_HoaDon đầu tiên:
            // Application.Run(new form_HoaDon());
            // Application.Run(new form_NhanVien());
            Application.Run(new form_KhachHang());
            // Hoặc, nếu bạn có form Đăng nhập/Menu chính:
            // Application.Run(new form_DangNhap());
        }
    }
}