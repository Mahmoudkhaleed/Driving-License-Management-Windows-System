using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Project
{
    public partial class frmPersons : Form
    {
        public frmPersons()
        {
            InitializeComponent();
            _LoadData();
        }

        private void _LoadData()
        {
            DataTable data = clsPerson.GetAllPeople();
            dgv_persons.DataSource = data;
            lb_totalPersons.Text = data.Rows.Count.ToString();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            cob_Filter.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            frmHandlePerson form = new frmHandlePerson();
            form.ShowDialog();
            _LoadData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandlePerson form = new frmHandlePerson();
            form.ShowDialog();
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandlePerson form = new frmHandlePerson((int)dgv_persons.CurrentRow.Cells["Person ID"].Value);
            form.ShowDialog();
            _LoadData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails form = new frmPersonDetails((int)dgv_persons.CurrentRow.Cells["Person ID"].Value);
            form.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete person with id = " + dgv_persons.CurrentRow.Cells["Person ID"].Value.ToString(), "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                clsPerson person = clsPerson.GetPersonBy((int)dgv_persons.CurrentRow.Cells["Person ID"].Value);
                if (person != null)
                {
                    if (person.Delete())
                    {
                        if (person.ImagePath != "")
                            File.Delete(person.ImagePath);
                        MessageBox.Show("Person was deleted successfully!", "Deleted");
                        _LoadData();
                    }
                    else
                        MessageBox.Show("Person faild to delete because it is connected to a user!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Person is not found!", "Faild");
            }
        }

        private void _LoadPersonsAccordingToGender(bool MaleGender)
        {
            int gender = 0;
            if (!MaleGender)
                gender = 1;
            DataTable data = clsPerson.GetPeopleByGender(gender);
            dgv_persons.DataSource = data;
            lb_totalPersons.Text = data.Rows.Count.ToString();
        }
        private void cob_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                tb_SearchBox.Visible = false;
                panel_Gender.Visible = false;
                _LoadData();
            }
            else if (cob_Filter.SelectedIndex == 7)
            {
                tb_SearchBox.Visible = false;
                panel_Gender.Visible = true;
                rb_Male.Checked = true;
                _LoadPersonsAccordingToGender(rb_Male.Checked);
                panel_Gender.Location = new Point(224, 164);
            }
            else
            {
                tb_SearchBox.Visible = true;
                panel_Gender.Visible = false;
                tb_SearchBox.Text = string.Empty;
                tb_SearchBox.Select();
            }
        }

        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            if (cob_Filter.SelectedIndex == 1)
            {
                if (int.TryParse(tb_SearchBox.Text, out int value))
                {
                    data = clsPerson.GetPeopleByPersonID(value);
                    dgv_persons.DataSource = data;
                }
                else
                {
                    tb_SearchBox.Text = null;
                }
            }
            else if (cob_Filter.SelectedIndex == 2)
            {
                data = clsPerson.GetPeopleByNationalNo(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 3)
            {
                data = clsPerson.GetPeopleByFirstName(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 4)
            {
                data = clsPerson.GetPeopleBySecondName(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 5)
            {
                data = clsPerson.GetPeopleByThirdName(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 6)
            {
                data = clsPerson.GetPeopleByLastName(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 8)
            {
                data = clsPerson.GetPeopleByAddress(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 9)
            {
                data = clsPerson.GetPeopleByPhone(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 10)
            {
                data = clsPerson.GetPeopleByEmail(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            else if (cob_Filter.SelectedIndex == 11)
            {
                data = clsPerson.GetPeopleByCountryName(tb_SearchBox.Text);
                dgv_persons.DataSource = data;
            }
            lb_totalPersons.Text = data.Rows.Count.ToString();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            _LoadPersonsAccordingToGender(rb_Male.Checked);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }
    }
}
