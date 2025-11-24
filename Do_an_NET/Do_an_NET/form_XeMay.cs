using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Dùng cho việc kiểm tra định dạng chữ
using System.Linq;
using System.Collections.Generic;

namespace Do_an_NET
{
    public partial class form_XeMay : Form
    {
        // Biến trạng thái để xác định đang Thêm mới hay Cập nhật
        private bool isAddingNew = false;

        // Chuỗi kết nối cố định (Biến thành viên)
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        public string SelectedMaXe { get; private set; }
        public form_XeMay()
        {
            InitializeComponent();
            // Thiết lập chế độ ban đầu: chỉ xem, khóa các ô nhập liệu
        }

        // ===============================================
        // TẢI DANH SÁCH MÀU XE ĐỘC NHẤT
        // ===============================================
        public void LoadMauXeData()
        {
            // Truy vấn lấy danh sách màu sắc duy nhất, không rỗng, và sắp xếp theo bảng chữ cái (ASC)
            string sqlQuery = "SELECT DISTINCT MauXe FROM xemay WHERE MauXe IS NOT NULL AND MauXe != '' ORDER BY MauXe ASC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, conn);
                    DataTable dtMauXe = new DataTable();
                    adapter.Fill(dtMauXe);

                    // Xóa dữ liệu cũ và gán dữ liệu mới cho ComboBox
                    cmbMauXe.DataSource = null;

                    // Lấy danh sách chuỗi (string) từ DataTable
                    List<string> mauXeList = dtMauXe.AsEnumerable()
                                                     .Select(row => row.Field<string>("MauXe"))
                                                     .ToList();

                    // Gán List vào ComboBox
                    cmbMauXe.DataSource = mauXeList;
                    cmbMauXe.SelectedIndex = -1; // Không chọn mục nào ban đầu
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("LỖI TẢI DANH SÁCH MÀU XE: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadData(string keyword = "")
        {
            string sqlQuery = "SELECT MaXe, TenXe, HangXe, MauXe, GiaXe, SoLuong, CreatedAt FROM xemay";
            // ĐÃ XÓA DÒNG NÀY: string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

            // Điều kiện tìm kiếm nếu có từ khóa
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tìm kiếm LIKE trong nhiều cột (TenXe, MaXe, HangXe)
                sqlQuery += " WHERE TenXe LIKE @Keyword OR MaXe LIKE @Keyword OR HangXe LIKE @Keyword";
            }

            // TRUY VẤN LẤY TẤT CẢ DỮ LIỆU ĐỂ HIỂN THỊ
            using (MySqlConnection conn = new MySqlConnection(connectionString)) // Dùng biến thành viên
            {
                try
                {
                    conn.Open();

                    // Khởi tạo Adapter và DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, conn);
                    DataTable dataTable = new DataTable();

                    // Thêm tham số tìm kiếm an toàn (chỉ khi có từ khóa)
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }
                    // Lấp đầy (Fill) DataTable bằng dữ liệu từ CSDL
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dgvDanhSachXe.DataSource = dataTable;

                    // Tự động điều chỉnh độ rộng cột cho phù hợp
                    dgvDanhSachXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (MySqlException ex)
                {
                    // Hiển thị lỗi ra thông báo hộp thoại
                    MessageBox.Show("LỖI TẢI DỮ LIỆU CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtMaXe.Text = "";
            txtTenXe.Text = "";
            txtHangXe.Text = "";
            cmbMauXe.Text = "";
            txtGiaXe.Text = "";
            txtSoLuong.Text = "";
        }
        private void SetEditMode(bool isEnabled)
        {
            // Bật/tắt các ô nhập liệu
            txtTenXe.ReadOnly = !isEnabled;
            txtHangXe.ReadOnly = !isEnabled;
            cmbMauXe.Enabled = isEnabled;
            txtGiaXe.ReadOnly = !isEnabled;
            txtSoLuong.ReadOnly = !isEnabled;

            // Mã xe chỉ được chỉnh sửa khi đang Thêm mới
            txtMaXe.ReadOnly = !(isAddingNew && isEnabled);

            // Bật/tắt các nút chức năng
            btnLuu.Enabled = isEnabled;
            btnHuy.Enabled = isEnabled;

            btnThem.Enabled = !isEnabled;
            btnCapNhat.Enabled = !isEnabled && !string.IsNullOrEmpty(txtMaXe.Text); // Chỉ bật Cập nhật/Xóa khi có dữ liệu được chọn
            btnXoa.Enabled = !isEnabled && !string.IsNullOrEmpty(txtMaXe.Text);
        }
        // Hàm chung thực thi INSERT, UPDATE, DELETE
        private void ExecuteNonQuery(string sqlQuery, string successMessage)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        // Thêm tham số từ TextBoxes
                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                        cmd.Parameters.AddWithValue("@HangXe", txtHangXe.Text);
                        cmd.Parameters.AddWithValue("@MauXe", cmbMauXe.Text);

                        // Chuyển đổi sang kiểu số, dùng TryParse để kiểm tra lỗi nhập liệu
                        if (!decimal.TryParse(txtGiaXe.Text, out decimal giaXe))
                            throw new Exception("Giá xe không hợp lệ.");
                        if (!int.TryParse(txtSoLuong.Text, out int soLuong))
                            throw new Exception("Số lượng không hợp lệ.");

                        cmd.Parameters.AddWithValue("@GiaXe", giaXe);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(successMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu
                            ClearTextBoxes();
                            isAddingNew = false;
                            SetEditMode(false);
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào bị ảnh hưởng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI THAO TÁC CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // CÁC SỰ KIỆN CỦA FORM VÀ CONTROLS
        private void form_XeMay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMauXeData();

            // Để kẻ ô full, ta đặt là False để ngăn DataGridView tạo hàng trống cuối cùng
            // Mặc định, nếu không muốn người dùng nhập, nên đặt là False.
            dgvDanhSachXe.AllowUserToAddRows = false;

            // Chỉnh chế độ chia cột 
            // Đảm bảo DataGridView lấp đầy chiều ngang.
            dgvDanhSachXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thiết lập thanh cuộn cho DataGridView
            dgvDanhSachXe.ScrollBars = ScrollBars.Vertical;
        }
        private void dgvDanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là hàng header không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại mà người dùng đã click
                DataGridViewRow row = dgvDanhSachXe.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng đó vào các TextBox
                txtMaXe.Text = row.Cells["MaXe"].Value.ToString();
                txtTenXe.Text = row.Cells["TenXe"].Value.ToString();
                txtHangXe.Text = row.Cells["HangXe"].Value.ToString();
                cmbMauXe.Text = row.Cells["MauXe"].Value.ToString();

                // Sử dụng ToString() để đảm bảo định dạng số không bị lỗi
                txtGiaXe.Text = row.Cells["GiaXe"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                // Đảm bảo các nút Cập nhật/Xóa được bật
                SetEditMode(false);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearTextBoxes();
            SetEditMode(true);
            txtMaXe.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mauXeValue = cmbMauXe.Text.Trim();

            // Thêm kiểm tra cho Hãng Xe và Màu Xe
            if (string.IsNullOrEmpty(txtMaXe.Text) ||
                string.IsNullOrEmpty(txtTenXe.Text) ||
                string.IsNullOrEmpty(txtHangXe.Text) ||
                string.IsNullOrEmpty(mauXeValue))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Xe và Tên Xe.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Regex.IsMatch(cmbMauXe.Text, @"\d"))
            {
                MessageBox.Show("Màu Xe không được chứa ký tự số. Vui lòng nhập đúng định dạng chữ (ví dụ: Đỏ, Xanh Lá Cây...).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiaXe.Text, out _) || !int.TryParse(txtSoLuong.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng số cho Giá Xe và Số Lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql;
            string message;

            if (isAddingNew) // INSERT (Thêm mới)
            {
                sql = "INSERT INTO xemay (MaXe, TenXe, HangXe, MauXe, GiaXe, SoLuong, CreatedAt) " +
                      "VALUES (@MaXe, @TenXe, @HangXe, @MauXe, @GiaXe, @SoLuong, NOW())";
                message = "Thêm mới xe máy thành công!";
            }
            else // UPDATE (Cập nhật)
            {
                sql = "UPDATE xemay SET TenXe = @TenXe, HangXe = @HangXe, MauXe = @MauXe, " +
                      "GiaXe = @GiaXe, SoLuong = @SoLuong WHERE MaXe = @MaXe";
                message = "Cập nhật xe máy thành công!";
            }

            ExecuteNonQuery(sql, message);

            LoadMauXeData();

            cmbMauXe.MaxDropDownItems = 15;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe cần Cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAddingNew = false; // Chế độ Cập nhật
            SetEditMode(true);
            txtMaXe.ReadOnly = true; // Không cho phép sửa Mã Xe khi Cập nhật
            txtTenXe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa xe có Mã là {txtMaXe.Text}?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM xemay WHERE MaXe = @MaXe";
                ExecuteNonQuery(sql, "Xóa xe máy thành công!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong tất cả các TextBox
            ClearTextBoxes();

            // Đặt lại trạng thái về chế độ xem (không Thêm mới/Cập nhật)
            isAddingNew = false;
            SetEditMode(false);

            // Tải lại toàn bộ dữ liệu (không có từ khóa tìm kiếm)
            LoadData();
        }

        // Hàm cho nút Tải lại 
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = ""; // Xóa nội dung tìm kiếm
            LoadData();
            ClearTextBoxes();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // (Không có logic)
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData(); // Nếu ô tìm kiếm trống, tải lại toàn bộ
            }
            else
            {
                LoadData(keyword); // Tìm kiếm theo từ khóa
            }
        }

        private void dgvDanhSachXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // (Không có logic)
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // (Không có logic)
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // (Không có logic)
        }
        private void btnChonXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn một chiếc xe trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Lưu Mã Xe đã chọn
            SelectedMaXe = txtMaXe.Text;

            // 2. Đóng Form với DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}