
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        private string chuoiKetNoi =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DangKyKhoaHocDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            mtxtPhone.Mask = "(000) 000-0000";

            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.MaxDate = DateTime.Today;

            rdoMale.Checked = true;

            LoadKhoaHoc();
        }

        private void LoadKhoaHoc()
        {
            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    string sql =
                        "SELECT MaKhoaHoc, TenKhoaHoc, HocPhi " +
                        "FROM KhoaHoc ORDER BY MaKhoaHoc";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(sql, ketNoi);

                    DataTable bang = new DataTable();
                    adapter.Fill(bang);

                    cboCourse.DataSource = bang;
                    cboCourse.DisplayMember = "TenKhoaHoc";
                    cboCourse.ValueMember = "MaKhoaHoc";
                    cboCourse.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách khóa học!\n" + ex.Message,
                    "Lỗi SQL Server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!");
                txtFullName.Focus();
                return;
            }

            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại!");
                mtxtPhone.Focus();
                return;
            }

            if (dtpBirthDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (cboCourse.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khóa học!");
                cboCourse.Focus();
                return;
            }

            string hoTen = txtFullName.Text.Trim();
            string soDienThoai = mtxtPhone.Text;
            DateTime ngaySinh = dtpBirthDate.Value.Date;
            string gioiTinh = rdoMale.Checked ? "Nam" : "Nữ";
            int maKhoaHoc = Convert.ToInt32(cboCourse.SelectedValue);

            string dichVu = "";

            if (chkMaterials.Checked)
                dichVu += "Tài liệu, ";

            if (chkCertificate.Checked)
                dichVu += "Chứng chỉ, ";

            if (dichVu.Length > 0)
                dichVu = dichVu.Substring(0, dichVu.Length - 2);
            else
                dichVu = "Không";

            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    string sql = @"
                        INSERT INTO DangKy
                        (HoTen, SoDienThoai, NgaySinh,
                         GioiTinh, MaKhoaHoc, DichVu)
                        VALUES
                        (@HoTen, @SoDienThoai, @NgaySinh,
                         @GioiTinh, @MaKhoaHoc, @DichVu)";

                    using (SqlCommand lenh =
                        new SqlCommand(sql, ketNoi))
                    {
                        lenh.Parameters.Add(
                            "@HoTen", SqlDbType.NVarChar, 100).Value = hoTen;

                        lenh.Parameters.Add(
                            "@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                            soDienThoai;

                        lenh.Parameters.Add(
                            "@NgaySinh", SqlDbType.Date).Value = ngaySinh;

                        lenh.Parameters.Add(
                            "@GioiTinh", SqlDbType.NVarChar, 10).Value =
                            gioiTinh;

                        lenh.Parameters.Add(
                            "@MaKhoaHoc", SqlDbType.Int).Value = maKhoaHoc;

                        lenh.Parameters.Add(
                            "@DichVu", SqlDbType.NVarChar, 200).Value =
                            dichVu;

                        lenh.ExecuteNonQuery();
                    }
                }

                DataRowView khoaHoc =
                    cboCourse.SelectedItem as DataRowView;

                string tenKhoaHoc = khoaHoc["TenKhoaHoc"].ToString();
                decimal hocPhi = Convert.ToDecimal(khoaHoc["HocPhi"]);

                MessageBox.Show(
                    "ĐĂNG KÝ THÀNH CÔNG!\n\n" +
                    "Họ tên: " + hoTen + "\n" +
                    "Số điện thoại: " + soDienThoai + "\n" +
                    "Ngày sinh: " + ngaySinh.ToString("dd/MM/yyyy") + "\n" +
                    "Giới tính: " + gioiTinh + "\n" +
                    "Khóa học: " + tenKhoaHoc + "\n" +
                    "Học phí: " + hocPhi.ToString("N0") + " VNĐ\n" +
                    "Dịch vụ: " + dichVu,
                    "Thông tin đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể lưu thông tin đăng ký!\n" + ex.Message,
                    "Lỗi SQL Server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
