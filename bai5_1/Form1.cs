
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
    {
        private string chuoiKetNoi =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LoginDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            AcceptButton = btnLogin;
            CancelButton = btnExit;
        }

        private bool KiemTraDuLieu()
        {
            bool hopLe = true;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(
                    txtUsername,
                    "Vui lòng nhập tên đăng nhập!");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(
                    txtPassword,
                    "Vui lòng nhập mật khẩu!");

                hopLe = false;
            }

            return hopLe;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    string sql =
                        "SELECT COUNT(*) FROM TaiKhoan " +
                        "WHERE TenDangNhap = @TenDangNhap " +
                        "AND MatKhau = @MatKhau";

                    using (SqlCommand lenh =
                        new SqlCommand(sql, ketNoi))
                    {
                        lenh.Parameters.AddWithValue(
                            "@TenDangNhap",
                            txtUsername.Text.Trim());

                        lenh.Parameters.AddWithValue(
                            "@MatKhau",
                            txtPassword.Text);

                        int ketQua = Convert.ToInt32(
                            lenh.ExecuteScalar());

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Đăng nhập thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Tên đăng nhập hoặc mật khẩu không đúng!",
                                "Đăng nhập thất bại",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Lỗi kết nối cơ sở dữ liệu!\n" + ex.Message,
                    "Lỗi SQL Server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(
            object sender, EventArgs e)
        {
            errorProvider.SetError(txtUsername, "");
        }

        private void txtPassword_TextChanged(
            object sender, EventArgs e)
        {
            errorProvider.SetError(txtPassword, "");
        }
    }
}
