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

namespace DVLD_Project.Local_Driving_Licence
{
    public partial class frmIssueDrivingLicenceFirstTime : Form
    {
        clsLocalDrivingLicenseApplication _LDLApp;
        public frmIssueDrivingLicenceFirstTime(int LocalDrivingLicenceAppID)
        {
            InitializeComponent();
            if (clsTest.GetPassedTestCount(LocalDrivingLicenceAppID) < 3)
            {
                MessageBox.Show("You should pass all tests first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenceAppID);
            if (_LDLApp == null)
            {
                MessageBox.Show("there is no Local Driving Licence Application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            _LoadData();
        }

        private void _LoadData()
        {
            cuc_ApplicationInfo1.LoadDataByLocalDrivingLicenceAppID(_LDLApp.LocalDrivingLicenseApplicationID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Issue_Click(object sender, EventArgs e)
        {

            if (_LDLApp.IssueLicenseForFirstTime(tb_Notes.Text, clsGeneralSettings.CurrentUser.UserID))
            {
                btn_Issue.Enabled = false;
                tb_Notes.Enabled = false;
                cuc_ApplicationInfo1.MakeShowLicenseEnabled();
                MessageBox.Show("Licence was issued successfully!", "Success");
            }
            else
                MessageBox.Show("Licence Faild to issue!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
