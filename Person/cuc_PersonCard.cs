using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Project
{
    public partial class cuc_PersonCard : UserControl
    {
        public clsPerson Person = null;
        public cuc_PersonCard()
        {
            InitializeComponent();
        }
        private void _FillFormWithData()
        {
            lbl_PersonID.Text = Person.PersonID.ToString();
            lb_NationalNo.Text = Person.NationalNo;
            lb_FullName.Text = Person.GetFullName();
            lb_Gender.Text = (Person.Gender == 0 ? "Male" : "Female");
            lb_Email.Text = Person.Email;
            lb_Address.Text = Person.Address;
            lb_DataOfBirth.Text = clsGeneralSettings.DateFormate(Person.DateOfBirth);
            lb_Phone.Text = Person.Phone;
            lb_Country.Text = clsCountry.Find(Person.CountryID).CountryName;
            if (Person.ImagePath == "")
            {
                pb_ProfilePicture.Image = il_maleAndFemale.Images[Person.Gender];
            }
            else
            {
                pb_ProfilePicture.ImageLocation = Person.ImagePath;
            }
        }

        private void lb_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Person != null)
            {
                frmHandlePerson form = new frmHandlePerson(Person.PersonID);              
                form.ShowDialog();
                
                // Refresh
                LoadPersonInCard(Person.PersonID);
            }
        }
        public void LoadPersonInCard(int PersonID)
        {
            Person = clsPerson.GetPersonBy(PersonID);
            if (Person != null)
            {
                _FillFormWithData();
            }
        }
        public void ResetCard()
        {
            Person = null;
            lbl_PersonID.Text = "[????]";
            lb_NationalNo.Text = "[????]";
            lb_FullName.Text = "[????]";
            lb_Gender.Text = "[????]";
            lb_Email.Text = "[????]";
            lb_Address.Text = "[????]";
            lb_DataOfBirth.Text = "[????]";
            lb_Phone.Text = "[????]";
            lb_Country.Text = "[????]";
            pb_ProfilePicture.Image = null;
        }
    }
}
