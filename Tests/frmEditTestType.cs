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
    public partial class frmEditTestType : Form
    {
        private clsTestType _TestType;
        public frmEditTestType(int TestID)
        {
            InitializeComponent();
            _TestType = clsTestType.Find(TestID);
            if (_TestType != null )
            {
                _FillInputsWithData();
            }
            else
                MessageBox.Show("This Test type is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillInputsWithData()
        {
            lbl_TestTypeID.Text = _TestType.TestTypeID.ToString();
            tb_TestTitle.Text = _TestType.TestTypeTitle;
            tb_TestDescription.Text = _TestType.TestTypeDescription;
            tb_TestFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _TestType.TestTypeTitle = tb_TestTitle.Text;
                _TestType.TestTypeDescription = tb_TestDescription.Text;
                _TestType.TestTypeFees = Convert.ToSingle(tb_TestFees.Text);
                if (_TestType.Save())
                {
                    MessageBox.Show("Test type was updated successfully!", "Success");

                }
                else MessageBox.Show("Test type faild to updated!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Feilds should be valid!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void tb_TestTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_TestTitle.Text) || string.IsNullOrWhiteSpace(tb_TestTitle.Text))
            {
                errorProvider1.SetError(tb_TestTitle, "This feild should not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_TestTitle, null);
            }
        }

        private void tb_TestDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_TestDescription.Text) || string.IsNullOrWhiteSpace(tb_TestDescription.Text))
            {
                errorProvider1.SetError(tb_TestDescription, "This feild should not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_TestDescription, null);
            }
        }

        private void tb_TestFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_TestFees.Text) || string.IsNullOrWhiteSpace(tb_TestFees.Text))
            {
                errorProvider1.SetError(tb_TestFees, "This feild should not be empty!");
                e.Cancel = true;
            }
            else if (!float.TryParse(tb_TestFees.Text, out float value) && !(value >= 0))
            {
                errorProvider1.SetError(tb_TestFees, "This feild should contain positive numbers only!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb_TestFees, null);
            }
        }
    }
}
