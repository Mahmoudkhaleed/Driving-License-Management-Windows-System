using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmHandleUser : Form
    {
        private clsUser _User;
        private int _UserID;
        private int _PersonID = -1;
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public frmHandleUser()
        {
            InitializeComponent();
            _HandleAddNewMode();
        }
        public frmHandleUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
            _HandleUpdateMode();
        }
        private void _HandleUpdateMode()
        {
            _User = clsUser.Find(_UserID);
            if (_User != null)
            {
                _FillUserFormWithData();
            }
            else
            {
                MessageBox.Show("This user is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void _HandleAddNewMode()
        {
            _Mode = enMode.AddNew;
            tabPage_LoginInfo.Enabled = false;
        }

        private void _FillUserFormWithData()
        {
            _UpdateTitlesAndButtons();
            cuc_SearchForUser1.FillPerosnCard(_User.PersonID);
            _FillUserLoginInputsWithData();
        }

        private void _UpdateTitlesAndButtons()
        {
            _Mode = enMode.Update;
            this.Text = "Update User";
            btn_Save.Text = "        Update";
            cuc_SearchForUser1.MakeFilterBoxDisabled();
        }

        private void _FillUserLoginInputsWithData()
        {
            lb_UserID.Text = _User.UserID.ToString();
            tb_Username.Text = _User.UserName;
            tb_password.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;
            tb_ConfirmPassword.Visible = false;
            label6.Visible = false;
            pictureBox2.Visible = false;
            cb_IsActive.Location = new Point(29, 127);
            cb_IsActive.Checked = _User.IsActive;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (clsUser.FindPersonID(_PersonID) == null)
            {
                tabPage_LoginInfo.Enabled = true;
                ctrlBox_HandleUser.SelectTab(1);
            }
            else
            {
                tabPage_LoginInfo.Enabled = false;
                MessageBox.Show($"Perosn with ID = {_PersonID} is already a user in the system!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                switch (_Mode)
                {
                    case enMode.AddNew:
                        if (_PersonID != -1)
                        {
                            if (clsUser.FindPersonID(_PersonID) != null)
                            {
                                MessageBox.Show($"Perosn with ID = {_PersonID} is already a user in the system!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else _HandleAddingNewUser();
                        }
                        break;
                    case enMode.Update:
                        _HandleUpdatingUser();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show($"You should first initiate or bind a person and add user info to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void _HandleUpdatingUser()
        {
            _User.UserName = tb_Username.Text;
            _User.Password = clsEncryptions.ComputeHash(tb_password.Text);
            _User.IsActive = cb_IsActive.Checked;
            if (_User.Save())
            {
                MessageBox.Show("User was updated successfully!", "Success");
            }
            else MessageBox.Show("User is faild to update!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _HandleAddingNewUser()
        {
            clsUser user = new clsUser();
            user.PersonID = cuc_SearchForUser1.Person.PersonID;
            user.UserName = tb_Username.Text;
            user.Password = clsEncryptions.ComputeHash(tb_password.Text);
            user.IsActive = cb_IsActive.Checked;
            if (user.Save())
            {
                _User = user;
                lb_UserID.Text = user.UserID.ToString();
                _UpdateTitlesAndButtons();
                MessageBox.Show("User was added successfully!", "Success");
            }
            else MessageBox.Show("User is faild to add!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tb_Username_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tb_Username.Text))
            {
                errorProvider.SetError(tb_Username, "Username should not be empty!");
                e.Cancel = true;
            }
            else if (clsUser.Find(tb_Username.Text) != null && _User?.UserName != tb_Username.Text)
            {
                errorProvider.SetError(tb_Username, "Username was already exist. please, try another one!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Username, null);
            }
        }

        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_password.Text) && tb_password.Text.Length < 3)
            {
                errorProvider.SetError(tb_password, "The feild should not be empty and the length should exceeds 3 characters");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_password, null);
            }
        }

        private void tb_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tb_password.Text != tb_ConfirmPassword.Text)
            {
                errorProvider.SetError(tb_ConfirmPassword, "Two passwords should be the same!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_ConfirmPassword, null);
            }
        }

        private void cuc_SearchForUser1_OnPersonSelect(int personID)
        {
            _PersonID = personID;
            if (clsUser.FindPersonID(_PersonID) == null)
            {
                tabPage_LoginInfo.Enabled = true;
            }
            else
            {
                tabPage_LoginInfo.Enabled = false;
                MessageBox.Show($"Perosn with ID = {_PersonID} is already a user in the system!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
