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
    public partial class frmTestAppointments : Form
    {
        private int _LocalLicenceAppID;
        private string _Title;
        private Image _Image;
        private clsTestType.enTestTypes _TestTypeID;
        public frmTestAppointments(int LocalLicenceAppID, clsTestType.enTestTypes TestTypeID)
        {
            InitializeComponent();
            _LocalLicenceAppID = LocalLicenceAppID;
            _TestTypeID = TestTypeID;
            _FillFormAccordingToTestType();
        }

        private void _FillFormAccordingToTestType()
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestTypes.VisionTest:
                    _Title = "Vision Test Appointment";
                    _Image = Resources.VisionTest;
                    break;
                case clsTestType.enTestTypes.WrittenTest:
                    _Title = "Written Test Appointment";
                    _Image = Resources.WrittenTest;
                    break;
                case clsTestType.enTestTypes.PracticalTest:
                    _Title = "Practical Test Appointment";
                    _Image = Resources.PracticalTest;
                    break;
                default:
                    break;
            }
            pb_HeaderImage.Image = _Image;
            lb_header.Text = _Title;
            this.Text = _Title;
            cuc_ApplicationInfo1.LoadDataByLocalDrivingLicenceAppID(_LocalLicenceAppID);
            _FillTestAppointmentTable();
            if (_TestTypeID != clsTestType.enTestTypes.PracticalTest)
            {
                bool IsTestPassed = clsTest.IsTestPassed((int)_TestTypeID, _LocalLicenceAppID);
                btn_NextTest.Enabled = IsTestPassed;
                btn_NextTest.Visible = IsTestPassed;
            }
        }

        private void _FillTestAppointmentTable()
        {
            DataTable dt = clsTestAppointment.GetAllTestAppointmentsBy((int)_TestTypeID, _LocalLicenceAppID);
            dgv_TestsAppointments.DataSource = dt;          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            if (!clsTest.IsTestPassed((int)_TestTypeID, _LocalLicenceAppID)) // 
            {
                // in Case of faild in test to Retake test
                if (clsTest.GetTestTrailsByTestAppID((int)_TestTypeID, _LocalLicenceAppID) > 0 && 
                    !clsTestAppointment.IsThereAnyActiveAppointment((int)_TestTypeID, _LocalLicenceAppID))
                {
                    frmSechduleTest TestForm = new frmSechduleTest(_LocalLicenceAppID, _TestTypeID, -1, (int)clsApplication.enApplicationTypes.RetakeTest);
                    TestForm.ShowDialog();
                    _FillTestAppointmentTable();
                    return;
                }

                // in case of new appointment
                if (!clsTestAppointment.IsThereAnyActiveAppointment((int)_TestTypeID, _LocalLicenceAppID))
                {
                    frmSechduleTest TestForm = new frmSechduleTest(_LocalLicenceAppID, _TestTypeID);
                    TestForm.ShowDialog();
                    _FillTestAppointmentTable();
                }
                else
                {
                    MessageBox.Show($"There is an active {_Title} already!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("This person is already passed this exam!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgv_TestsAppointments.CurrentRow.Cells[0].Value;
            frmSechduleTest visionTestForm = new frmSechduleTest(_LocalLicenceAppID, _TestTypeID, AppointmentID);
            visionTestForm.ShowDialog();
            _FillTestAppointmentTable();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgv_TestsAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest takeTest = new frmTakeTest(_LocalLicenceAppID, AppointmentID, (int)_TestTypeID);
            takeTest.ShowDialog();
            _FillTestAppointmentTable();
            cuc_ApplicationInfo1.LoadDataByLocalDrivingLicenceAppID(_LocalLicenceAppID);
            if (_TestTypeID != clsTestType.enTestTypes.PracticalTest)
            {
                bool IsTestPassed = clsTest.IsTestPassed((int)_TestTypeID, _LocalLicenceAppID);
                btn_NextTest.Enabled = IsTestPassed;
                btn_NextTest.Visible = IsTestPassed;
            }
        }

        private void cmc_HandleVisionAppointment_Opening(object sender, CancelEventArgs e)
        {
            takeTestToolStripMenuItem.Enabled = true;
            if ((bool)dgv_TestsAppointments.CurrentRow.Cells["Is Locked"].Value)
            {
                takeTestToolStripMenuItem.Enabled = false;
            }
        }

        private void btn_NextTest_Click(object sender, EventArgs e)
        {
            int NextTestTypeID = (int)_TestTypeID + 1;
            frmTestAppointments NextTestAppointment = new frmTestAppointments(_LocalLicenceAppID, (clsTestType.enTestTypes)NextTestTypeID);
            NextTestAppointment.ShowDialog();
            this.Close();
        }
    }
}
