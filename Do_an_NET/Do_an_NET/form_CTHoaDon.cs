using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq; 

namespace Do_an_NET
{
    public partial class form_CTHoaDon : Form
    {
        // Biến trạng thái
        private bool isAddingNew = false;
        private string maHoaDonHienTai; // Lưu trữ Mã HĐ được truyền vào

        // Chuỗi kết nối CSDL
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";
        public form_CTHoaDon()
        {
            InitializeComponent();
            maHoaDonHienTai = string.Empty;
            txtMaHD.ReadOnly = true;
        }

        
        public form_CTHoaDon(string maHD) : this() 
        {
            

            maHoaDonHienTai = maHD;
            txtMaHD.Text = maHD; 
            txtMaHD.ReadOnly = true;

            SetEditMode(false);
        }

        // ===============================================
        // CÁC HÀM CHỨC NĂNG CƠ BẢN
        // ===============================================

        public void LoadData(string keyword = "")
        {
            if (string.IsNullOrEmpty(maHoaDonHienTai)) return;

            // === 1. Tối ưu hóa SQL để hiển thị Tên Xe ===
            string sqlQuery = @"
                SELECT 
                    cthd.MaHD,
                    cthd.MaXe,
                    xm.TenXe, 
                    cthd.SoLuong,
                    cthd.DonGia,
                    cthd.ThanhTien 
                FROM CTHoaDon cthd
                JOIN xemay xm ON cthd.MaXe = xm.MaXe
                WHERE cthd.MaHD = @MaHD";

            if (!string.IsNullOrEmpty(keyword))
            {
                // Tìm kiếm theo MaXe, TenXe hoặc MaHD trong chi tiết
                sqlQuery += " AND (cthd.MaXe LIKE @Keyword OR xm.TenXe LIKE @Keyword)";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, conn);
                    DataTable dataTable = new DataTable();

                    adapter.SelectCommand.Parameters.AddWithValue("@MaHD", maHoaDonHienTai);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }

                    adapter.Fill(dataTable);
                    dgvDanhSachCTHoaDon.DataSource = dataTable;
                    dgvDanhSachCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Thêm Tên Xe vào header (nếu chưa có trong Designer)
                    if (dgvDanhSachCTHoaDon.Columns.Contains("TenXe") && dgvDanhSachCTHoaDon.Columns["TenXe"] != null)
                    {
                        dgvDanhSachCTHoaDon.Columns["TenXe"].HeaderText = "Tên Xe";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("LỖI TẢI DỮ LIỆU CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtMaHD.Text = maHoaDonHienTai; // Giữ lại Mã HĐ
            txtMaXe.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
        }

        private void SetEditMode(bool isEnabled)
        {
            
            txtMaXe.ReadOnly = !isEnabled;
            txtSoLuong.ReadOnly = !isEnabled;
            txtDonGia.ReadOnly = !isEnabled;
            txtThanhTien.ReadOnly = true;

            btnLuu.Enabled = isEnabled;
            btnHuy.Enabled = isEnabled;

            btnThem.Enabled = !isEnabled;
            btnXoa.Enabled = !isEnabled && !string.IsNullOrEmpty(txtMaXe.Text);
            btnInHD.Enabled = !isEnabled;

            btnTim.Enabled = true;
            btnTaiLai.Enabled = true;

            
        }

        // Hàm tự động tính Thành Tiền
        private void CalculateThanhTien()
        {
            if (decimal.TryParse(txtDonGia.Text, out decimal donGia) &&
                int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                decimal thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }

        // Hàm hỗ trợ thực thi CSDL (Giữ nguyên)
        private bool ExecuteNonQuery(string sqlQuery, string successMessage)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
                            throw new Exception("Số lượng không hợp lệ.");

                        string rawDonGia = Regex.Replace(txtDonGia.Text, "[^0-9]", ""); 
                        string rawThanhTien = Regex.Replace(txtThanhTien.Text, "[^0-9]", ""); 

                        if (!decimal.TryParse(rawDonGia, out decimal donGia) || donGia <= 0)
                            throw new Exception("Đơn giá không hợp lệ.");

                        
                        decimal thanhTien = donGia * soLuong;

                        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@ThanhTien", thanhTien); // Sử dụng giá trị tính toán

                       

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(successMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào bị ảnh hưởng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI THAO TÁC CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Hàm kiểm tra sự tồn tại của MaXe trong MaHD hiện tại (Giữ nguyên)
        private bool IsDetailExist(string maHD, string maXe)
        {
            string sqlQuery = "SELECT COUNT(*) FROM CTHoaDon WHERE MaHD = @MaHD AND MaXe = @MaXe";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaXe", maXe);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra tồn tại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Hàm lấy Đơn giá từ MaXe (MỚI)
        private decimal GetGiaXeByMaXe(string maXe)
        {
            string sqlQuery = "SELECT GiaXe FROM xemay WHERE MaXe = @MaXe";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@MaXe", maXe);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                    return 0m;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy giá xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0m;
                }
            }
        }

        // ===============================================
        // CÁC SỰ KIỆN XỬ LÝ
        // ===============================================

        private void form_CTHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEditMode(false);
            dgvDanhSachCTHoaDon.AllowUserToAddRows = false;
        }

        private void dgvDanhSachCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachCTHoaDon.Rows.Count) 
            {
                DataGridViewRow row = dgvDanhSachCTHoaDon.Rows[e.RowIndex];

                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtMaXe.Text = row.Cells["MaXe"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                if (decimal.TryParse(row.Cells["DonGia"].Value.ToString(), out decimal donGia))
                {
                    txtDonGia.Text = donGia.ToString("N0");
                }
                if (decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                {
                    txtThanhTien.Text = thanhTien.ToString("N0");
                }

                isAddingNew = false;
                SetEditMode(false);
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maHoaDonHienTai))
            {
                MessageBox.Show("Không thể thêm chi tiết. Vui lòng tạo Hóa đơn chính trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === 2. Mở Form chọn Xe (form_XeMay) ===
            using (form_XeMay xeMayForm = new form_XeMay())
            {
                if (xeMayForm.ShowDialog() == DialogResult.OK)
                {
                    string maXeDaChon = xeMayForm.SelectedMaXe;

                    if (!string.IsNullOrEmpty(maXeDaChon))
                    {
                        // 1. Kiểm tra xe đã tồn tại trong CTHD chưa
                        if (IsDetailExist(maHoaDonHienTai, maXeDaChon))
                        {
                            MessageBox.Show($"Xe có Mã {maXeDaChon} đã tồn tại trong hóa đơn này. Vui lòng sửa chi tiết hoặc chọn xe khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            // Đặt lại các chế độ như ban đầu
                            ClearTextBoxes();
                            SetEditMode(false);
                            return;
                        }

                        // 2. Lấy Đơn Giá (GiaXe) từ CSDL
                        decimal giaXe = GetGiaXeByMaXe(maXeDaChon);

                        // 3. Đổ dữ liệu vào Textboxes
                        isAddingNew = true;
                        ClearTextBoxes(); // Xóa và đặt lại MaHD
                        SetEditMode(true);

                        txtMaXe.Text = maXeDaChon;
                        txtDonGia.Text = giaXe.ToString("N0"); 
                        txtSoLuong.Text = "1"; // Mặc định số lượng là 1
                        txtSoLuong.Focus();
                    }
                }
            }
            // ===================================
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtMaXe.Text) ||
                string.IsNullOrEmpty(txtSoLuong.Text) ||
                string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Xe, Số Lượng và Đơn Giá.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql;
            string message;

            if (isAddingNew)
            {
                // Thao tác Thêm Mới
                if (IsDetailExist(txtMaHD.Text, txtMaXe.Text))
                {
                    MessageBox.Show("Chi tiết hóa đơn với Mã Xe này đã tồn tại. Vui lòng cập nhật hoặc hủy.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql = "INSERT INTO chitiethoadon (MaHD, MaXe, SoLuong, DonGia, ThanhTien) " +
                      "VALUES (@MaHD, @MaXe, @SoLuong, @DonGia, @ThanhTien)";
                message = "Thêm chi tiết hóa đơn thành công!";
            }
            else
            {
                // Thao tác Cập nhật
                sql = "UPDATE chitiethoadon SET SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien " +
                      "WHERE MaHD = @MaHD AND MaXe = @MaXe";
                message = "Cập nhật chi tiết hóa đơn thành công!";
            }

            if (ExecuteNonQuery(sql, message))
            {
                LoadData();
                ClearTextBoxes();
                isAddingNew = false;
                SetEditMode(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn chi tiết hóa đơn cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa chi tiết HĐ cho xe {txtMaXe.Text}?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM chitiethoadon WHERE MaHD = @MaHD AND MaXe = @MaXe";
                if (ExecuteNonQuery(sql, "Xóa chi tiết hóa đơn thành công!"))
                {
                    ClearTextBoxes();
                    LoadData();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            isAddingNew = false;
            SetEditMode(false);
            LoadData();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadData();
            ClearTextBoxes();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            LoadData(keyword);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng In Hóa Đơn chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===============================================
        // SỰ KIỆN TÍNH TOÁN THÀNH TIỀN
        // ===============================================

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            // Loại bỏ định dạng khi đọc Đơn giá (để tính toán)
            // Lưu ý: txtDonGia.Text = Regex.Replace(txtDonGia.Text, "[^0-9.]", ""); có thể gây mất định dạng hiển thị
            // Ta chỉ cần gọi CalculateThanhTien()
            CalculateThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.ReadOnly == false)
            {
                CalculateThanhTien();
            }
        }
    }
}