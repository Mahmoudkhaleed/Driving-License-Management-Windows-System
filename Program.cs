using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 
            while (true)
            {
                clsGeneralSettings.CurrentUser = null;
                frmLogin loginForm = new frmLogin();
                DialogResult LoginDialogResult = loginForm.ShowDialog();

                if (LoginDialogResult == DialogResult.OK)
                {
                    clsGeneralSettings.CurrentUser = loginForm.User;
                    frmMain dashboardForm = new frmMain();
                    DialogResult dashboardDialogResult = dashboardForm.ShowDialog();
                    if (dashboardDialogResult == DialogResult.Abort)
                    {
                        dashboardForm.Close();
                        continue;
                    }
                    else
                    {
                        dashboardForm.Close();
                        loginForm.Close();
                        break;
                    }
                }
                else
                {
                    loginForm.Close();
                    break;
                }
            }

        }
    }
}
