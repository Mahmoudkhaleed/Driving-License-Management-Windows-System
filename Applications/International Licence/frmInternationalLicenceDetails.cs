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
    public partial class frmInternationalLicenceDetails : Form
    {
        public frmInternationalLicenceDetails(int InternationalLicenceID)
        {
            InitializeComponent();
            cuc_InterLicenceDetails1.LoadDataByInternationalLicenceID(InternationalLicenceID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
