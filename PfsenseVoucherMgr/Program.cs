using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PfsenseVoucherMgr
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //load language settings
            UICulture Lng = new UICulture();
            Lng.LoadAndActivate();

            Application.Run(new frmMain());
        }
    }
}
