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

namespace DVLD_Project.Applications
{
    public partial class frmReplacementForDamagedOrLost : Form
    {
        private clsLicense _OldLicense;
        private clsApplicationType _ApplicationType;
        public frmReplacementForDamagedOrLost()
        {
            InitializeComponent();
            cob_ReplacementReason.SelectedIndex = 0;
            _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.ReplacementforDamagedDrivingLicense);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_SearchBox.Text, out int LicenceID))
            {
                _OldLicense = clsLicense.Find(LicenceID);
                if (_OldLicense != null)
                {
                    cuc_LicenceDetails1.LoadDataByLicenseID(_OldLicense.LicenseID);
                    if (clsDetainedLicense.FindByLicenseID(LicenceID) == null)
                    {
                        if (_OldLicense.IsActive)
                        {
                            _HandleFillLabels(LicenceID);
                        }
                        else
                            MessageBox.Show("This driving licence is inactive!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("This driving licence is detained!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("This driving licence is not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _HandleFillLabels(int LicenceID)
        {
            lb_LocalLicenceID.Text = LicenceID.ToString();
            lb_AppFees.Text = _ApplicationType.ApplicationFees.ToString();
            lb_CreatedBy.Text = clsGeneralSettings.CurrentUser.UserName;
            lb_AppDate.Text = DateTime.Now.ToString();
            lb_IssueDate.Text = DateTime.Now.ToString();
            lb_ExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            btn_Save.Enabled = true;
            lb_ShowLicenceHistory.Enabled = true;
        }

        private void lb_ShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenceHistory historyForm = new frmLicenceHistory(_OldLicense.DriverID);
            historyForm.ShowDialog();
        }

        private void lb_ShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenceDetails details = new frmShowLicenceDetails(_OldLicense.LicenseID);
            details.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int NewApplicationID = -1, NewLicenseID = -1;
            if (_OldLicense.IssueLicenseFor((clsApplication.enApplicationTypes)_ApplicationType.ApplicationTypeID,
                tb_Notes.Text, clsGeneralSettings.CurrentUser.UserID, ref NewApplicationID, ref NewLicenseID))
            {
                lb_RAppID.Text = NewApplicationID.ToString();
                lb_RLLicenceID.Text = NewLicenseID.ToString();
                MessageBox.Show("New Licence was renewed successfully!", "Success");
                btn_Save.Enabled = false;
                gb_Filter.Enabled = false;
                tb_Notes.Enabled = false;
                cob_ReplacementReason.Enabled = false;
                lb_ShowLicenceInfo.Enabled = true;
            }
            else MessageBox.Show("Licence Faild to renew!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cob_ReplacementReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_ReplacementReason.SelectedIndex == 0)
            {
                _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.ReplacementforDamagedDrivingLicense);
            }
            else
            {
                _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.ReplacementforLostDrivingLicense);
            }
            lb_AppFees.Text = _ApplicationType.ApplicationFees.ToString();
        }
    }
}
