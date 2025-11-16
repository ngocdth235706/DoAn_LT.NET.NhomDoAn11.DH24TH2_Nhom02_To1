using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class Form1 : Form
    {
        // Biến trạng thái để xác định đang Thêm mới hay Cập nhật
        private bool isAddingNew = false;

        // Chuỗi kết nối cố định
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";
        public Form1()
        {
            InitializeComponent();
            // Thiết lập chế độ ban đầu: chỉ xem, khóa các ô nhập liệu
            
        }

        // ĐẶT PHƯƠNG THỨC Ở ĐÂY (BÊN TRONG CLASS Form1)
        public void LoadData(string keyword = "")
        {
            string sqlQuery = "SELECT MaXe, TenXe, HangXe, MauXe, GiaXe, SoLuong, CreatedAt FROM xemay";
            // Cập nhật Chuỗi Kết Nối CSDL của bạn tại đây!
            string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

            // Thêm điều kiện tìm kiếm nếu có từ khóa
            if (!string.IsNullOrEmpty(keyword))
            {
                // Tìm kiếm LIKE trong nhiều cột (TenXe, MaXe, HangXe)
                sqlQuery += " WHERE TenXe LIKE @Keyword OR MaXe LIKE @Keyword OR HangXe LIKE @Keyword";
            }
            // TRUY VẤN LẤY TẤT CẢ DỮ LIỆU ĐỂ HIỂN THỊ
            // Bỏ mệnh đề WHERE và tham số vì chúng ta lấy toàn bộ dữ liệu
          

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Khởi tạo Adapter và DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, conn);
                    DataTable dataTable = new DataTable();

                    // Thêm tham số tìm kiếm an toàn (chỉ khi có từ khóa)
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }
                    // 2. Lấp đầy (Fill) DataTable bằng dữ liệu từ CSDL
                    adapter.Fill(dataTable);

                    // 3. Gán DataTable làm nguồn dữ liệu cho DataGridView
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
            txtMauXe.Text = "";
            txtGiaXe.Text = "";
            txtSoLuong.Text = "";
        }
        private void SetEditMode(bool isEnabled)
        {
            // Bật/tắt các ô nhập liệu
            txtTenXe.ReadOnly = !isEnabled;
            txtHangXe.ReadOnly = !isEnabled;
            txtMauXe.ReadOnly = !isEnabled;
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
                        cmd.Parameters.AddWithValue("@MauXe", txtMauXe.Text);

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
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gọi hàm để tải dữ liệu ngay khi Form được mở
            LoadData();
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
                txtMauXe.Text = row.Cells["MauXe"].Value.ToString();

                // Sử dụng Convert.ToDecimal/ToString() để đảm bảo định dạng số không bị lỗi
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
            if (string.IsNullOrEmpty(txtMaXe.Text) || string.IsNullOrEmpty(txtTenXe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Xe và Tên Xe.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // 1. Xóa nội dung trong tất cả các TextBox
            ClearTextBoxes();

            // 2. Đặt lại trạng thái về chế độ xem (không Thêm mới/Cập nhật)
            isAddingNew = false;
            SetEditMode(false);

            // 3. Tải lại toàn bộ dữ liệu (không có từ khóa tìm kiếm)
            // SỬA: Dùng hàm LoadData() mới thay vì LoadDataFromxemay() cũ
            LoadData();
        }

        // Hàm cho nút Tải lại (Nếu bạn đã đặt tên là btnTaiLai)
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = ""; // Xóa nội dung tìm kiếm
            LoadData();
            ClearTextBoxes();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
    }
}
        
