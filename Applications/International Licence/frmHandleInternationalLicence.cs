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

namespace DVLD_Project.International_Licence
{
    public partial class frmHandleInternationalLicence : Form
    {
        private clsLicense _License;
        private clsApplicationType _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationTypes.NewInternationalLicense);
        private int _InternationalLicenceID;
        public frmHandleInternationalLicence()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            lb_ShowLicenceHistory.Enabled = false;
            if (int.TryParse(tb_SearchBox.Text, out int LicenceID))
            {
                _License = clsLicense.Find(LicenceID);
                if (_License == null)
                {
                    MessageBox.Show("This driving licence is not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cuc_LicenceDetails1.LoadDataByLicenseID(_License.LicenseID);
                if (_License.IsDetained())
                {
                    MessageBox.Show("This driving licence is detained!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!_License.IsActive)
                {
                    MessageBox.Show("This driving licence is inactive!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_License.IsExpired)
                {
                    MessageBox.Show("This driving licence is Expire!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_License.HasInternationalLicense())
                {
                    MessageBox.Show("This driver does already have an international licence of this licence class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _HandleFillLabels(LicenceID);
            }
        }

        private void _HandleFillLabels(int LicenceID)
        {
            lb_LocalLicenceID.Text = LicenceID.ToString();
            lb_Fees.Text = _ApplicationType.ApplicationFees.ToString();
            lb_CreatedBy.Text = clsGeneralSettings.CurrentUser.UserName;
            lb_AppDate.Text = DateTime.Now.ToString();
            lb_IssueDate.Text = DateTime.Now.ToString();
            lb_ExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            btn_Save.Enabled = true;
            lb_ShowLicenceHistory.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int ApplicationID = -1, InternationalLicenseID = -1;
            if (_License.IssueInternationalLicense(clsGeneralSettings.CurrentUser.UserID, ref ApplicationID, ref InternationalLicenseID))
            {
                lb_AppID.Text = ApplicationID.ToString();
                _InternationalLicenceID = InternationalLicenseID;
                lb_InternationalLicenceID.Text = InternationalLicenseID.ToString();
                btn_Save.Enabled = false;
                gb_Filter.Enabled = false;
                lb_ShowLicenceInfo.Enabled = true;
                MessageBox.Show("The International Licence Was Issued Successfully!", "Success", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("The International Licence Was Faild to issue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lb_ShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenceHistory historyForm = new frmLicenceHistory(_License.DriverID);
            historyForm.ShowDialog();
        }

        private void lb_ShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenceDetails internationalLicence = new frmInternationalLicenceDetails(_InternationalLicenceID);
            internationalLicence.ShowDialog();
        }
    }
}
