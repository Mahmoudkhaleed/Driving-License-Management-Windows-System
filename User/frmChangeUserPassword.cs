using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class frmChangeUserPassword : Form
    {
        private clsUser _User;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _User = clsUser.Find(UserID);
            if (_User != null)
            {
                cuc_userCard1.LoadData(UserID);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_User.Password == tb_CurrentPassword.Text)
            {
                _User.Password = tb_NewPassword.Text;
                if (_User.Save())
                {
                    MessageBox.Show("Password was changed successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Password faild to change!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Password is incorrect please try another one!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_NewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_NewPassword.Text))
            {
                errorProvider1.SetError(tb_NewPassword, "Feild shouldn't be empty!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_NewPassword, null);

        }

        private void tb_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ConfirmPassword.Text) || tb_ConfirmPassword.Text != tb_NewPassword.Text)
            {
                errorProvider1.SetError(tb_ConfirmPassword, "Two passwords should be matched!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_ConfirmPassword, null);
        }
    }
}
