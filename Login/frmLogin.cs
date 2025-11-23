using BusinessLayer;
using DVLD_Project.Global_Classes;
using DVLD_Project.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmLogin : Form
    {
        public clsUser User;
        private string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_Application";
        private string _valueName = "RememberMe";
        public frmLogin()
        {
            InitializeComponent();
            TB_Username.Select();
            _HandleReturningUserFromRememberMe();
        }

        private void _HandleReturningUserFromRememberMe()
        {
            try
            {
                string valueData = Registry.GetValue(_keyPath, _valueName, "")?.ToString();
                if (valueData != null)
                {                
                    string[] parts = valueData.Split(new string[] { "/##/" }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        TB_Username.Text = parts[0];
                        TB_Password.Text = parts[1];
                        CB_Remember.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving remember me data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;
        private void DraggingOnMouseDown()
        {
            Dragging = true;
            DragFormPoint = this.Location;
            DragCursorPoint = Cursor.Position;
        }
        private void DraggingOnMouseMove()
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }
        private void DraggingOnMouseUp()
        {
            Dragging = false;
        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingOnMouseDown();
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            DraggingOnMouseMove();
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingOnMouseUp();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingOnMouseDown();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DraggingOnMouseMove();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingOnMouseUp();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingOnMouseDown();
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            DraggingOnMouseMove();

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingOnMouseUp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingOnMouseDown();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            DraggingOnMouseMove();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingOnMouseUp();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingOnMouseDown();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            DraggingOnMouseMove();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingOnMouseUp();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TB_Username.Select();
        }

        bool _PasswordShow = true;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (_PasswordShow)
            {
                pictureBox4.Image = Resources.showpassword;
                TB_Password.PasswordChar = '\0';
            }
            else
            {
                pictureBox4.Image = Resources.hidepassword;
                TB_Password.PasswordChar = '*';
            }
            _PasswordShow = !_PasswordShow;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Username.Text) && !string.IsNullOrEmpty(TB_Password.Text))
            {
                User = clsUser.Find(TB_Username.Text);
                if (User == null)
                {
                    MessageBox.Show("Username or password is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (User.Password == clsEncryptions.ComputeHash(TB_Password.Text))
                {
                    _HandleRememberMe();
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("Feilds should not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _HandleRememberMe()
        {
            string valueData = TB_Username.Text + "/##/" + TB_Password.Text;
            if (CB_Remember.Checked)
            {
                try
                {
                    Registry.SetValue(_keyPath, _valueName, valueData, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving remember me data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Registry.GetValue(_keyPath, _valueName, null) != null)
                {
                    try
                    {
                        Registry.SetValue(_keyPath, _valueName, null, RegistryValueKind.String);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error clearing remember me data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }             
            }
        }

        private void CB_Remember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
