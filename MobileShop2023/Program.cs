using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop2023
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string user_ID;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login.Frm_login());

            //Form_TMD_FinancialClaim
            // new Login.Frm_login
            // PL.Form_Main
            // FRM_SERVER
        }
    }
}
