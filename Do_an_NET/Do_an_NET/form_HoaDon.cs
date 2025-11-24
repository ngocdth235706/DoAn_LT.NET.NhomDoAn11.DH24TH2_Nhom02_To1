using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class form_HoaDon : Form
    {
        // 1. KHAI BÁO BIẾN & CHUỖI KẾT NỐI
        // (Giữ nguyên chuỗi kết nối của bạn)
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        // Trạng thái Form: true = Đang Thêm mới, false = Bình thường
        private bool isAddingNew = false;

        // Constructor: Chỉ giữ lại một phiên bản
        public form_HoaDon()
        {
            InitializeComponent();
        }

        // Sự kiện Load Form: Chỉ giữ lại một phiên bản
        private void form_HoaDon_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDataHoaDon();
            LoadKhachHangIntoComboBox(); // Tải danh sách khách hàng vào ComboBox
            SetEditMode(false);

            // Thiết lập giá trị mặc định cho Ngày bán là ngày hiện tại
            txtNgayban.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // =======================================================
        // PHƯƠNG THỨC CHUNG & CÀI ĐẶT
        // (Giữ nguyên không thay đổi)
        // =======================================================

        private void SetupDataGridView()
        {
            dgvDanhSachHoaDon.AllowUserToAddRows = false;
            dgvDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachHoaDon.ScrollBars = ScrollBars.Vertical;
        }

        private void ClearTextBoxes()
        {
            txtMaHD.Clear();
            txtMaNV.Clear();
            txtGhichu.Clear();
            cmbKhachhang.Text = ""; // Xóa lựa chọn ComboBox (giữ lại nội dung gõ nếu cần)
            txtNgayban.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// Thiết lập trạng thái Bật/Tắt cho các controls
        /// </summary>
        private void SetEditMode(bool isEnabled)
        {
            // Controls Input
            txtMaHD.ReadOnly = !isAddingNew;
            txtMaNV.ReadOnly = !isEnabled;
            txtNgayban.ReadOnly = !isEnabled;
            txtGhichu.ReadOnly = !isEnabled;
            cmbKhachhang.Enabled = isEnabled;

            // Buttons
            btnThem.Enabled = !isEnabled;
            btnLuu.Enabled = isEnabled;

            btnXoa.Enabled = !isEnabled;
            btnHuy.Enabled = isEnabled;
            btnQuayLai.Enabled = !isEnabled;

            // Nút hỗ trợ Khách hàng
            btnTimkhach.Enabled = isEnabled;
            btnThemkhach.Enabled = isEnabled;

            // Search
            txtTimKiem.ReadOnly = isEnabled;
            btnTim.Enabled = !isEnabled;
            btnTaiLai.Enabled = !isEnabled;
        }

        // =======================================================
        // TẢI DỮ LIỆU & LẤY THÔNG TIN KHÁCH HÀNG
        // (Giữ nguyên không thay đổi)
        // =======================================================

        /// <summary>
        /// Tải danh sách Khách hàng vào ComboBox (cmbKhachhang) và sắp xếp theo tên.
        /// </summary>
        private void LoadKhachHangIntoComboBox()
        {
            cmbKhachhang.Items.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Lấy Tên Khách hàng (TenKH) và sắp xếp theo bảng chữ cái (ORDER BY TenKH)
                    string sql = "SELECT TenKH FROM KHACHHANG ORDER BY TenKH ASC";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbKhachhang.Items.Add(reader["TenKH"].ToString());
                        }
                    }
                }
                // Thiết lập kiểu gõ cho phép tìm kiếm nhanh (Đã sửa lỗi DropDownList)
                cmbKhachhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbKhachhang.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách Khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hàm hỗ trợ: Lấy MaKH từ TenKH được chọn/nhập 
        /// </summary>
        private string GetMaKHFromTenKH(string tenKH)
        {
            if (string.IsNullOrEmpty(tenKH)) return null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT MaKH FROM KHACHHANG WHERE TenKH = @TenKH";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@TenKH", tenKH);

                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm Mã KH: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Thêm mới Khách hàng nếu chưa tồn tại.
        /// </summary>
        /// <param name="tenKH">Tên Khách hàng được nhập vào ComboBox.</param>
        /// <returns>MaKH mới được tạo (dưới dạng chuỗi), hoặc null nếu hủy.</returns>
        private string SaveNewKhachHang(string tenKH)
        {
            // Hàm này vẫn giữ nguyên, logic của bạn hoạt động tốt.
            if (MessageBox.Show($"Khách hàng '{tenKH}' chưa tồn tại. Bạn có muốn thêm mới Khách hàng này ngay bây giờ không? (Lưu ý: Chỉ thêm Tên Khách hàng)",
                                    "Xác nhận thêm Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string newMaKH = GenerateNewMaKH(connection);

                        string sql = "INSERT INTO KHACHHANG (MaKH, TenKH) VALUES (@MaKH, @TenKH)";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@MaKH", newMaKH);
                        command.Parameters.AddWithValue("@TenKH", tenKH);

                        command.ExecuteNonQuery();

                        LoadKhachHangIntoComboBox();

                        MessageBox.Show($"Đã thêm Khách hàng mới: {newMaKH} - {tenKH}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return newMaKH;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm mới Khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                return null; // Người dùng không muốn thêm, hủy lưu HĐ
            }
        }

        /// <summary>
        /// Hàm giả lập tạo Mã Khách hàng mới (ví dụ: KH0001, KH0002)
        /// </summary>
        private string GenerateNewMaKH(MySqlConnection connection)
        {
            // Logic của bạn để tạo MaKH
            string maxMaKH = "";
            string selectSql = "SELECT MaKH FROM KHACHHANG ORDER BY MaKH DESC LIMIT 1";
            MySqlCommand selectCommand = new MySqlCommand(selectSql, connection);
            object result = selectCommand.ExecuteScalar();

            if (result != null)
            {
                maxMaKH = result.ToString();
            }

            if (string.IsNullOrEmpty(maxMaKH) || !maxMaKH.StartsWith("KH"))
            {
                return "KH0001";
            }

            if (int.TryParse(maxMaKH.Substring(2), out int number))
            {
                return "KH" + (number + 1).ToString("D4"); // D4 đảm bảo 4 chữ số (KH0002)
            }
            return "KH0001";
        }


        /// <summary>
        /// Tải dữ liệu Hóa đơn
        /// </summary>
        private void LoadDataHoaDon(string filter = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"
                        SELECT 
                            HD.MaHD, HD.NgayBan, HD.MaNV, 
                            KH.TenKH AS KhachHang, HD.GhiChu
                        FROM HOADON HD
                        INNER JOIN KHACHHANG KH ON HD.MaKH = KH.MaKH";

                    if (!string.IsNullOrEmpty(filter))
                    {
                        sql += " WHERE HD.MaHD LIKE @Filter OR KH.TenKH LIKE @Filter";
                    }

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSachHoaDon.DataSource = dt;

                    // Tùy chỉnh HeaderText và FillWeight
                    if (dgvDanhSachHoaDon.Columns.Contains("MaHD"))
                    {
                        dgvDanhSachHoaDon.Columns["MaHD"].HeaderText = "Mã HĐ";
                        dgvDanhSachHoaDon.Columns["NgayBan"].HeaderText = "Ngày Bán";
                        dgvDanhSachHoaDon.Columns["MaNV"].HeaderText = "Mã NV";
                        dgvDanhSachHoaDon.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
                        dgvDanhSachHoaDon.Columns["GhiChu"].HeaderText = "Ghi Chú";

                        dgvDanhSachHoaDon.Columns["MaHD"].FillWeight = 50;
                        dgvDanhSachHoaDon.Columns["NgayBan"].FillWeight = 80;
                        dgvDanhSachHoaDon.Columns["MaNV"].FillWeight = 50;
                        dgvDanhSachHoaDon.Columns["KhachHang"].FillWeight = 100;
                        dgvDanhSachHoaDon.Columns["GhiChu"].FillWeight = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // =======================================================
        // SỰ KIỆN BUTTON CLICK (Đã loại bỏ CS0111)
        // =======================================================

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearTextBoxes();
            SetEditMode(true);
            txtMaHD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKH = cmbKhachhang.Text.Trim();

            // 1. Kiểm tra ràng buộc cơ bản
            if (string.IsNullOrEmpty(txtMaHD.Text) ||
                string.IsNullOrEmpty(txtMaNV.Text) ||
                string.IsNullOrEmpty(tenKH) ||
                !DateTime.TryParse(txtNgayban.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã HĐ, Mã NV, Tên Khách hàng và Ngày bán hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Xử lý Khách hàng: Lấy MaKH nếu đã có, hoặc tạo mới nếu chưa
            string maKH = GetMaKHFromTenKH(tenKH);

            if (string.IsNullOrEmpty(maKH))
            {
                // Khách hàng chưa tồn tại, gọi hàm thêm mới
                maKH = SaveNewKhachHang(tenKH);

                if (string.IsNullOrEmpty(maKH))
                {
                    // Nếu người dùng hủy thêm mới KH, thì hủy lưu Hóa đơn
                    MessageBox.Show("Hủy Lưu Hóa đơn do Khách hàng chưa được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 3. Thực hiện Lưu Hóa đơn (Chỉ INSERT)
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand("INSERT INTO HOADON (MaHD, MaNV, MaKH, NgayBan, GhiChu) VALUES (@MaHD, @MaNV, @MaKH, @NgayBan, @GhiChu)", connection))
                {
                    connection.Open();

                    // Chuẩn bị tham số
                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    command.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    command.Parameters.AddWithValue("@NgayBan", DateTime.Parse(txtNgayban.Text));
                    command.Parameters.AddWithValue("@GhiChu", txtGhichu.Text);
                    command.Parameters.AddWithValue("@MaKH", maKH); // Sử dụng MaKH đã được xác định/tạo mới

                    command.ExecuteNonQuery();

                    MessageBox.Show("Tạo Hóa đơn thành công! Vui lòng mở Chi tiết HĐ để thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextBoxes();
                    LoadDataHoaDon();
                    SetEditMode(false);
                    isAddingNew = false;

                    // Tải lại danh sách KH (phòng trường hợp KH mới vừa được thêm)
                    LoadKhachHangIntoComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi CSDL khi lưu Hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHoaDon.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maHD = txtMaHD.Text;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Hóa đơn: {maHD} không? (Cần đảm bảo Chi tiết HĐ đã được xóa)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Lưu ý: Cần xóa Chi tiết HĐ trước
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM HOADON WHERE MaHD = @MaHD", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@MaHD", maHD);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Xóa Hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        LoadDataHoaDon();
                        SetEditMode(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            SetEditMode(false);
            isAddingNew = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            LoadDataHoaDon(keyword);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDataHoaDon();
            SetEditMode(false);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CHỨC NĂNG MỞ CHI TIẾT HÓA ĐƠN: Đã kích hoạt
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn một Hóa đơn để xem Chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maHD = txtMaHD.Text;

            // KÍCH HOẠT LIÊN KẾT: Thay thế MessageBox bằng việc mở Form Chi tiết Hóa đơn
            try
            {
                form_CTHoaDon chiTietForm = new form_CTHoaDon(maHD);
                chiTietForm.ShowDialog();
                // Sau khi Form chi tiết đóng, tải lại dữ liệu Hóa đơn chính (nếu có thay đổi tổng tiền)
                LoadDataHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở Form Chi tiết Hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Tìm khách" (btnTimkhach) - Giữ nguyên
        private void btnTimkhach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Form tìm kiếm Khách hàng (Chưa triển khai).", "Chức năng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút "Thêm khách" (btnThemkhach) - Giữ nguyên
        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            // Mở Form Quản lý Khách hàng
            MessageBox.Show("Mở Form Quản lý Khách hàng để thêm mới (Chưa triển khai).", "Chức năng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // =======================================================
        // SỰ KIỆN DATAGRIDVIEW (Đã loại bỏ CS0121)
        // =======================================================

        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachHoaDon.Rows.Count - 1)
            {
                DataGridViewRow row = dgvDanhSachHoaDon.Rows[e.RowIndex];

                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtGhichu.Text = row.Cells["GhiChu"].Value?.ToString();

                // Gán giá trị vào ComboBox
                cmbKhachhang.Text = row.Cells["KhachHang"].Value?.ToString();

                if (row.Cells["NgayBan"].Value != null && DateTime.TryParse(row.Cells["NgayBan"].Value.ToString(), out DateTime ngayBan))
                {
                    txtNgayban.Text = ngayBan.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    txtNgayban.Clear();
                }

                SetEditMode(false);
                btnXoa.Enabled = true;

            }
        }
    }
}