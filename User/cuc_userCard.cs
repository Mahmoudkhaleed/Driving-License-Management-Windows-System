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
    public partial class cuc_userCard : UserControl
    {
        public cuc_userCard()
        {
            InitializeComponent();
        }
        public void LoadData(int UserID)
        {
            clsUser user = clsUser.Find(UserID);
            if (user != null )
            {
                cuc_PersonCard1.LoadPersonInCard(user.PersonID);
                lbl_UserID.Text = user.UserID.ToString();
                lb_Username.Text = user.UserName;
                lb_IsActive.Text = (user.IsActive ? "Yes" : "No");
            }
        }
    }
}
