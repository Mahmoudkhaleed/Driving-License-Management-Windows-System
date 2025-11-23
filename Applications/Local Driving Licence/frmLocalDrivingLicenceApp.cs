using BusinessLayer;
using DVLD_Project.Local_Driving_Licence;
using DVLD_Project.Properties;
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
    public partial class frmLocalDrivingLicenceApp : Form
    {
        public frmLocalDrivingLicenceApp()
        {
            InitializeComponent();
            cob_Filter.SelectedIndex = 0;
            _LoadData();
        }

        private void _LoadData()
        {
            DataTable dt = clsApplication.GetAllLocalApps();
            dgv_LocalDrivingLicencesApps.DataSource = dt;
            lb_totalApps.Text = dt.Rows.Count.ToString();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddLocalLicenceApp_Click(object sender, EventArgs e)
        {
            frmHandleLocalLicence form = new frmHandleLocalLicence();
            form.ShowDialog();
            _LoadData();
            cob_Filter.SelectedIndex = 0;
        }
        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                cob_IsAcive.Visible = false;
                _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 4)
            {
                tb_SearchBox.Visible = false;
                cob_IsAcive.Visible = true;
                cob_IsAcive.Location = new Point(224, 208);
                cob_IsAcive.SelectedIndex = 0;               
                _LoadData();
            }
            else
            {
                tb_SearchBox.Visible = true;
                cob_IsAcive.Visible = false;
            }
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 1)
            {
                if (int.TryParse(tb_SearchBox.Text, out int AppID))
                {
                    DataTable dt = clsApplication.GetAllLocalAppsByAppID(AppID);
                    dgv_LocalDrivingLicencesApps.DataSource = dt;
                    lb_totalApps.Text = dt.Rows.Count.ToString();
                }
                else
                    tb_SearchBox.Text = string.Empty;
            }
            else if (cob_Filter.SelectedIndex == 2)
            {
                if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                {
                    DataTable dt = clsApplication.GetAllLocalAppsByNationalNo(tb_SearchBox.Text);
                    dgv_LocalDrivingLicencesApps.DataSource = dt;
                    lb_totalApps.Text = dt.Rows.Count.ToString();
                }
                else _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 3)
            {
                if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                {
                    DataTable dt = clsApplication.GetAllLocalAppsByFullName(tb_SearchBox.Text);
                    dgv_LocalDrivingLicencesApps.DataSource = dt;
                    lb_totalApps.Text = dt.Rows.Count.ToString();
                }
                else _LoadData();
            }
        }

        private void dgv_LocalDrivingLicencesApps_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hello");

        }
        private void _ResetComboBox()
        {
            editAppToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            CancelAppToolStripMenuItem.Enabled = true;
            SechduleTeststoolStripMenuItem.Enabled = true;
            visionTesttoolStripMenuItem4.Enabled = true;
            sechduleWrittenTestToolStripMenuItem.Enabled = true;
            sechduleStreetTestToolStripMenuItem.Enabled = true;
            issueDrivingLicenceToolStripMenuItem.Enabled = true;
            showLicenceToolStripMenuItem.Enabled = true;
        }
        private void cms_HandleLocalApps_Opening(object sender, CancelEventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            int PassedTestsCount = clsTest.GetPassedTestCount(LDLAppID);
            _ResetComboBox();
            if (LDLApp.Application.ApplicationStatus == clsApplication.enStatus.New)
            {
                if (PassedTestsCount == 0)
                {
                    visionTesttoolStripMenuItem4.Enabled = true;
                    sechduleWrittenTestToolStripMenuItem.Enabled = false;
                    sechduleStreetTestToolStripMenuItem.Enabled = false;

                    issueDrivingLicenceToolStripMenuItem.Enabled = false;
                    showLicenceToolStripMenuItem.Enabled = false;
                }
                else if (PassedTestsCount == 1)
                {
                    editAppToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;

                    visionTesttoolStripMenuItem4.Enabled = false;
                    sechduleWrittenTestToolStripMenuItem.Enabled = true;
                    sechduleStreetTestToolStripMenuItem.Enabled = false;

                    issueDrivingLicenceToolStripMenuItem.Enabled = false;
                    showLicenceToolStripMenuItem.Enabled = false;
                }
                else if (PassedTestsCount == 2)
                {
                    editAppToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;

                    visionTesttoolStripMenuItem4.Enabled = false;
                    sechduleWrittenTestToolStripMenuItem.Enabled = false;
                    sechduleStreetTestToolStripMenuItem.Enabled = true;

                    issueDrivingLicenceToolStripMenuItem.Enabled = false;
                    showLicenceToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editAppToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    SechduleTeststoolStripMenuItem.Enabled = false;
                    CancelAppToolStripMenuItem.Enabled = false;

                    issueDrivingLicenceToolStripMenuItem.Enabled = true;
                    showLicenceToolStripMenuItem.Enabled = false;
                }
            }
            else if (LDLApp.Application.ApplicationStatus == clsApplication.enStatus.Completed)
            {
                editAppToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                CancelAppToolStripMenuItem.Enabled = false;
                SechduleTeststoolStripMenuItem.Enabled = false;
                issueDrivingLicenceToolStripMenuItem.Enabled = false;
                showLicenceToolStripMenuItem.Enabled = true;
            }
            else if (LDLApp.Application.ApplicationStatus == clsApplication.enStatus.Cancelled)
            {
                editAppToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                CancelAppToolStripMenuItem.Enabled = false;
                SechduleTeststoolStripMenuItem.Enabled = false;
                issueDrivingLicenceToolStripMenuItem.Enabled = false;
                showLicenceToolStripMenuItem.Enabled = false;
            }
        }

        private void CancelAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            if (localDrivingLicenseApp == null)
            {
                MessageBox.Show("This application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm cancellation
            if (MessageBox.Show($"Are you sure you want to cancel application with Id = {localDrivingLicenseApp.LocalDrivingLicenseApplicationID}!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            localDrivingLicenseApp.Application.ApplicationStatus = clsApplication.enStatus.Cancelled;
            if (localDrivingLicenseApp.Application.Save())
            {
                MessageBox.Show("The application was canceled successfully!", "Success", MessageBoxButtons.OK);
                _LoadData();
            }
            else
                MessageBox.Show("The application faild to cancel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cob_Statuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_IsAcive.SelectedIndex == 0)
            {
                _LoadData();
            }
            else
            {
                DataTable dt = clsApplication.GetAllLocalAppsByStatus(cob_IsAcive.SelectedItem.ToString());
                dgv_LocalDrivingLicencesApps.DataSource = dt;
                lb_totalApps.Text = dt.Rows.Count.ToString();
            }
        }

        private void _HandleTest(clsTestType.enTestTypes TestTypeID)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmTestAppointments form = new frmTestAppointments(LDLAppID, TestTypeID);
            form.ShowDialog();
            _LoadData();
        }

        private void visionTesttoolStripMenuItem4_Click(object sender, EventArgs e)
        {            
            _HandleTest(clsTestType.enTestTypes.VisionTest);
        }
        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleTest(clsTestType.enTestTypes.WrittenTest);
        }
        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleTest(clsTestType.enTestTypes.PracticalTest);
        }
        private void issueDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmIssueDrivingLicenceFirstTime form = new frmIssueDrivingLicenceFirstTime(LDLAppID);
            form.ShowDialog();
            _LoadData();
        }
        private void showLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmShowLicenceDetails showLicence = new frmShowLicenceDetails(clsLocalDrivingLicenseApplication.Find(LDLAppID).ApplicationID);
            showLicence.ShowDialog();
        }
        private void showPersonLicencesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localApplication = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            frmLicenceHistory licenceHistory = new frmLicenceHistory(clsDriver.FindByPersonID(localApplication.Application.ApplicantPersonID).DriverID);
            licenceHistory.ShowDialog();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            if (localDrivingLicenseApp != null)
            {
                clsApplication LocalApp = clsApplication.Find(localDrivingLicenseApp.ApplicationID);
                if (LocalApp != null)
                {
                    if (MessageBox.Show($"Are you sure you want to Delete the application with Id = {localDrivingLicenseApp.LocalDrivingLicenseApplicationID}!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (localDrivingLicenseApp.Delete())
                        {
                            if (LocalApp.Delete())
                            {
                                MessageBox.Show("The application was Deleted successfully!", "Success", MessageBoxButtons.OK);
                                _LoadData();
                            }
                            else
                                MessageBox.Show("The application faild to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("The application faild to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("This application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmShowLocalLicenceAppDetails form = new frmShowLocalLicenceAppDetails(LDLAppID);
            form.ShowDialog();
        }
        private void editAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgv_LocalDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmHandleLocalLicence UpdateAppointment = new frmHandleLocalLicence(LDLAppID);
            UpdateAppointment.ShowDialog();
            _LoadData();
        }
    }
}
