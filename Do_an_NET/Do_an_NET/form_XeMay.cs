using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Do_an_NET
{
    public partial class form_XeMay : Form
    {
        private bool isAddingNew = false;
        private readonly string connectionString = "Server=localhost;Database=qlcuahangxemay;Uid=root;Pwd=DoAn_Python_DH24TH2;";

        
        public string SelectedMaXe { get; private set; } = "";

        public form_XeMay()
        {
            InitializeComponent();
            dgvDanhSachXe.AllowUserToAddRows = false;
            dgvDanhSachXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================= Load dữ liệu =================
        public void LoadData(string keyword = "")
        {
            string sqlQuery = "SELECT MaXe, TenXe, HangXe, MauXe, GiaXe, SoLuong, CreatedAt FROM xemay";
            if (!string.IsNullOrEmpty(keyword))
            {
                sqlQuery += " WHERE TenXe LIKE @Keyword OR MaXe LIKE @Keyword OR HangXe LIKE @Keyword";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, conn);
                    if (!string.IsNullOrEmpty(keyword))
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSachXe.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public void LoadMauXeData()
        {
            string sql = "SELECT DISTINCT MauXe FROM xemay WHERE MauXe IS NOT NULL AND MauXe != '' ORDER BY MauXe ASC";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 1. Chuyển DataTable thành List<string>
                    List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("MauXe")).ToList();

                    // 2. Gán DataSource trước
                    cmbMauXe.DataSource = list;

                    // 3. KIỂM TRA ĐIỀU KIỆN TRƯỚC KHI THIẾT LẬP SelectedIndex = -1
                    // Chỉ thiết lập SelectedIndex = -1 nếu danh sách có mục.
                    // Nếu danh sách rỗng, để mặc định (hoặc đặt Text = "")
                    if (list.Count > 0)
                    {
                        cmbMauXe.SelectedIndex = -1;
                    }
                    else
                    {
                        // Nếu không có dữ liệu, có thể đặt Text rỗng để hiển thị không có gì
                        cmbMauXe.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải màu xe: " + ex.Message);
                }
            }
        }

        // ================= Xử lý thêm/sửa/xóa =================
        private void ExecuteNonQuery(string sql, string message)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                        cmd.Parameters.AddWithValue("@HangXe", txtHangXe.Text);
                        cmd.Parameters.AddWithValue("@MauXe", cmbMauXe.Text);

                        if (!decimal.TryParse(txtGiaXe.Text, out decimal giaXe))
                            throw new Exception("Giá xe không hợp lệ.");
                        if (!int.TryParse(txtSoLuong.Text, out int soLuong))
                            throw new Exception("Số lượng không hợp lệ.");

                        cmd.Parameters.AddWithValue("@GiaXe", giaXe);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearTextBoxes();
                            SetEditMode(false);
                            isAddingNew = false;
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào bị ảnh hưởng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thao tác CSDL: " + ex.Message);
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            txtHangXe.Clear();
            cmbMauXe.SelectedIndex = -1;
            txtGiaXe.Clear();
            txtSoLuong.Clear();
        }

        private void SetEditMode(bool isEnabled)
        {
            txtMaXe.ReadOnly = !(isEnabled && isAddingNew);
            txtTenXe.ReadOnly = !isEnabled;
            txtHangXe.ReadOnly = !isEnabled;
            cmbMauXe.Enabled = isEnabled;
            txtGiaXe.ReadOnly = !isEnabled;
            txtSoLuong.ReadOnly = !isEnabled;

            btnLuu.Enabled = isEnabled;
            btnHuy.Enabled = isEnabled;
            btnThem.Enabled = !isEnabled;
            btnCapNhat.Enabled = !isEnabled && !string.IsNullOrEmpty(txtMaXe.Text);
            btnXoa.Enabled = !isEnabled && !string.IsNullOrEmpty(txtMaXe.Text);
        }

        // ================= Sự kiện =================
        private void form_XeMay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMauXeData();
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
            if (string.IsNullOrEmpty(txtMaXe.Text) || string.IsNullOrEmpty(txtTenXe.Text) || string.IsNullOrEmpty(txtHangXe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql;
            string msg;
            if (isAddingNew)
            {
                sql = "INSERT INTO xemay (MaXe, TenXe, HangXe, MauXe, GiaXe, SoLuong, CreatedAt) VALUES (@MaXe,@TenXe,@HangXe,@MauXe,@GiaXe,@SoLuong,NOW())";
                msg = "Thêm mới xe thành công!";
            }
            else
            {
                sql = "UPDATE xemay SET TenXe=@TenXe,HangXe=@HangXe,MauXe=@MauXe,GiaXe=@GiaXe,SoLuong=@SoLuong WHERE MaXe=@MaXe";
                msg = "Cập nhật xe thành công!";
            }
            ExecuteNonQuery(sql, msg);
            LoadMauXeData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe cần cập nhật.");
                return;
            }
            isAddingNew = false;
            SetEditMode(true);
            txtMaXe.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe cần xóa.");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa xe {txtMaXe.Text}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM xemay WHERE MaXe=@MaXe";
                ExecuteNonQuery(sql, "Xóa xe thành công!");
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
            txtTimKiem.Clear();
            LoadData();
            ClearTextBoxes();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDanhSachXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedMaXe = dgvDanhSachXe.Rows[e.RowIndex].Cells["MaXe"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void dgvDanhSachXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDanhSachXe.Rows[e.RowIndex];
            txtMaXe.Text = row.Cells["MaXe"].Value.ToString();
            txtTenXe.Text = row.Cells["TenXe"].Value.ToString();
            txtHangXe.Text = row.Cells["HangXe"].Value.ToString();
            cmbMauXe.Text = row.Cells["MauXe"].Value.ToString();
            txtGiaXe.Text = row.Cells["GiaXe"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            SetEditMode(false);
        }

    }
}
