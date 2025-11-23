using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using DVLD_Project.User;

namespace DVLD_Project
{
    public partial class frmUsers : Form
    {
        DataTable _AllUsers;
        public frmUsers()
        {
            InitializeComponent();
            cob_Filter.SelectedIndex = 0;
            _LoadData();
        }

        private void _LoadData()
        {
            _AllUsers = clsUser.GetAllUsers();
            dgv_users.DataSource = _AllUsers;
            lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            frmHandleUser form = new frmHandleUser();
            form.ShowDialog();
            _LoadData();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //None
            //User ID
            //Full Name
            //Username
            //Is Active
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                cob_IsActive.Visible = false;
                _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 4)
            {
                cob_IsActive.Visible = true;

                tb_SearchBox.Visible = false;
                cob_IsActive.SelectedIndex = 0;
                _LoadData();
                cob_IsActive.Location = new Point(224, 151);
            }
            else
            {
                tb_SearchBox.Visible = true;
                cob_IsActive.Visible = false;
                tb_SearchBox.Select();
            }
            tb_SearchBox.Text = string.Empty;
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 1)
            {
                if (int.TryParse(tb_SearchBox.Text, out int UserID))
                {
                    _AllUsers.DefaultView.RowFilter = string.Format("[User ID] = {0}", UserID);
                    lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
                }
                else
                {
                    tb_SearchBox.Text = string.Empty;
                }
            }
            else if (cob_Filter.SelectedIndex == 2)
            {
                _AllUsers.DefaultView.RowFilter = string.Format("[Full Name] like '{0}%'", tb_SearchBox.Text);
                lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
            }
            else if (cob_Filter.SelectedIndex == 3)
            {
                _AllUsers.DefaultView.RowFilter = string.Format("[UserName] like '{0}%'", tb_SearchBox.Text);
                lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
            }
        }

        private void cob_IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_IsActive.SelectedIndex == 0)
            {
                _LoadData();
            }
            else if (cob_IsActive.SelectedIndex == 1)
            {
                _AllUsers.DefaultView.RowFilter = "[IsActive] = 1";
                lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
            }
            else if (cob_IsActive.SelectedIndex == 2)
            {
                _AllUsers.DefaultView.RowFilter = "[IsActive] = 0";
                lb_totalUsers.Text = _AllUsers.Rows.Count.ToString();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandleUser form = new frmHandleUser((int)dgv_users.CurrentRow.Cells["User ID"].Value);
            form.ShowDialog();
            _LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user with id = " + dgv_users.CurrentRow.Cells["User ID"].Value.ToString(), "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                clsUser user = clsUser.Find((int)dgv_users.CurrentRow.Cells["User ID"].Value);
                if (user != null)
                {
                    if (user.Delete())
                    {
                        MessageBox.Show("User Deleted successfully!", "Deleted");
                        _LoadData();
                    }
                    else
                    {
                        MessageBox.Show("User faild to Delete because it has many records!", "Faild");
                    }
                }

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails form = new frmUserDetails((int)dgv_users.CurrentRow.Cells["User ID"].Value);
            form.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }

        private void changePassword_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword form = new frmChangeUserPassword((int)dgv_users.CurrentRow.Cells["User ID"].Value);
            form.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandleUser form = new frmHandleUser();
            form.ShowDialog();
            _LoadData();
        }
    }
}
