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
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
            cob_Filter.SelectedIndex = 0;
            _LoadData();
        }
        
        private void _LoadData()
        {
            DataTable data = clsDetainedLicense.GetAllDetainedLicenses();
            dgv_ManageDetained.DataSource = data;
            lb_total.Text = data.Rows.Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Release_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense form = new frmReleaseDetainedLicense();
            form.ShowDialog();
        }

        private void btn_Detain_Click(object sender, EventArgs e)
        {
            frmDetainLicense form = new frmDetainLicense();
            form.ShowDialog();
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = (int)dgv_ManageDetained.CurrentRow.Cells[1].Value;
            clsLicense license = clsLicense.Find(LicenseId);
            if (license != null)
            {
                clsApplication application = clsApplication.Find(license.ApplicationID);
                if (application != null)
                {
                    frmPersonDetails personDetails = new frmPersonDetails(application.ApplicantPersonID);
                    personDetails.ShowDialog();
                }
            }
        }
        private void showPersonLicenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = (int)dgv_ManageDetained.CurrentRow.Cells[1].Value;
            clsLicense license = clsLicense.Find(LicenseId);
            if (license != null)
            {
                frmLicenceHistory form = new frmLicenceHistory(license.ApplicationID);
                form.ShowDialog();
            }
        }

        private void showLicenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = (int)dgv_ManageDetained.CurrentRow.Cells[1].Value;
            clsLicense license = clsLicense.Find(LicenseId);
            if (license != null)
            {
                frmShowLicenceDetails form = new frmShowLicenceDetails(license.ApplicationID);
                form.ShowDialog();
            }
        }


        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = (int)dgv_ManageDetained.CurrentRow.Cells[1].Value;
            frmReleaseDetainedLicense form = new frmReleaseDetainedLicense(LicenseId);
            form.ShowDialog();
            _LoadData();
        }

        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                cob_IsReleased.Visible = false;
            }
            else if (cob_Filter.SelectedIndex == 4)
            {
                cob_IsReleased.Location = new Point(224, 203);
                cob_IsReleased.SelectedIndex = 0;
                cob_IsReleased.Visible = true;
                tb_SearchBox.Visible = false;
            }
            else
            {
                tb_SearchBox.Visible = true;
                cob_IsReleased.Visible = false;
                tb_SearchBox.Text = string.Empty;
                tb_SearchBox.Select();
            }
            _LoadData();
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_SearchBox.Text))
            {
                _LoadData();
            }
            if (cob_Filter.SelectedIndex == 1)
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    DataTable data = clsDetainedLicense.GetAllDetainedLicensesByDetainID(value);
                    dgv_ManageDetained.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                    tb_SearchBox.Text = string.Empty;
            }
            else if (cob_Filter.SelectedIndex == 2)
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    DataTable data = clsDetainedLicense.GetAllDetainedLicensesByLicenseID(value);
                    dgv_ManageDetained.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                    tb_SearchBox.Text = string.Empty;
            }
            else if (cob_Filter.SelectedIndex == 3)
            {
                if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                {
                    DataTable data = clsDetainedLicense.GetAllDetainedLicensesByNationalNo(tb_SearchBox.Text);
                    dgv_ManageDetained.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                    _LoadData();
            }
        }

        private void cob_IsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_IsReleased.SelectedIndex == 0)
            {
                _LoadData();
            }
            else if (cob_IsReleased.SelectedIndex == 1)
            {
                DataTable data = clsDetainedLicense.GetAllDetainedLicensesByIsReleased(true);
                dgv_ManageDetained.DataSource = data;
                lb_total.Text = data.Rows.Count.ToString();
            }
            else if (cob_IsReleased.SelectedIndex == 2)
            {
                DataTable data = clsDetainedLicense.GetAllDetainedLicensesByIsReleased(false);
                dgv_ManageDetained.DataSource = data;
                lb_total.Text = data.Rows.Count.ToString();
            }
        }

        private void dgv_ManageDetained_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            string columnName = dgv_ManageDetained.Columns[e.ColumnIndex].Name;
            if ((columnName == "Release Date" || columnName == "Release Application ID") &&
                (e.Value is DBNull || e.Value == null))
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }
    }
}
