using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class form_KhachHang : Form
    {
        // Khai báo chuỗi kết nối MySQL
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        private int formState = 0; // 0: Bình thường, 1: Thêm, 2: Sửa

        public form_KhachHang()
        {
            InitializeComponent();
        }

        private void form_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
            SetControlState(false); // Khóa các ô nhập liệu

            // =======================================================
            // Tự động lấp đầy khoảng trống (AutoSize)
            // =======================================================
            dgvDanhSachKhachHang.AllowUserToAddRows = false;
            dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dgvDanhSachKhachHang.ScrollBars = ScrollBars.Vertical;
            
        }

        // =======================================================
        // PHƯƠNG THỨC XỬ LÝ CHUNG
        // =======================================================

        private void ClearTextBoxes()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }

        // Cài đặt trạng thái Bật/Tắt cho các ô nhập liệu và các nút
        private void SetControlState(bool enableInput)
        {
            // Input Controls
            txtMaKH.ReadOnly = (formState != 1);
            txtTenKH.ReadOnly = !enableInput;
            txtDiaChi.ReadOnly = !enableInput;
            txtSDT.ReadOnly = !enableInput;
            txtEmail.ReadOnly = !enableInput;

            // Buttons
            btnThem.Enabled = !enableInput;
            btnLuu.Enabled = enableInput;
            btnCapNhat.Enabled = !enableInput && (formState == 0);
            btnXoa.Enabled = !enableInput && (formState == 0);
            btnHuy.Enabled = enableInput;
            btnQuayLai.Enabled = !enableInput;

            // Search
            txtTimKiem.ReadOnly = enableInput;
            btnTim.Enabled = !enableInput;
            btnTaiLai.Enabled = !enableInput;
        }

        /// <summary>
        /// Tải dữ liệu từ bảng KHACHHANG vào DataGridView, có thể thêm điều kiện lọc
        /// </summary>
        private void LoadDataKhachHang(string filter = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT MaKH, TenKH, DiaChi, SDT, Email FROM KHACHHANG";

                    if (!string.IsNullOrEmpty(filter))
                    {
                        sql += " WHERE TenKH LIKE @Filter OR MaKH LIKE @Filter OR SDT LIKE @Filter";
                    }

                    MySqlCommand command = new MySqlCommand(sql, conn);
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable dtKhachHang = new DataTable();
                    da.Fill(dtKhachHang);
                    dgvDanhSachKhachHang.DataSource = dtKhachHang;

                    // Tùy chỉnh hiển thị cột
                    dgvDanhSachKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                    dgvDanhSachKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                    dgvDanhSachKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dgvDanhSachKhachHang.Columns["SDT"].HeaderText = "SĐT";
                    dgvDanhSachKhachHang.Columns["Email"].HeaderText = "Email";

                    // Giúp cột tự điều chỉnh độ rộng để lấp đầy DataGridView
                    if (dgvDanhSachKhachHang.Columns.Count > 0)
                    {
                        dgvDanhSachKhachHang.Columns["MaKH"].FillWeight = 50; // Giảm độ rộng cột Mã KH
                        dgvDanhSachKhachHang.Columns["TenKH"].FillWeight = 80;
                        dgvDanhSachKhachHang.Columns["SDT"].FillWeight = 70;
                        dgvDanhSachKhachHang.Columns["DiaChi"].FillWeight = 100;
                        dgvDanhSachKhachHang.Columns["Email"].FillWeight = 120;
                    }
                }
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu khách hàng: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thực thi các lệnh SQL không trả về dữ liệu (Insert, Update, Delete)
        /// </summary>
        private void ExecuteNonQuery(string sql, string successMessage)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();

                    // Thêm tham số chung
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    // Tham số MaKH chỉ cần khi Update/Delete/Insert thủ công
                    if (sql.Contains("@MaKH"))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    formState = 0;
                    ClearTextBoxes();
                    SetControlState(false);
                    LoadDataKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // =======================================================
        // PHƯƠNG THỨC XỬ LÝ SỰ KIỆN CÁC NÚT
        // =======================================================

        private void btnThem_Click(object sender, EventArgs e)
        {
            formState = 1;
            ClearTextBoxes();
            SetControlState(true);
            txtMaKH.Text = "Nhập Mã KH";
            txtMaKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã KH, Tên Khách Hàng và Số Điện Thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql;
            string message;

            if (formState == 1) // Trạng thái Thêm mới
            {
                sql = "INSERT INTO KHACHHANG (MaKH, TenKH, DiaChi, SDT, Email) " +
                      "VALUES (@MaKH, @TenKH, @DiaChi, @SDT, @Email)";
                message = "Thêm mới Khách hàng thành công!";
            }
            else if (formState == 2) // Trạng thái Cập nhật
            {
                sql = "UPDATE KHACHHANG SET TenKH = @TenKH, DiaChi = @DiaChi, SDT = @SDT, Email = @Email " +
                      "WHERE MaKH = @MaKH";
                message = "Cập nhật Khách hàng thành công!";
            }
            else
            {
                return;
            }

            ExecuteNonQuery(sql, message);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một Khách hàng từ danh sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            formState = 2;
            SetControlState(true);
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một Khách hàng từ danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa Khách hàng Mã: {txtMaKH.Text} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string sql = "DELETE FROM KHACHHANG WHERE MaKH = @MaKH";
                ExecuteNonQuery(sql, "Xóa Khách hàng thành công!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            formState = 0;
            SetControlState(false);
            ClearTextBoxes();
            LoadDataKhachHang();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDataKhachHang();
                return;
            }
            LoadDataKhachHang(keyword);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDataKhachHang();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =======================================================
        // PHƯƠNG THỨC XỬ LÝ SỰ KIỆN DATAGRIDVIEW
        // =======================================================

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                formState = 0;
                SetControlState(false);
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}