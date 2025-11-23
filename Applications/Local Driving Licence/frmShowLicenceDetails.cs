using BusinessLayer;
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
    public partial class frmShowLicenceDetails : Form
    {
        public frmShowLicenceDetails(int LicenseID)
        {
            InitializeComponent();
            cuc_LicenceDetails1.LoadDataByLicenseID(LicenseID);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
