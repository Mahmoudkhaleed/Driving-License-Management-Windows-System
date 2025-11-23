using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Project
{
    public class clsGeneralSettings
    {
        public static clsUser CurrentUser;
        public enum enStatuses { New = 1, Cancelled = 2, Completed = 3 }

        public static string DateFormate(DateTime Date)
        {
            return Date.ToString("dd/MMM/yyyy");
        }
    }
}
