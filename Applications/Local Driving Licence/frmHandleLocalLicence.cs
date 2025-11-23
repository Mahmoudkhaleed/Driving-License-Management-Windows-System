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

namespace DVLD_Project
{
    public partial class frmHandleLocalLicence : Form
    {
        private float _LicenceFees = clsApplicationType.Find((int)clsApplication.enApplicationTypes.NewLocalDrivingLicenseService).ApplicationFees;
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private int _PersonID = -1;

        public frmHandleLocalLicence()
        {
            InitializeComponent();
            _LoadLicencesClasses();
            cob_LicenceClasses.SelectedIndex = 2;
            _HandleAddingLicenceAppointment();
            _Mode = enMode.AddNew;

        }
        public frmHandleLocalLicence(int LocalDrivingLicenceAppID)
        {
            InitializeComponent();
            _LoadLicencesClasses();
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenceAppID);
            if (_LDLApp != null)
            {
                _HandleUpdateLicenceAppointment();
            }
        }

        private void _HandleUpdateLicenceAppointment()
        {
            _Mode = enMode.Update;
            this.Text = "Update Licence Appointment";
            lb_Head.Text = "Update Local Driving Licence Appointment";
            btn_Save.Text = "       Update";
            cuc_SearchForPerson1.FillPerosnCard(_LDLApp.Application.ApplicantPersonID);
            cuc_SearchForPerson1.MakeFilterBoxDisabled();

            lb_LocalAppLicenceID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lb_AppDate.Text = clsGeneralSettings.DateFormate(DateTime.Now);
            cob_LicenceClasses.SelectedItem = clsLicenseClass.Find(_LDLApp.LicenseClassID).ClassName;
            lb_AppFees.Text = _LicenceFees.ToString();
            lb_CreatedBy.Text = clsUser.Find(_LDLApp.Application.CreatedByUserID).UserName;
        }
        private void _HandleAddingLicenceAppointment()
        {
            this.Text = "Adding Licence Appointment";
            lb_Head.Text = "Adding New Local Driving Licence Appointment";
            lb_AppDate.Text = clsGeneralSettings.DateFormate(DateTime.Now);
            lb_CreatedBy.Text = clsGeneralSettings.CurrentUser.UserName;
            lb_AppFees.Text = _LicenceFees.ToString();
            cuc_SearchForPerson1.SearchBoxFocus();
        }
        private void _LoadLicencesClasses()
        {
            DataTable data = clsLicenseClass.GetAllLicenseClasses();
            foreach (DataRow row in data.Rows)
            {
                cob_LicenceClasses.Items.Add(row["ClassName"].ToString());
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cuc_SearchForPerson1.Person == null)
            {
                MessageBox.Show($"You should set a person first!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectTab(0);
                return;
            }
            clsLicenseClass LicenceClass = clsLicenseClass.FindByName(cob_LicenceClasses.SelectedItem.ToString());
            int LicenseClassID = LicenceClass.LicenseClassID;
            // to check Age validity
            int PersonAge = DateTime.Now.Year - cuc_SearchForPerson1.Person.DateOfBirth.Year;
            if (PersonAge < LicenceClass.MinimumAllowedAge)
            {
                MessageBox.Show($"The minimum allowed age for this class is {LicenceClass.MinimumAllowedAge}!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (_Mode)
            {
                case enMode.AddNew:
                    _AddingNewLocalDrivingLicenceAppointment(LicenseClassID);
                    break;
                case enMode.Update:
                    _UpdateNewLocalDrivingLicenceAppointment(LicenseClassID);
                    break;
                default:
                    break;
            }
        }
        private void _AddingNewLocalDrivingLicenceAppointment(int LicenseClassID)
        {
            // to check if this licence is already set
            if (clsApplication.IsPersonApplyForLicenseClass(cuc_SearchForPerson1.Person.PersonID, LicenseClassID))
            {
                MessageBox.Show("this Application is already placed once!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create Local Application based on The new Application above
            clsLocalDrivingLicenseApplication LocalLicence = new clsLocalDrivingLicenseApplication(cuc_SearchForPerson1.Person.PersonID,
                                                                                                    clsGeneralSettings.CurrentUser.UserID, 
                                                                                                    clsApplication.enApplicationTypes.NewLocalDrivingLicenseService, 
                                                                                                    LicenseClassID);
            if (LocalLicence.Save())
            {
                lb_LocalAppLicenceID.Text = LocalLicence.ApplicationID.ToString();
                _MakeInputsDisable();
                MessageBox.Show("Application was placed successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Application faild to place!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _UpdateNewLocalDrivingLicenceAppointment(int LicenseClassID)
        {
            if (clsApplication.IsPersonApplyForLicenseClass(cuc_SearchForPerson1.Person.PersonID, LicenseClassID))
            {
                MessageBox.Show("this Application is already placed once!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LDLApp.Application.ApplicationDate = DateTime.Now;
            if (!_LDLApp.Application.Save())
            {
                MessageBox.Show("Application faild to place!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LDLApp.LicenseClassID = LicenseClassID;
            if (_LDLApp.Save())
            {
                _MakeInputsDisable();
                MessageBox.Show("Application was placed successfully!", "Success");
            }
            else
            {
                MessageBox.Show("Application faild to place!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _MakeInputsDisable()
        {
            cuc_SearchForPerson1.MakeFilterBoxDisabled();
            cob_LicenceClasses.Enabled = false;
            btn_Save.Enabled = false;
        }
        private void cuc_SearchForPerson1_OnPersonSelect(int personID)
        {
            _PersonID = personID;
        }
    }
}
