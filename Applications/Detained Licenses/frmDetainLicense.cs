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
    public partial class frmDetainLicense : Form
    {
        private clsLicense _LicenseToDetain;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tb_FineFees.Text, out float Value))
            {      
                if (_LicenseToDetain.Detain(Value, clsGeneralSettings.CurrentUser.UserID))
                {
                    MessageBox.Show("License is now detained!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Save.Enabled = false;
                    gb_Filter.Enabled = false;
                }
                else
                    MessageBox.Show("License faild to be detained!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("The fees value show be valid!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_ShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenceDetails showLicence = new frmShowLicenceDetails(_LicenseToDetain.LicenseID);
            showLicence.ShowDialog();
        }

        private void lb_ShowLicenceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenceHistory form = new frmLicenceHistory(_LicenseToDetain.Application.ApplicationID);
            form.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            lb_ShowLicenceHistory.Enabled = false;
            if (int.TryParse(tb_SearchBox.Text, out int LicenceID))
            {
                _LicenseToDetain = clsLicense.Find(LicenceID);
                if (_LicenseToDetain != null)
                {
                    cuc_LicenceDetails1.LoadDataByLicenseID(_LicenseToDetain.LicenseID);
                    if (!_LicenseToDetain.IsDetained())
                    {
                        _HandleFillLabels(LicenceID);
                    }
                    else MessageBox.Show("This driving licence is detained!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("This driving licence is not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _HandleFillLabels(int LicenceID)
        {
            lb_LicenceID.Text = LicenceID.ToString();
            lb_CreatedBy.Text = clsGeneralSettings.CurrentUser.UserName;
            lb_DetainDate.Text = DateTime.Now.ToString();
            btn_Save.Enabled = true;
            lb_ShowLicenceHistory.Enabled = true;
            lb_ShowLicenceInfo.Enabled = true;
        }
    }
}
