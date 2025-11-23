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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            _LoadData();
        }

        private void _LoadData()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            dgv_TestTypes.DataSource = dt;
            dgv_TestTypes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lb_totalTypes.Text = dt.Rows.Count.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAppTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestID = (int)dgv_TestTypes.CurrentRow.Cells["ID"].Value;
            frmEditTestType form = new frmEditTestType(TestID);
            form.ShowDialog();
            _LoadData();
        }
    }
}
