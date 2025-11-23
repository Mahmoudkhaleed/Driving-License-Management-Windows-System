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
using System.Xml.Linq;

namespace DVLD_Project.Local_Driving_Licence
{
    public partial class frmTakeTest : Form
    {
        private int _LocalLicenceAppID;
        private int _TestAppointmentID;
        private int _TestTypeID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsTestAppointment _TestAppointment;
        public frmTakeTest(int LocalLicenceAppID, int AppointmentID, int TestTypeID)
        {
            _LocalLicenceAppID = LocalLicenceAppID;
            _TestAppointmentID = AppointmentID;
            _TestTypeID = TestTypeID;

            _TestAppointment = clsTestAppointment.Find(AppointmentID);
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalLicenceAppID);
            InitializeComponent();      
            _FillWithData();
        }

        private void _FillWithData()
        {
            lb_DLAppID.Text = _LocalLicenceAppID.ToString();
            lb_LicenceClass.Text = _LocalDrivingLicenseApplication.LicenseClass.ClassName;
            lb_Fees.Text = _TestAppointment.PaidFees.ToString();
            lb_Date.Text = clsGeneralSettings.DateFormate(_TestAppointment.AppointmentDate);
            lb_ApplicantName.Text = _LocalDrivingLicenseApplication.Application.ApplicantPerson.GetFullName();
            int Trails = clsTest.GetTestTrailsByTestAppID(_TestTypeID, _LocalLicenceAppID);
            lb_trails.Text = Trails.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsTest Test = new clsTest();
            Test.TestResult = rb_Passed.Checked;
            Test.Notes = tb_Notes.Text;
            Test.TestAppointmentID = _TestAppointmentID;
            Test.CreatedByUserID = clsGeneralSettings.CurrentUser.UserID;
            if (Test.Save())
            {
                _TestAppointment.IsLocked = true;
                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Done successfully!");
                    lb_TestID.Text = Test.TestID.ToString();
                    btn_Save.Enabled = false;
                    tb_Notes.Enabled = false;
                    rb_Faild.Enabled = false;
                    rb_Passed.Enabled = false;
                }
            }
            else
                MessageBox.Show("faild!");
        }
    }
}
