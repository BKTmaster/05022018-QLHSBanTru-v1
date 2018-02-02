using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.DAO;

namespace QLHSBanTru2018_Demo_V1
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                labError.Text = "Mời bạn nhập đầy đủ thông tin";
                txtUsername.Focus();
                txtPassword.ResetText();
            }
            else
            {
                int result = new EmployeeDAO().Login(txtUsername.Text, MD5Hash.PasswordEncryptor.MD5Hash(txtPassword.Text));
                if (result == 0)
                {
                    labError.Text = "Tài khoản không tồn tại hoặc đã xảy ra lỗi";
                    txtUsername.Focus();
                    txtPassword.ResetText();
                }
                else
                {
                    if (result == 2)
                    {
                        labError.Text = "Mật khẩu không chính xác";
                        txtPassword.ResetText();
                        txtPassword.Focus();
                    }
                    if (result == -1)
                    {
                        labError.Text = "Tài khoản đã bị khoá";
                        txtUsername.Focus();
                        txtPassword.ResetText();
                    }
                    else if (result == 1)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}