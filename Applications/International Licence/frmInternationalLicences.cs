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
    public partial class frmInternationalLicences : Form
    {
        public frmInternationalLicences()
        {
            InitializeComponent();
            _LoadData();
            cob_Filter.SelectedIndex = 0;
        }

        private void _LoadData()
        {
            DataTable data = clsInternationalLicense.GetAllInternationalLicenses();
            dgv_InternDrivingLicencesApps.DataSource = data;
            lb_totalApps.Text = data.Rows.Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddInternLicenceApp_Click(object sender, EventArgs e)
        {
            frmHandleInternationalLicence form = new frmHandleInternationalLicence();
            form.ShowDialog();
        }

        private void EditAppTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver.Find((int)dgv_InternDrivingLicencesApps.CurrentRow.Cells[2].Value).PersonID;
            frmPersonDetails personDetails = new frmPersonDetails(PersonID);
            personDetails.ShowDialog();
        }

        private void showLicenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InterLicenseID = (int)dgv_InternDrivingLicencesApps.CurrentRow.Cells[0].Value;
            frmInternationalLicenceDetails form = new frmInternationalLicenceDetails(InterLicenseID);
            form.ShowDialog();
        }

        private void showPersonLicenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.Find((int)dgv_InternDrivingLicencesApps.CurrentRow.Cells[3].Value);
            if (license != null)
            {
                frmLicenceHistory form = new frmLicenceHistory(license.ApplicationID);
                form.ShowDialog();
            }
        }

        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                cob_IsActive.Visible = false;
                _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 5)
            {
                tb_SearchBox.Visible = false;
                cob_IsActive.Visible = true;
                cob_IsActive.Location = new Point(224, 198);
                cob_IsActive.SelectedIndex = 0;
            }
            else
            {
                tb_SearchBox.Visible = true;
                cob_IsActive.Visible = false;
                tb_SearchBox.Text = "";
                tb_SearchBox.Select();
                _LoadData();
            }
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_SearchBox.Text))
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    if (cob_Filter.SelectedIndex == 1)
                    {
                        DataTable data = clsInternationalLicense.GetAllInternationalLicensesByInternationalLicenseID(value);
                        dgv_InternDrivingLicencesApps.DataSource = data;
                        lb_totalApps.Text = data.Rows.Count.ToString();
                    }
                    else if (cob_Filter.SelectedIndex == 2)
                    {
                        DataTable data = clsInternationalLicense.GetAllInternationalLicensesByApplicationID(value);
                        dgv_InternDrivingLicencesApps.DataSource = data;
                        lb_totalApps.Text = data.Rows.Count.ToString();
                    }
                    else if (cob_Filter.SelectedIndex == 3)
                    {
                        DataTable data = clsInternationalLicense.GetAllInternationalLicensesByDriverID(value);
                        dgv_InternDrivingLicencesApps.DataSource = data;
                        lb_totalApps.Text = data.Rows.Count.ToString();
                    }
                    else if (cob_Filter.SelectedIndex == 4)
                    {
                        DataTable data = clsInternationalLicense.GetAllInternationalLicensesByIssuedUsingLocalLicenseID(value);
                        dgv_InternDrivingLicencesApps.DataSource = data;
                        lb_totalApps.Text = data.Rows.Count.ToString();
                    }
                }
                else
                {
                    tb_SearchBox.Text = string.Empty;
                }
            }
            else
            {
                _LoadData();
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
                DataTable data = clsInternationalLicense.GetAllInternationalLicensesByIsActive(true);
                dgv_InternDrivingLicencesApps.DataSource = data;
                lb_totalApps.Text = data.Rows.Count.ToString();
            }
            else
            {
                DataTable data = clsInternationalLicense.GetAllInternationalLicensesByIsActive(false);
                dgv_InternDrivingLicencesApps.DataSource = data;
                lb_totalApps.Text = data.Rows.Count.ToString();
            }
        }
    }
}
