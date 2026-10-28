
namespace Bai5_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(30, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(100, 20);
            lblUsername.Text = "Tên đăng nhập";

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(150, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(220, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(30, 85);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(75, 20);
            lblPassword.Text = "Mật khẩu";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(150, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(220, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;

            // chkShowPassword
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new System.Drawing.Point(150, 122);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new System.Drawing.Size(130, 24);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // btnLogin
            btnLogin.Location = new System.Drawing.Point(75, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(125, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            // btnExit
            btnExit.Location = new System.Drawing.Point(220, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(100, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            // errorProvider
            errorProvider.ContainerControl = this;

            // Form1
            AcceptButton = btnLogin;
            CancelButton = btnExit;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 255);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng nhập";

            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
