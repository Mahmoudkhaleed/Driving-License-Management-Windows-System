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

namespace DVLD_Project.User_Controls
{
    public partial class cuc_LicenceDetails : UserControl
    {
        public cuc_LicenceDetails()
        {
            InitializeComponent();
        }
        public void LoadDataByLicenseID(int LicenseID)
        {
            clsLicense license = clsLicense.Find(LicenseID);
            if (license == null)
                return;
            // Fill Labels
            lb_LicenceClass.Text = license.LicenseClassInfo.ClassName;
            lb_ApplicantName.Text = license.Application.ApplicantPerson.GetFullName();
            lb_LicenceID.Text = license.LicenseID.ToString();
            lb_NationalNo.Text = license.Application.ApplicantPerson.NationalNo;
            lb_Gender.Text = (license.Application.ApplicantPerson.Gender == 0 ? "Male" : "Female");
            lb_IssueDate.Text = clsGeneralSettings.DateFormate(license.IssueDate);
            lb_IssueReason.Text = license.Application.ApplicationType.ApplicationTypeTitle;
            lb_Notes.Text = (license.Notes != "" ? license.Notes : "Not notes");
            lb_IsActive.Text = (license.IsActive ? "Yes" : "No");
            lb_DateofBirth.Text = clsGeneralSettings.DateFormate(license.Application.ApplicantPerson.DateOfBirth);
            lb_DriverID.Text = license.DriverID.ToString();
            lb_ExpirationDate.Text = clsGeneralSettings.DateFormate(license.ExpirationDate);
            lb_IsDetained.Text = (license.IsDetained() ? "Yes" : "No");
            pb_Image.ImageLocation = license.Application.ApplicantPerson.ImagePath;
        }


        private void pb_Image_Click(object sender, EventArgs e)
        {

        }

        private void lb_LicenceClass_Click(object sender, EventArgs e)
        {

        }
    }
}
