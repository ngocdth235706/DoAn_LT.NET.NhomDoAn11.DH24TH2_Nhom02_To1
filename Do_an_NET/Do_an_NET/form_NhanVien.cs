using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class form_NhanVien : Form
    {
        // 1. KHAI BÁO BIẾN
        // Chuỗi kết nối CSDL (Sử dụng lại từ Form Xe Máy)
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        // Biến trạng thái để xác định đang Thêm mới hay Cập nhật
        private bool isAddingNew = false;

        public form_NhanVien()
        {
            InitializeComponent();
        }

        // --- BẮT ĐẦU CÁC PHƯƠNG THỨC XỬ LÝ DỮ LIỆU ---

        private void form_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEditMode(false); // Khóa ô nhập liệu khi mới tải Form

            // Thiết lập DataGridView (tương tự như Form Xe Máy)
            dgvDanhSachNhanVien.AllowUserToAddRows = false;
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNhanVien.ScrollBars = ScrollBars.Vertical;
        }

        /// <summary>
        /// 2. Tải dữ liệu từ bảng nhanvien vào DataGridView
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT MaNV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi, ChucVu, Luong FROM nhanvien";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSachNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 3. Thiết lập trạng thái các TextBox (có cho phép chỉnh sửa hay không)
        /// </summary>
        private void SetEditMode(bool isEnabled)
        {
            // Kiểm soát TextBox
            txtMaNV.ReadOnly = !isAddingNew; // Chỉ cho phép nhập MaNV khi Thêm mới
            txtHoTen.ReadOnly = !isEnabled;
            txtNgaySinh.ReadOnly = !isEnabled;
            txtSDT.ReadOnly = !isEnabled;
            txtGioiTinh.ReadOnly = !isEnabled;
            txtDiaChi.ReadOnly = !isEnabled;
            txtChucVu.ReadOnly = !isEnabled;
            txtLuong.ReadOnly = !isEnabled;

            // Kiểm soát Button
            btnThem.Enabled = !isEnabled;
            btnCapNhat.Enabled = !isEnabled;
            btnXoa.Enabled = !isEnabled;
            btnLuu.Enabled = isEnabled; // Chỉ cho phép Lưu khi đang chỉnh sửa/thêm
            btnHuy.Enabled = isEnabled;
        }

        /// <summary>
        /// Xóa nội dung trong tất cả các TextBox
        /// </summary>
        private void ClearTextBoxes()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtSDT.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
        }

        /// <summary>
        /// Thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        /// </summary>
        private void ExecuteNonQuery(string sql, string successMessage)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    // Thêm tham số: Đảm bảo tên tham số khớp với tên cột CSDL
                    command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    command.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    command.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    command.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text)); // Cần kiểm tra định dạng
                    command.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
                    command.Parameters.AddWithValue("@Luong", decimal.Parse(txtLuong.Text)); // Cần kiểm tra định dạng

                    command.ExecuteNonQuery();

                    MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi thành công:
                    ClearTextBoxes();
                    LoadData();
                    SetEditMode(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BẮT ĐẦU CÁC SỰ KIỆN BUTTON CLICK ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearTextBoxes();
            SetEditMode(true);
            txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 4. KIỂM TRA RÀNG BUỘC (VALIDATION)
            if (string.IsNullOrEmpty(txtMaNV.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtNgaySinh.Text) ||
                string.IsNullOrEmpty(txtGioiTinh.Text) ||
                string.IsNullOrEmpty(txtChucVu.Text) ||
                string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc (Mã NV, Họ tên, Ngày sinh, Giới tính, Chức vụ, Lương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số và ngày
            if (!DateTime.TryParse(txtNgaySinh.Text, out _))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng (VD: YYYY-MM-DD).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtLuong.Text, out _))
            {
                MessageBox.Show("Lương không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql;
            string message;

            if (isAddingNew) // INSERT (Thêm mới)
            {
                // Cần đảm bảo tên cột CSDL là chính xác (MaNV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi, ChucVu, Luong)
                sql = "INSERT INTO nhanvien (MaNV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi, ChucVu, Luong) " +
                      "VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @SDT, @DiaChi, @ChucVu, @Luong)";
                message = "Thêm mới nhân viên thành công!";
            }
            else // UPDATE (Cập nhật)
            {
                sql = "UPDATE nhanvien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT, DiaChi = @DiaChi, ChucVu = @ChucVu, Luong = @Luong " +
                      "WHERE MaNV = @MaNV";
                message = "Cập nhật nhân viên thành công!";
            }

            ExecuteNonQuery(sql, message);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            SetEditMode(false);
            isAddingNew = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy MaNV từ hàng được chọn
            string maNV = dgvDanhSachNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có Mã NV: {maNV} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "DELETE FROM nhanvien WHERE MaNV = @MaNV";
                ExecuteNonQuery(sql, "Xóa nhân viên thành công!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Chuyển sang chế độ chỉnh sửa (Update)
            isAddingNew = false;
            SetEditMode(true);
            txtHoTen.Focus(); // Bắt đầu chỉnh sửa từ HoTen
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearTextBoxes();
            SetEditMode(false);
        }

        // Sự kiện khi click vào một ô trong DataGridView để hiển thị dữ liệu lên TextBox
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachNhanVien.Rows[e.RowIndex];

                // Gán giá trị từ hàng được chọn vào các TextBox
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtLuong.Text = row.Cells["Luong"].Value.ToString();

                // Sau khi click: chỉ cho phép Cập nhật và Xóa
                SetEditMode(false);
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // CÁC HÀM KHÁC (Tim, QuayLai...) bạn có thể thêm sau

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            // Giả định bạn có một Form chính để quay lại
            // Form mainForm = new MainForm();
            // mainForm.Show();
            this.Close(); // Đóng Form hiện tại
        }

        // Phương thức tìm kiếm (Tùy chọn)
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Logic tìm kiếm cơ bản theo HoTen hoặc MaNV
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT MaNV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi, ChucVu, Luong FROM nhanvien " +
                                 "WHERE HoTen LIKE @Keyword OR MaNV LIKE @Keyword";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSachNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}