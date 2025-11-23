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
    public partial class frmUserDetails : Form
    {
        
        private int _UserID;
        public frmUserDetails(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            clsUser User = clsUser.Find(UserID);
            if (User != null )
            {
                cuc_userCard1.LoadData(UserID);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_EditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHandleUser form = new frmHandleUser(_UserID);
            form.ShowDialog();
        }
    }
}
