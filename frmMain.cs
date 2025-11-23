using BusinessLayer;
using DVLD_Project.Applications;
using DVLD_Project.Detained_Licenses;
using DVLD_Project.International_Licence;
using DVLD_Project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lb_CurrentUser.Text = clsGeneralSettings.CurrentUser.UserName;
            lb_LoginDate.Text = DateTime.Now.ToString();
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersons form = new frmPersons();
            form.MdiParent = this;
            form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers form = new frmUsers();
            form.MdiParent = this;
            form.Show();
        }

        private void CurrentUserInfo_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails form = new frmUserDetails(clsGeneralSettings.CurrentUser.UserID);
            form.ShowDialog();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword form = new frmChangeUserPassword(clsGeneralSettings.CurrentUser.UserID);
            form.ShowDialog();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            //this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes form = new frmManageApplicationTypes();
            form.MdiParent = this;
            form.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes form = new frmManageTestTypes();
            form.MdiParent = this;
            form.Show();
        }

        private void renewDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDrivingLicence form = new frmRenewDrivingLicence();
            form.MdiParent = this;
            form.Show();
        }

        private void replacementForLostOrDamagedLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementForDamagedOrLost form = new frmReplacementForDamagedOrLost();
            form.MdiParent = this;
            form.Show();
        }

        private void releaseDetainedDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandleLocalLicence form = new frmHandleLocalLicence();
            form.MdiParent = this;
            form.Show();
        }

        private void internationalLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandleInternationalLicence form = new frmHandleInternationalLicence();
            form.MdiParent = this;
            form.Show();
        }

        private void localDrivingLicenceApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenceApp form = new frmLocalDrivingLicenceApp();
            form.MdiParent = this;
            form.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers drivers = new frmDrivers();
            drivers.MdiParent = this;
            drivers.Show();
        }

        private void internationlDrivingLicenceApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicences form = new frmInternationalLicences();
            form.MdiParent = this;
            form.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses form = new frmManageDetainedLicenses();
            form.MdiParent = this;
            form.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense form = new frmDetainLicense();
            form.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense form = new frmReleaseDetainedLicense();
            form.ShowDialog();
        }
    }
}
