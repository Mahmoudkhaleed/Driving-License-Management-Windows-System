using BusinessLayer;
using DVLD_Project.Local_Driving_Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User_Controls
{
    public partial class cuc_ApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApp;
        public cuc_ApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadDataByLocalDrivingLicenceAppID(int LocalDrivingLicenseApplicationID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            if ( _LDLApp != null )
            {
                _FillCardWithData();
            }
        }
        private void _FillCardWithData()
        {
            lb_DLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lb_LicenceClass.Text = _LDLApp.LicenseClass.ClassName;
            lb_AppID.Text = _LDLApp.Application.ApplicationID.ToString();
            lb_Status.Text = (_LDLApp.Application.ApplicationStatus == clsApplication.enStatus.New ? "New" : 
                _LDLApp.Application.ApplicationStatus == clsApplication.enStatus.Cancelled ? "Cancelled" : "Completed");
            lb_Fees.Text = _LDLApp.Application.PaidFees.ToString();
            int passedTestsCount = clsTest.GetPassedTestCount(_LDLApp.LocalDrivingLicenseApplicationID);
            lb_PassedTests.Text = passedTestsCount.ToString() + "/3";
            lb_CreatedBy.Text = _LDLApp.Application.CreatedByUser.UserName;
            lb_ApplicantName.Text = _LDLApp.Application.ApplicantPerson.GetFullName();
            lb_Type.Text = _LDLApp.Application.ApplicationType.ApplicationTypeTitle;
            lb_Date.Text = clsGeneralSettings.DateFormate(_LDLApp.Application.ApplicationDate);
            lb_StatusDate.Text = clsGeneralSettings.DateFormate(_LDLApp.Application.LastStatusDate);
        }

        public void MakeShowLicenseEnabled()
        {
            link_ShowLicense.Enabled = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(_LDLApp.Application.ApplicantPersonID);
            personDetails.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenceDetails showLicenceDetails = new frmShowLicenceDetails(_LDLApp.Application.ApplicationID);
            showLicenceDetails.ShowDialog();
        }
    }
}
