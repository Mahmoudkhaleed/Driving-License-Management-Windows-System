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
    public partial class frmEditAppType : Form
    {
        private clsApplicationType _ApplicationType;
        public frmEditAppType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationType = clsApplicationType.Find(ApplicationTypeID);
            if (_ApplicationType != null)
            {
                _FillInputsWithData();
            }
            else
            {
                MessageBox.Show("This Application type is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillInputsWithData()
        {
            lbl_AppTypeID.Text = _ApplicationType.ApplicationTypeID.ToString();
            tb_AppTitle.Text = _ApplicationType.ApplicationTypeTitle;  
            tb_AppFees.Text = _ApplicationType.ApplicationFees.ToString();
            tb_AppTitle.Select();
        }

        private void EditAppTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _ApplicationType.ApplicationTypeTitle = tb_AppTitle.Text;
                _ApplicationType.ApplicationFees = Convert.ToSingle(tb_AppFees.Text);
                if (_ApplicationType.Save())
                {
                    MessageBox.Show("Application type was updated successfully!", "Success");
                    
                }
                else MessageBox.Show("Application type faild to updated!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Feilds should be valid!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tb_AppTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_AppTitle.Text) || string.IsNullOrWhiteSpace(tb_AppTitle.Text))
            {
                errorProvider1.SetError(tb_AppTitle, "This feild should not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_AppTitle, null);
            }
        }

        private void tb_AppFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_AppFees.Text) || string.IsNullOrWhiteSpace(tb_AppFees.Text))
            {
                errorProvider1.SetError(tb_AppFees, "This feild should not be empty!");
                e.Cancel = true;
            }
            else if (!float.TryParse(tb_AppFees.Text, out float value) && !(value >= 0))
            {
                errorProvider1.SetError(tb_AppFees, "This feild should contain positive numbers only!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_AppFees, null);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
