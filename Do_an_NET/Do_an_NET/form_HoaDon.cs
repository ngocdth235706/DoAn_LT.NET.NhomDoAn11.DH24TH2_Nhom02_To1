using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Do_an_NET
{
    public partial class form_HoaDon : Form
    {
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";
        private bool isAddingNew = false;

        public form_HoaDon()
        {
            InitializeComponent();
        }

        private void form_HoaDon_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDataHoaDon();
            LoadKhachHangIntoComboBox();
            SetEditMode(false);
            txtNgayban.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #region COMMON METHODS

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
            cmbKhachhang.Text = "";
            txtMaKH.Clear();
            txtNgayban.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void SetEditMode(bool isEnabled)
        {
            txtMaHD.ReadOnly = !isAddingNew;
            txtMaNV.ReadOnly = !isEnabled;
            txtNgayban.ReadOnly = !isEnabled;
            txtGhichu.ReadOnly = !isEnabled;
            cmbKhachhang.Enabled = isEnabled;

            txtMaKH = new TextBox();
            txtMaKH.Location = new Point(920, 78); 
            txtMaKH.Size = new Size(150, 35);
            txtMaKH.Visible = false; 
            groupBoxThongtinhoadon.Controls.Add(txtMaKH);

            btnThem.Enabled = !isEnabled;
            btnLuu.Enabled = isEnabled;
            btnXoa.Enabled = !isEnabled;
            btnHuy.Enabled = isEnabled;
            btnQuayLai.Enabled = !isEnabled;

            btnTimkhach.Enabled = isEnabled;
            btnThemkhach.Enabled = isEnabled;

            txtTimKiem.ReadOnly = isEnabled;
            btnTim.Enabled = !isEnabled;
            btnTaiLai.Enabled = !isEnabled;
        }

        #endregion

        #region LOAD DATA

        private void LoadKhachHangIntoComboBox()
        {
            cmbKhachhang.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT TenKH FROM KHACHHANG ORDER BY TenKH ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbKhachhang.Items.Add(reader["TenKH"].ToString());
                        }
                    }
                }

                cmbKhachhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbKhachhang.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách Khách hàng: " + ex.Message);
            }
        }

        private string GetMaKHFromTenKH(string tenKH)
        {
            if (string.IsNullOrEmpty(tenKH)) return null;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT MaKH FROM KHACHHANG WHERE TenKH = @TenKH";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm Mã KH: " + ex.Message);
                return null;
            }
        }

        private void LoadDataHoaDon(string filter = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        SELECT HD.MaHD, HD.NgayBan, HD.MaNV, KH.TenKH AS KhachHang, HD.GhiChu
                        FROM HOADON HD
                        INNER JOIN KHACHHANG KH ON HD.MaKH = KH.MaKH";

                    if (!string.IsNullOrEmpty(filter))
                        sql += " WHERE HD.MaHD LIKE @Filter OR KH.TenKH LIKE @Filter";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (!string.IsNullOrEmpty(filter))
                        cmd.Parameters.AddWithValue("@Filter", "%" + filter + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachHoaDon.DataSource = dt;

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
                MessageBox.Show("Lỗi tải Hóa đơn: " + ex.Message);
            }
        }

        #endregion

        #region BUTTON EVENTS

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
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaNV.Text) ||
                string.IsNullOrEmpty(tenKH) || !DateTime.TryParse(txtNgayban.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Hóa đơn.", "Thông báo");
                return;
            }

            // Lấy MaKH hoặc tạo mới thông qua form_KhachHang
            string maKH = GetMaKHFromTenKH(tenKH);
            if (string.IsNullOrEmpty(maKH))
            {
                if (MessageBox.Show($"Khách hàng '{tenKH}' chưa tồn tại. Bạn muốn thêm mới?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_KhachHang khForm = new form_KhachHang();
                    khForm.ShowDialog();
                    maKH = khForm.SelectedMaKH;
                    if (!string.IsNullOrEmpty(maKH))
                    {
                        LoadKhachHangIntoComboBox();
                        cmbKhachhang.Text = khForm.SelectedTenKH;
                    }
                    else
                    {
                        MessageBox.Show("Hủy lưu Hóa đơn do chưa có Khách hàng.");
                        return;
                    }
                }
                else return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO HOADON (MaHD, MaNV, MaKH, NgayBan, GhiChu) VALUES (@MaHD, @MaNV, @MaKH, @NgayBan, @GhiChu)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@NgayBan", DateTime.Parse(txtNgayban.Text));
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhichu.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tạo Hóa đơn thành công!");
                    ClearTextBoxes();
                    LoadDataHoaDon();
                    SetEditMode(false);
                    isAddingNew = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu Hóa đơn: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Chọn Hóa đơn cần xóa.");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa Hóa đơn {txtMaHD.Text}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM HOADON WHERE MaHD=@MaHD", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa Hóa đơn thành công.");
                        ClearTextBoxes();
                        LoadDataHoaDon();
                        SetEditMode(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Hóa đơn: " + ex.Message);
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
            LoadDataHoaDon(txtTimKiem.Text.Trim());
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

        #endregion

        #region CHỌN & THÊM KHÁCH HÀNG

        private void btnTimkhach_Click(object sender, EventArgs e)
        {
            form_KhachHang khForm = new form_KhachHang();
            if (khForm.ShowDialog() == DialogResult.OK)
            {
                cmbKhachhang.Text = khForm.SelectedTenKH;
                txtMaKH.Text = khForm.SelectedMaKH;
            }
        }

        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            form_KhachHang khForm = new form_KhachHang();
            khForm.FormState = 1; // Mở ở chế độ Thêm
            if (khForm.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangIntoComboBox();
                cmbKhachhang.Text = khForm.SelectedTenKH;
                // Nếu bạn có textbox mã KH:
                // txtMaKH.Text = khForm.SelectedMaKH;
            }
        }


        private void btnMoCTHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHoaDon.CurrentRow != null)
            {
                string selectedMaHD = dgvDanhSachHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                form_CTHoaDon cthdForm = new form_CTHoaDon(selectedMaHD);
                cthdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region DATAGRIDVIEW EVENTS

        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtGhichu.Text = row.Cells["GhiChu"].Value?.ToString();
                cmbKhachhang.Text = row.Cells["KhachHang"].Value?.ToString();

                if (row.Cells["NgayBan"].Value != null && DateTime.TryParse(row.Cells["NgayBan"].Value.ToString(), out DateTime ngayBan))
                {
                    txtNgayban.Text = ngayBan.ToString("yyyy-MM-dd HH:mm:ss");
                }

                SetEditMode(false);
                btnXoa.Enabled = true;
            }
        }

        #endregion
    }
}
