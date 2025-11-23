using BusinessLayer;
using DVLD_Project.Properties;
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
    public partial class frmSechduleTest : Form
    {
        private enum enMode { Add = 1, Update = 2 }
        private int _TestTypeID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsTestType _TestType;
        private enMode _Mode = enMode.Add;
        private clsTestAppointment _Appointment;
        private clsApplicationType _applicationType = null;

        public frmSechduleTest(int LocalLicenceAppID, clsTestType.enTestTypes TestTypeID, int AppointmentID = -1, int RetakeTestID = -1)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalLicenceAppID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _HandleFormAccordingToTestType(TestTypeID);
            // in case of faild in the previous exam
            if (RetakeTestID != -1)
            {
                _HandleRetakeTest(RetakeTestID);
            }
            // In case of we need to edit the appointment date
            if (AppointmentID != -1)
            {
                _HandleUpdatingAppointment(AppointmentID);
            }
            else
            {
                _HandleAddingNewAppointment();
            }
        }

        private void _HandleFormAccordingToTestType(clsTestType.enTestTypes TestTypeID)
        {
            string title = null;
            Image image = null;
            switch (TestTypeID)
            {
                case clsTestType.enTestTypes.VisionTest:
                    title = "Vision Test Appointment";
                    image = Resources.VisionTest;
                    break;
                case clsTestType.enTestTypes.WrittenTest:
                    title = "Written Test Appointment";
                    image = Resources.WrittenTest;
                    break;
                case clsTestType.enTestTypes.PracticalTest:
                    title = "Practical Test Appointment";
                    image = Resources.PracticalTest;
                    break;
                default:
                    break;
            }
            _TestType = clsTestType.Find((int)TestTypeID);
            _TestTypeID = (int)TestTypeID;
            this.Text = title;
            pb_Header.Image = image;
        }
        private void _HandleGeneral()
        {
            lb_DLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lb_LicenceClass.Text = _LocalDrivingLicenseApplication.LicenseClass.ClassName;
            lb_ApplicantName.Text = _LocalDrivingLicenseApplication.Application.ApplicantPerson.GetFullName();
            int Trails = clsTest.GetTestTrailsByTestAppID(_TestTypeID, _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            lb_trails.Text = Trails.ToString();
            lb_Fees.Text = _TestType.TestTypeFees.ToString();
        }
        private void _HandleAddingNewAppointment()
        {
            _Mode = enMode.Add;
            _HandleGeneral();
            dtp_Date.MinDate = DateTime.Now;
            lb_TotalFees.Text = ((_applicationType != null ? _applicationType.ApplicationFees : 0) + _TestType.TestTypeFees).ToString();
        }
        private void _HandleUpdatingAppointment(int AppointmentID)
        {
            _Mode = enMode.Update;
            btn_Save.Text = "        Update";
            this.Text = "Edit Test";
            lb_header.Text = "Edit Test Date";

            _HandleGeneral();
            _Appointment = clsTestAppointment.Find(AppointmentID);
            lb_TotalFees.Text = _Appointment.PaidFees.ToString();
            if (_Appointment.RetakeTestApplicationID != null)
            {
                lb_RTestAppID.Text = _Appointment.RetakeTestApplicationID.ToString();
                lb_RAppFees.Text = clsApplication.Find((int)_Appointment.RetakeTestApplicationID).PaidFees.ToString();
                gb_RetakeTestInfo.Enabled = true;
            }

            if (DateTime.Compare(DateTime.Now, _Appointment.AppointmentDate) < 0)
                dtp_Date.MinDate = DateTime.Now;
            else
                dtp_Date.MinDate = _Appointment.AppointmentDate;
            dtp_Date.Value = _Appointment.AppointmentDate;
            
            if (_Appointment.IsLocked)
            {
                dtp_Date.Enabled = false;
                btn_Save.Enabled = false;
            }
        }
        private void _HandleRetakeTest(int RetakeTestID)
        {
            gb_RetakeTestInfo.Enabled = true;
            _applicationType = clsApplicationType.Find(RetakeTestID);
            lb_RAppFees.Text = _applicationType?.ApplicationFees.ToString();
            lb_header.Text = "Sechdule Retake Test";
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _ProceedUpdatingNewTestAppointment();
            }
            else
            {
                _ProceedAddingNewTestAppointment();
            }
        }

        private void _ProceedUpdatingNewTestAppointment()
        {
            _Appointment.AppointmentDate = dtp_Date.Value;
            if (_Appointment.Save())
            {
                MessageBox.Show("Test was updated successfully!", "Success");
                dtp_Date.Enabled = false;
                btn_Save.Enabled = false;
            }
            else
                MessageBox.Show("Test Faild to update!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _ProceedAddingNewTestAppointment()
        {
            clsTestAppointment TestApp = new clsTestAppointment();
            TestApp.TestTypeID = _TestTypeID;
            TestApp.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            TestApp.AppointmentDate = dtp_Date.Value;
            TestApp.PaidFees = ((_applicationType != null ? _applicationType.ApplicationFees : 0) + _TestType.TestTypeFees);
            TestApp.CreatedByUserID = clsGeneralSettings.CurrentUser.UserID;
            TestApp.IsLocked = false;
            if (_applicationType != null)
            {
                clsApplication NewApplicationForRetakeTest = new clsApplication();
                NewApplicationForRetakeTest.ApplicationTypeID = (int)clsApplication.enApplicationTypes.RetakeTest;
                NewApplicationForRetakeTest.ApplicationDate = DateTime.Now;
                NewApplicationForRetakeTest.LastStatusDate = DateTime.Now;
                NewApplicationForRetakeTest.PaidFees = _applicationType.ApplicationFees;
                NewApplicationForRetakeTest.ApplicantPersonID = _LocalDrivingLicenseApplication.Application.ApplicantPersonID;
                NewApplicationForRetakeTest.ApplicationStatus = clsApplication.enStatus.Completed;
                NewApplicationForRetakeTest.CreatedByUserID = clsGeneralSettings.CurrentUser.UserID;
                if (NewApplicationForRetakeTest.Save())
                {
                    TestApp.RetakeTestApplicationID = NewApplicationForRetakeTest.ApplicationID;
                }
            }
            if (TestApp.Save())
            {
                MessageBox.Show("Test was setted successfully!", "Success");
                dtp_Date.Enabled = false;
                btn_Save.Enabled = false;
                if (_applicationType != null)
                    lb_RTestAppID.Text = TestApp.RetakeTestApplicationID?.ToString();
            }
            else
                MessageBox.Show("Test Faild to set!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
