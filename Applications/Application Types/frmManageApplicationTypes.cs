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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            _LoadData();
        }
        private void _LoadData()
        {
            DataTable data = clsApplicationType.GetAllApplicationTypes();
            dgv_ApplicationTypes.DataSource = data;
            dgv_ApplicationTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            lb_totalTypes.Text = data.Rows.Count.ToString();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAppTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAppType form = new frmEditAppType((int)dgv_ApplicationTypes.CurrentRow.Cells["ID"].Value);
            form.ShowDialog();
            _LoadData();
        }
    }
}
