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

namespace DVLD_Project.User_Controls
{
    public partial class cuc_SearchForPerson : UserControl
    {
        public clsPerson Person;
        public cuc_SearchForPerson()
        {
            InitializeComponent();
            cob_Filter.SelectedIndex = 0;
        }

        public void FillPerosnCard(int PersonID)
        {
            cuc_PersonCard1.LoadPersonInCard(PersonID);
            Person = cuc_PersonCard1.Person;
            if (cob_Filter.SelectedIndex == 0)
                tb_SearchBox.Text = Person.PersonID.ToString();
            else
                tb_SearchBox.Text = Person.NationalNo;

        }

        public void MakeFilterBoxDisabled()
        {
            groupBox1.Enabled = false;
        }

        public void SearchBoxFocus()
        {
            tb_SearchBox.Select();
        }

        public event Action<int> OnPersonSelect;
        protected void PersonSelect(int PersonID)
        {
            if(OnPersonSelect != null)
                OnPersonSelect(PersonID);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            switch (cob_Filter.SelectedIndex)
            {
                case 0:
                    if (int.TryParse(tb_SearchBox.Text, out int PersonID))
                    {
                        Person = clsPerson.GetPersonBy(PersonID);
                        _CheckIfPersonExist();
                    }
                    else tb_SearchBox.Text = string.Empty;
                    break;
                case 1:
                    if (!string.IsNullOrEmpty(tb_SearchBox.Text))
                    {
                        Person = clsPerson.GetPersonBy(tb_SearchBox.Text);
                        _CheckIfPersonExist();
                    }
                    break;
                default:
                    break;
            }
            if (Person != null)
            {
                PersonSelect(Person.PersonID);
            }
        }

        private void _CheckIfPersonExist()
        {
            if (Person != null)
            {
                FillPerosnCard(Person.PersonID);
            }
            else
            {
                MessageBox.Show($"Perosn with National no = {tb_SearchBox.Text} is not found!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cuc_PersonCard1.ResetCard();
                Person = null;
            }
        }
        private void btn_AddNewPerson_Click(object sender, EventArgs e)
        {
            frmHandlePerson form = new frmHandlePerson();
            form.BackPersonID += FillPerosnCard;
            form.ShowDialog();
        }
        private void tb_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cob_Filter.SelectedIndex == 0)
            {
                if (!int.TryParse(tb_SearchBox.Text, out int PersonID))
                    tb_SearchBox.Text = string.Empty;
            }
        }

        private void cuc_PersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void tb_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.ActiveControl = null;
            }
        }
    }
}
