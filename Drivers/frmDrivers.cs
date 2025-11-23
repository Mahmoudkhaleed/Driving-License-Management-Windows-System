using BusinessLayer;
using DVLD_Project.Local_Driving_Licence;
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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
            _LoadData();
            cob_Filter.SelectedIndex = 0;
        }

        private void _LoadData()
        {
            DataTable dataTable = clsDriver.GetAllDriversByView();
            dgv_Drivers.DataSource = dataTable;
            lb_total.Text = dataTable.Rows.Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                _LoadData();
            }
            else
            {
                tb_SearchBox.Visible = true;
                tb_SearchBox.Text = string.Empty;
                tb_SearchBox.Select();
            }
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            //Full Name
            if (cob_Filter.SelectedIndex == 1)
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    DataTable data = clsDriver.GetAllDriversByViewByDriverID(value);
                    dgv_Drivers.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                {
                    tb_SearchBox.Text = string.Empty;
                    _LoadData();
                }
            }
            else if (cob_Filter.SelectedIndex == 2)
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    DataTable data = clsDriver.GetAllDriversByViewByPersonID(value);
                    dgv_Drivers.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                {
                    tb_SearchBox.Text = string.Empty;
                    _LoadData();
                }
            }
            else if (cob_Filter.SelectedIndex == 3)
            {
                if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                {
                    DataTable data = clsDriver.GetAllDriversByViewByNationalNo(tb_SearchBox.Text);
                    dgv_Drivers.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                    _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 4)
            {
                if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                {
                    DataTable data = clsDriver.GetAllDriversByViewByFullName(tb_SearchBox.Text);
                    dgv_Drivers.DataSource = data;
                    lb_total.Text = data.Rows.Count.ToString();
                }
                else
                    _LoadData();
            }
        }

        private void EditAppTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv_Drivers.CurrentRow.Cells[1].Value;
            frmPersonDetails personDetails = new frmPersonDetails(PersonID);
            personDetails.ShowDialog();
        }

        private void showPersonLicenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgv_Drivers.CurrentRow.Cells[0].Value;
            frmLicenceHistory licenceHistory = new frmLicenceHistory(DriverID);
            licenceHistory?.ShowDialog();
        }
    }
}
