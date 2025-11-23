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
    public partial class cuc_InterLicenceDetails : UserControl
    {
        public cuc_InterLicenceDetails()
        {
            InitializeComponent();
        }

        public void LoadDataByInternationalLicenceID(int InternationalLicenceID)
        {
            clsInternationalLicense internationalLicense = clsInternationalLicense.Find(InternationalLicenceID);
            // Fill Labels
            lb_ApplicantName.Text = internationalLicense.Application.ApplicantPerson.GetFullName();
            lb_InterLicenceID.Text = internationalLicense.InternationalLicenseID.ToString();
            lb_LicenceID.Text = internationalLicense.IssuedUsingLocalLicense.LicenseID.ToString();
            lb_NationalNo.Text = internationalLicense.Application.ApplicantPerson.NationalNo;
            lb_Gender.Text = (internationalLicense.Application.ApplicantPerson.Gender == 0 ? "Male" : "Female");
            lb_IssueDate.Text = internationalLicense.IssueDate.ToString("dd/MMM/yyyy");
            lb_IsActive.Text = (internationalLicense.IsActive ? "Yes" : "No");
            lb_DateofBirth.Text = internationalLicense.Application.ApplicantPerson.DateOfBirth.ToString("dd/MMM/yyyy");
            lb_DriverID.Text = internationalLicense.DriverID.ToString();
            lb_ExpirationDate.Text = internationalLicense.ExpirationDate.ToString("dd/MMM/yyyy");
            pb_Image.ImageLocation = internationalLicense.Application.ApplicantPerson.ImagePath;
        }

        private void lb_ApplicantName_Click(object sender, EventArgs e)
        {

        }
    }
}
