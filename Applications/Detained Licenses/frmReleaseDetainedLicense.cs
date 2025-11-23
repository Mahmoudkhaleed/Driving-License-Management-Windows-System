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

namespace DVLD_Project.Detained_Licenses
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsLicense _DetainedLicense;
        private clsApplicationType _ApplicationType;
        private clsDetainedLicense _Detain;
        private float _TotalFees;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.ReleaseDetainedDrivingLicsense);
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.ReleaseDetainedDrivingLicsense);
            _HandleEditMode(LicenseID);
        }
        private void _HandleEditMode(int LicenseID)
        {
            _HandleGettingLicenseInfo(LicenseID);
            tb_SearchBox.Text = LicenseID.ToString();
            gb_Filter.Enabled = false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            lb_ShowLicenceHistory.Enabled = false;
            if (int.TryParse(tb_SearchBox.Text, out int LicenceID))
            {
                _HandleGettingLicenseInfo(LicenceID);
            }
            else MessageBox.Show("You should type a valid driving licence id in the search box!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void _HandleGettingLicenseInfo(int LicenceID)
        {       
            _DetainedLicense = clsLicense.Find(LicenceID);
            if (_DetainedLicense != null)
            {
                cuc_LicenceDetails1.LoadDataByLicenseID(_DetainedLicense.LicenseID);
                _HandleFillingDetainInfo(LicenceID);
            }
            else MessageBox.Show("This driving licence is not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void _HandleFillingDetainInfo(int LicenceID)
        {
            _Detain = clsDetainedLicense.FindByLicenseID(LicenceID);
            if (_Detain != null)
            {
                _TotalFees = _Detain.FineFees + _ApplicationType.ApplicationFees;
                lb_DetainID.Text = _Detain.DetainID.ToString();
                lb_DetainDate.Text = clsGeneralSettings.DateFormate(_Detain.DetainDate);
                lb_ReleaseDate.Text = clsGeneralSettings.DateFormate(_Detain.DetainDate);
                lb_FineFees.Text = _Detain.FineFees.ToString();
                lb_LicenceID.Text = _Detain.LicenseID.ToString();
                lb_CreatedBy.Text = clsUser.Find(_Detain.CreatedByUserID).UserName;
                lb_ReleasedBy.Text = clsGeneralSettings.CurrentUser.UserName;
                lb_AppFees.Text = _ApplicationType.ApplicationFees.ToString();
                lb_TotalFees.Text = _TotalFees.ToString();
                lb_ShowLicenceHistory.Enabled = true;
                lb_ShowLicenceInfo.Enabled = true;
                btn_Save.Enabled = true;
            }
            else MessageBox.Show("This driving licence is not detained!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int NewApplicationID;
            bool IsReleased = (NewApplicationID = _DetainedLicense.Release(_Detain.DetainID, clsGeneralSettings.CurrentUser.UserID)) != -1;
            if (IsReleased)
            {
                MessageBox.Show("Driving licence is released successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lb_AppID.Text = NewApplicationID.ToString();
                btn_Save.Enabled = false;
                gb_Filter.Enabled = false;
            }
            else
                MessageBox.Show("Driving licence faild to be released!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_ShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = _DetainedLicense.Application.ApplicationID;
            frmLicenceHistory form = new frmLicenceHistory(ApplicationID);
            form.ShowDialog();
        }

        private void lb_ShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenceDetails form = new frmShowLicenceDetails(_DetainedLicense.LicenseID);
            form.ShowDialog();
        }
    }
}
