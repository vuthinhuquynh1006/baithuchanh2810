
namespace Bai5_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.CheckBox chkMaterials;
        private System.Windows.Forms.CheckBox chkCertificate;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblFullName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblBirthDate = new System.Windows.Forms.Label();
            lblGender = new System.Windows.Forms.Label();
            lblCourse = new System.Windows.Forms.Label();

            txtFullName = new System.Windows.Forms.TextBox();
            mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            dtpBirthDate = new System.Windows.Forms.DateTimePicker();

            rdoMale = new System.Windows.Forms.RadioButton();
            rdoFemale = new System.Windows.Forms.RadioButton();

            cboCourse = new System.Windows.Forms.ComboBox();
            chkMaterials = new System.Windows.Forms.CheckBox();
            chkCertificate = new System.Windows.Forms.CheckBox();
            btnRegister = new System.Windows.Forms.Button();

            SuspendLayout();

            // lblFullName
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(30, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Text = "Họ và tên";

            // txtFullName
            txtFullName.Location = new System.Drawing.Point(150, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(250, 27);
            txtFullName.TabIndex = 0;

            // lblPhone
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(30, 75);
            lblPhone.Name = "lblPhone";
            lblPhone.Text = "Số điện thoại";

            // mtxtPhone
            mtxtPhone.Location = new System.Drawing.Point(150, 72);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Size = new System.Drawing.Size(250, 27);
            mtxtPhone.TabIndex = 1;

            // lblBirthDate
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new System.Drawing.Point(30, 120);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Text = "Ngày sinh";

            // dtpBirthDate
            dtpBirthDate.Location = new System.Drawing.Point(150, 117);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new System.Drawing.Size(250, 27);
            dtpBirthDate.TabIndex = 2;
            dtpBirthDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // lblGender
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(30, 165);
            lblGender.Name = "lblGender";
            lblGender.Text = "Giới tính";

            // rdoMale
            rdoMale.AutoSize = true;
            rdoMale.Location = new System.Drawing.Point(150, 162);
            rdoMale.Name = "rdoMale";
            rdoMale.Text = "Nam";
            rdoMale.TabIndex = 3;
            rdoMale.Checked = true;

            // rdoFemale
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new System.Drawing.Point(240, 162);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Text = "Nữ";
            rdoFemale.TabIndex = 4;

            // lblCourse
            lblCourse.AutoSize = true;
            lblCourse.Location = new System.Drawing.Point(30, 210);
            lblCourse.Name = "lblCourse";
            lblCourse.Text = "Khóa học";

            // cboCourse
            cboCourse.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new System.Drawing.Point(150, 207);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new System.Drawing.Size(250, 28);
            cboCourse.TabIndex = 5;

            // chkMaterials
            chkMaterials.AutoSize = true;
            chkMaterials.Location = new System.Drawing.Point(150, 252);
            chkMaterials.Name = "chkMaterials";
            chkMaterials.Text = "Đăng ký tài liệu";
            chkMaterials.TabIndex = 6;

            // chkCertificate
            chkCertificate.AutoSize = true;
            chkCertificate.Location = new System.Drawing.Point(150, 282);
            chkCertificate.Name = "chkCertificate";
            chkCertificate.Text = "Đăng ký chứng chỉ";
            chkCertificate.TabIndex = 7;

            // btnRegister
            btnRegister.Location = new System.Drawing.Point(150, 330);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(150, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(440, 400);

            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblPhone);
            Controls.Add(mtxtPhone);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(chkMaterials);
            Controls.Add(chkCertificate);
            Controls.Add(btnRegister);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Đăng ký khóa học";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
