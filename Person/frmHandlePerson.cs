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
using System.IO;
using DVLD_Project.Global_Classes;

namespace DVLD_Project
{
    public partial class frmHandlePerson : Form
    {
        private clsPerson _Person = null;
        private int _PersonID;
        private enum enMode { AddNew = 0, Update = 1 }
        private enum enGender { Male = 0, Female = 1 }
        private enMode _Mode = enMode.AddNew;
        private bool _HasImage = false;
        public frmHandlePerson()
        {
            InitializeComponent();
            _FillCountriesComboBox();
            _HandleDateRange();
            _HandleAddNewMode();
        }
        public frmHandlePerson(int PersonID)
        {
            InitializeComponent();
            _FillCountriesComboBox();
            _HandleDateRange();           
            _PersonID = PersonID;
            _HandleUpdateMode();
        }
        private void _HandleAddNewMode()
        {
            _Mode = enMode.AddNew;
            pb_ProfilePicture.Image = il_maleAndFemale.Images[0];
            rb_Male.Checked = true;
            cob_Country.SelectedItem = "Egypt";
            tb_FirstName.Select();
        }
        private void _HandleUpdateMode()
        {
            _Mode = enMode.Update;
            _Person = clsPerson.GetPersonBy(_PersonID);
            if (_Person != null)
            {
                _FillInputsWithData();
            }
            else
            {
                MessageBox.Show("This Person is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void _HandleDateRange()
        {
            dtp_DateOfBirth.MinDate = new DateTime(1950, 1, 1);
            dtp_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void _FillCountriesComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                cob_Country.Items.Add(dr["CountryName"].ToString());
            }
        }

        private void _UpdateTitlesAndButtons()
        {
            _Mode = enMode.Update;
            this.Text = "Update";
            lb_Head.Text = "Update Person";
            btn_Save.Text = "        Update";
        }
        private void _FillInputsWithData()
        {
            _UpdateTitlesAndButtons();
            lbl_PersonID.Text = _Person.PersonID.ToString();
            tb_FirstName.Text = _Person.FirstName;
            tb_LastName.Text = _Person.LastName;
            tb_SecondName.Text = _Person.SecondName;
            tb_ThirdName.Text = _Person.ThirdName;
            tb_Email.Text = _Person.Email;
            tb_Phone.Text = _Person.Phone;
            tb_Address.Text = _Person.Address;
            tb_NationalNo.Text = _Person.NationalNo;
            dtp_DateOfBirth.Value = _Person.DateOfBirth;
            cob_Country.SelectedItem = clsCountry.Find(_Person.CountryID).CountryName;
            rb_Male.Checked = (_Person.Gender == 0);
            rb_Female.Checked = (_Person.Gender == 1);
            if (_Person.ImagePath == "")
            {
                pb_ProfilePicture.Image = il_maleAndFemale.Images[_Person.Gender];
                lb_Remove.Visible = false;
                _HasImage = false;
            }
            else
            {
                pb_ProfilePicture.ImageLocation = _Person.ImagePath;
                lb_Remove.Visible = true;
                _HasImage = true;
            }
        }

        public delegate void ReturnBackPersonID(int PersonID);
        public ReturnBackPersonID BackPersonID;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_Mode == enMode.Update)
                {
                    _HandleUpdatePerson();
                }
                else
                {
                    _HandleAddNewPerson();
                }
            }
            else
            {
                MessageBox.Show("Input or more are invalid please recheck!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _FillPersonWithDataFromInputs(ref clsPerson person)
        {
            person.FirstName = tb_FirstName.Text.Trim();
            person.SecondName = tb_SecondName.Text.Trim();
            person.ThirdName = tb_ThirdName.Text.Trim();
            person.LastName = tb_LastName.Text.Trim();
            person.NationalNo = tb_NationalNo.Text.Trim();
            person.Email = tb_Email.Text.Trim();
            person.Phone = tb_Phone.Text.Trim();
            person.Address = tb_Address.Text.Trim();
            person.DateOfBirth = dtp_DateOfBirth.Value;
            person.Gender = (rb_Male.Checked ? (int)enGender.Male : (int)enGender.Female);
            person.CountryID = clsCountry.Find(cob_Country.SelectedItem.ToString()).CountryID;

            if (_HasImage)
            {
                if (pb_ProfilePicture.ImageLocation != person.ImagePath)
                {
                    string newDest = _GetNewImageDestinationPath(pb_ProfilePicture.ImageLocation, person.ImagePath);
                    person.ImagePath = newDest;
                }
            }
            else
            {
                if (person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(person.ImagePath);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error deleting File!");
                    }
                }
                person.ImagePath = "";
            }
        }
        private string _GetNewImageDestinationPath(string currentDest, string oldDest)
        {
            string targetDirectory = @"C:\DVLD-People-Images\";
            if (!Directory.Exists(targetDirectory))
            {
                try
                {
                    Directory.CreateDirectory(targetDirectory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }

            if (oldDest != "")
            {
                File.Delete(oldDest);
            }

            if (currentDest != "")
            {
                string guidID = Guid.NewGuid().ToString();
                string originalExtension = Path.GetExtension(currentDest);
                string newFileName = guidID + originalExtension;
                string destinationPath = targetDirectory + newFileName;
                File.Copy(currentDest, destinationPath);
                return destinationPath;
            }
            return "";
        }
        private void _HandleUpdatePerson()
        {
            _FillPersonWithDataFromInputs(ref _Person);
            if (_Person.Save())
            {
                MessageBox.Show("Person was updated successfully!", "Success");
            }
            else MessageBox.Show("Person is faild to update!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _HandleAddNewPerson()
        {
            clsPerson NewPerson = new clsPerson();
            _FillPersonWithDataFromInputs(ref NewPerson);
            if (NewPerson.Save())
            {
                _Person = NewPerson;
                lbl_PersonID.Text = NewPerson.PersonID.ToString();
                _UpdateTitlesAndButtons();
                MessageBox.Show("Person was added successfully!", "Success");
                BackPersonID?.Invoke(NewPerson.PersonID);
            }
            else MessageBox.Show("Person is faild to add!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Male.Checked && pb_ProfilePicture.ImageLocation == null)
            {
                rb_Female.Checked = false;
                pb_ProfilePicture.Image = il_maleAndFemale.Images[0];
            }
        }
        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Female.Checked && pb_ProfilePicture.ImageLocation == null)
            {
                rb_Male.Checked = false;
                pb_ProfilePicture.Image = il_maleAndFemale.Images[1];
            }
        }
        private void lb_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openImageDialog.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string ImageSrc = openImageDialog.FileName;
            if (ImageSrc != "")
                pb_ProfilePicture.ImageLocation = $@"{ImageSrc}";
            lb_Remove.Visible = true;
            _HasImage = true;
        }
        private void lb_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb_ProfilePicture.ImageLocation = "";
            pb_ProfilePicture.Image = il_maleAndFemale.Images[(rb_Male.Checked ? 0 : 1)];
            lb_Remove.Visible = false;
            _HasImage = false;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    inputs_ErrorProvider.SetError(textBox, "Please enter a value");
                    e.Cancel = true;
                }
                else
                {
                    inputs_ErrorProvider.SetError(textBox, null);
                }

            }               
            else if (sender is RichTextBox)
            {
                RichTextBox textBox = (RichTextBox)sender;
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    inputs_ErrorProvider.SetError(textBox, "Please enter a value");
                    e.Cancel = true;
                }
                else
                {
                    inputs_ErrorProvider.SetError(textBox, null);
                }
            }
        }
        private void tb_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.GetPersonBy(tb_NationalNo.Text) == null || tb_NationalNo.Text == _Person?.NationalNo)
            {
                inputs_ErrorProvider.SetError(tb_NationalNo, null);
            }
            else
            {
                inputs_ErrorProvider.SetError(tb_NationalNo, "This value is already exist! choose another one");
                e.Cancel = true;
            }
        }
        private void tb_Email_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Email.Text))
            {
                if (clsValidate.IsEmailValid(tb_Email.Text))
                {
                    inputs_ErrorProvider.SetError(tb_Email, null);
                }
                else
                {
                    inputs_ErrorProvider.SetError(tb_Email, "Please enter a valid email");
                    e.Cancel = true;
                }
            }
            else inputs_ErrorProvider.SetError(tb_Email, null);
        }

        private void tb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(tb_Phone.Text, out int value))
            {
                inputs_ErrorProvider.SetError(tb_Phone, null);
            }
            else
            {
                inputs_ErrorProvider.SetError(tb_Phone, "Please enter a valid Phone number");
                e.Cancel = true;
            }
        }
    }
}
