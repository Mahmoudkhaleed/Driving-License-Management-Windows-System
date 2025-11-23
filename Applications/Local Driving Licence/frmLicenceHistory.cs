using BusinessLayer;
using DVLD_Project.International_Licence;
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
    public partial class frmLicenceHistory : Form
    {
        private clsDriver _Driver;
        public frmLicenceHistory(int DriverID)
        {
            InitializeComponent();
            _Driver = clsDriver.Find(DriverID);
            if (_Driver == null )
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _LoadData();
        }

        private void _LoadData()
        {
            cuc_PersonCard2.LoadPersonInCard(_Driver.PersonID);
            _FillGridViewWithLocalLicences(_Driver.DriverID);
            _FillGridViewWithInternationalLicences(_Driver.DriverID);
        }

        private void _FillGridViewWithLocalLicences(int DriverID)
        {
            DataTable data = clsLicense.GetLicensesByDriverID(DriverID);
            dgv_LocalLicences.DataSource = data;
            lb_LocalRecords.Text = data.Rows.Count.ToString();
        }

        private void _FillGridViewWithInternationalLicences(int DriverID)
        {
            DataTable data = clsInternationalLicense.GetAllInternationalLicensesByDriverID(DriverID);
            dgv_InternationalLicences.DataSource = data;
            lb_InterRecord.Text = data.Rows.Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgv_LocalLicences.CurrentRow.Cells[0].Value;
            frmShowLicenceDetails form = new frmShowLicenceDetails(LicenseID);
            form.ShowDialog();
        }

        private void InternLicencrDetailsStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternLicenseID = (int)dgv_InternationalLicences.CurrentRow.Cells[0].Value;
            frmInternationalLicenceDetails form = new frmInternationalLicenceDetails(InternLicenseID);
            form.ShowDialog();
        }
    }
}
