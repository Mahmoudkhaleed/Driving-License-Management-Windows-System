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
    public partial class frmShowLocalLicenceAppDetails : Form
    {
        public frmShowLocalLicenceAppDetails(int LocalLicenceAppID)
        {

            InitializeComponent();
            cuc_ApplicationInfo1.LoadDataByLocalDrivingLicenceAppID(LocalLicenceAppID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
